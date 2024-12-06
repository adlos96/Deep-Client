using Client_V3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Home_Load_1(object sender, EventArgs e)
        {
            if (Variabili.cloudMining_TRansaction.Count != 0)
                foreach (var item in Variabili.cloudMining_TRansaction)
                    datagrid_Unstake.Rows.Add(item);

            Withdraw_Selection.Text = Withdraw_Selection.Items[0].ToString();
            Coin_Selection.Items.Add("CHIA");
            Coin_Selection.Text = "CHIA";
            //Update withdrawal fee
            txt_Fee_A.Text = Variabili.fee_A;
            txt_Fee_B.Text = Variabili.fee_B;
            txt_Fee_C.Text = Variabili.fee_C;
            radioB_Fee_A.Checked = true;

            //Update balance data
            txt_Chia_Balance.Text           = Variabili.Bilanci.Protocol.XCH;
            txt_ATOM_Balance.Text           = Variabili.Bilanci.Protocol.ATOM;
            txt_CRO_Balance.Text            = Variabili.Bilanci.Protocol.CRO;
            txt_LUNA_Balance.Text           = Variabili.Bilanci.Protocol.LUNA;
            txt_TIA_Balance.Text            = Variabili.Bilanci.Protocol.TIA;
            txt_USDT_Balance.Text           = Variabili.Bilanci.Protocol.USDT;
            txt_USDC_Balance.Text           = Variabili.Bilanci.Protocol.USDC;
            txt_axlUSDC_Balance.Text        = Variabili.Bilanci.Protocol.axlUSDC;
            txt_XDLS_Balance.Text           = Variabili.Bilanci.Protocol.XDLS;
            txt_XUSDT_Balance.Text          = Variabili.Bilanci.Protocol.XUSDT;

            txt_Withdrawable_Xch.Text       = "Avaiable: " + Variabili.xch_Prelevabili + " XCH"; //Chia cloud mining
            txt_Pending_Xch.Text            = "Pending: " + Variabili.xch_Pending + " XCH"; //Chia cloud mining
            txt_Totale_Xch_Prelevati.Text   = Variabili.chia_prelevati + " XCH";
            txt_Credito_Rimasto.Text        = Variabili.Credito_Rimasto + " €";
            txt_Resoconto_Protocollo.Text   = $"Utenti: {Variabili.totale_Utenti}      Depositi: [{Variabili.totale_Deposito_Euro}€ | {Variabili.totale_Deposito_USDT} USDT]      Totale Pagato: {Variabili.totale_Bonus_Pagato}€";
            txt_Giorni_Rimasti.Text         = Variabili.giorni_Rimasti + " Days";
        }

        private async void Btn_Withdrawal_Click(object sender, EventArgs e)
        {
            Btn_Withdrawal.Enabled = false;
            string fee = "null";

            if (radioB_Fee_A.Checked == true) fee = Variabili.fee_A;
            if (radioB_Fee_B.Checked == true) fee = Variabili.fee_B;
            if (radioB_Fee_C.Checked == true) fee = Variabili.fee_C;

            if (Withdraw_Selection.Text == "Cloud Mining")
                await ClientsConnection.TestClient.Send_Server($"withdrawal|{Variabili.wallet}|{Variabili.xch_Prelevabili}|{fee}|{Withdraw_Selection.Text}|{Coin_Selection.Text}");
            else
            {
                if (Coin_Selection.Text == "CHIA")
                    await ClientsConnection.TestClient.Send_Server($"withdrawal|{Variabili.wallet}|{Variabili.Bilanci.Swap.XCH}|{fee}|{Withdraw_Selection.Text}|{Coin_Selection.Text}");
            }

            Btn_Withdrawal.Enabled = false;
            await Sleep(4);
            Btn_Withdrawal.Enabled = true;
        }
        public static async Task Sleep(int tempo)
        {
            await Task.Delay(tempo * 1000);
        }

        private void Withdraw_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Withdraw_Selection.Text == "Cloud Mining")
            {
                Coin_Selection.Items.Clear();
                Coin_Selection.Items.Add("CHIA");
                Coin_Selection.Text = "CHIA";

                Btn_Withdrawal.Enabled = true;
                Btn_Withdrawal.Text = "Withdraw Mining";
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.xch_Prelevabili + " XCH"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.xch_Pending + " XCH"; //Chia cloud mining
            }
            if (Withdraw_Selection.Text == "Swap")
            {
                Coin_Selection.Items.Clear();
                foreach (var coin in Variabili.coins)
                    Coin_Selection.Items.Add(coin);
                Coin_Selection.Text = Coin_Selection.Items[0].ToString();

                if (Coin_Selection.Text == "CHIA")
                {
                    Coin_Selection.Text = Coin_Selection.Items[0].ToString();
                    txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.XCH + " XCH"; //Chia cloud mining
                    txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.XCH + " XCH"; //Chia cloud mining
                }
                Btn_Withdrawal.Text = "Withdraw Swap";
            }
        }

        private void Coin_Selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Withdrawal.Enabled = false;

            if (Coin_Selection.Text == "CHIA" && Withdraw_Selection.Text == "Swap")
            {
                Coin_Selection.Text = Coin_Selection.Items[0].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.XCH + " XCH"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.XCH + " XCH"; //Chia cloud mining
                Btn_Withdrawal.Enabled = true;
            }
            if (Coin_Selection.Text == "ATOM")
            {
                Coin_Selection.Text = Coin_Selection.Items[1].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.ATOM + " ATOM"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.ATOM + " ATOM"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "CRO")
            {
                Coin_Selection.Text = Coin_Selection.Items[2].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.CRO + " CRO"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.CRO + " CRO"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "LUNA")
            {
                Coin_Selection.Text = Coin_Selection.Items[3].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.LUNA + " LUNA"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.LUNA + " LUNA"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "TIA")
            {
                Coin_Selection.Text = Coin_Selection.Items[4].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.TIA + " TIA"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.TIA + " TIA"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "USDT")
            {
                Coin_Selection.Text = Coin_Selection.Items[5].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.USDT + " USDT"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.USDT + " USDT"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "USDC")
            {
                Coin_Selection.Text = Coin_Selection.Items[6].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.USDC + " USDC"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.USDC + " USDC"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "axlUSDC")
            {
                Coin_Selection.Text = Coin_Selection.Items[7].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.axlUSDC + " axlUSDC"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.axlUSDC + " axlUSDC"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "XDLS")
            {
                Coin_Selection.Text = Coin_Selection.Items[8].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.XDLS + " XDLS"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.XDLS + " XDLS"; //Chia cloud mining
            }
            if (Coin_Selection.Text == "XUSDT")
            {
                Coin_Selection.Text = Coin_Selection.Items[9].ToString();
                txt_Withdrawable_Xch.Text = "Avaiable: " + Variabili.Bilanci.Swap.XUSDT + " XUSDT"; //Chia cloud mining
                txt_Pending_Xch.Text = "Pending: " + Variabili.Bilanci.Swap_Pending.XUSDT + " XUSDT"; //Chia cloud mining
            }
        }
    }
}
