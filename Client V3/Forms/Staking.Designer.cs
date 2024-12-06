namespace Client_V3.Forms
{
    partial class Staking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagrid_Unstake = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Coin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colquantita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colstato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colwallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpBox_Withdraw = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bilancio_Unstake = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.Coin_Unstake = new System.Windows.Forms.ComboBox();
            this.btn_Unstake = new System.Windows.Forms.Button();
            this.txt_Day_Lock_Unstake = new System.Windows.Forms.TextBox();
            this.txt_Prelievo_Unstake = new System.Windows.Forms.TextBox();
            this.GpBox_Staking = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bilancio_Staking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.btn_Staking = new System.Windows.Forms.Button();
            this.txt_APY_Staking = new System.Windows.Forms.TextBox();
            this.txt_Deposito_Staking = new System.Windows.Forms.TextBox();
            this.Coin_Staking = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Unstake)).BeginInit();
            this.GpBox_Withdraw.SuspendLayout();
            this.panel26.SuspendLayout();
            this.GpBox_Staking.SuspendLayout();
            this.panel33.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.GpBox_Withdraw);
            this.groupBox1.Controls.Add(this.GpBox_Staking);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 374);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.datagrid_Unstake);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(6, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 182);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // datagrid_Unstake
            // 
            this.datagrid_Unstake.AllowUserToAddRows = false;
            this.datagrid_Unstake.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.datagrid_Unstake.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Unstake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_Unstake.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.datagrid_Unstake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Unstake.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Unstake.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Unstake.ColumnHeadersHeight = 20;
            this.datagrid_Unstake.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.Col_Coin,
            this.Colquantita,
            this.Coltimer,
            this.Colstato,
            this.Coldata,
            this.Col_Type,
            this.Colwallet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Unstake.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_Unstake.EnableHeadersVisualStyles = false;
            this.datagrid_Unstake.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.datagrid_Unstake.Location = new System.Drawing.Point(3, 16);
            this.datagrid_Unstake.Name = "datagrid_Unstake";
            this.datagrid_Unstake.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Unstake.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_Unstake.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            this.datagrid_Unstake.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_Unstake.Size = new System.Drawing.Size(749, 163);
            this.datagrid_Unstake.TabIndex = 0;
            // 
            // col_ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            this.col_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 40;
            // 
            // Col_Coin
            // 
            this.Col_Coin.HeaderText = "Coin";
            this.Col_Coin.Name = "Col_Coin";
            this.Col_Coin.ReadOnly = true;
            this.Col_Coin.Width = 60;
            // 
            // Colquantita
            // 
            this.Colquantita.HeaderText = "Quantità";
            this.Colquantita.Name = "Colquantita";
            this.Colquantita.ReadOnly = true;
            this.Colquantita.Width = 90;
            // 
            // Coltimer
            // 
            this.Coltimer.HeaderText = "Timer";
            this.Coltimer.Name = "Coltimer";
            this.Coltimer.ReadOnly = true;
            this.Coltimer.Width = 60;
            // 
            // Colstato
            // 
            this.Colstato.HeaderText = "Stato";
            this.Colstato.Name = "Colstato";
            this.Colstato.ReadOnly = true;
            this.Colstato.Width = 80;
            // 
            // Coldata
            // 
            this.Coldata.HeaderText = "Data";
            this.Coldata.Name = "Coldata";
            this.Coldata.ReadOnly = true;
            this.Coldata.Width = 115;
            // 
            // Col_Type
            // 
            this.Col_Type.HeaderText = "Type";
            this.Col_Type.Name = "Col_Type";
            this.Col_Type.ReadOnly = true;
            this.Col_Type.Width = 55;
            // 
            // Colwallet
            // 
            this.Colwallet.HeaderText = "Wallet";
            this.Colwallet.Name = "Colwallet";
            this.Colwallet.ReadOnly = true;
            this.Colwallet.Width = 370;
            // 
            // GpBox_Withdraw
            // 
            this.GpBox_Withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpBox_Withdraw.Controls.Add(this.label6);
            this.GpBox_Withdraw.Controls.Add(this.txt_Bilancio_Unstake);
            this.GpBox_Withdraw.Controls.Add(this.label5);
            this.GpBox_Withdraw.Controls.Add(this.label10);
            this.GpBox_Withdraw.Controls.Add(this.panel26);
            this.GpBox_Withdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.GpBox_Withdraw.Location = new System.Drawing.Point(6, 96);
            this.GpBox_Withdraw.Name = "GpBox_Withdraw";
            this.GpBox_Withdraw.Size = new System.Drawing.Size(755, 82);
            this.GpBox_Withdraw.TabIndex = 23;
            this.GpBox_Withdraw.TabStop = false;
            this.GpBox_Withdraw.Text = "Unstake";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(33, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Balance Staked";
            // 
            // txt_Bilancio_Unstake
            // 
            this.txt_Bilancio_Unstake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bilancio_Unstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_Bilancio_Unstake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Bilancio_Unstake.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Bilancio_Unstake.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_Bilancio_Unstake.Location = new System.Drawing.Point(125, 56);
            this.txt_Bilancio_Unstake.Name = "txt_Bilancio_Unstake";
            this.txt_Bilancio_Unstake.ReadOnly = true;
            this.txt_Bilancio_Unstake.Size = new System.Drawing.Size(446, 18);
            this.txt_Bilancio_Unstake.TabIndex = 60;
            this.txt_Bilancio_Unstake.Text = "0.000";
            this.txt_Bilancio_Unstake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(598, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Day/lock";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(320, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "Prelievo";
            // 
            // panel26
            // 
            this.panel26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel26.Controls.Add(this.Coin_Unstake);
            this.panel26.Controls.Add(this.btn_Unstake);
            this.panel26.Controls.Add(this.txt_Day_Lock_Unstake);
            this.panel26.Controls.Add(this.txt_Prelievo_Unstake);
            this.panel26.Location = new System.Drawing.Point(6, 27);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(743, 26);
            this.panel26.TabIndex = 55;
            // 
            // Coin_Unstake
            // 
            this.Coin_Unstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.Coin_Unstake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coin_Unstake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coin_Unstake.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Unstake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.Coin_Unstake.FormattingEnabled = true;
            this.Coin_Unstake.Items.AddRange(new object[] {
            "XDLS",
            "XUSDT"});
            this.Coin_Unstake.Location = new System.Drawing.Point(3, 1);
            this.Coin_Unstake.Name = "Coin_Unstake";
            this.Coin_Unstake.Size = new System.Drawing.Size(110, 23);
            this.Coin_Unstake.TabIndex = 69;
            this.Coin_Unstake.SelectedIndexChanged += new System.EventHandler(this.Coin_Unstake_SelectedIndexChanged);
            // 
            // btn_Unstake
            // 
            this.btn_Unstake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Unstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Unstake.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Unstake.FlatAppearance.BorderSize = 0;
            this.btn_Unstake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Unstake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unstake.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Unstake.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Unstake.Location = new System.Drawing.Point(652, 1);
            this.btn_Unstake.Name = "btn_Unstake";
            this.btn_Unstake.Size = new System.Drawing.Size(90, 23);
            this.btn_Unstake.TabIndex = 25;
            this.btn_Unstake.Text = "Sblocca";
            this.btn_Unstake.UseVisualStyleBackColor = false;
            this.btn_Unstake.Click += new System.EventHandler(this.btn_Unstake_Click);
            // 
            // txt_Day_Lock_Unstake
            // 
            this.txt_Day_Lock_Unstake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Day_Lock_Unstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_Day_Lock_Unstake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Day_Lock_Unstake.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Day_Lock_Unstake.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_Day_Lock_Unstake.Location = new System.Drawing.Point(571, 4);
            this.txt_Day_Lock_Unstake.Name = "txt_Day_Lock_Unstake";
            this.txt_Day_Lock_Unstake.ReadOnly = true;
            this.txt_Day_Lock_Unstake.Size = new System.Drawing.Size(75, 18);
            this.txt_Day_Lock_Unstake.TabIndex = 37;
            this.txt_Day_Lock_Unstake.Text = "24";
            this.txt_Day_Lock_Unstake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Prelievo_Unstake
            // 
            this.txt_Prelievo_Unstake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Prelievo_Unstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_Prelievo_Unstake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Prelievo_Unstake.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Prelievo_Unstake.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_Prelievo_Unstake.Location = new System.Drawing.Point(119, 5);
            this.txt_Prelievo_Unstake.Name = "txt_Prelievo_Unstake";
            this.txt_Prelievo_Unstake.Size = new System.Drawing.Size(446, 18);
            this.txt_Prelievo_Unstake.TabIndex = 37;
            this.txt_Prelievo_Unstake.Text = "0.000";
            this.txt_Prelievo_Unstake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GpBox_Staking
            // 
            this.GpBox_Staking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpBox_Staking.Controls.Add(this.label4);
            this.GpBox_Staking.Controls.Add(this.txt_Bilancio_Staking);
            this.GpBox_Staking.Controls.Add(this.label3);
            this.GpBox_Staking.Controls.Add(this.label2);
            this.GpBox_Staking.Controls.Add(this.panel33);
            this.GpBox_Staking.Controls.Add(this.label9);
            this.GpBox_Staking.Controls.Add(this.label8);
            this.GpBox_Staking.ForeColor = System.Drawing.SystemColors.Control;
            this.GpBox_Staking.Location = new System.Drawing.Point(6, 8);
            this.GpBox_Staking.Name = "GpBox_Staking";
            this.GpBox_Staking.Size = new System.Drawing.Size(756, 82);
            this.GpBox_Staking.TabIndex = 22;
            this.GpBox_Staking.TabStop = false;
            this.GpBox_Staking.Text = "Staking";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(45, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "User Balance";
            // 
            // txt_Bilancio_Staking
            // 
            this.txt_Bilancio_Staking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bilancio_Staking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_Bilancio_Staking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Bilancio_Staking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Bilancio_Staking.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_Bilancio_Staking.Location = new System.Drawing.Point(125, 56);
            this.txt_Bilancio_Staking.Name = "txt_Bilancio_Staking";
            this.txt_Bilancio_Staking.ReadOnly = true;
            this.txt_Bilancio_Staking.Size = new System.Drawing.Size(446, 18);
            this.txt_Bilancio_Staking.TabIndex = 59;
            this.txt_Bilancio_Staking.Text = "0.000";
            this.txt_Bilancio_Staking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(608, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "APY";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(320, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Deposito";
            // 
            // panel33
            // 
            this.panel33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.panel33.Controls.Add(this.btn_Staking);
            this.panel33.Controls.Add(this.txt_APY_Staking);
            this.panel33.Controls.Add(this.txt_Deposito_Staking);
            this.panel33.Controls.Add(this.Coin_Staking);
            this.panel33.Location = new System.Drawing.Point(6, 27);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(744, 26);
            this.panel33.TabIndex = 52;
            // 
            // btn_Staking
            // 
            this.btn_Staking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Staking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.btn_Staking.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Staking.FlatAppearance.BorderSize = 0;
            this.btn_Staking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btn_Staking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Staking.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Staking.Location = new System.Drawing.Point(652, 1);
            this.btn_Staking.Name = "btn_Staking";
            this.btn_Staking.Size = new System.Drawing.Size(91, 23);
            this.btn_Staking.TabIndex = 25;
            this.btn_Staking.Text = "Blocca";
            this.btn_Staking.UseVisualStyleBackColor = false;
            this.btn_Staking.Click += new System.EventHandler(this.btn_Staking_Click);
            // 
            // txt_APY_Staking
            // 
            this.txt_APY_Staking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_APY_Staking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_APY_Staking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_APY_Staking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_APY_Staking.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_APY_Staking.Location = new System.Drawing.Point(571, 5);
            this.txt_APY_Staking.Name = "txt_APY_Staking";
            this.txt_APY_Staking.ReadOnly = true;
            this.txt_APY_Staking.Size = new System.Drawing.Size(75, 18);
            this.txt_APY_Staking.TabIndex = 37;
            this.txt_APY_Staking.Text = "3%";
            this.txt_APY_Staking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Deposito_Staking
            // 
            this.txt_Deposito_Staking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Deposito_Staking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.txt_Deposito_Staking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Deposito_Staking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Deposito_Staking.ForeColor = System.Drawing.Color.YellowGreen;
            this.txt_Deposito_Staking.Location = new System.Drawing.Point(119, 5);
            this.txt_Deposito_Staking.Name = "txt_Deposito_Staking";
            this.txt_Deposito_Staking.Size = new System.Drawing.Size(446, 18);
            this.txt_Deposito_Staking.TabIndex = 37;
            this.txt_Deposito_Staking.Text = "0.000";
            this.txt_Deposito_Staking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Coin_Staking
            // 
            this.Coin_Staking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.Coin_Staking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coin_Staking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coin_Staking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin_Staking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.Coin_Staking.FormattingEnabled = true;
            this.Coin_Staking.Items.AddRange(new object[] {
            "XDLS",
            "XUSDT"});
            this.Coin_Staking.Location = new System.Drawing.Point(1, 1);
            this.Coin_Staking.Name = "Coin_Staking";
            this.Coin_Staking.Size = new System.Drawing.Size(112, 23);
            this.Coin_Staking.TabIndex = 68;
            this.Coin_Staking.SelectedIndexChanged += new System.EventHandler(this.Coin_Staking_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(446, -81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "APR";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(339, -81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Deposito";
            // 
            // Staking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(779, 379);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Staking";
            this.Text = "Staking";
            this.Load += new System.EventHandler(this.Staking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Unstake)).EndInit();
            this.GpBox_Withdraw.ResumeLayout(false);
            this.GpBox_Withdraw.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.GpBox_Staking.ResumeLayout(false);
            this.GpBox_Staking.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GpBox_Staking;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GpBox_Withdraw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.ComboBox Coin_Unstake;
        private System.Windows.Forms.Button btn_Unstake;
        private System.Windows.Forms.TextBox txt_Day_Lock_Unstake;
        private System.Windows.Forms.TextBox txt_Prelievo_Unstake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button btn_Staking;
        private System.Windows.Forms.TextBox txt_APY_Staking;
        private System.Windows.Forms.TextBox txt_Deposito_Staking;
        private System.Windows.Forms.ComboBox Coin_Staking;
        private System.Windows.Forms.TextBox txt_Bilancio_Unstake;
        private System.Windows.Forms.TextBox txt_Bilancio_Staking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagrid_Unstake;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Coin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colquantita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colstato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colwallet;
    }
}