using Client.Forms;
using Client_V3.Forms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_V3
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public static Form currentChildForm;
        static int contatore_Timer = 0;
        static bool loop = false;

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
        private void DisableButton()
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
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {

                currentChildForm.Close();
            }
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
            Variabili.Impostazioni();
            Btn_Sync.Enabled = false;
            Gbox_Reset_Password.Visible = true;

            if (Client_V3.Properties.Settings.Default.Salvataggio == false)
                Menu_First_Register();
            else
            {
                Menu_Coming_Soon();
                goupB_Main_Form.Visible = false;

                Variabili.invito_Referal = Client_V3.Properties.Settings.Default.Referal_Code;
                Variabili.wallet = Client_V3.Properties.Settings.Default.Wallet_Chia;

                lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai un accesso parziale al software";
                lbl_Avviso_Password.Text = "Per avere pieno accesso al software, inserisci una password e salvati la Seed Phrase";
                lbl_PopUp_Main_XCH_Address.Text = Variabili.wallet; //INDIRIZZO CHIA
                lbl_PopUp_Main_Conferma.Visible = true;
                lbl_PopUp_Main_XCH_Address.Visible = true;
                lbl_Avviso_Password.Visible = true;
                txt_Password_Post.Visible = true;
            }
            
            await Update_Data(); //Aggiornamento dati
        }
        private async void btn_Conferma_Main_Click(object sender, EventArgs e)
        {
            if (loop == true)
            { contatore_Timer = 0; return; }
            if(txt_User_Address.Text.Contains("xch"))
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Il wallet Chia deve inziare con xch";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
            }
            if (txt_User_Address.Text == "Inserisci wallet XCH")
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Inserisci un wallet valido";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
            }
            if (txt_User_Address.Text.Count() != 62)
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Il wallet Chia deve avere 62 caratteri";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
            }

            if (radioBtn_EULA_1.Checked == true && radioBtn_EULA_2.Checked == true && txt_User_Address.Text.Length > 0 && txt_User_Address.Text != "Address") {
                if (txt_Password.Text == "Inserisci Password (Opzionale)")
                {
                    lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false;
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

                    lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai un accesso parziale al software";
                    lbl_Avviso_Password.Text = "Per avere pieno accesso al software, inserisci una password e salvati la Seed Phrase";
                    lbl_PopUp_Main_XCH_Address.Text = txt_User_Address.Text; //INDIRIZZO CHIA
                    lbl_PopUp_Main_Conferma.Visible = true;
                    lbl_Avviso_Password.Visible = true;
                    lbl_PopUp_Main_XCH_Address.Visible = true;
                    Variabili.invito_Referal = txt_Referal_Code.Text;
                    Variabili.wallet = txt_User_Address.Text;

                    //Salvataggio impostazioni dati utente
                    Client_V3.Properties.Settings.Default.Salvataggio = true;
                    Client_V3.Properties.Settings.Default.Wallet_Chia = Variabili.wallet;
                    Client_V3.Properties.Settings.Default.Referal_Code = Variabili.invito_Referal;
                    Properties.Settings.Default.Save();

                    Menu_Coming_Soon();
                } else
                {
                    loop = true;
                    btn_Conferma_Main.Enabled = false;
                    txt_Avviso.Text = txt_Seed_Phrase.Text;
                    lbl_Avviso.Visible = true;
                    txt_Avviso.Visible = true;
                    btn_Conferma_Main.Text = "ATTENDERE";
                    Gbox_Seed_Phrase.Visible = true;
                    await Sleep(2);
                    btn_Conferma_Main.ForeColor = Color.Red;
                    btn_Conferma_Main.Enabled = true;
                    btn_Conferma_Main.ForeColor = Color.ForestGreen;
                    btn_Conferma_Main.Text = "Attenzione!! Se mi clicchi, resetti il timer";
                    await Sleep(5);
                    btn_Conferma_Main.Text = "Pronto?";
                    await Sleep(1);
                    btn_Conferma_Main.Text = "Non sò se hai capito, ma devi segnarmi da qualche parte...?";
                    await Sleep(3);
                    await Sleep_Timer(3, "");
                    btn_Conferma_Password.Visible = true;
                    await Sleep_Timer(20, "Assicurati di aver salvato il Seed Phrase");
                    Gbox_Reset_Password_Post.Visible = true;
                    txt_Password_Post.Visible = false;

                    lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false;
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

                    lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai accesso completo al software";
                    lbl_PopUp_Main_XCH_Address.Text = txt_User_Address.Text; //INDIRIZZO CHIA
                    lbl_PopUp_Main_Conferma.Visible = true;
                    lbl_Avviso_Password.Visible = true;
                    lbl_PopUp_Main_XCH_Address.Visible = true;
                    Variabili.invito_Referal = txt_Referal_Code.Text;
                    Variabili.wallet = txt_User_Address.Text;

                    //Salvataggio impostazioni dati utente
                    Client_V3.Properties.Settings.Default.Salvataggio = true;
                    Client_V3.Properties.Settings.Default.Wallet_Chia = Variabili.wallet;
                    Client_V3.Properties.Settings.Default.Referal_Code = Variabili.invito_Referal;
                    Properties.Settings.Default.Save();

                    Menu_Coming_Soon();
                    loop = false;
                }
            }
            else
            {
                lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                lbl_Avviso_Main.Text = "Accetta EULA ed inserisci un'indirizzo CHIA";
                lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;

                if (radioBtn_EULA_1.Checked == true && radioBtn_EULA_2.Checked == true)
                {
                    lbl_Avviso_Main_Titolo.Text = "Per continuare:";
                    lbl_Avviso_Main.Text = "Inserisci un'indirizzo CHIA";
                    lbl_Avviso_Main.Visible = true; lbl_Avviso_Main_Titolo.Visible = true;
                }
            }
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

            btn_Staking.Enabled = false;
            btn_Staking.Text = "Coming Soon"; // Staking
            btn_Staking.BackColor = Color.FromArgb(110, 106, 106);

            btn_Simulate.Enabled = true;
            btn_Simulate.Text = "Simulate";
            btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);

            btn_Payment.Enabled = true;
            btn_Payment.Text = "Payment";
            btn_Payment.BackColor = Color.FromArgb(39, 45, 59);

            Btn_Swap.Enabled = false;
            Btn_Swap.Text = "Coming Soon"; //Swap
            Btn_Swap.BackColor = Color.FromArgb(110, 106, 106);

            goupB_Main_Form.Visible = false;
        }
        void Menu_First_Register()
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
        }
        static async Task<bool> Update_Data()
        {
            await ClientsConnection.TestClient.Connessione();
            await ClientsConnection.TestClient.Send_Server($"auth|{Variabili.wallet}"); // Autenticazione walle/Client
            await ClientsConnection.TestClient.Send_Server($"home|fee_Update"); //aggiorniamo dati form Home - Fee & Withdrawal
            await ClientsConnection.TestClient.Send_Server($"balance|protocol|{Variabili.wallet}"); //Aggiorniamo dati form Home - Balance protocol
            return true;
        }

        #region FORMS
        private void btn_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Home());
        }
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Payment());
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Dashboard());
        }
        private void btn_Simulate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Simulate());
        }
        private void btn_Staking_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Staking());
        }
        private void btn_EULA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new EULA());
        }
        private void Btn_Swap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Swap());
        }
        #endregion

        private void label_Logo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
            else
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icon_Current_Selection.IconChar = IconChar.A;   //Icona
            icon_Current_Selection.IconColor = Color.FromArgb(24, 161, 251); //Colore
            label_Form_Selected.Text = "Login Menu";
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
            public static Color color7 = Color.FromArgb(243, 170, 0);
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

            //Invio dati al server [richiesta_Sync_Transazioni|numero_Transazioni]
            await ClientsConnection.TestClient.ComunicazioneServer(); //Invio dati al server
            //Thread.Sleep(3000);

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
                    contatore_Timer = 0;
                    return true;
                }
                contatore_Timer++;
                await Task.Delay(1000);
            }
        }
        static Task Disconnetti() // Metodo non asyncrono
        {   return Task.Run(async () => //Crea un task e gli assegna un blocco istruzioni da eseguire.
            {
                await ClientsConnection.TestClient.Disconnetti();
            });
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
        private async void btn_Reset_Password_Post_Click(object sender, EventArgs e)
        {
            Gbox_New_Password_Request_Post.Visible = true;
            btn_Reset_Password_Post.Enabled = false;
            await ClientsConnection.TestClient.Send_Server($"resetPassword|{txt_Reset_Seed_Phrase.Text}|{Variabili.wallet}");
            await Sleep(10);
        }
        private async void Btn_Update_Password_Post_Click(object sender, EventArgs e)
        {
            //Invio update password server user
            Btn_Update_Password_Post.Enabled = false;
            await ClientsConnection.TestClient.Send_Server($"updatePassword|{txt_Reset_Seed_Phrase.Text}|{Variabili.wallet}");
            await Sleep(10);
        }
        private void btn_Conferma_Password_Click(object sender, EventArgs e) // Bottone inserimento password post registrazione... (usando solo indirizzo chia)
        {
            txt_Password_Post.Visible = false;
            Gbox_Reset_Password_Post.Visible = true;
            lbl_Avviso_Password.Visible = false;
            lbl_Avviso.Text = "Grazie per la registrazione, hai pieno accesso al software";
            btn_Conferma_Password.Visible = false;
        }
    }
}