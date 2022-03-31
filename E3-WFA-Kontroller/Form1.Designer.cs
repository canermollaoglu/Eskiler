namespace E3_WFA_Kontroller
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
            this.txtmesaj = new System.Windows.Forms.TextBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lstSatirlar = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtMetin1 = new System.Windows.Forms.TextBox();
            this.btnMetinAktar = new System.Windows.Forms.Button();
            this.txtMetin2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmesaj
            // 
            this.txtmesaj.Location = new System.Drawing.Point(2, 45);
            this.txtmesaj.Multiline = true;
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmesaj.Size = new System.Drawing.Size(226, 105);
            this.txtmesaj.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(3, 156);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(226, 23);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "Lines Property\'si";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lstSatirlar
            // 
            this.lstSatirlar.FormattingEnabled = true;
            this.lstSatirlar.Location = new System.Drawing.Point(235, 45);
            this.lstSatirlar.Name = "lstSatirlar";
            this.lstSatirlar.Size = new System.Drawing.Size(120, 160);
            this.lstSatirlar.TabIndex = 2;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(2, 185);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(226, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Textboxı Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtMetin1
            // 
            this.txtMetin1.Location = new System.Drawing.Point(3, 225);
            this.txtMetin1.Name = "txtMetin1";
            this.txtMetin1.Size = new System.Drawing.Size(226, 20);
            this.txtMetin1.TabIndex = 3;
            // 
            // btnMetinAktar
            // 
            this.btnMetinAktar.Location = new System.Drawing.Point(3, 252);
            this.btnMetinAktar.Name = "btnMetinAktar";
            this.btnMetinAktar.Size = new System.Drawing.Size(226, 23);
            this.btnMetinAktar.TabIndex = 4;
            this.btnMetinAktar.Text = "Metin Aktar";
            this.btnMetinAktar.UseVisualStyleBackColor = true;
            this.btnMetinAktar.Click += new System.EventHandler(this.btnMetinAktar_Click);
            // 
            // txtMetin2
            // 
            this.txtMetin2.Location = new System.Drawing.Point(3, 281);
            this.txtMetin2.Name = "txtMetin2";
            this.txtMetin2.Size = new System.Drawing.Size(226, 20);
            this.txtMetin2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 311);
            this.Controls.Add(this.btnMetinAktar);
            this.Controls.Add(this.txtMetin2);
            this.Controls.Add(this.txtMetin1);
            this.Controls.Add(this.lstSatirlar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.txtmesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmesaj;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lstSatirlar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtMetin1;
        private System.Windows.Forms.Button btnMetinAktar;
        private System.Windows.Forms.TextBox txtMetin2;
    }
}

