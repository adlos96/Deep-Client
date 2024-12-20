﻿using Client_V3;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client_V3.Forms
{
    partial class EULA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_Prelievo_Deposito = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Deep_Client = new System.Windows.Forms.Label();
            this.lbl_Link_DeepMiningProtocol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Bonus_Invitato_Ref = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_Bonus_Invito_Ref = new System.Windows.Forms.Label();
            this.lbl_Rendimento = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Bonus_Deposito = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lbl_Prelievo_Deposito);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.lbl_Deep_Client);
            this.groupBox4.Controls.Add(this.lbl_Link_DeepMiningProtocol);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(495, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 422);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(104, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 19);
            this.label18.TabIndex = 19;
            this.label18.Text = "Prelievo - Deposito";
            // 
            // lbl_Prelievo_Deposito
            // 
            this.lbl_Prelievo_Deposito.AutoSize = true;
            this.lbl_Prelievo_Deposito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prelievo_Deposito.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_Prelievo_Deposito.Location = new System.Drawing.Point(21, 122);
            this.lbl_Prelievo_Deposito.Name = "lbl_Prelievo_Deposito";
            this.lbl_Prelievo_Deposito.Size = new System.Drawing.Size(85, 21);
            this.lbl_Prelievo_Deposito.TabIndex = 18;
            this.lbl_Prelievo_Deposito.Text = "Click here";
            this.lbl_Prelievo_Deposito.Click += new System.EventHandler(this.lbl_Prelievo_Deposito_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(104, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Deep Client";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(104, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Deep Mining Protocol";
            // 
            // lbl_Deep_Client
            // 
            this.lbl_Deep_Client.AutoSize = true;
            this.lbl_Deep_Client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deep_Client.ForeColor = System.Drawing.Color.Violet;
            this.lbl_Deep_Client.Location = new System.Drawing.Point(21, 100);
            this.lbl_Deep_Client.Name = "lbl_Deep_Client";
            this.lbl_Deep_Client.Size = new System.Drawing.Size(85, 21);
            this.lbl_Deep_Client.TabIndex = 14;
            this.lbl_Deep_Client.Text = "Click here";
            this.lbl_Deep_Client.Click += new System.EventHandler(this.lbl_Deep_Client_Click);
            // 
            // lbl_Link_DeepMiningProtocol
            // 
            this.lbl_Link_DeepMiningProtocol.AutoSize = true;
            this.lbl_Link_DeepMiningProtocol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link_DeepMiningProtocol.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_Link_DeepMiningProtocol.Location = new System.Drawing.Point(21, 78);
            this.lbl_Link_DeepMiningProtocol.Name = "lbl_Link_DeepMiningProtocol";
            this.lbl_Link_DeepMiningProtocol.Size = new System.Drawing.Size(85, 21);
            this.lbl_Link_DeepMiningProtocol.TabIndex = 12;
            this.lbl_Link_DeepMiningProtocol.Text = "Click here";
            this.lbl_Link_DeepMiningProtocol.Click += new System.EventHandler(this.lbl_Link_DeepMiningProtocol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deep Mining Protocol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(21, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Per maggiori dettagli:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lbl_Bonus_Invitato_Ref);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lbl_Bonus_Invito_Ref);
            this.groupBox3.Controls.Add(this.lbl_Rendimento);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbl_Bonus_Deposito);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(7, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 205);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // lbl_Bonus_Invitato_Ref
            // 
            this.lbl_Bonus_Invitato_Ref.AutoSize = true;
            this.lbl_Bonus_Invitato_Ref.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Bonus_Invitato_Ref.ForeColor = System.Drawing.Color.White;
            this.lbl_Bonus_Invitato_Ref.Location = new System.Drawing.Point(176, 87);
            this.lbl_Bonus_Invitato_Ref.Name = "lbl_Bonus_Invitato_Ref";
            this.lbl_Bonus_Invitato_Ref.Size = new System.Drawing.Size(66, 19);
            this.lbl_Bonus_Invitato_Ref.TabIndex = 18;
            this.lbl_Bonus_Invitato_Ref.Text = "4% (ADS)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label26.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label26.Location = new System.Drawing.Point(128, 87);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 19);
            this.label26.TabIndex = 16;
            this.label26.Text = "Referal:";
            // 
            // lbl_Bonus_Invito_Ref
            // 
            this.lbl_Bonus_Invito_Ref.AutoSize = true;
            this.lbl_Bonus_Invito_Ref.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Bonus_Invito_Ref.ForeColor = System.Drawing.Color.White;
            this.lbl_Bonus_Invito_Ref.Location = new System.Drawing.Point(164, 65);
            this.lbl_Bonus_Invito_Ref.Name = "lbl_Bonus_Invito_Ref";
            this.lbl_Bonus_Invito_Ref.Size = new System.Drawing.Size(66, 19);
            this.lbl_Bonus_Invito_Ref.TabIndex = 15;
            this.lbl_Bonus_Invito_Ref.Text = "9% (ADS)";
            // 
            // lbl_Rendimento
            // 
            this.lbl_Rendimento.AutoSize = true;
            this.lbl_Rendimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Rendimento.ForeColor = System.Drawing.Color.White;
            this.lbl_Rendimento.Location = new System.Drawing.Point(239, 108);
            this.lbl_Rendimento.Name = "lbl_Rendimento";
            this.lbl_Rendimento.Size = new System.Drawing.Size(99, 19);
            this.lbl_Rendimento.TabIndex = 13;
            this.lbl_Rendimento.Text = "0,87% - 2,75%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label16.Location = new System.Drawing.Point(177, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Deposito:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label12.Location = new System.Drawing.Point(116, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Referal:";
            // 
            // lbl_Bonus_Deposito
            // 
            this.lbl_Bonus_Deposito.AutoSize = true;
            this.lbl_Bonus_Deposito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Bonus_Deposito.ForeColor = System.Drawing.Color.White;
            this.lbl_Bonus_Deposito.Location = new System.Drawing.Point(160, 43);
            this.lbl_Bonus_Deposito.Name = "lbl_Bonus_Deposito";
            this.lbl_Bonus_Deposito.Size = new System.Drawing.Size(93, 19);
            this.lbl_Bonus_Deposito.TabIndex = 10;
            this.lbl_Bonus_Deposito.Text = "22% (Tantum)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(98, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Deposito:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(26, 87);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 19);
            this.label25.TabIndex = 17;
            this.label25.Text = "- Bonus invitato";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(26, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "- Bonus invito";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "- Rendimento annuo sul";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "- Bonus sul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rendimenti del software:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(391, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "- Non smarrire la Seed Phrase, essa non può essere recuperata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "- Lo staff non chiederà mai i dati di accesso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "- Diffida da chi ti chiede le chiavi d\'accesso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "- Attenzione, non è posssibile richiedere il recupero dei dati smarriti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "- Assicurati di inserire un indirizzo chia valido, di cui si ha il controllo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rischi legati all\'utilizzo del software:";
            // 
            // EULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(781, 456);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.Name = "EULA";
            this.Text = "EULA";
            this.Load += new System.EventHandler(this.EULA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label8;
        private Label label2;
        private Label label7;
        private Label label13;
        private Label label15;
        private Label label11;
        private Label lbl_Bonus_Invito_Ref;
        private Label lbl_Rendimento;
        private Label label16;
        private Label label12;
        private Label lbl_Bonus_Deposito;
        private Label lbl_Bonus_Invitato_Ref;
        private Label label25;
        private Label label26;
        private Label lbl_Link_DeepMiningProtocol;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label lbl_Deep_Client;
        private Label label18;
        private Label lbl_Prelievo_Deposito;
        private Label label17;
        private Label label14;
        private Label label10;
        private Label label9;
    }
}