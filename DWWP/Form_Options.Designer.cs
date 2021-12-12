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
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 452);
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
    }
}