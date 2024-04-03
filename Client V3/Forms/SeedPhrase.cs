using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Client_V3.Forms
{
    public partial class SeedPhrase : Form
    {
        int contatore_Timer_Avvisi = 0;
        public SeedPhrase()
        {
            InitializeComponent();
        }

        private async void SeedPhrase_Load(object sender, EventArgs e)
        {
            await load_data();
            lbl_PopUp_Main_Conferma.Visible = true;
            lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai pieno accesso al client";
            lbl_Avviso_Password.Visible = false;
            lbl_PopUp_Main_XCH_Address.Text = Variabili.wallet;
            lbl_PopUp_Main_XCH_Address.Visible = true;
        }
        private async void btn_Load_Wallet_Click(object sender, EventArgs e)
        {
            lbl_Erroe.Visible = false;
            string wallet = comboBox_Load_Wallet.Text;
            var data = await load_data();
            foreach (var dati in data) {
                if (dati[0].Contains(wallet))
                {
                    Variabili.wallet = dati[0];
                    Variabili.password = dati[1];
                    Variabili.seed = dati[2];
                    Variabili.invito_Referal = dati[3];
                }
            }
            lbl_PopUp_Main_XCH_Address.Text = Variabili.wallet;
        }
        private async void btn_Add_Wallet_Click(object sender, EventArgs e)
        {
            lbl_Erroe.Visible = false;
            int a = conta_numero__transazioni();
            if (a >= 10) return;
            FormMain.add_Wallet = true;
            FormMain.goupB_Main_Form.Visible = true;
            await load_data();
            FormMain.label_Logo_Click(sender, e);
            Variabili.seed_Phrase = false;
        }

        private async void btn_Clear_Data_Post_Click(object sender, EventArgs e)
        {
            lbl_Erroe.Visible = false;
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\";
            int dato = 2;
            while (true)
            {
                System.IO.File.Delete($"{percorso_profili}Wallet\\{dato}.xml");
                int dati = conta_numero__transazioni();
                if (dati == 1)
                {
                    await load_data();
                    return;
                }
                while (System.IO.File.Exists($"{percorso_profili}Wallet\\{dato}.xml") == false)
                    dato++; //Se già esiste incrementa di 1 e riprova
            }
        }

        private async void Btn_Update_Password_Post_Click(object sender, EventArgs e)
        {
            if (txt_Update_Password.Text == "New Password? Change me" || txt_Update_Password.Text.Length <= 6)
            {
                lbl_Erroe.Text = "Inserisci una Password di almeno 7 caratteri";
                lbl_Erroe.Visible = true;
                await Sleep_Timer_Update_Password(3);
            }
            else
            {
                lbl_Erroe.Visible = false;
                Btn_Update_Password_Post.Enabled = false;
                await ClientsConnection.TestClient.Send_Server($"resetPassword|{txt_Update_Password.Text}|{txt_Reset_SeedPhrase.Text}|{Variabili.wallet}");
                await Sleep(10);
                Btn_Update_Password_Post.Enabled = true;
            }
        }

        private async void btn_Reset_Password_Post_Click(object sender, EventArgs e)
        {
            if (txt_Reset_SeedPhrase.Text == "AAAA-BBBB-CCCC-DDDD" || txt_Reset_SeedPhrase.Text.Length != 19)
            {
                lbl_Erroe.Text = "Inserisci una SeedPhrase valida, con 19 caratteri";
                lbl_Erroe.Visible = true;
                await Sleep_Timer_Update_Seed(3);
            }
            else
            {
                lbl_Erroe.Visible = false;
                btn_Reset_Password_Post.Enabled = false;
                Gbox_New_Password_Request.Visible = true;
                await ClientsConnection.TestClient.Send_Server($"updatePassword|{txt_Reset_SeedPhrase.Text}|{Variabili.wallet}");
                await Sleep(10);
                btn_Reset_Password_Post.Enabled = true;
            }
        }
        public static int conta_numero__transazioni()
        {
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\Wallet";
            return System.IO.Directory.GetFiles(percorso_profili).Length;
        }//Conta il numero di elementi all'interno della cartella database, restituendo un valore numerico
        async Task<List<string[]>> load_data()
        {
            comboBox_Load_Wallet.Items.Clear();
            List<string[]> stato_Transazione = new List<string[]>();
            string[] elementi_passati = new string[conta_numero__transazioni()];
            elementi_passati = carica_transazioni();
            for (int x = 0; x < elementi_passati.Length; x++)
            {   //Assegna ad una "stringa" nodo il valore del file .xml
                XmlDocument DocumentoXml = new XmlDataDocument();
                DocumentoXml.Load(elementi_passati[x]);
                XmlNode nodeWallet = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Wallet");
                XmlNode nodePassword = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Password");
                XmlNode nodeSeed = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Seed");
                XmlNode nodeReferal = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Referal");
                comboBox_Load_Wallet.Items.Add(nodeWallet.InnerText);
                var txn_Data = new string[] { nodeWallet.InnerText, nodePassword.InnerText, nodeReferal.InnerText, nodeSeed.InnerText };
                stato_Transazione.Add(txn_Data);
                if (x == 0)
                {
                    Variabili.wallet = nodeWallet.InnerText;
                    Variabili.password = nodePassword.InnerText;
                    Variabili.seed = nodeSeed.InnerText;
                    Variabili.invito_Referal = nodeReferal.InnerText;
                    Variabili.seed_Phrase = true;
                }
            }
            comboBox_Load_Wallet.Text = comboBox_Load_Wallet.Items[0].ToString();
            return stato_Transazione;
        }
        public static string[] carica_transazioni()
        {
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\Wallet\";
            string[] transazioni_trovate = System.IO.Directory.GetFiles(percorso_profili);
            return transazioni_trovate;
        }
        public static string Generate_Random_Transaction_Memo(int numWords, int wordLength, char separator)
        {
            StringBuilder randomString = new StringBuilder();
            for (int i = 0; i < numWords; i++)
            {
                string randomWord = Generate_Random_Code(wordLength);
                randomString.Append(randomWord);
                if (i < numWords - 1)
                    randomString.Append(separator);
            }
            return randomString.ToString();
        }
        public static string Generate_Random_Code(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            byte[] data = new byte[length];

            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
                rng.GetBytes(data);

            StringBuilder code = new StringBuilder(length);

            foreach (byte byteValue in data)
                code.Append(characters[byteValue % characters.Length]);
            return code.ToString();
        }
        public static async Task<bool> Sleep(int secondi)
        {
            await Task.Delay(1000 * secondi);
            return true;
        }
        public async Task<bool> Sleep_Timer_Update_Seed(int secondi) {
            while (true)
            {
                txt_Reset_SeedPhrase.BackColor = Color.DarkRed;
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_Reset_SeedPhrase.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_Reset_SeedPhrase.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
        public async Task<bool> Sleep_Timer_Update_Password(int secondi) {
            while (true)
            {
                txt_Update_Password.BackColor = Color.DarkRed;
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_Update_Password.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_Update_Password.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
    }
}
