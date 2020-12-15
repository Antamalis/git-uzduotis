
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
            this.pridetiSkaiciu = new System.Windows.Forms.Button();
            this.ivestis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pridetiSkaiciu
            // 
            this.pridetiSkaiciu.Location = new System.Drawing.Point(12, 38);
            this.pridetiSkaiciu.Name = "pridetiSkaiciu";
            this.pridetiSkaiciu.Size = new System.Drawing.Size(100, 23);
            this.pridetiSkaiciu.TabIndex = 0;
            this.pridetiSkaiciu.Text = "Prideti skaiciu";
            this.pridetiSkaiciu.UseVisualStyleBackColor = true;
            this.pridetiSkaiciu.Click += new System.EventHandler(this.pridetiSkaiciu_Click);
            // 
            // ivestis
            // 
            this.ivestis.Location = new System.Drawing.Point(12, 12);
            this.ivestis.Name = "ivestis";
            this.ivestis.Size = new System.Drawing.Size(100, 20);
            this.ivestis.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ivestis);
            this.Controls.Add(this.pridetiSkaiciu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pridetiSkaiciu;
        private System.Windows.Forms.TextBox ivestis;
    }
}

