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
            await ClientsConnection.TestClient.Connessione();
            await ClientsConnection.TestClient.Send_Server($"balance|protocol|{Variabili.wallet}");
            await Fee_Update();

            if (ClientsConnection.TestClient._ServerIp != "127.1")
            {
                chart_Grafico_Home.Visible = false;
            }

            //Update withdrawal fee
            txt_Fee_A.Text = Variabili.fee_A;
            txt_Fee_B.Text = Variabili.fee_B;
            txt_Fee_C.Text = Variabili.fee_C;

            //Update balance data
            txt_Chia_Balance.Text           = Variabili.CHIA;
            txt_ATOM_Balance.Text           = Variabili.ATOM;
            txt_CRO_Balance.Text            = Variabili.CRO;
            txt_LUNA_Balance.Text           = Variabili.LUNA;
            txt_TIA_Balance.Text            = Variabili.TIA;
            txt_USDT_Balance.Text           = Variabili.USDT;
            txt_USDC_Balance.Text           = Variabili.USDC;
            txt_axlUSDC_Balance.Text        = Variabili.axlUSDC;
            txt_XDLS_Balance.Text           = Variabili.XDLS;
            txt_XUSDT_Balance.Text          = Variabili.XUSDT;
            lbl_Withdrawable_Xch.Text       = "Prelevabili: " + Variabili.xch_Prelevabili + " XCH";
            lbl_Pending_Xch.Text            = "Pending: " + Variabili.xch_Pending + " XCH";
            txt_Totale_Xch_Prelevati.Text   = Variabili.chia_prelevati + " XCH";
            txt_Credito_Rimasto.Text        = Variabili.Credito_Rimasto + " Euro";
        }

        private async void Btn_Withdrawal_Click(object sender, EventArgs e)
        {
            Btn_Withdrawal.Enabled = false;
            string fee = "null";
            string xch = "null";

            if (radioB_Fee_A.Checked == true) fee = Variabili.fee_A;
            if (radioB_Fee_B.Checked == true) fee = Variabili.fee_B;
            if (radioB_Fee_C.Checked == true) fee = Variabili.fee_C;

            await ClientsConnection.TestClient.Send_Server($"withdrawal|{Variabili.wallet}|{Variabili.xch_Prelevabili}|{fee}");
            Btn_Withdrawal.Enabled = false;
            await Sleep();
            Btn_Withdrawal.Enabled = true;
        }
        public async Task<Task> Fee_Update(){
            return Task.Run(async () =>
            {
                await ClientsConnection.TestClient.Send_Server($"home|fee_Update|{Variabili.wallet}");
                Thread.Sleep(5000);
            });
        }
        public async Task<Task> Sleep() {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
        }
    }
}
