using System.Drawing;
using System.Windows.Forms;

namespace Client_V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu_Laterale = new System.Windows.Forms.Panel();
            this.btn_Wallet = new FontAwesome.Sharp.IconButton();
            this.btn_Simulate = new FontAwesome.Sharp.IconButton();
            this.btn_Staking = new FontAwesome.Sharp.IconButton();
            this.btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.btn_Payment = new FontAwesome.Sharp.IconButton();
            this.Btn_Swap = new FontAwesome.Sharp.IconButton();
            this.btn_EULA = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Superiore = new System.Windows.Forms.Panel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            label_Form_Selected = new System.Windows.Forms.Label();
            icon_Current_Selection = new FontAwesome.Sharp.IconPictureBox();
            panel_Desktop = new System.Windows.Forms.Panel();
            goupB_Main_Form = new System.Windows.Forms.GroupBox();
            this.groupBox_Riscrivi_Seed = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Inserisci_Seed_Phrase_1 = new System.Windows.Forms.TextBox();
            this.txt_Inserisci_Seed_Phrase_2 = new System.Windows.Forms.TextBox();
            this.txt_Avviso = new System.Windows.Forms.TextBox();
            this.lbl_Avviso = new System.Windows.Forms.Label();
            this.Btn_Sync = new System.Windows.Forms.Button();
            this.Gbox_New_Password = new System.Windows.Forms.GroupBox();
            this.btn_New_Password_Request = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Gbox_Reset_Password = new System.Windows.Forms.GroupBox();
            this.btn_Reset_Password = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Reset_Seed_Phrase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gbox_Seed_Phrase = new System.Windows.Forms.GroupBox();
            this.txt_Seed_Phrase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Conferma_Main = new System.Windows.Forms.Button();
            this.panel_Referal = new System.Windows.Forms.Panel();
            this.txt_Referal_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox_Eula = new System.Windows.Forms.GroupBox();
            this.lbl_Avviso_Main_Titolo = new System.Windows.Forms.Label();
            this.lbl_Avviso_Main = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioBtn_EULA_2 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioBtn_EULA_1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_User_Address = new System.Windows.Forms.TextBox();
            this.panel_Menu_Laterale.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Superiore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(icon_Current_Selection)).BeginInit();
            panel_Desktop.SuspendLayout();
            goupB_Main_Form.SuspendLayout();
            this.groupBox_Riscrivi_Seed.SuspendLayout();
            this.Gbox_New_Password.SuspendLayout();
            this.Gbox_Reset_Password.SuspendLayout();
            this.Gbox_Seed_Phrase.SuspendLayout();
            this.panel_Referal.SuspendLayout();
            this.GroupBox_Eula.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu_Laterale
            // 
            this.panel_Menu_Laterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel_Menu_Laterale.Controls.Add(this.btn_Wallet);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Simulate);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Staking);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Dashboard);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Payment);
            this.panel_Menu_Laterale.Controls.Add(this.Btn_Swap);
            this.panel_Menu_Laterale.Controls.Add(this.btn_EULA);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Home);
            this.panel_Menu_Laterale.Controls.Add(this.panel1);
            this.panel_Menu_Laterale.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu_Laterale.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Laterale.Name = "panel_Menu_Laterale";
            this.panel_Menu_Laterale.Size = new System.Drawing.Size(154, 521);
            this.panel_Menu_Laterale.TabIndex = 0;
            // 
            // btn_Wallet
            // 
            this.btn_Wallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Wallet.FlatAppearance.BorderSize = 0;
            this.btn_Wallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Wallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Wallet.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Wallet.IconChar = FontAwesome.Sharp.IconChar.Hotjar;
            this.btn_Wallet.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Wallet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Wallet.IconSize = 32;
            this.btn_Wallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Wallet.Location = new System.Drawing.Point(0, 332);
            this.btn_Wallet.Name = "btn_Wallet";
            this.btn_Wallet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Wallet.Size = new System.Drawing.Size(154, 43);
            this.btn_Wallet.TabIndex = 9;
            this.btn_Wallet.Text = "Wallet";
            this.btn_Wallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Wallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Wallet.UseVisualStyleBackColor = true;
            this.btn_Wallet.Click += new System.EventHandler(this.btn_Wallet_Click);
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Simulate.FlatAppearance.BorderSize = 0;
            this.btn_Simulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Simulate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Simulate.IconChar = FontAwesome.Sharp.IconChar.Instalod;
            this.btn_Simulate.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Simulate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Simulate.IconSize = 32;
            this.btn_Simulate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simulate.Location = new System.Drawing.Point(0, 289);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Simulate.Size = new System.Drawing.Size(154, 43);
            this.btn_Simulate.TabIndex = 5;
            this.btn_Simulate.Text = "Simulate";
            this.btn_Simulate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simulate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simulate_Click);
            // 
            // btn_Staking
            // 
            this.btn_Staking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Staking.FlatAppearance.BorderSize = 0;
            this.btn_Staking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Staking.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Staking.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btn_Staking.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Staking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Staking.IconSize = 32;
            this.btn_Staking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staking.Location = new System.Drawing.Point(0, 246);
            this.btn_Staking.Name = "btn_Staking";
            this.btn_Staking.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Staking.Size = new System.Drawing.Size(154, 43);
            this.btn_Staking.TabIndex = 7;
            this.btn_Staking.Text = "Staking";
            this.btn_Staking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Staking.UseVisualStyleBackColor = true;
            this.btn_Staking.Click += new System.EventHandler(this.btn_Staking_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Dashboard.IconSize = 32;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 203);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(154, 43);
            this.btn_Dashboard.TabIndex = 4;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.AccessibleDescription = "";
            this.btn_Payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Payment.FlatAppearance.BorderSize = 0;
            this.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Payment.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Payment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btn_Payment.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Payment.IconSize = 32;
            this.btn_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Payment.Location = new System.Drawing.Point(0, 160);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Payment.Size = new System.Drawing.Size(154, 43);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // Btn_Swap
            // 
            this.Btn_Swap.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Swap.FlatAppearance.BorderSize = 0;
            this.Btn_Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Swap.ForeColor = System.Drawing.Color.DarkOrange;
            this.Btn_Swap.IconChar = FontAwesome.Sharp.IconChar.Mixer;
            this.Btn_Swap.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Swap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Swap.IconSize = 32;
            this.Btn_Swap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Swap.Location = new System.Drawing.Point(0, 117);
            this.Btn_Swap.Name = "Btn_Swap";
            this.Btn_Swap.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Swap.Size = new System.Drawing.Size(154, 43);
            this.Btn_Swap.TabIndex = 8;
            this.Btn_Swap.Text = "Swap";
            this.Btn_Swap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Swap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Swap.UseVisualStyleBackColor = true;
            this.Btn_Swap.Click += new System.EventHandler(this.Btn_Swap_Click);
            // 
            // btn_EULA
            // 
            this.btn_EULA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_EULA.FlatAppearance.BorderSize = 0;
            this.btn_EULA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_EULA.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_EULA.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.btn_EULA.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_EULA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EULA.IconSize = 32;
            this.btn_EULA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EULA.Location = new System.Drawing.Point(0, 478);
            this.btn_EULA.Name = "btn_EULA";
            this.btn_EULA.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_EULA.Size = new System.Drawing.Size(154, 43);
            this.btn_EULA.TabIndex = 6;
            this.btn_EULA.Text = "EULA";
            this.btn_EULA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EULA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EULA.UseVisualStyleBackColor = true;
            this.btn_EULA.Click += new System.EventHandler(this.btn_EULA_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Home.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.btn_Home.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 32;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 74);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Home.Size = new System.Drawing.Size(154, 43);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Client_V3.Properties.Resources.out_01;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 74);
            this.panel3.TabIndex = 37;
            // 
            // panel_Superiore
            // 
            this.panel_Superiore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel_Superiore.Controls.Add(this.txt_User);
            this.panel_Superiore.Controls.Add(this.btn_Update);
            this.panel_Superiore.Controls.Add(this.btn_Login);
            this.panel_Superiore.Controls.Add(label_Form_Selected);
            this.panel_Superiore.Controls.Add(icon_Current_Selection);
            this.panel_Superiore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superiore.Location = new System.Drawing.Point(154, 0);
            this.panel_Superiore.Name = "panel_Superiore";
            this.panel_Superiore.Size = new System.Drawing.Size(899, 74);
            this.panel_Superiore.TabIndex = 1;
            // 
            // txt_User
            // 
            this.txt_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_User.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_User.Location = new System.Drawing.Point(731, 46);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(164, 20);
            this.txt_User.TabIndex = 36;
            this.txt_User.Text = "ID: Guest";
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_Update.Location = new System.Drawing.Point(656, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(72, 29);
            this.btn_Update.TabIndex = 35;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Login.Location = new System.Drawing.Point(656, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(72, 29);
            this.btn_Login.TabIndex = 34;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label_Form_Selected
            // 
            label_Form_Selected.AutoSize = true;
            label_Form_Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            label_Form_Selected.Font = new System.Drawing.Font("Segoe UI", 13F);
            label_Form_Selected.ForeColor = System.Drawing.Color.DarkOrange;
            label_Form_Selected.Location = new System.Drawing.Point(51, 21);
            label_Form_Selected.Name = "label_Form_Selected";
            label_Form_Selected.Size = new System.Drawing.Size(106, 25);
            label_Form_Selected.TabIndex = 2;
            label_Form_Selected.Text = "Login Menu";
            // 
            // icon_Current_Selection
            // 
            icon_Current_Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            icon_Current_Selection.ErrorImage = null;
            icon_Current_Selection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            icon_Current_Selection.IconChar = FontAwesome.Sharp.IconChar.A;
            icon_Current_Selection.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            icon_Current_Selection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_Current_Selection.IconSize = 28;
            icon_Current_Selection.InitialImage = null;
            icon_Current_Selection.Location = new System.Drawing.Point(17, 21);
            icon_Current_Selection.Name = "icon_Current_Selection";
            icon_Current_Selection.Size = new System.Drawing.Size(31, 28);
            icon_Current_Selection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            icon_Current_Selection.TabIndex = 2;
            icon_Current_Selection.TabStop = false;
            // 
            // panel_Desktop
            // 
            panel_Desktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel_Desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            panel_Desktop.Controls.Add(goupB_Main_Form);
            panel_Desktop.Location = new System.Drawing.Point(154, 74);
            panel_Desktop.Name = "panel_Desktop";
            panel_Desktop.Size = new System.Drawing.Size(899, 447);
            panel_Desktop.TabIndex = 3;
            // 
            // goupB_Main_Form
            // 
            goupB_Main_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            goupB_Main_Form.Controls.Add(this.groupBox_Riscrivi_Seed);
            goupB_Main_Form.Controls.Add(this.txt_Avviso);
            goupB_Main_Form.Controls.Add(this.lbl_Avviso);
            goupB_Main_Form.Controls.Add(this.Btn_Sync);
            goupB_Main_Form.Controls.Add(this.Gbox_New_Password);
            goupB_Main_Form.Controls.Add(this.txt_Password);
            goupB_Main_Form.Controls.Add(this.Gbox_Reset_Password);
            goupB_Main_Form.Controls.Add(this.Gbox_Seed_Phrase);
            goupB_Main_Form.Controls.Add(this.btn_Conferma_Main);
            goupB_Main_Form.Controls.Add(this.panel_Referal);
            goupB_Main_Form.Controls.Add(this.GroupBox_Eula);
            goupB_Main_Form.Controls.Add(this.panel2);
            goupB_Main_Form.Controls.Add(this.txt_User_Address);
            goupB_Main_Form.ForeColor = System.Drawing.Color.CornflowerBlue;
            goupB_Main_Form.Location = new System.Drawing.Point(3, -1);
            goupB_Main_Form.Name = "goupB_Main_Form";
            goupB_Main_Form.Size = new System.Drawing.Size(893, 446);
            goupB_Main_Form.TabIndex = 22;
            goupB_Main_Form.TabStop = false;
            // 
            // groupBox_Riscrivi_Seed
            // 
            this.groupBox_Riscrivi_Seed.Controls.Add(this.label16);
            this.groupBox_Riscrivi_Seed.Controls.Add(this.label17);
            this.groupBox_Riscrivi_Seed.Controls.Add(this.txt_Inserisci_Seed_Phrase_1);
            this.groupBox_Riscrivi_Seed.Controls.Add(this.txt_Inserisci_Seed_Phrase_2);
            this.groupBox_Riscrivi_Seed.Location = new System.Drawing.Point(660, 235);
            this.groupBox_Riscrivi_Seed.Name = "groupBox_Riscrivi_Seed";
            this.groupBox_Riscrivi_Seed.Size = new System.Drawing.Size(211, 118);
            this.groupBox_Riscrivi_Seed.TabIndex = 33;
            this.groupBox_Riscrivi_Seed.TabStop = false;
            this.groupBox_Riscrivi_Seed.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(11, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Riscrivi Seed Phrase";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(11, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Riscrivilo ancora una volta";
            // 
            // txt_Inserisci_Seed_Phrase_1
            // 
            this.txt_Inserisci_Seed_Phrase_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Inserisci_Seed_Phrase_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Inserisci_Seed_Phrase_1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Inserisci_Seed_Phrase_1.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Inserisci_Seed_Phrase_1.Location = new System.Drawing.Point(5, 33);
            this.txt_Inserisci_Seed_Phrase_1.Name = "txt_Inserisci_Seed_Phrase_1";
            this.txt_Inserisci_Seed_Phrase_1.Size = new System.Drawing.Size(203, 27);
            this.txt_Inserisci_Seed_Phrase_1.TabIndex = 29;
            this.txt_Inserisci_Seed_Phrase_1.Text = "SEED-xDIx-PROVA-xxxx";
            this.txt_Inserisci_Seed_Phrase_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Inserisci_Seed_Phrase_2
            // 
            this.txt_Inserisci_Seed_Phrase_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Inserisci_Seed_Phrase_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Inserisci_Seed_Phrase_2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Inserisci_Seed_Phrase_2.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Inserisci_Seed_Phrase_2.Location = new System.Drawing.Point(5, 87);
            this.txt_Inserisci_Seed_Phrase_2.Name = "txt_Inserisci_Seed_Phrase_2";
            this.txt_Inserisci_Seed_Phrase_2.Size = new System.Drawing.Size(203, 27);
            this.txt_Inserisci_Seed_Phrase_2.TabIndex = 30;
            this.txt_Inserisci_Seed_Phrase_2.Text = "SEED-xDIx-PROVA-x12x";
            this.txt_Inserisci_Seed_Phrase_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Avviso
            // 
            this.txt_Avviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Avviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Avviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Avviso.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_Avviso.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Avviso.Location = new System.Drawing.Point(230, 270);
            this.txt_Avviso.Name = "txt_Avviso";
            this.txt_Avviso.ReadOnly = true;
            this.txt_Avviso.Size = new System.Drawing.Size(398, 32);
            this.txt_Avviso.TabIndex = 27;
            this.txt_Avviso.Text = "AAAA-BBBB-CCCC-DDDD";
            this.txt_Avviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Avviso.Visible = false;
            // 
            // lbl_Avviso
            // 
            this.lbl_Avviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Avviso.AutoSize = true;
            this.lbl_Avviso.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbl_Avviso.ForeColor = System.Drawing.Color.Red;
            this.lbl_Avviso.Location = new System.Drawing.Point(184, 230);
            this.lbl_Avviso.Name = "lbl_Avviso";
            this.lbl_Avviso.Size = new System.Drawing.Size(478, 32);
            this.lbl_Avviso.TabIndex = 28;
            this.lbl_Avviso.Text = "Dont lost this code!!  SAVE IT \"Seed Phrase\"";
            this.lbl_Avviso.Visible = false;
            // 
            // Btn_Sync
            // 
            this.Btn_Sync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Sync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.Btn_Sync.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Btn_Sync.FlatAppearance.BorderSize = 0;
            this.Btn_Sync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Btn_Sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sync.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Sync.ForeColor = System.Drawing.Color.Yellow;
            this.Btn_Sync.Location = new System.Drawing.Point(14, 401);
            this.Btn_Sync.Name = "Btn_Sync";
            this.Btn_Sync.Size = new System.Drawing.Size(128, 30);
            this.Btn_Sync.TabIndex = 23;
            this.Btn_Sync.Text = "Sync";
            this.Btn_Sync.UseVisualStyleBackColor = false;
            this.Btn_Sync.Visible = false;
            this.Btn_Sync.Click += new System.EventHandler(this.Btn_Sync_Click);
            // 
            // Gbox_New_Password
            // 
            this.Gbox_New_Password.Controls.Add(this.btn_New_Password_Request);
            this.Gbox_New_Password.Controls.Add(this.label10);
            this.Gbox_New_Password.Controls.Add(this.textBox1);
            this.Gbox_New_Password.Controls.Add(this.label11);
            this.Gbox_New_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gbox_New_Password.Location = new System.Drawing.Point(164, 316);
            this.Gbox_New_Password.Name = "Gbox_New_Password";
            this.Gbox_New_Password.Size = new System.Drawing.Size(250, 121);
            this.Gbox_New_Password.TabIndex = 26;
            this.Gbox_New_Password.TabStop = false;
            this.Gbox_New_Password.Text = "New Password Request";
            this.Gbox_New_Password.Visible = false;
            // 
            // btn_New_Password_Request
            // 
            this.btn_New_Password_Request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New_Password_Request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_New_Password_Request.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_New_Password_Request.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_New_Password_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_Password_Request.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_New_Password_Request.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_New_Password_Request.Location = new System.Drawing.Point(10, 84);
            this.btn_New_Password_Request.Name = "btn_New_Password_Request";
            this.btn_New_Password_Request.Size = new System.Drawing.Size(229, 30);
            this.btn_New_Password_Request.TabIndex = 26;
            this.btn_New_Password_Request.Text = "Update Password";
            this.btn_New_Password_Request.UseVisualStyleBackColor = false;
            this.btn_New_Password_Request.Click += new System.EventHandler(this.btn_New_Password_Request_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(19, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Insert your new password here:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox1.Location = new System.Drawing.Point(6, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Password";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(24, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "New Password: If not, ingore it";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Password.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Password.Location = new System.Drawing.Point(5, 67);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(883, 27);
            this.txt_Password.TabIndex = 25;
            this.txt_Password.Text = "Inserisci Password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gbox_Reset_Password
            // 
            this.Gbox_Reset_Password.Controls.Add(this.btn_Reset_Password);
            this.Gbox_Reset_Password.Controls.Add(this.label9);
            this.Gbox_Reset_Password.Controls.Add(this.txt_Reset_Seed_Phrase);
            this.Gbox_Reset_Password.Controls.Add(this.label8);
            this.Gbox_Reset_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gbox_Reset_Password.Location = new System.Drawing.Point(413, 316);
            this.Gbox_Reset_Password.Name = "Gbox_Reset_Password";
            this.Gbox_Reset_Password.Size = new System.Drawing.Size(241, 121);
            this.Gbox_Reset_Password.TabIndex = 24;
            this.Gbox_Reset_Password.TabStop = false;
            this.Gbox_Reset_Password.Text = "Reset Password";
            this.Gbox_Reset_Password.Visible = false;
            // 
            // btn_Reset_Password
            // 
            this.btn_Reset_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Reset_Password.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_Reset_Password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Reset_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Reset_Password.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Reset_Password.Location = new System.Drawing.Point(6, 85);
            this.btn_Reset_Password.Name = "btn_Reset_Password";
            this.btn_Reset_Password.Size = new System.Drawing.Size(229, 30);
            this.btn_Reset_Password.TabIndex = 25;
            this.btn_Reset_Password.Text = "Reset Password";
            this.btn_Reset_Password.UseVisualStyleBackColor = false;
            this.btn_Reset_Password.Click += new System.EventHandler(this.btn_Reset_Password_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(24, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Insert your seed phrase here:";
            // 
            // txt_Reset_Seed_Phrase
            // 
            this.txt_Reset_Seed_Phrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Reset_Seed_Phrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Reset_Seed_Phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Reset_Seed_Phrase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Reset_Seed_Phrase.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Reset_Seed_Phrase.Location = new System.Drawing.Point(6, 60);
            this.txt_Reset_Seed_Phrase.Name = "txt_Reset_Seed_Phrase";
            this.txt_Reset_Seed_Phrase.Size = new System.Drawing.Size(229, 20);
            this.txt_Reset_Seed_Phrase.TabIndex = 24;
            this.txt_Reset_Seed_Phrase.Text = "AAAA-BBBB-CCCC-DDDD";
            this.txt_Reset_Seed_Phrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(16, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lost password? Need reset it?";
            // 
            // Gbox_Seed_Phrase
            // 
            this.Gbox_Seed_Phrase.Controls.Add(this.txt_Seed_Phrase);
            this.Gbox_Seed_Phrase.Controls.Add(this.label6);
            this.Gbox_Seed_Phrase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gbox_Seed_Phrase.Location = new System.Drawing.Point(653, 371);
            this.Gbox_Seed_Phrase.Name = "Gbox_Seed_Phrase";
            this.Gbox_Seed_Phrase.Size = new System.Drawing.Size(224, 66);
            this.Gbox_Seed_Phrase.TabIndex = 23;
            this.Gbox_Seed_Phrase.TabStop = false;
            this.Gbox_Seed_Phrase.Text = "Seed Phrase";
            this.Gbox_Seed_Phrase.Visible = false;
            // 
            // txt_Seed_Phrase
            // 
            this.txt_Seed_Phrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Seed_Phrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Seed_Phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Seed_Phrase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Seed_Phrase.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Seed_Phrase.Location = new System.Drawing.Point(6, 39);
            this.txt_Seed_Phrase.Name = "txt_Seed_Phrase";
            this.txt_Seed_Phrase.ReadOnly = true;
            this.txt_Seed_Phrase.Size = new System.Drawing.Size(212, 20);
            this.txt_Seed_Phrase.TabIndex = 24;
            this.txt_Seed_Phrase.Text = "SEED-xDIx-PROVA-xxxx";
            this.txt_Seed_Phrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(38, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dont lost this code!!";
            // 
            // btn_Conferma_Main
            // 
            this.btn_Conferma_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Conferma_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Conferma_Main.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Conferma_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Conferma_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conferma_Main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Conferma_Main.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Conferma_Main.Location = new System.Drawing.Point(14, 193);
            this.btn_Conferma_Main.Name = "btn_Conferma_Main";
            this.btn_Conferma_Main.Size = new System.Drawing.Size(860, 30);
            this.btn_Conferma_Main.TabIndex = 19;
            this.btn_Conferma_Main.Text = "Conferma";
            this.btn_Conferma_Main.UseVisualStyleBackColor = false;
            this.btn_Conferma_Main.Click += new System.EventHandler(this.btn_Conferma_Main_Click);
            // 
            // panel_Referal
            // 
            this.panel_Referal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Referal.Controls.Add(this.txt_Referal_Code);
            this.panel_Referal.Controls.Add(this.label3);
            this.panel_Referal.Controls.Add(this.label4);
            this.panel_Referal.Controls.Add(this.label5);
            this.panel_Referal.Location = new System.Drawing.Point(5, 163);
            this.panel_Referal.Name = "panel_Referal";
            this.panel_Referal.Size = new System.Drawing.Size(883, 27);
            this.panel_Referal.TabIndex = 22;
            // 
            // txt_Referal_Code
            // 
            this.txt_Referal_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Referal_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Referal_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Referal_Code.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Referal_Code.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Referal_Code.Location = new System.Drawing.Point(396, 3);
            this.txt_Referal_Code.Name = "txt_Referal_Code";
            this.txt_Referal_Code.Size = new System.Drawing.Size(88, 20);
            this.txt_Referal_Code.TabIndex = 23;
            this.txt_Referal_Code.Text = "Ref_Code";
            this.txt_Referal_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(85, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inserisci un";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(161, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "referal code:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Opzionale)";
            // 
            // GroupBox_Eula
            // 
            this.GroupBox_Eula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Eula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.GroupBox_Eula.Controls.Add(this.lbl_Avviso_Main_Titolo);
            this.GroupBox_Eula.Controls.Add(this.lbl_Avviso_Main);
            this.GroupBox_Eula.Controls.Add(this.panel5);
            this.GroupBox_Eula.Controls.Add(this.panel4);
            this.GroupBox_Eula.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupBox_Eula.Location = new System.Drawing.Point(5, 94);
            this.GroupBox_Eula.Name = "GroupBox_Eula";
            this.GroupBox_Eula.Size = new System.Drawing.Size(883, 61);
            this.GroupBox_Eula.TabIndex = 21;
            this.GroupBox_Eula.TabStop = false;
            this.GroupBox_Eula.Text = "EULA";
            // 
            // lbl_Avviso_Main_Titolo
            // 
            this.lbl_Avviso_Main_Titolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Avviso_Main_Titolo.AutoSize = true;
            this.lbl_Avviso_Main_Titolo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Avviso_Main_Titolo.ForeColor = System.Drawing.Color.Red;
            this.lbl_Avviso_Main_Titolo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Avviso_Main_Titolo.Location = new System.Drawing.Point(456, 13);
            this.lbl_Avviso_Main_Titolo.Name = "lbl_Avviso_Main_Titolo";
            this.lbl_Avviso_Main_Titolo.Size = new System.Drawing.Size(115, 20);
            this.lbl_Avviso_Main_Titolo.TabIndex = 24;
            this.lbl_Avviso_Main_Titolo.Text = "Per continuare:";
            this.lbl_Avviso_Main_Titolo.Visible = false;
            // 
            // lbl_Avviso_Main
            // 
            this.lbl_Avviso_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Avviso_Main.AutoSize = true;
            this.lbl_Avviso_Main.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Avviso_Main.ForeColor = System.Drawing.Color.Red;
            this.lbl_Avviso_Main.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Avviso_Main.Location = new System.Drawing.Point(456, 34);
            this.lbl_Avviso_Main.Name = "lbl_Avviso_Main";
            this.lbl_Avviso_Main.Size = new System.Drawing.Size(293, 20);
            this.lbl_Avviso_Main.TabIndex = 23;
            this.lbl_Avviso_Main.Text = "Accetta EULA ed Insierisci indirizzo CHIA";
            this.lbl_Avviso_Main.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.radioBtn_EULA_2);
            this.panel5.Location = new System.Drawing.Point(3, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 23);
            this.panel5.TabIndex = 23;
            // 
            // radioBtn_EULA_2
            // 
            this.radioBtn_EULA_2.AutoSize = true;
            this.radioBtn_EULA_2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtn_EULA_2.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_EULA_2.Name = "radioBtn_EULA_2";
            this.radioBtn_EULA_2.Size = new System.Drawing.Size(252, 17);
            this.radioBtn_EULA_2.TabIndex = 16;
            this.radioBtn_EULA_2.TabStop = true;
            this.radioBtn_EULA_2.Text = "Accetto i rischi legati alla fluttuazione dei mercati";
            this.radioBtn_EULA_2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.radioBtn_EULA_1);
            this.panel4.Location = new System.Drawing.Point(3, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 22);
            this.panel4.TabIndex = 23;
            // 
            // radioBtn_EULA_1
            // 
            this.radioBtn_EULA_1.AutoSize = true;
            this.radioBtn_EULA_1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtn_EULA_1.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_EULA_1.Name = "radioBtn_EULA_1";
            this.radioBtn_EULA_1.Size = new System.Drawing.Size(196, 17);
            this.radioBtn_EULA_1.TabIndex = 15;
            this.radioBtn_EULA_1.TabStop = true;
            this.radioBtn_EULA_1.Text = "Accetto i rischi legati alla blockchain";
            this.radioBtn_EULA_1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 29);
            this.panel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(324, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Inserisci un";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(400, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "wallet chia";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(479, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "per accedere";
            // 
            // txt_User_Address
            // 
            this.txt_User_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_User_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_User_Address.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_User_Address.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_User_Address.Location = new System.Drawing.Point(5, 42);
            this.txt_User_Address.Name = "txt_User_Address";
            this.txt_User_Address.Size = new System.Drawing.Size(883, 27);
            this.txt_User_Address.TabIndex = 18;
            this.txt_User_Address.Text = "Inserisci wallet XCH";
            this.txt_User_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 521);
            this.Controls.Add(panel_Desktop);
            this.Controls.Add(this.panel_Superiore);
            this.Controls.Add(this.panel_Menu_Laterale);
            this.MinimumSize = new System.Drawing.Size(950, 495);
            this.Name = "FormMain";
            this.Text = "Deep Mining Protocol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_Menu_Laterale.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_Superiore.ResumeLayout(false);
            this.panel_Superiore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(icon_Current_Selection)).EndInit();
            panel_Desktop.ResumeLayout(false);
            goupB_Main_Form.ResumeLayout(false);
            goupB_Main_Form.PerformLayout();
            this.groupBox_Riscrivi_Seed.ResumeLayout(false);
            this.groupBox_Riscrivi_Seed.PerformLayout();
            this.Gbox_New_Password.ResumeLayout(false);
            this.Gbox_New_Password.PerformLayout();
            this.Gbox_Reset_Password.ResumeLayout(false);
            this.Gbox_Reset_Password.PerformLayout();
            this.Gbox_Seed_Phrase.ResumeLayout(false);
            this.Gbox_Seed_Phrase.PerformLayout();
            this.panel_Referal.ResumeLayout(false);
            this.panel_Referal.PerformLayout();
            this.GroupBox_Eula.ResumeLayout(false);
            this.GroupBox_Eula.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Menu_Laterale;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Simulate;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private FontAwesome.Sharp.IconButton btn_Payment;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_EULA;
        private Panel panel_Superiore;
        private GroupBox GroupBox_Eula;
        private RadioButton radioBtn_EULA_1;
        private Panel panel2;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button btn_Conferma_Main;
        private TextBox txt_User_Address;
        private Panel panel_Referal;
        private TextBox txt_Referal_Code;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private RadioButton radioBtn_EULA_2;
        private Label lbl_Avviso_Main;
        private Label lbl_Avviso_Main_Titolo;
        private Button Btn_Sync;
        private FontAwesome.Sharp.IconButton btn_Staking;
        private FontAwesome.Sharp.IconButton Btn_Swap;
        private GroupBox Gbox_Reset_Password;
        private TextBox txt_Reset_Seed_Phrase;
        private Label label8;
        private GroupBox Gbox_Seed_Phrase;
        private TextBox txt_Seed_Phrase;
        private Label label6;
        private Button btn_Reset_Password;
        private Label label9;
        private GroupBox Gbox_New_Password;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private TextBox txt_Password;
        private TextBox txt_Avviso;
        private Label lbl_Avviso;
        private Button btn_New_Password_Request;
        private Label label16;
        private TextBox txt_Inserisci_Seed_Phrase_2;
        private TextBox txt_Inserisci_Seed_Phrase_1;
        private Label label17;
        private GroupBox groupBox_Riscrivi_Seed;
        private FontAwesome.Sharp.IconButton btn_Wallet;
        public Button btn_Login;
        public Button btn_Update;
        private TextBox txt_User;
        private Panel panel3;
        static private FontAwesome.Sharp.IconPictureBox icon_Current_Selection;
        static private Label label_Form_Selected;
        static private Panel panel_Desktop;
        static public GroupBox goupB_Main_Form;
    }
}