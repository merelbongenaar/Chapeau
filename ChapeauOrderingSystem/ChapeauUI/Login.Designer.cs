
namespace ChapeauUI
{
    partial class Login
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
            this.lblFirstNr = new System.Windows.Forms.Label();
            this.lblSecondNr = new System.Windows.Forms.Label();
            this.lblThirdNr = new System.Windows.Forms.Label();
            this.lblFourthNr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNr
            // 
            this.lblFirstNr.AutoSize = true;
            this.lblFirstNr.Location = new System.Drawing.Point(171, 188);
            this.lblFirstNr.Name = "lblFirstNr";
            this.lblFirstNr.Size = new System.Drawing.Size(25, 13);
            this.lblFirstNr.TabIndex = 0;
            this.lblFirstNr.Text = "___";
            // 
            // lblSecondNr
            // 
            this.lblSecondNr.AutoSize = true;
            this.lblSecondNr.Location = new System.Drawing.Point(221, 188);
            this.lblSecondNr.Name = "lblSecondNr";
            this.lblSecondNr.Size = new System.Drawing.Size(25, 13);
            this.lblSecondNr.TabIndex = 1;
            this.lblSecondNr.Text = "___";
            // 
            // lblThirdNr
            // 
            this.lblThirdNr.AutoSize = true;
            this.lblThirdNr.Location = new System.Drawing.Point(265, 188);
            this.lblThirdNr.Name = "lblThirdNr";
            this.lblThirdNr.Size = new System.Drawing.Size(25, 13);
            this.lblThirdNr.TabIndex = 2;
            this.lblThirdNr.Text = "___";
            // 
            // lblFourthNr
            // 
            this.lblFourthNr.AutoSize = true;
            this.lblFourthNr.Location = new System.Drawing.Point(330, 188);
            this.lblFourthNr.Name = "lblFourthNr";
            this.lblFourthNr.Size = new System.Drawing.Size(25, 13);
            this.lblFourthNr.TabIndex = 3;
            this.lblFourthNr.Text = "___";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(174, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 652);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFourthNr);
            this.Controls.Add(this.lblThirdNr);
            this.Controls.Add(this.lblSecondNr);
            this.Controls.Add(this.lblFirstNr);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNr;
        private System.Windows.Forms.Label lblSecondNr;
        private System.Windows.Forms.Label lblThirdNr;
        private System.Windows.Forms.Label lblFourthNr;
        private System.Windows.Forms.TextBox textBox1;
    }
}