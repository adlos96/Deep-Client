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

namespace Client_V3
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

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
        private void FormMain_Load(object sender, EventArgs e)
        {
            Variabili.Impostazioni();
            if (Client_V3.Properties.Settings.Default.Salvataggio == false)
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
            }
            else
            {
                lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false; Btn_Sync.Enabled = false;
                /*
                btn_Home.Enabled = true;
                btn_Home.Text = "Dashboard"; // ex Home
                btn_Home.BackColor = Color.FromArgb(39, 45, 59);

                btn_Dashboard.Enabled = true;
                btn_Dashboard.Text = "Dashboard";
                btn_Dashboard.BackColor = Color.FromArgb(39, 45, 59);

                btn_Simulate.Enabled = true;
                btn_Simulate.Text = "Simulate";
                btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);
                */

                lbl_Avviso_Main.Visible = false; btn_Home.Enabled = false;
                btn_Home.Text = "Coming Soon";
                btn_Home.BackColor = Color.FromArgb(110, 106, 106);

                btn_Dashboard.Enabled = false;
                btn_Dashboard.Text = "Coming Soon";
                btn_Dashboard.BackColor = Color.FromArgb(110, 106, 106);

                btn_Simulate.Enabled = true;
                btn_Simulate.Text = "Simulate";
                btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);

                btn_Payment.Enabled = true;
                btn_Payment.Text = "Payment";
                btn_Payment.BackColor = Color.FromArgb(39, 45, 59);
                goupB_Main_Form.Visible = false;

                Variabili.invito_Referal = Client_V3.Properties.Settings.Default.Referal_Code;
                Variabili.wallet = Client_V3.Properties.Settings.Default.Wallet_Chia;

                lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai il pieno accesso al software";
                lbl_PopUp_Main_XCH_Address.Text = Variabili.wallet; //INDIRIZZO CHIA
                lbl_PopUp_Main_Conferma.Visible = true; lbl_PopUp_Main_XCH_Address.Visible = true;
            }
            
        }
        private void btn_Conferma_Main_Click(object sender, EventArgs e)
        {
            if (radioBtn_EULA_1.Checked == true && radioBtn_EULA_2.Checked == true && txt_User_Address.Text.Length > 0 && txt_User_Address.Text != "Address")
            {
                lbl_Avviso_Main.Visible = false; lbl_Avviso_Main_Titolo.Visible = false;
                /*
                btn_Home.Enabled = true;
                btn_Home.Text = "Home";
                btn_Home.BackColor = Color.FromArgb(39, 45, 59);

                btn_Dashboard.Enabled = true;
                btn_Dashboard.Text = "Dashboard";
                btn_Dashboard.BackColor = Color.FromArgb(39, 45, 59);

                */
                btn_Simulate.Enabled = true;
                btn_Simulate.Text = "Simulate";
                btn_Simulate.BackColor = Color.FromArgb(39, 45, 59);

                btn_Payment.Enabled = true;
                btn_Payment.Text = "Payment";
                btn_Payment.BackColor = Color.FromArgb(39, 45, 59);
                goupB_Main_Form.Visible = false;

                lbl_PopUp_Main_Conferma.Text = "Grazie per la registrazione, hai il pieno accesso al software";
                lbl_PopUp_Main_XCH_Address.Text = txt_User_Address.Text; //INDIRIZZO CHIA
                lbl_PopUp_Main_Conferma.Visible = true;
                lbl_PopUp_Main_XCH_Address.Visible = true;
                Variabili.invito_Referal = txt_Referal_Code.Text;
                Variabili.wallet = txt_User_Address.Text;

                //Salvataggio impostazioni dati utente
                Client_V3.Properties.Settings.Default.Salvataggio = true;
                Client_V3.Properties.Settings.Default.Wallet_Chia = Variabili.wallet;
                Client_V3.Properties.Settings.Default.Referal_Code = Variabili.invito_Referal;
                Properties.Settings.Default.Save();
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
        private void btn_EULA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new EULA());
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
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(44, 203, 198);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientsConnection.TestClient.Disconnetti();
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
            await Blocco_Sync();
            Btn_Sync.Enabled = true;
        }

        static Task Blocco_Sync()
        {
            return Task.Run(() => //Crea un task e gli assegna un blocco istruzioni da eseguire.
            {
                int attesa = 1000 * 5; // --> 5 secondi per test
                Thread.Sleep(attesa);
            });
        }
        static Task Disconnetti()
        {
            return Task.Run(async () => //Crea un task e gli assegna un blocco istruzioni da eseguire.
            {
                await ClientsConnection.TestClient.Disconnetti();
            });
        }
    }
}