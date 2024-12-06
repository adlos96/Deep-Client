using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Client_V3.Forms
{
    public partial class Swap : Form
    {
        static int contatore_Timer_Avvisi = 0;
        public Swap()
        {
            InitializeComponent();
        }

        private async void Swap_Load(object sender, EventArgs e)
        {
            datagrid_Unstake.Rows.Clear();

            await ClientsConnection.TestClient.Send_Server($"update_user_balance|{Variabili.wallet}"); //Richiesta dati - Bilancio Utente
            await ClientsConnection.TestClient.Send_Server($"balance|{Variabili.wallet}");
            await ClientsConnection.TestClient.Send_Server("update_coin_price|0"); //Richiesta prezzi coin swap

            if (Variabili.swap_TRansaction.Count != 0)
                foreach (var item in Variabili.swap_TRansaction)
                    datagrid_Unstake.Rows.Add(item);

            foreach (var coin in Variabili.coins)
                Coin_Selection_From.Items.Add(coin);
            foreach (var coin in Variabili.coins)
                Coin_Selection_To.Items.Add(coin);

            Chain_Selection_From.Items.Add("Chia Network");
            Chain_Selection_From.Items.Add("Poligon");
            Chain_Selection_From.Items.Add("Cronos");
            Chain_Selection_From.Items.Add("Terra");

            Chain_Selection_To.Items.Add("Chia Network");
            Chain_Selection_To.Items.Add("Poligon");
            Chain_Selection_To.Items.Add("Cronos");
            Chain_Selection_To.Items.Add("Terra");

            txt_Slippage.Text = Variabili.slippage + " %";
            txt_Protocol_Fee.Text = Variabili.protocol_Fee + " %";
            txt_Transaction_Fee.Text = "0";
            txt_Bridge_Fee.Text = "0 ";
        }

        private void Coin_Selection_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Wallet_Deposit.ReadOnly = true;
            Btn_Swap.Enabled = true;
            Coin_Selection_To.Enabled = true;

            Coin_Selection_To.Items.Clear();
            foreach (var coin in Variabili.coins)
                Coin_Selection_To.Items.Add(coin);

            string selezione = Coin_Selection_From.Text;
            switch (selezione) {
                case "XDLS":

                    Coin_Selection_To.Items.Remove("XDLS");

                    Coin_Selection_To.Text = "XUSDT";
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Chia Network");
                    Chain_Selection_To.Text = "Chia Network";

                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Chia Network");
                    Chain_Selection_From.Text = "Chia Network";
                    lbl_Importo_From.Text = "XDLS";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XDLS + " USDT";

                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XDLS;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XDLS) == 0)
                        Btn_Swap.Enabled = false;
                    break;

                case "XUSDT":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Chia Network");
                    Chain_Selection_From.Text = "Chia Network";

                    Coin_Selection_To.Items.Remove("XUSDT");

                    Coin_Selection_To.Text = "XDLS";
                    lbl_Importo_From.Text = "XUSDT";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XUSDT + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XUSDT;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XUSDT) == 0)
                        Btn_Swap.Enabled = false;
                    break;

                case "CHIA":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Chia Network");
                    Chain_Selection_From.Text = "Chia Network";

                    Coin_Selection_To.Items.Remove("CHIA");

                    Coin_Selection_To.Text = "XDLS";
                    lbl_Importo_From.Text = "XCH";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XCH + " USDT";

                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XCH;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XCH) == 0)
                        Btn_Swap.Enabled = false;
                    break;

                case "ATOM":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Cosmos");
                    Chain_Selection_From.Text = "Cosmos";

                    Coin_Selection_To.Items.Remove("ATOM");

                    Coin_Selection_To.Text = "CHIA";
                    lbl_Importo_From.Text = "ATOM";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.ATOM + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.ATOM;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.ATOM) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "CRO":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Cronos");
                    Chain_Selection_From.Text = "Cronos";

                    Coin_Selection_To.Items.Remove("CRO");

                    Coin_Selection_To.Text = "CHIA";
                    lbl_Importo_From.Text = "CRO";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.CRO + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.CRO;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.CRO) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "TIA":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Cronos");
                    Chain_Selection_From.Text = "Cronos";

                    Coin_Selection_To.Items.Remove("TIA");

                    Coin_Selection_To.Text = "CHIA";
                    lbl_Importo_From.Text = "TIA";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.TIA + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.TIA;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.TIA) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "LUNA":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Terra");
                    Chain_Selection_From.Text = "Terra";

                    Coin_Selection_To.Items.Remove("LUNA");

                    Coin_Selection_To.Text = "XDLS";
                    lbl_Importo_From.Text = "LUNA";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.LUNA + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.LUNA;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.LUNA) == 0)
                        Btn_Swap.Enabled = false;
                    break;

                case "USDT":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Polygon");
                    Chain_Selection_From.Text = "Polygon";

                    Coin_Selection_To.Items.Remove("USDT");

                    Coin_Selection_To.Text = "XUSDT";
                    lbl_Importo_From.Text = "USDT";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.USDT + " USDT";
                    txt_Wallet_Deposit.Text = "Inserisci Wallet Invio";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.USDT;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.USDT) == 0)
                        Btn_Swap.Enabled = false;

                    break;
                case "USDC":
                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Polygon");
                    Chain_Selection_From.Text = "Polygon";

                    Coin_Selection_To.Items.Remove("USDC");

                    Coin_Selection_To.Text = "XUSDT";
                    lbl_Importo_From.Text = "USDC";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.USDC + " USDC";
                    txt_Wallet_Deposit.Text = "Inserisci Wallet Invio";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.USDC;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.USDT) == 0)
                        Btn_Swap.Enabled = false;

                    break;

                case "axlUSDC":

                    Chain_Selection_From.Items.Clear();
                    Chain_Selection_From.Items.Add("Terra");
                    Chain_Selection_From.Text = "Terra";

                    Coin_Selection_To.Items.Remove("axlUSDC");

                    Coin_Selection_To.Text = "XUSDT";
                    lbl_Importo_From.Text = "axlUSDC";
                    lbl_Price_From.Text = "Prezzo: " + Variabili.Prezzi.Protocol.axlUSDC + " USDT";
                    txt_Wallet_Deposit.Text = "Not Need - Internal Only";
                    Btn_Swap.Text = "Update Data";
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.USDT;

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.axlUSDC) == 0)
                        Btn_Swap.Enabled = false;
                    break;
            }
        }
        private void Coin_Selection_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Swap.Enabled = true;
            Btn_Swap.Text = "Update Data";

            string selezione = Coin_Selection_To.Text;
            switch (selezione) {
                case "XUSDT":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Chia Network");
                    Chain_Selection_To.Text = "Chia Network";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 XUSDT";
                    txt_Bridge_Fee.Text = "0 XUSDT";
                    lbl_Importo_To.Text = "XUSDT";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.XUSDT;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XUSDT + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XUSDT) == 0)
                        Btn_Swap.Enabled = false;
                    if (Chain_Selection_From.Text != Chain_Selection_To.Text)
                        txt_Bridge_Fee.Text = "1.50";
                    break;
                case "XDLS":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Chia Network");
                    Chain_Selection_To.Text = "Chia Network";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 XDLS";
                    txt_Bridge_Fee.Text = "0 XDLS";
                    lbl_Importo_To.Text = "XDLS";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.XDLS;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XDLS + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XDLS) == 0)
                        Btn_Swap.Enabled = false;
                    if (Chain_Selection_From.Text != Chain_Selection_To.Text)
                        txt_Bridge_Fee.Text = "1.50";
                    break;
                case "CHIA":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Chia Network");
                    Chain_Selection_To.Text = "Chia Network";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 XCH";
                    txt_Bridge_Fee.Text = "0 XCH";
                    lbl_Importo_To.Text = "XCH";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.XCH;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.XCH + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.XCH) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "ATOM":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Cosmos");
                    Chain_Selection_To.Text = "Cosmos";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 ATOM";
                    txt_Bridge_Fee.Text = "0 ATOM";
                    lbl_Importo_To.Text = "ATOM";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.ATOM;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.ATOM + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.ATOM) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "CRO":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Cronos");
                    Chain_Selection_To.Text = "Cronos";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 CRO";
                    txt_Bridge_Fee.Text = "0 CRO";
                    lbl_Importo_To.Text = "CRO";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.CRO;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.CRO + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.CRO) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "LUNA":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Terra");
                    Chain_Selection_To.Text = "Terra";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 LUNA";
                    txt_Bridge_Fee.Text = "0 LUNA";
                    lbl_Importo_To.Text = "LUNA";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.LUNA;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.LUNA + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.LUNA) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "TIA":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Cronos");
                    Chain_Selection_To.Text = "Cronos";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 TIA";
                    txt_Bridge_Fee.Text = "0 TIA";
                    lbl_Importo_To.Text = "TIA";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.TIA;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.TIA + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.TIA) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "USDT":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Polygon");
                    Chain_Selection_To.Text = "Polygon";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 USDT";
                    txt_Bridge_Fee.Text = "0 USDT";
                    lbl_Importo_To.Text = "USDT";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.USDT;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.USDT + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.USDT) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "USDC":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Polygon");
                    Chain_Selection_To.Text = "Polygon";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 USDC";
                    txt_Bridge_Fee.Text = "0 USDC";
                    lbl_Importo_To.Text = "USDC";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.USDC;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.USDC + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.USDC) == 0)
                        Btn_Swap.Enabled = false;
                    break;
                case "axlUSDC":
                    Chain_Selection_To.Items.Clear();
                    Chain_Selection_To.Items.Add("Terra");
                    Chain_Selection_To.Text = "Terra";

                    txt_Wallet_Withdrawal.Text = "Not Need - Internal Only";
                    txt_Wallet_Withdrawal.ReadOnly = true;

                    txt_Transaction_Fee.Text = "0 axlUSDC";
                    txt_Bridge_Fee.Text = "0 axlUSDC";
                    lbl_Importo_To.Text = "axlUSDC";
                    txt_Coin_Disponibili_To.Text = "Protocollo: " + Variabili.Bilanci.Protocol_Swap.axlUSDC;
                    lbl_Price_To.Text = "Prezzo: " + Variabili.Prezzi.Protocol.axlUSDC + " USDT";

                    if (Convert.ToDouble(Variabili.Prezzi.Protocol.axlUSDC) == 0)
                        Btn_Swap.Enabled = false;
                    if (Chain_Selection_From.Text != Chain_Selection_To.Text)
                        txt_Bridge_Fee.Text = "0 axlUSDC";

                    break;
            }
        }

        private async void checkB_Show_Client_Balance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Show_Client_Balance.Checked == true) Panel_Credito_Utente.Visible = true;
            else Panel_Credito_Utente.Visible = false;

            await Load_User_Balance();
        }
        public Task Load_User_Balance()
        {
            txt_Chia_Balance.Text       = Variabili.Bilanci.Swap.XCH;
            txt_Atom_Balance.Text       = Variabili.Bilanci.Swap.ATOM;
            txt_Cro_Balance.Text        = Variabili.Bilanci.Swap.CRO;
            txt_Luna_Balance.Text       = Variabili.Bilanci.Swap.LUNA;
            txt_Tia_Balance.Text        = Variabili.Bilanci.Swap.TIA;
            txt_USDT_Balance.Text       = Variabili.Bilanci.Swap.USDT;
            txt_USDC_Balance.Text       = Variabili.Bilanci.Swap.USDC;
            txt_axlUSDC_Balance.Text    = Variabili.Bilanci.Swap.axlUSDC;
            txt_XDLS_Balance.Text       = Variabili.Bilanci.Swap.XDLS;
            txt_XUSDT_Balance.Text      = Variabili.Bilanci.Swap.XUSDT;
            return Task.CompletedTask;
        }
        public Task Update_UI_Swap(string from, string to)
        {
            switch (to)
            {
                case "CHIA":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.XCH;
                    break;
                case "ATOM":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.ATOM;
                    break;
                case "CRO":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.CRO;
                    break;
                case "LUNA":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.LUNA;
                    break;
                case "USDT":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.USDT;
                    break;
                case "USDC":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.USDC;
                    break;
                case "axlUSDC":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.axlUSDC;
                    break;
                case "XDLS":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.XDLS;
                    break;
                case "XUSDT":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.XUSDT;
                    break;
                case "DMP":
                    txt_Coin_Disponibili_To.Text = "Disponibili: " + Variabili.Bilanci.Protocol_Swap.DMP;
                    break;
            }
            switch (from)
            {
                case "CHIA":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XCH;
                    break;
                case "ATOM":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.ATOM;
                    break;
                case "CRO":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.CRO;
                    break;
                case "LUNA":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.LUNA;
                    break;
                case "USDT":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.USDT;
                    break;
                case "USDC":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.USDC;
                    break;
                case "axlUSDC":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.axlUSDC;
                    break;
                case "XDLS":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XDLS;
                    break;
                case "XUSDT":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.XUSDT;
                    break;
                case "DMP":
                    txt_Coin_Disponibili_From.Text = "Disponibili: " + Variabili.Bilanci.Swap.DMP;
                    break;
            }
            Load_User_Balance();
            return Task.CompletedTask;
        }

        private async void Btn_Swap_Click(object sender, EventArgs e)
        {
            Btn_Swap.Enabled = false;
            Coin_Selection_From.Enabled = false;
            Coin_Selection_To.Enabled = false;
            CultureInfo culture = new CultureInfo("it-IT");

            double depositAmount = 0;
            double protocol_Fee = 0;
            string selezione = Coin_Selection_From.Text;

            double.TryParse(txt_Coin_From_Importo.Text.Replace(".", ","), NumberStyles.Number, culture, out depositAmount);
            switch (selezione)
            {
                case "CHIA":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.XCH) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "CHIA");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "ATOM":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.ATOM) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "ATOM");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "CRO":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.CRO) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "CRO");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "LUNA":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.LUNA) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "LUNA");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "USDT":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.USDT) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "USDT");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "USDC":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.USDC) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "USDC");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "axlUSDC":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.axlUSDC) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "axlUSDC");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "XDLS":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.XDLS) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "XDLS");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
                case "XUSDT":
                    if (Convert.ToDouble(Variabili.Bilanci.Swap.XUSDT) < depositAmount)
                    {
                        Btn_Swap.Text = "Fondi Insufficienti";
                        checkB_Show_Client_Balance.Checked = true;
                        await Sleep_Timer_Seed_Phrase(4, "XUSDT");
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                    break;
            }
            if (await Sleep_Protocol_Balance(4) == true)
            {
                Btn_Swap.Enabled = true;
                Coin_Selection_From.Enabled = true;
                Coin_Selection_To.Enabled = true;
                return;
            }

            if (Btn_Swap.Text == "Fondi Insufficienti") 
                Btn_Swap.Text = "Update Data";
            if (Btn_Swap.Text == "Update Data")
            {
                Btn_Swap.Enabled = false;

                try {
                    if (double.TryParse(txt_Coin_From_Importo.Text.Replace(".", ","), out depositAmount) && depositAmount > 0)
                    {
                        if (!double.TryParse(txt_Protocol_Fee.Text.Replace(".", ",").Replace(" %", ""), out protocol_Fee) && protocol_Fee > 0)
                        {
                            System.Windows.MessageBox.Show("L'importo deve essere maggiore di zero o un numero valido [protocol_Fee]."); // Gestisci il caso in cui il valore convertito è non positivo (<= 0)
                            Btn_Swap.Enabled = true;
                            Coin_Selection_From.Enabled = true;
                            Coin_Selection_To.Enabled = true;
                            return;
                        }
                        Btn_Swap.Text = "SWAP";
                        await ClientsConnection.TestClient.Send_Server($"swap_result|{Variabili.wallet}|{txt_Coin_From_Importo.Text.Replace(".", ",")}|{Coin_Selection_From.Text.Replace(".", ",")}|{Coin_Selection_To.Text.Replace(".", ",")}|{txt_Protocol_Fee.Text.Replace(".",",")}|{txt_Transaction_Fee.Text.Replace(".", ",")}|{txt_Bridge_Fee.Text.Replace(".", ",")}");
                        await Sleep(4000);
                        txt_Coin_Recived.Text = Variabili.swap_Result;
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        if (Convert.ToDouble(txt_Coin_Recived.Text) == 0)
                            Btn_Swap.Text = "Update Data";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("L'importo deve essere maggiore di zero o un numero valido [depositAmount]."); // Gestisci il caso in cui il valore convertito è non positivo (<= 0)
                        Btn_Swap.Enabled = true;
                        Coin_Selection_From.Enabled = true;
                        Coin_Selection_To.Enabled = true;
                        return;
                    }
                }
                catch (FormatException) { MessageBox.Show("Inserisci un valore numerico valido."); } // Gestisci il caso in cui il testo non può essere convertito in un numero
                catch (OverflowException) { MessageBox.Show("Il valore inserito è troppo grande."); } // Gestisci il caso in cui il testo rappresenta un numero troppo grande per essere convertito
                catch (Exception ex) { MessageBox.Show($"Si è verificato un errore: {ex.Message}"); } // Gestisci altre eccezioni non previste

                await Sleep(1000);
            }
            if (Btn_Swap.Text == "SWAP")
            {
                Swapping(4);
                double coin_Da = 0;
                Btn_Swap.Enabled = false;

                if (double.TryParse(txt_Coin_From_Importo.Text, NumberStyles.Number, culture, out coin_Da) == true && double.TryParse(txt_Protocol_Fee.Text.Replace(" %", ""), NumberStyles.Number, culture, out coin_Da) == true)
                {
                    await ClientsConnection.TestClient.Send_Server($"swap|{Variabili.wallet}|{txt_Coin_From_Importo.Text}|{Coin_Selection_From.Text}|{Coin_Selection_To.Text}|{txt_Protocol_Fee.Text}|{txt_Transaction_Fee.Text}|{txt_Bridge_Fee.Text}");
                    await ClientsConnection.TestClient.Send_Server($"transaction|{Variabili.wallet}");
                    Variabili.swap_Result = "0.0000000000";
                    txt_Coin_Recived.Text = "0.0000000000";
                    await Sleep(3000);
                    await Update_UI_Swap(Coin_Selection_From.Text, Coin_Selection_To.Text);

                    datagrid_Unstake.Rows.Clear();
                    if (Variabili.swap_TRansaction.Count != 0)
                        foreach (var item in Variabili.swap_TRansaction)
                            datagrid_Unstake.Rows.Add(item);
                }
                //End Code
                Btn_Swap.Enabled = true;
                Btn_Swap.Text = "Update Data";
                Coin_Selection_From.Enabled = true;
                Coin_Selection_To.Enabled = true;
                Coin_Selection_To.Text = Chain_Selection_To.Text;
                txt_Coin_From_Importo.Text = "0";
            }
        }

        public Task Sleep(int millisecondi)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(millisecondi);
            });
        }
        private async Task<bool> Sleep_Protocol_Balance(int secondi)
        {
            while (true)
                if (txt_Coin_Disponibili_To.Text == "Disponibili: 0")
                {
                    Btn_Swap.Text = "Fondi Insufficienti (Protocollo)";
                    txt_Coin_Disponibili_To.BackColor = Color.FromArgb(0, 7, 33);
                    await Task.Delay(125);
                    if (secondi * 4 == contatore_Timer_Avvisi)
                    {
                        contatore_Timer_Avvisi = 0;
                        txt_Coin_Disponibili_To.BackColor = Color.FromArgb(0, 7, 33);
                        return true;
                    }
                    else
                    {
                        contatore_Timer_Avvisi++;
                        txt_Coin_Disponibili_To.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                }else return false;
        }
        public async Task<bool> Sleep_Timer_Seed_Phrase(int secondi, string coin)
        {
            switch (coin) {
                case "CHIA":
                    while (true)
                    {
                        txt_Chia_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_Chia_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_Chia_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "ATOM":
                    while (true)
                    {
                        txt_Atom_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_Atom_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_Atom_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "CRO":
                    while (true)
                    {
                        txt_Cro_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_Cro_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_Cro_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "LUNA":
                    while (true)
                    {
                        txt_Luna_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_Luna_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_Luna_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "USDT":
                    while (true)
                    {
                        txt_USDT_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_USDT_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_USDT_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "USDC":
                    while (true)
                    {
                        txt_USDC_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_USDC_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_USDC_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "axlUSDC":
                    while (true)
                    {
                        txt_axlUSDC_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_axlUSDC_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_axlUSDC_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "XDLS":
                    while (true)
                    {
                        txt_XDLS_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_XDLS_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_XDLS_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
                case "XUSDT":
                    while (true)
                    {
                        txt_XUSDT_Balance.BackColor = Color.FromArgb(0, 7, 33);
                        await Task.Delay(125);
                        if (secondi * 4 == contatore_Timer_Avvisi)
                        {
                            contatore_Timer_Avvisi = 0;
                            txt_XUSDT_Balance.BackColor = Color.FromArgb(0, 7, 33);
                            return true;
                        }
                        contatore_Timer_Avvisi++;
                        txt_XUSDT_Balance.BackColor = Color.FromArgb(196, 12, 24);
                        await Task.Delay(125);
                    }
            }
            return true;
        }
        public async void Swapping(int secondi)
        {
            int contatore_Animazione = 0;
            while (true)
            {
                Btn_Swap_NOT_USE.TextAlign = ContentAlignment.TopLeft;
                await Task.Delay(175);
                if (secondi * 4 == contatore_Animazione)
                {
                    contatore_Animazione = 0;
                    Btn_Swap_NOT_USE.TextAlign = ContentAlignment.TopLeft;
                    return;
                }
                contatore_Animazione++;
                Btn_Swap_NOT_USE.TextAlign = ContentAlignment.BottomRight;
                await Task.Delay(175);
            }
        }

        private void Btn_Swap_NOT_USE_Click(object sender, EventArgs e)
        {
            string A = Coin_Selection_From.Text;
            Coin_Selection_From.Text = Coin_Selection_To.Text;
            Coin_Selection_To.Text = A;
        }

        private void txt_Coin_From_Importo_TextChanged(object sender, EventArgs e)
        {
            Btn_Swap.Text = "Update Data";
        }
    }
}
