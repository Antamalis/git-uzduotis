
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
            this.eglutesDydis = new System.Windows.Forms.TextBox();
            this.piesti = new System.Windows.Forms.Button();
            this.eglute = new System.Windows.Forms.RichTextBox();
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
            this.isvestis.Location = new System.Drawing.Point(129, 12);
            this.isvestis.Multiline = true;
            this.isvestis.Name = "isvestis";
            this.isvestis.ReadOnly = true;
            this.isvestis.Size = new System.Drawing.Size(165, 49);
            this.isvestis.TabIndex = 2;
            // 
            // eglutesDydis
            // 
            this.eglutesDydis.Location = new System.Drawing.Point(12, 119);
            this.eglutesDydis.Name = "eglutesDydis";
            this.eglutesDydis.Size = new System.Drawing.Size(100, 20);
            this.eglutesDydis.TabIndex = 3;
            // 
            // piesti
            // 
            this.piesti.Location = new System.Drawing.Point(12, 146);
            this.piesti.Name = "piesti";
            this.piesti.Size = new System.Drawing.Size(100, 23);
            this.piesti.TabIndex = 4;
            this.piesti.Text = "Piesti";
            this.piesti.UseVisualStyleBackColor = true;
            this.piesti.Click += new System.EventHandler(this.piesti_Click);
            // 
            // eglute
            // 
            this.eglute.Location = new System.Drawing.Point(129, 119);
            this.eglute.Name = "eglute";
            this.eglute.ReadOnly = true;
            this.eglute.Size = new System.Drawing.Size(165, 84);
            this.eglute.TabIndex = 5;
            this.eglute.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 215);
            this.Controls.Add(this.eglute);
            this.Controls.Add(this.piesti);
            this.Controls.Add(this.eglutesDydis);
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
        private System.Windows.Forms.TextBox eglutesDydis;
        private System.Windows.Forms.Button piesti;
        private System.Windows.Forms.RichTextBox eglute;
    }
}

