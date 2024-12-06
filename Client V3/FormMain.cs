using Client.Forms;
using Client_V3.Forms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Color = System.Drawing.Color;
using System.Xml;
using System.Globalization;
using System.Collections.Generic;

namespace Client_V3
{
    public partial class FormMain : Form
    {
        private static  IconButton currentBtn;
        private static Panel leftBorderBtn;
        public static Form currentChildForm;
        static int contatore_Timer = 0;
        static int contatore_Timer_Avvisi = 0;
        static bool loop = false;
        public static bool add_Wallet = false;
        static int errori = 0;

        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panel_Menu_Laterale.Controls.Add(leftBorderBtn);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(39, 45, 59);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                icon_Current_Selection.IconChar = currentBtn.IconChar;
                icon_Current_Selection.IconColor = color;
            }
        }
        private static void DisableButton()
        {
            // Reimpostiamo i valori predefiniti del bottone una volta che viene deselezionato
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(39, 45, 59);
                currentBtn.ForeColor = Color.DarkOrange;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private static void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(childForm);
            panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_Form_Selected.Text = childForm.Text;
        }
        private async void FormMain_Load(object sender, EventArgs e)
        {
            await Menu_First_Register();
            await ClientsConnection.TestClient.Connessione();
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\";
            //Caricamento dati salvati
            if (System.IO.File.Exists($"{percorso_profili}Wallet\\{1}.xml") == true)
            {
                btn_Conferma_Main.Enabled = false;
                btn_Login.Enabled = false;
                var data = await load_data();
                foreach (var dati in data)
                {
                    Variabili.wallet = dati[0];
                    Variabili.password = dati[1];
                    Variabili.invito_Referal = dati[2];
                }
                await ClientsConnection.TestClient.Send_Server($"login|{Variabili.wallet}|{Variabili.password}");
                await Update_Data(); //Aggiornamento dati
                await Sleep_Timer(4, "Login");

                btn_Conferma_Main.Enabled = true;
                btn_Login.Enabled = true;
                Btn_Sync.Enabled = false;
                txt_Password.Visible = true; // <-- password main -->
                goupB_Main_Form.Visible = false;
                btn_Conferma_Main.Text = "Conferma";

                Variabili.seed = Forms.SeedPhrase.Generate_Random_Transaction_Memo(4, 4, '-');
                if (Variabili.login_Stato == true || Variabili.login_Approved == true)
                {
                    Gbox_Reset_Password.Visible = true;  // <-- Seed Phrase
                    txt_User.Text = $"ID: {Variabili.id_Client}";
                }

                Menu_Coming_Soon();
                Wallet();
                await Update_Data(); //Aggiornamento dati

                return;
            }

            Btn_Sync.Enabled = false;
            txt_Password.Visible = true; // <-- password main -->
            Variabili.seed = Forms.SeedPhrase.Generate_Random_Transaction_Memo(4, 4, '-');

            if (Variabili.login_Stato == true || Variabili.seedPhrase_Approved == true)
                Gbox_Reset_Password.Visible = true;  // <-- Seed Phrase

            if (Variabili.login_Approved == false) //Sostituire con l'avvenuta autenticazione, se in lista server, e con i propri dati salvati in locale.. es. wallet, pass, ref
                await Menu_First_Register();
            else
            {
                goupB_Main_Form.Visible = false;
                Menu_Coming_Soon();
                Wallet();
            }
            await Update_Data(); //Aggiornamento dati

            btn_Conferma_Main.Enabled = true;
        }
        private async void btn_Conferma_Main_Click(object sender, EventArgs e)
        {
            lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false; // Resetta la visibilità dell'errore...
            btn_Login.Enabled = false;

            if (Variabili.login_Stato == true)
            {
                Gbox_Reset_Password.Visible = true;  // <-- Seed Phrase
                groupBox_Riscrivi_Seed.Visible = false;
                txt_Inserisci_Seed_Phrase_1.Text = "XXXX-XXXX-XXXX-XXXX";
                txt_Inserisci_Seed_Phrase_2.Text = "XXXX-XXXX-XXXX-XXXX";
            }

            if (loop == true)
            { 
                contatore_Timer = 0;
                Sleep_Timer_Seed_Phrase(4);
                return; 
            }
            if(!txt_User_Address.Text.Contains("xch"))
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Il wallet Chia deve inziare con xch";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                radioBtn_EULA_1.Checked = false;
                radioBtn_EULA_2.Checked = false;
                await Sleep_Timer_Wallet_Chia(3);
                loop = false;
                btn_Login.Enabled = true;
                return;
            }
            if (txt_User_Address.Text.Length != 62)
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Il wallet Chia deve contenere 63 caratteri";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                radioBtn_EULA_1.Checked = false;
                radioBtn_EULA_2.Checked = false;
                await Sleep_Timer_Wallet_Chia(3);
                loop = false;
                btn_Login.Enabled = true;
                return;
            }
            if (txt_User_Address.Text == "Inserisci wallet XCH")
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Inserisci un wallet valido";
                radioBtn_EULA_1.Checked = false;
                radioBtn_EULA_2.Checked = false;
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                await Sleep_Timer_Wallet_Chia(3);
                loop = false;
                btn_Login.Enabled = true;
                return;
            }
            if (txt_User_Address.Text.Length == 0)
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Inserisci un wallet valido";
                radioBtn_EULA_1.Checked = false;
                radioBtn_EULA_2.Checked = false;
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                await Sleep_Timer_Wallet_Chia(3);
                loop = false;
                btn_Login.Enabled = true;
                return;
            }
            if (txt_Password.Text.Length > 30)
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Password massimo 30 caratteri";
                radioBtn_EULA_1.Checked = false;
                radioBtn_EULA_2.Checked = false;
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                await Sleep_Timer_Wallet_Chia(3);
                loop = false;
                btn_Login.Enabled = true;
                return;
            }
            
            if (Variabili.login_Stato == true) //Login
                if (txt_Inserisci_Seed_Phrase_1.Text == txt_Inserisci_Seed_Phrase_2.Text)
                {
                    bool stato = await Login(); // Se premuto il pulsante Login in precedenza
                    if (stato == false) return;

                    btn_Login.Enabled = true;
                    Client_V3.Properties.Settings.Default.Salvataggio = true;
                    Properties.Settings.Default.Save();
                    Variabili.login_Stato = false;
                    btn_Login.Visible = false;
                    Add_on_List();
                    Reset_Main();
                    return;
                } else await Sleep_Timer_Color(3);
    
            if (errori == 0)
            {
                Variabili.seed = Forms.SeedPhrase.Generate_Random_Transaction_Memo(4, 4, '-');
                txt_Seed_Phrase.Text = Variabili.seed;

            }
            if (radioBtn_EULA_1.Checked == true && radioBtn_EULA_2.Checked == true) {
                if (groupBox_Riscrivi_Seed.Visible == false)
                {
                    loop = true;
                    btn_Conferma_Main.Enabled = false;
                    btn_Conferma_Main.Text = "ATTENDERE";
                    await Sleep(2);
                    btn_Conferma_Main.ForeColor = Color.Red;
                    btn_Conferma_Main.Enabled = true;
                    btn_Conferma_Main.ForeColor = Color.ForestGreen;
                    await Sleep_Timer(3, "");
                
                    txt_Avviso.Text = txt_Seed_Phrase.Text; // <<-- Seed Phrase
                    lbl_Avviso.Visible = true;              // <<-- Seed Phrase - Scritta lbl
                    txt_Avviso.Visible = true;              // <<-- Seed Phrase - Testo
                
                    btn_Conferma_Main.Text = "Inserisci Seed Phrase";
                    Sleep_Timer_Seed_Phrase(4);
                    await Sleep_Timer(18, "Assicurati di aver salvato la Seed Phrase");
                    await Sleep_Timer(1, "Conferma");

                    Gbox_Seed_Phrase.Visible = true;        // <<-- Seed Phrase - Box Reinserimento
                    groupBox_Riscrivi_Seed.Visible = true;
                    Sleep_Timer_Seed_Phrase(4);
                }
                if (txt_Inserisci_Seed_Phrase_1.Text != txt_Inserisci_Seed_Phrase_2.Text || ( txt_Seed_Phrase.Text != txt_Inserisci_Seed_Phrase_1.Text && txt_Seed_Phrase.Text != txt_Inserisci_Seed_Phrase_2.Text))
                {
                    lbl_Avviso_Main.Text = "Inserisci la seed Prase per continuare";
                    lbl_Avviso_Main_Titolo.Visible = true;
                    lbl_Avviso_Main.Visible = true;
                    lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                    lbl_Avviso_Main.Text = "Riscrivi la Seed Phrase";
                    lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;

                    if (errori >= 2)
                        await Sleep_Timer_Color(3);
                    errori++;
                    loop = false;
                    return;
                }
                else
                {
                    btn_Conferma_Main.Text = "Conferma";
                    groupBox_Riscrivi_Seed.Visible = true;
                }

                lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false;

                Variabili.wallet = txt_User_Address.Text;
                Variabili.password = txt_Password.Text;
                Variabili.invito_Referal = txt_Referal_Code.Text;

                Add_on_List();
                Menu_Coming_Soon();
                Wallet();
                Reset_Main();
            }
            else
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Conferma presa visione EULA";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                await Sleep_Timer_EULA(3);
            }
        }
        void Reset_Main()
        {
            //Resettiamo i campi per i nuovi dati
            loop = false;
            lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false; // Resetta la visibilità dell'errore...
            Gbox_Seed_Phrase.Visible = false;
            txt_User_Address.Text = "Inserisci wallet XCH";
            txt_Password.Text = "Inserisci Password";
            txt_Referal_Code.Text = "Ref_Code";

            Gbox_Seed_Phrase.Visible = false;
            txt_Inserisci_Seed_Phrase_1.Text = "SEED-xDIx-PROVA-xxxx";
            txt_Inserisci_Seed_Phrase_2.Text = "SEED-xDIx-PROVA-x12x";
            Gbox_Seed_Phrase.Visible = false;
            txt_Avviso.Text = "AAAA-BBBB-CCCC-DDDD";
            groupBox_Riscrivi_Seed.Visible = false;
            radioBtn_EULA_1.Checked = false;
            radioBtn_EULA_2.Checked = false;
            loop = false;
            errori = 0;
        }
        void Add_on_List() {
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\";

            if (System.IO.Directory.Exists(percorso_profili) == false)
                System.IO.Directory.CreateDirectory(percorso_profili);
            if (System.IO.Directory.Exists(percorso_profili + @"Wallet\") == false)
                System.IO.Directory.CreateDirectory(percorso_profili + @"Wallet\");

            int id = 1;
            string password     = Variabili.password;
            string wallet       = Variabili.wallet;
            string referal      = Variabili.invito_Referal;

            XDocument Salvataggio_Xml = new XDocument(new XElement("Wallet_Data",
                new XElement("Wallet", wallet),
                new XElement("Password", password),
                new XElement("Referal", referal)
                ));

            //while (System.IO.File.Exists($"{percorso_profili}Wallet\\{id}.xml") == true)
            //    id++; //Se già esiste incrementa di 1 e riprova
            Salvataggio_Xml.Save($"{percorso_profili}Wallet\\{id}.xml"); //Crea - Salva file | Database _path

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
            }
        }
        public static int conta_numero__transazioni()
        {
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\Wallet";
            return System.IO.Directory.GetFiles(percorso_profili).Length;
        }//Conta il numero di elementi all'interno della cartella database, restituendo un valore numerico
        public static string[] carica_transazioni()
        {
            var percorso_profili = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Deep_Client_\Wallet\";
            string[] transazioni_trovate = System.IO.Directory.GetFiles(percorso_profili);
            return transazioni_trovate;
        }
        void Menu_Coming_Soon()
        {
            // Coming soon Color -->  Color.FromArgb(110, 106, 106); Base Color -->  Color.FromArgb(39, 45, 59);
            lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false; Btn_Sync.Enabled = false;

            btn_Home.Enabled = true;
            btn_Home.Text = "Home";
            btn_Home.BackColor = Color.FromArgb(39, 45, 59);

            btn_Dashboard.Enabled = false;
            btn_Dashboard.Text = "Coming Soon"; // Dashboard
            btn_Dashboard.BackColor = Color.FromArgb(110, 106, 106);

            btn_Staking.Enabled = true;
            btn_Staking.Text = "Staking"; // Staking
            btn_Staking.BackColor = Color.FromArgb(39, 45, 59);
            //Color.FromArgb(110, 106, 106); Coming Soon color

            btn_Simulate.Enabled = true;
            btn_Simulate.Text = "Simulate";
            btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);

            btn_Payment.Enabled = true;
            btn_Payment.Text = "Payment";
            btn_Payment.BackColor = Color.FromArgb(39, 45, 59);

            Btn_Swap.Enabled = true;
            Btn_Swap.Text = "Swap"; //Swap
            Btn_Swap.BackColor = Color.FromArgb(39, 45, 59);

            btn_Wallet.Enabled = true;
            btn_Wallet.Text = "Wallet";
            btn_Wallet.BackColor = Color.FromArgb(39, 45, 59);

            goupB_Main_Form.Visible = false;
        }
        async Task Menu_First_Register()
        {
            lbl_Avviso_Main.Visible = false; btn_Home.Enabled = false;
            btn_Home.Text = "First Register";
            btn_Home.BackColor = Color.FromArgb(110, 106, 106);

            btn_Dashboard.Enabled = false;
            btn_Dashboard.Text = "First Register";
            btn_Dashboard.BackColor = Color.FromArgb(110, 106, 106);

            btn_Simulate.Enabled = false;
            btn_Simulate.Text = "First Register";
            btn_Simulate.BackColor = Color.FromArgb(110, 106, 106);

            btn_Payment.Enabled = false;
            btn_Payment.Text = "First Register";
            btn_Payment.BackColor = Color.FromArgb(110, 106, 106);

            btn_Staking.Enabled = false;
            btn_Staking.Text = "First Register";
            btn_Staking.BackColor = Color.FromArgb(110, 106, 106);

            Btn_Swap.Enabled = false;
            Btn_Swap.Text = "First Register";
            Btn_Swap.BackColor = Color.FromArgb(110, 106, 106);

            btn_Wallet.Enabled = false;
            btn_Wallet.Text = "First Register";
            btn_Wallet.BackColor = Color.FromArgb(110, 106, 106);
        }
        public static async Task<bool> Update_Data()
        {
            await ClientsConnection.TestClient.Send_Server($"data|{Variabili.wallet}"); //Dati utente, credito, giorni rimasti, bonus, etc etc etc
            await ClientsConnection.TestClient.Send_Server($"bonus|{Variabili.wallet}"); //Aggiorniamo dati form Home - Balance protocol
            await ClientsConnection.TestClient.Send_Server($"home|{Variabili.wallet}"); //Invia le fee per il prelievo di xch
            await ClientsConnection.TestClient.Send_Server($"rendita|{Variabili.wallet}"); //Aggiorniamo dati form Home - Balance protocol
            await ClientsConnection.TestClient.Send_Server($"balance|{Variabili.wallet}"); //Bilanci
            await ClientsConnection.TestClient.Send_Server($"update_user_balance|{Variabili.wallet}"); //Richiesta dati - Bilancio Utente
            await ClientsConnection.TestClient.Send_Server($"transaction|{Variabili.wallet}"); //Transazioni (CM, Staking, Unstake) CM = Cloud Mining
            await ClientsConnection.TestClient.Send_Server("update_coin_price|0"); //Richiesta prezzi coin swap

            return true;
        }

        #region FORMS
        private void btn_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Home());
            btn_Login.Visible = false;
            btn_Update.Visible = true;
            Variabili.login_Stato = false;
        }
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Payment());
            btn_Login.Visible = false;
            btn_Update.Visible = false;
            Variabili.login_Stato = false;
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Dashboard());
            btn_Login.Visible = false;
            btn_Update.Visible = false;
            Variabili.login_Stato = false;
        }
        private void btn_Simulate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Simulate());
            btn_Login.Visible = false;
            btn_Update.Visible = false;
            Variabili.login_Stato = false;
        }
        private void btn_Staking_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Staking());
            btn_Login.Visible = false;
            btn_Update.Visible = true;
            Variabili.login_Stato = false;
        }
        private void btn_EULA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new EULA());
            btn_Login.Visible = false;
            Variabili.login_Stato = false;
        }
        private void Btn_Swap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Swap());
            btn_Login.Visible = false;
            btn_Update.Visible = true;
            Variabili.login_Stato = false;
        }
        private void btn_Wallet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new SeedPhrase());
            btn_Update.Visible = false;
            btn_Login.Visible = true;
            btn_Login.Enabled = true;
        }

        private void Wallet()
        {

            OpenChildForm(new SeedPhrase());
            btn_Update.Visible = false;
            btn_Login.Visible = true;
            Variabili.login_Stato = false;
        }
        #endregion
        public static void label_Logo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
            else Reset();

            add_Wallet = true;
            goupB_Main_Form.Visible = true;
        }
        public static void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_Current_Selection.IconChar = IconChar.A;   //Icona
            icon_Current_Selection.IconColor = Color.FromArgb(24, 161, 251); //Colore
            label_Form_Selected.Text = "New User";
        }
        //Struttura colori RGB per le icone dei pulsanti del pannello laterale
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(19, 164, 14);
            public static Color color3 = Color.FromArgb(44, 203, 198);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.Green;
        }
        private async void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            await ClientsConnection.TestClient.Disconnetti();
            Thread.Sleep(1000);
            Application.Exit();
        }
        private async void Btn_Sync_Click(object sender, EventArgs e)
        {
            Btn_Sync.Enabled = false;
            //Inviare prima quante transazioni ha il client
            int numero_Transazioni = Variabili.conta_numero_elementi();

            //Connessione al server se non è già connessio
            ClientsConnection.argomento_Invio = "richiesta_Sync_Transazioni" + "|" + numero_Transazioni + "|" + "Referal";
            if (ClientsConnection.client_Connesso == false)
                await ClientsConnection.TestClient.InitializeClient(); //Connessione Client al server

            //Controllare che le cartelle esistano, altrimenti le creiamo
            if (System.IO.Directory.Exists(Variabili.test_Percorso_Cartella) == false)
                System.IO.Directory.CreateDirectory(Variabili.test_Percorso_Cartella);
            if (System.IO.Directory.Exists(Variabili.test_Percorso_Transazioni) == false)
                System.IO.Directory.CreateDirectory(Variabili.test_Percorso_Transazioni);

            //Ricevere la risposta
            string risposta = ClientsConnection.argomento_Ricevuto;

            //Salvare le transazioni nella cartella
            string encoded_file = Encoding.UTF8.GetString(Convert.FromBase64String(risposta));
            Console.WriteLine("*********************************************");
            Console.WriteLine("Risposta server: " + encoded_file);

            int id_file = 1;
            while (System.IO.File.Exists(Variabili.percorso_database + id_file + ".xml") == true)
                id_file++; //Se già esiste incrementa di 1 e riprova

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(Variabili.percorso_database + id_file + ".xml")))
                await outputFile.WriteAsync(encoded_file); // Salva il file da stringa
            
            Console.WriteLine("Transazioni salvate correttamete - Sync completato, bona caro ^.^ ");

            //Ciudere la connessione col server
            //await Disconnetti();
            
            //Reset risposta server nel dubbio
            //ClientsConnection.argomento_Ricevuto = "";

            //Bloccare il bottone per circa 5 minuti dopo l'avvenuto sync, per evitare richieste multiple
            await Sleep(5);
            Btn_Sync.Enabled = true;
        }
        public static async Task<bool> Sleep(int secondi) {
            await Task.Delay(1000 * secondi);
            return true;
        }
        public async Task<bool> Sleep_Timer(int secondi, string testo) {
            while(true) {
                btn_Conferma_Main.Text = $"{testo} ({secondi - contatore_Timer}s)";
                if (secondi == contatore_Timer)
                {
                    if (secondi - contatore_Timer == 0)
                        btn_Conferma_Main.Text = $"{testo}";
                    contatore_Timer = 0;
                    return true;
                }
                contatore_Timer++;
                await Task.Delay(1000);
            }
        }
        public async Task<bool> Sleep_Timer_Color(int secondi){
            while (true)
            {
                txt_Inserisci_Seed_Phrase_1.BackColor = Color.DarkRed; // Reinserimento Seed Phrase non corretto 1
                txt_Inserisci_Seed_Phrase_2.BackColor = Color.DarkRed; // Reinserimento Seed Phrase non corretto 2
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_Inserisci_Seed_Phrase_1.BackColor = Color.FromArgb(32, 36, 47);
                    txt_Inserisci_Seed_Phrase_2.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_Inserisci_Seed_Phrase_1.BackColor = Color.FromArgb(32, 36, 47);
                txt_Inserisci_Seed_Phrase_2.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
        public async Task<bool> Sleep_Timer_Wallet_Chia(int secondi) {
            while (true)
            {
                txt_User_Address.BackColor = Color.DarkRed;
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_User_Address.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_User_Address.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
        public async Task<bool> Sleep_Timer_EULA(int secondi) {
            while (true)
            {
                radioBtn_EULA_1.BackColor = Color.DarkRed;
                radioBtn_EULA_2.BackColor = Color.DarkRed;
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    radioBtn_EULA_1.BackColor = Color.FromArgb(32, 36, 47);
                    radioBtn_EULA_2.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                radioBtn_EULA_1.BackColor = Color.FromArgb(32, 36, 47);
                radioBtn_EULA_2.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
        public async Task<bool> Sleep_Timer_Seed_Phrase(int secondi){
            while (true)
            {
                txt_Avviso.BackColor = Color.DarkGreen;
                txt_Seed_Phrase.BackColor = Color.DarkGreen;
                await Task.Delay(125);
                if (secondi * 4 == contatore_Timer_Avvisi)
                {
                    contatore_Timer_Avvisi = 0;
                    txt_Avviso.BackColor = Color.FromArgb(32, 36, 47);
                    txt_Seed_Phrase.BackColor = Color.FromArgb(32, 36, 47);
                    return true;
                }
                contatore_Timer_Avvisi++;
                txt_Avviso.BackColor = Color.FromArgb(32, 36, 47);
                txt_Seed_Phrase.BackColor = Color.FromArgb(32, 36, 47);
                await Task.Delay(125);
            }
        }
        private async void btn_Reset_Password_Click(object sender, EventArgs e)
        {
            Gbox_New_Password.Visible = true;
            btn_Reset_Password.Enabled = false;
            await ClientsConnection.TestClient.Send_Server($"resetPassword|{txt_Reset_Seed_Phrase.Text}|{Variabili.wallet}");
            await Sleep(10);
        }
        private async void btn_New_Password_Request_Click(object sender, EventArgs e)
        {
            btn_New_Password_Request.Enabled = false;
            await ClientsConnection.TestClient.Send_Server($"updatePassword|{txt_Reset_Seed_Phrase.Text}|{Variabili.wallet}");
            await Sleep(10);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Variabili.login_Stato = true;
            label_Logo_Click(sender, e);
            if (Variabili.login_Stato == true) label_Form_Selected.Text = "Login";
            btn_Conferma_Main.Enabled = true;
            btn_Conferma_Main.Text = "Login";
        }
        async Task<bool> Login()
        {
            btn_Conferma_Main.Text = "Login";
            btn_Conferma_Main.ForeColor = Color.MediumSeaGreen;
            btn_Conferma_Main.Enabled = false;

            await ClientsConnection.TestClient.Send_Server($"login|{txt_User_Address.Text}|{txt_Password.Text}");
            await Sleep_Timer(5, "Attendi");

            if (Variabili.login_Approved == false)
            {
                Console.WriteLine($"Login fallito | {Variabili.login_Approved}");
                btn_Conferma_Main.Enabled = true;
                btn_Conferma_Main.ForeColor = Color.Red;
                btn_Conferma_Main.Text = "Login Fallito.... Riprova con un'altra password o Resettala";
                return false;
            }

            btn_Conferma_Main.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            panel_Referal.Visible = false;
            GroupBox_Eula.Visible = false;


            /*
               btn_Home.Enabled = true;
               btn_Home.Text = "Home";
               btn_Home.BackColor = Color.FromArgb(39, 45, 59);
            */

            btn_Dashboard.Enabled = true;
            btn_Dashboard.Text = "Dashboard";
            btn_Dashboard.BackColor = Color.FromArgb(39, 45, 59);

            btn_Simulate.Enabled = true;
            btn_Simulate.Text = "Simulate";
            btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);

            btn_Payment.Enabled = true;
            btn_Payment.Text = "Payment";
            btn_Payment.BackColor = Color.FromArgb(39, 45, 59);
            goupB_Main_Form.Visible = false;

            Variabili.wallet = txt_User_Address.Text;
            Variabili.password = txt_Password.Text;
            Variabili.seed = txt_Avviso.Text;
            Variabili.invito_Referal = txt_Referal_Code.Text;

            Menu_Coming_Soon();
            Wallet();
            Reset_Main();
            return true;
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            await Update_Data();
            btn_Update.Enabled = false;
            await Sleep_Timer_Update(6, "Update");
            btn_Update.Enabled = true;
            txt_User.Text = $"ID: {Variabili.id_Client}";
        }
        public async Task<bool> Sleep_Timer_Update(int secondi, string testo)
        {
            while (true)
            {
                btn_Update.Text = $"{testo} ({secondi - contatore_Timer}s)";
                if (secondi == contatore_Timer)
                {
                    if (secondi - contatore_Timer == 0)
                        btn_Update.Text = $"{testo}";
                    contatore_Timer = 0;
                    return true;
                }
                contatore_Timer++;
                await Task.Delay(1000);
            }
        }
        async Task<List<string[]>> load_data()
        {
            List<string[]> stato_Transazione = new List<string[]>();
            string[] elementi_passati = new string[conta_numero__transazioni()];
            elementi_passati = carica_transazioni();
            for (int x = 0; x < elementi_passati.Length; x++)
            {   //Assegna ad una "stringa" nodo il valore del file .xml
                XmlDocument DocumentoXml = new XmlDataDocument();
                DocumentoXml.Load(elementi_passati[x]);
                XmlNode nodeWallet = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Wallet");
                XmlNode nodePassword = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Password");
                XmlNode nodeReferal = DocumentoXml.DocumentElement.SelectSingleNode("/Wallet_Data/Referal");
                var txn_Data = new string[] { nodeWallet.InnerText, nodePassword.InnerText, nodeReferal.InnerText };
                stato_Transazione.Add(txn_Data);
                if (x == 0)
                {
                    Variabili.wallet = nodeWallet.InnerText;
                    Variabili.password = nodePassword.InnerText;
                    Variabili.invito_Referal = nodeReferal.InnerText;
                }
            }
            return stato_Transazione;
        }
    }
}