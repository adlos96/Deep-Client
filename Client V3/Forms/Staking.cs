using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_V3.Forms
{
    public partial class Staking : Form
    {
        public Staking()
        {
            InitializeComponent();
        }

        private async void Staking_Load(object sender, EventArgs e)
        {
            await Update_Grid();

            txt_Bilancio_Staking.Text = "0"; //Numero di coin disponibili nel bilancio dell'utente (User Swap Balance)
            txt_Bilancio_Unstake.Text = "0"; //Numero di coin in staking dell'utente
            Coin_Staking.Text = Coin_Staking.Items[0].ToString();
            Coin_Unstake.Text = Coin_Unstake.Items[0].ToString();
        }
        async Task Update_Grid()
        {
            datagrid_Unstake.Rows.Clear();
            if (Variabili.unstake_TRansaction.Count != 0)
                foreach (var item in Variabili.unstake_TRansaction)
                    datagrid_Unstake.Rows.Add(item);
        }


        private async void Coin_Staking_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Update_UI();
        }

        private async void Coin_Unstake_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Update_UI();
        }
        private async Task Update_UI()
        {
            if (Coin_Staking.Text == "XDLS")
            {
                txt_APY_Staking.Text = Variabili.Prezzi.APR.XDLS + "%";
                txt_Bilancio_Staking.Text = Variabili.Bilanci.Swap.XDLS;
            }
            if (Coin_Staking.Text == "XUSDT")
            {
                txt_APY_Staking.Text = Variabili.Prezzi.APR.XUSDT + "%";
                txt_Bilancio_Staking.Text = Variabili.Bilanci.Swap.XUSDT;
            }


            if (Coin_Unstake.Text == "XDLS")
            {
                txt_Day_Lock_Unstake.Text = Variabili.Prezzi.Unlock_Days.XDLS;
                txt_Bilancio_Unstake.Text = Variabili.Bilanci.Staking.XDLS;
            }
            if (Coin_Unstake.Text == "XUSDT")
            {
                txt_Day_Lock_Unstake.Text = Variabili.Prezzi.Unlock_Days.XUSDT;
                txt_Bilancio_Unstake.Text = Variabili.Bilanci.Staking.XUSDT;
            }
        }

        private async void btn_Staking_Click(object sender, EventArgs e)
        {
            btn_Staking.Enabled = false;
            CultureInfo culture = new CultureInfo("it-IT");
            double staking_Q = 0;
            double.TryParse(txt_Deposito_Staking.Text.Replace(".", ","), NumberStyles.Number, culture, out staking_Q);

            if (staking_Q > Convert.ToDouble(txt_Bilancio_Staking.Text) || staking_Q == 0)
            {
                await Sleep_Timer_Staking(4);
                btn_Staking.Enabled = true;
                return;
            }

            await Staking_Request();
            await Update_Grid();
            await Update_UI();

            txt_Deposito_Staking.Text = "0.0000000";
            btn_Staking.Enabled = true;
        }

        private async void btn_Unstake_Click(object sender, EventArgs e)
        {
            btn_Unstake.Enabled = false;
            CultureInfo culture = new CultureInfo("it-IT");
            double staking_Q = 0;
            double.TryParse(txt_Prelievo_Unstake.Text.Replace(".", ","), NumberStyles.Number, culture, out staking_Q);

            if (staking_Q > Convert.ToDouble(txt_Bilancio_Unstake.Text) || staking_Q == 0)
            {
                await Sleep_Timer_Staking(4);
                btn_Staking.Enabled = true;
                return;
            }

            await Unstake_Request();
            await Update_Grid();
            await Update_UI();

            txt_Prelievo_Unstake.Text = "0.00000000";
            btn_Unstake.Enabled = true;
        }
        private async Task Staking_Request ()
        {
            Variabili.unstake_TRansaction.Clear();

            await ClientsConnection.TestClient.Send_Server($"staking|{Variabili.wallet}|{Coin_Staking.SelectedItem}|{txt_Deposito_Staking.Text}");
            await ClientsConnection.TestClient.Send_Server($"transaction|{Variabili.wallet}");
            await ClientsConnection.TestClient.Send_Server($"update_user_balance|{Variabili.wallet}"); //Richiesta dati - Bilancio Utente
            await ClientsConnection.TestClient.Send_Server($"balance|{Variabili.wallet}");
            await Timer_Staking(5, "Process", "Staking");
        }
        private async Task Unstake_Request()
        {
            Variabili.unstake_TRansaction.Clear();

            await ClientsConnection.TestClient.Send_Server($"unstake|{Variabili.wallet}|{Coin_Unstake.SelectedItem}|{txt_Prelievo_Unstake.Text}");
            await ClientsConnection.TestClient.Send_Server($"transaction|{Variabili.wallet}");
            await ClientsConnection.TestClient.Send_Server($"update_user_balance|{Variabili.wallet}"); //Richiesta dati - Bilancio Utente
            await ClientsConnection.TestClient.Send_Server($"balance|{Variabili.wallet}");
            await Timer_Staking(5, "Process", "Unstake");
        }
        public async Task<bool> Timer_Staking(int secondi, string testo, string button)
        {
            int contatore_Timer = 0;
            while (true)
            {
                if (button == "Staking")
                {
                    btn_Staking.Text = $"{testo} ({secondi - contatore_Timer}s)";
                    if (secondi == contatore_Timer)
                    {
                        if (secondi - contatore_Timer == 0)
                            btn_Staking.Text = $"{testo}";
                        contatore_Timer = 0;
                        btn_Staking.Text = "Blocca";
                        return true;
                    }
                    contatore_Timer++;
                    await Task.Delay(1000);
                }
                if (button == "Unstake")
                {
                    btn_Unstake.Text = $"{testo} ({secondi - contatore_Timer}s)";
                    if (secondi == contatore_Timer)
                    {
                        if (secondi - contatore_Timer == 0)
                            btn_Unstake.Text = $"{testo}";
                        contatore_Timer = 0;
                        btn_Unstake.Text = "Sblocca";
                        return true;
                    }
                    contatore_Timer++;
                    await Task.Delay(1000);
                }
            }
        }

        public async Task<bool> Sleep_Timer_Staking(int secondi)
        {
            int contatore_Timer_Avvisi = 0;
            double staking_Q = 0;
            while (true)
            {
                txt_Bilancio_Staking.BackColor = Color.FromArgb(0, 7, 33);
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_Bilancio_Staking.BackColor = Color.FromArgb(0, 7, 33);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_Bilancio_Staking.BackColor = Color.FromArgb(196, 12, 24);
                await Task.Delay(125);
            }
        }
        public Task Sleep(int millisecondi)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(millisecondi);
            });
        }
    }
}
