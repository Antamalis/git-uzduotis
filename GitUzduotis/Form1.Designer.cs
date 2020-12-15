
namespace GitUzduotis
{
    partial class Form1
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
            this.skaiciuoti = new System.Windows.Forms.Button();
            this.ivestis = new System.Windows.Forms.TextBox();
            this.isvestis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skaiciuoti
            // 
            this.skaiciuoti.Location = new System.Drawing.Point(12, 38);
            this.skaiciuoti.Name = "skaiciuoti";
            this.skaiciuoti.Size = new System.Drawing.Size(100, 23);
            this.skaiciuoti.TabIndex = 0;
            this.skaiciuoti.Text = "Skaiciuoti";
            this.skaiciuoti.UseVisualStyleBackColor = true;
            this.skaiciuoti.Click += new System.EventHandler(this.skaiciuoti_Click);
            // 
            // ivestis
            // 
            this.ivestis.Location = new System.Drawing.Point(12, 12);
            this.ivestis.Name = "ivestis";
            this.ivestis.Size = new System.Drawing.Size(100, 20);
            this.ivestis.TabIndex = 1;
            // 
            // isvestis
            // 
            this.isvestis.BackColor = System.Drawing.SystemColors.Control;
            this.isvestis.Enabled = false;
            this.isvestis.Location = new System.Drawing.Point(129, 12);
            this.isvestis.Multiline = true;
            this.isvestis.Name = "isvestis";
            this.isvestis.ReadOnly = true;
            this.isvestis.Size = new System.Drawing.Size(165, 49);
            this.isvestis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 78);
            this.Controls.Add(this.isvestis);
            this.Controls.Add(this.ivestis);
            this.Controls.Add(this.skaiciuoti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skaiciuoti;
        private System.Windows.Forms.TextBox ivestis;
        private System.Windows.Forms.TextBox isvestis;
    }
}

