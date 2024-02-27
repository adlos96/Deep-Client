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
            this.btn_EULA = new FontAwesome.Sharp.IconButton();
            this.btn_Simulate = new FontAwesome.Sharp.IconButton();
            this.btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.btn_Payment = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.panel_Superiore = new System.Windows.Forms.Panel();
            this.label_Form_Selected = new System.Windows.Forms.Label();
            this.icon_Current_Selection = new FontAwesome.Sharp.IconPictureBox();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.Btn_Sync = new System.Windows.Forms.Button();
            this.goupB_Main_Form = new System.Windows.Forms.GroupBox();
            this.btn_Conferma_Main = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Referal_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_PopUp_Main_Conferma = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_PopUp_Main_XCH_Address = new System.Windows.Forms.Label();
            this.panel_Menu_Laterale.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Superiore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Current_Selection)).BeginInit();
            this.panel_Desktop.SuspendLayout();
            this.goupB_Main_Form.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu_Laterale
            // 
            this.panel_Menu_Laterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel_Menu_Laterale.Controls.Add(this.btn_EULA);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Simulate);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Dashboard);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Payment);
            this.panel_Menu_Laterale.Controls.Add(this.btn_Home);
            this.panel_Menu_Laterale.Controls.Add(this.panel1);
            this.panel_Menu_Laterale.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu_Laterale.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu_Laterale.Name = "panel_Menu_Laterale";
            this.panel_Menu_Laterale.Size = new System.Drawing.Size(189, 521);
            this.panel_Menu_Laterale.TabIndex = 0;
            // 
            // btn_EULA
            // 
            this.btn_EULA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EULA.FlatAppearance.BorderSize = 0;
            this.btn_EULA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_EULA.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_EULA.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.btn_EULA.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_EULA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EULA.IconSize = 32;
            this.btn_EULA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EULA.Location = new System.Drawing.Point(0, 246);
            this.btn_EULA.Name = "btn_EULA";
            this.btn_EULA.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_EULA.Size = new System.Drawing.Size(189, 43);
            this.btn_EULA.TabIndex = 6;
            this.btn_EULA.Text = "EULA";
            this.btn_EULA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EULA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EULA.UseVisualStyleBackColor = true;
            this.btn_EULA.Click += new System.EventHandler(this.btn_EULA_Click);
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Simulate.FlatAppearance.BorderSize = 0;
            this.btn_Simulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Simulate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Simulate.IconChar = FontAwesome.Sharp.IconChar.D;
            this.btn_Simulate.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Simulate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Simulate.IconSize = 32;
            this.btn_Simulate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simulate.Location = new System.Drawing.Point(0, 203);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Simulate.Size = new System.Drawing.Size(189, 43);
            this.btn_Simulate.TabIndex = 5;
            this.btn_Simulate.Text = "Simulate";
            this.btn_Simulate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Simulate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simulate_Click);
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
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 160);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(189, 43);
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
            this.btn_Payment.Location = new System.Drawing.Point(0, 117);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Payment.Size = new System.Drawing.Size(189, 43);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
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
            this.btn_Home.Size = new System.Drawing.Size(189, 43);
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
            this.panel1.Controls.Add(this.label_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 74);
            this.panel1.TabIndex = 0;
            // 
            // label_Logo
            // 
            this.label_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Logo.AutoSize = true;
            this.label_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Logo.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_Logo.Location = new System.Drawing.Point(43, 25);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(111, 21);
            this.label_Logo.TabIndex = 1;
            this.label_Logo.Text = "Login Protocol";
            this.label_Logo.Click += new System.EventHandler(this.label_Logo_Click);
            // 
            // panel_Superiore
            // 
            this.panel_Superiore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel_Superiore.Controls.Add(this.label_Form_Selected);
            this.panel_Superiore.Controls.Add(this.icon_Current_Selection);
            this.panel_Superiore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superiore.Location = new System.Drawing.Point(189, 0);
            this.panel_Superiore.Name = "panel_Superiore";
            this.panel_Superiore.Size = new System.Drawing.Size(864, 74);
            this.panel_Superiore.TabIndex = 1;
            // 
            // label_Form_Selected
            // 
            this.label_Form_Selected.AutoSize = true;
            this.label_Form_Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.label_Form_Selected.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label_Form_Selected.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_Form_Selected.Location = new System.Drawing.Point(51, 21);
            this.label_Form_Selected.Name = "label_Form_Selected";
            this.label_Form_Selected.Size = new System.Drawing.Size(106, 25);
            this.label_Form_Selected.TabIndex = 2;
            this.label_Form_Selected.Text = "Login Menu";
            // 
            // icon_Current_Selection
            // 
            this.icon_Current_Selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.icon_Current_Selection.ErrorImage = null;
            this.icon_Current_Selection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.icon_Current_Selection.IconChar = FontAwesome.Sharp.IconChar.A;
            this.icon_Current_Selection.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.icon_Current_Selection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Current_Selection.IconSize = 28;
            this.icon_Current_Selection.InitialImage = null;
            this.icon_Current_Selection.Location = new System.Drawing.Point(17, 21);
            this.icon_Current_Selection.Name = "icon_Current_Selection";
            this.icon_Current_Selection.Size = new System.Drawing.Size(31, 28);
            this.icon_Current_Selection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon_Current_Selection.TabIndex = 2;
            this.icon_Current_Selection.TabStop = false;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.panel_Desktop.Controls.Add(this.Btn_Sync);
            this.panel_Desktop.Controls.Add(this.goupB_Main_Form);
            this.panel_Desktop.Controls.Add(this.panel6);
            this.panel_Desktop.Controls.Add(this.panel7);
            this.panel_Desktop.Location = new System.Drawing.Point(189, 74);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(864, 447);
            this.panel_Desktop.TabIndex = 3;
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
            this.Btn_Sync.Location = new System.Drawing.Point(17, 211);
            this.Btn_Sync.Name = "Btn_Sync";
            this.Btn_Sync.Size = new System.Drawing.Size(104, 30);
            this.Btn_Sync.TabIndex = 23;
            this.Btn_Sync.Text = "Sync";
            this.Btn_Sync.UseVisualStyleBackColor = false;
            this.Btn_Sync.Click += new System.EventHandler(this.Btn_Sync_Click);
            // 
            // goupB_Main_Form
            // 
            this.goupB_Main_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goupB_Main_Form.Controls.Add(this.btn_Conferma_Main);
            this.goupB_Main_Form.Controls.Add(this.panel3);
            this.goupB_Main_Form.Controls.Add(this.groupBox2);
            this.goupB_Main_Form.Controls.Add(this.panel2);
            this.goupB_Main_Form.Controls.Add(this.txt_User_Address);
            this.goupB_Main_Form.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.goupB_Main_Form.Location = new System.Drawing.Point(5, 6);
            this.goupB_Main_Form.Name = "goupB_Main_Form";
            this.goupB_Main_Form.Size = new System.Drawing.Size(849, 432);
            this.goupB_Main_Form.TabIndex = 22;
            this.goupB_Main_Form.TabStop = false;
            // 
            // btn_Conferma_Main
            // 
            this.btn_Conferma_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Conferma_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Conferma_Main.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Conferma_Main.FlatAppearance.BorderSize = 0;
            this.btn_Conferma_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Conferma_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conferma_Main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Conferma_Main.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Conferma_Main.Location = new System.Drawing.Point(5, 168);
            this.btn_Conferma_Main.Name = "btn_Conferma_Main";
            this.btn_Conferma_Main.Size = new System.Drawing.Size(839, 30);
            this.btn_Conferma_Main.TabIndex = 19;
            this.btn_Conferma_Main.Text = "Conferma";
            this.btn_Conferma_Main.UseVisualStyleBackColor = false;
            this.btn_Conferma_Main.Click += new System.EventHandler(this.btn_Conferma_Main_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txt_Referal_Code);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(5, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 27);
            this.panel3.TabIndex = 22;
            // 
            // txt_Referal_Code
            // 
            this.txt_Referal_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Referal_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.txt_Referal_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Referal_Code.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Referal_Code.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_Referal_Code.Location = new System.Drawing.Point(374, 3);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.groupBox2.Controls.Add(this.lbl_Avviso_Main_Titolo);
            this.groupBox2.Controls.Add(this.lbl_Avviso_Main);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(5, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 61);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EULA";
            // 
            // lbl_Avviso_Main_Titolo
            // 
            this.lbl_Avviso_Main_Titolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Avviso_Main_Titolo.AutoSize = true;
            this.lbl_Avviso_Main_Titolo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Avviso_Main_Titolo.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Avviso_Main_Titolo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Avviso_Main_Titolo.Location = new System.Drawing.Point(434, 13);
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
            this.lbl_Avviso_Main.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Avviso_Main.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Avviso_Main.Location = new System.Drawing.Point(434, 34);
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
            this.panel2.Size = new System.Drawing.Size(839, 29);
            this.panel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(302, 4);
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
            this.label1.Location = new System.Drawing.Point(378, 4);
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
            this.label2.Location = new System.Drawing.Point(457, 4);
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
            this.txt_User_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User_Address.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_User_Address.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_User_Address.Location = new System.Drawing.Point(5, 47);
            this.txt_User_Address.Name = "txt_User_Address";
            this.txt_User_Address.Size = new System.Drawing.Size(839, 20);
            this.txt_User_Address.TabIndex = 18;
            this.txt_User_Address.Text = "Inserisci wallet XCH";
            this.txt_User_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_PopUp_Main_Conferma);
            this.panel6.Location = new System.Drawing.Point(5, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 23);
            this.panel6.TabIndex = 25;
            // 
            // lbl_PopUp_Main_Conferma
            // 
            this.lbl_PopUp_Main_Conferma.AutoSize = true;
            this.lbl_PopUp_Main_Conferma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_PopUp_Main_Conferma.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_PopUp_Main_Conferma.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_PopUp_Main_Conferma.Location = new System.Drawing.Point(155, 3);
            this.lbl_PopUp_Main_Conferma.Name = "lbl_PopUp_Main_Conferma";
            this.lbl_PopUp_Main_Conferma.Size = new System.Drawing.Size(293, 20);
            this.lbl_PopUp_Main_Conferma.TabIndex = 24;
            this.lbl_PopUp_Main_Conferma.Text = "Accetta EULA ed Insierisci indirizzo CHIA";
            this.lbl_PopUp_Main_Conferma.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_PopUp_Main_XCH_Address);
            this.panel7.Location = new System.Drawing.Point(5, 155);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(580, 23);
            this.panel7.TabIndex = 26;
            // 
            // lbl_PopUp_Main_XCH_Address
            // 
            this.lbl_PopUp_Main_XCH_Address.AutoSize = true;
            this.lbl_PopUp_Main_XCH_Address.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_PopUp_Main_XCH_Address.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_PopUp_Main_XCH_Address.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_PopUp_Main_XCH_Address.Location = new System.Drawing.Point(155, 3);
            this.lbl_PopUp_Main_XCH_Address.Name = "lbl_PopUp_Main_XCH_Address";
            this.lbl_PopUp_Main_XCH_Address.Size = new System.Drawing.Size(293, 20);
            this.lbl_PopUp_Main_XCH_Address.TabIndex = 24;
            this.lbl_PopUp_Main_XCH_Address.Text = "Accetta EULA ed Insierisci indirizzo CHIA";
            this.lbl_PopUp_Main_XCH_Address.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 521);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_Superiore);
            this.Controls.Add(this.panel_Menu_Laterale);
            this.MinimumSize = new System.Drawing.Size(835, 350);
            this.Name = "FormMain";
            this.Text = "Deep Mining Protocol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_Menu_Laterale.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Superiore.ResumeLayout(false);
            this.panel_Superiore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Current_Selection)).EndInit();
            this.panel_Desktop.ResumeLayout(false);
            this.goupB_Main_Form.ResumeLayout(false);
            this.goupB_Main_Form.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Menu_Laterale;
        private Panel panel1;
        private Label label_Logo;
        private FontAwesome.Sharp.IconButton btn_Simulate;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private FontAwesome.Sharp.IconButton btn_Payment;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_EULA;
        private Panel panel_Superiore;
        private FontAwesome.Sharp.IconPictureBox icon_Current_Selection;
        private Label label_Form_Selected;
        private Panel panel_Desktop;
        private GroupBox goupB_Main_Form;
        private GroupBox groupBox2;
        private RadioButton radioBtn_EULA_1;
        private Panel panel2;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button btn_Conferma_Main;
        private TextBox txt_User_Address;
        private Panel panel3;
        private TextBox txt_Referal_Code;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Panel panel5;
        private RadioButton radioBtn_EULA_2;
        private Label lbl_Avviso_Main;
        private Label lbl_Avviso_Main_Titolo;
        private Label lbl_PopUp_Main_Conferma;
        private Panel panel6;
        private Panel panel7;
        private Label lbl_PopUp_Main_XCH_Address;
        private Button Btn_Sync;
    }
}