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
            this.checkBoxResize = new System.Windows.Forms.CheckBox();
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
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(12, 43);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(196, 19);
            this.checkBoxResize.TabIndex = 3;
            this.checkBoxResize.Text = "should this window be Resizeabl";
            this.checkBoxResize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL Connection Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datenbank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Windows auth";
            // 
            // SQLServername
            // 
            this.SQLServername.Location = new System.Drawing.Point(12, 135);
            this.SQLServername.Name = "SQLServername";
            this.SQLServername.Size = new System.Drawing.Size(200, 23);
            this.SQLServername.TabIndex = 11;
            // 
            // SQLDatabase
            // 
            this.SQLDatabase.Location = new System.Drawing.Point(12, 183);
            this.SQLDatabase.Name = "SQLDatabase";
            this.SQLDatabase.Size = new System.Drawing.Size(200, 23);
            this.SQLDatabase.TabIndex = 12;
            // 
            // SQLPort
            // 
            this.SQLPort.Location = new System.Drawing.Point(301, 135);
            this.SQLPort.Name = "SQLPort";
            this.SQLPort.Size = new System.Drawing.Size(200, 23);
            this.SQLPort.TabIndex = 13;
            // 
            // SQLUsername
            // 
            this.SQLUsername.Location = new System.Drawing.Point(542, 135);
            this.SQLUsername.Name = "SQLUsername";
            this.SQLUsername.Size = new System.Drawing.Size(200, 23);
            this.SQLUsername.TabIndex = 14;
            // 
            // SQLPassword
            // 
            this.SQLPassword.Location = new System.Drawing.Point(542, 183);
            this.SQLPassword.Name = "SQLPassword";
            this.SQLPassword.Size = new System.Drawing.Size(200, 23);
            this.SQLPassword.TabIndex = 15;
            // 
            // SQLWinAuth
            // 
            this.SQLWinAuth.Location = new System.Drawing.Point(301, 183);
            this.SQLWinAuth.Name = "SQLWinAuth";
            this.SQLWinAuth.Size = new System.Drawing.Size(83, 23);
            this.SQLWinAuth.TabIndex = 16;
            this.SQLWinAuth.Text = "Enabled";
            this.SQLWinAuth.UseVisualStyleBackColor = true;
            this.SQLWinAuth.Click += new System.EventHandler(this.SQLWinAuth_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(839, 417);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(789, 109);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(125, 97);
            this.buttonCon.TabIndex = 18;
            this.buttonCon.Text = "Connect";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonConTest_Click);
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 452);
            this.Controls.Add(this.buttonCon);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.SQLWinAuth);
            this.Controls.Add(this.SQLPassword);
            this.Controls.Add(this.SQLUsername);
            this.Controls.Add(this.SQLPort);
            this.Controls.Add(this.SQLDatabase);
            this.Controls.Add(this.SQLServername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxResize);
            this.Controls.Add(this.labelInfo);
            this.Name = "Form_Options";
            this.Text = "Form_Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxResize;
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
    }
}