namespace DWWP
{
    partial class Form_Options
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SQLServername = new System.Windows.Forms.TextBox();
            this.SQLDatabase = new System.Windows.Forms.TextBox();
            this.SQLPort = new System.Windows.Forms.TextBox();
            this.SQLUsername = new System.Windows.Forms.TextBox();
            this.SQLPassword = new System.Windows.Forms.TextBox();
            this.SQLWinAuth = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressPartner = new System.Windows.Forms.TextBox();
            this.AddressDelivery = new System.Windows.Forms.TextBox();
            this.AddressCustomer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddressType = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerSQLCommand = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressType)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(327, 15);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "This is the Options Window, here you can enter your Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL Connection Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datenbank";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Windows auth";
            // 
            // SQLServername
            // 
            this.SQLServername.Location = new System.Drawing.Point(12, 52);
            this.SQLServername.Name = "SQLServername";
            this.SQLServername.Size = new System.Drawing.Size(200, 23);
            this.SQLServername.TabIndex = 11;
            // 
            // SQLDatabase
            // 
            this.SQLDatabase.Location = new System.Drawing.Point(12, 100);
            this.SQLDatabase.Name = "SQLDatabase";
            this.SQLDatabase.Size = new System.Drawing.Size(200, 23);
            this.SQLDatabase.TabIndex = 12;
            // 
            // SQLPort
            // 
            this.SQLPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLPort.Location = new System.Drawing.Point(301, 52);
            this.SQLPort.Name = "SQLPort";
            this.SQLPort.Size = new System.Drawing.Size(200, 23);
            this.SQLPort.TabIndex = 13;
            // 
            // SQLUsername
            // 
            this.SQLUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLUsername.Location = new System.Drawing.Point(542, 52);
            this.SQLUsername.Name = "SQLUsername";
            this.SQLUsername.Size = new System.Drawing.Size(200, 23);
            this.SQLUsername.TabIndex = 14;
            // 
            // SQLPassword
            // 
            this.SQLPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLPassword.Location = new System.Drawing.Point(542, 100);
            this.SQLPassword.Name = "SQLPassword";
            this.SQLPassword.Size = new System.Drawing.Size(200, 23);
            this.SQLPassword.TabIndex = 15;
            // 
            // SQLWinAuth
            // 
            this.SQLWinAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLWinAuth.Location = new System.Drawing.Point(301, 100);
            this.SQLWinAuth.Name = "SQLWinAuth";
            this.SQLWinAuth.Size = new System.Drawing.Size(83, 23);
            this.SQLWinAuth.TabIndex = 16;
            this.SQLWinAuth.Text = "Enabled";
            this.SQLWinAuth.UseVisualStyleBackColor = true;
            this.SQLWinAuth.Click += new System.EventHandler(this.SQLWinAuth_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(839, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCon
            // 
            this.buttonCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCon.Location = new System.Drawing.Point(789, 26);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(125, 97);
            this.buttonCon.TabIndex = 18;
            this.buttonCon.Text = "Connect";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonConTest_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.AddressPartner);
            this.panel1.Controls.Add(this.AddressDelivery);
            this.panel1.Controls.Add(this.AddressCustomer);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.AddressType);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CustomerSQLCommand);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.SQLWinAuth);
            this.panel1.Controls.Add(this.buttonCon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SQLPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SQLUsername);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SQLPort);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SQLDatabase);
            this.panel1.Controls.Add(this.SQLServername);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 400);
            this.panel1.TabIndex = 19;
            // 
            // AddressPartner
            // 
            this.AddressPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressPartner.Location = new System.Drawing.Point(710, 314);
            this.AddressPartner.Name = "AddressPartner";
            this.AddressPartner.Size = new System.Drawing.Size(132, 23);
            this.AddressPartner.TabIndex = 32;
            // 
            // AddressDelivery
            // 
            this.AddressDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressDelivery.Location = new System.Drawing.Point(710, 285);
            this.AddressDelivery.Name = "AddressDelivery";
            this.AddressDelivery.Size = new System.Drawing.Size(132, 23);
            this.AddressDelivery.TabIndex = 31;
            // 
            // AddressCustomer
            // 
            this.AddressCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCustomer.Location = new System.Drawing.Point(710, 256);
            this.AddressCustomer.Name = "AddressCustomer";
            this.AddressCustomer.Size = new System.Drawing.Size(132, 23);
            this.AddressCustomer.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(588, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 15);
            this.label16.TabIndex = 29;
            this.label16.Text = "Ansprechpartner";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(588, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lieferanten";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(588, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Kunden";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Adress Art:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(174, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(318, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "geben sie hier an, die wie vielte Spalte für die Adress art ist.";
            // 
            // AddressType
            // 
            this.AddressType.Location = new System.Drawing.Point(133, 257);
            this.AddressType.Name = "AddressType";
            this.AddressType.Size = new System.Drawing.Size(35, 23);
            this.AddressType.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Adress art Spalte:";
            // 
            // CustomerSQLCommand
            // 
            this.CustomerSQLCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerSQLCommand.Location = new System.Drawing.Point(85, 216);
            this.CustomerSQLCommand.Name = "CustomerSQLCommand";
            this.CustomerSQLCommand.Size = new System.Drawing.Size(829, 23);
            this.CustomerSQLCommand.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "SQL Befehl:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kunden:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "SQL Datenbank befehle";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelInfo);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 46);
            this.panel2.TabIndex = 20;
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Options";
            this.Text = "Form_Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SQLServername;
        private System.Windows.Forms.TextBox SQLDatabase;
        private System.Windows.Forms.TextBox SQLPort;
        private System.Windows.Forms.TextBox SQLUsername;
        private System.Windows.Forms.TextBox SQLPassword;
        private System.Windows.Forms.Button SQLWinAuth;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AddressDelivery;
        private System.Windows.Forms.TextBox AddressCustomer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown AddressType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CustomerSQLCommand;
        private System.Windows.Forms.TextBox AddressPartner;
    }
}