namespace E7_WFA_HepsiOrada
{
    partial class Guncelleme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSiparisAdi = new System.Windows.Forms.Label();
            this.txtSiparisFiyati = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtSiparisFiyati);
            this.panel1.Controls.Add(this.lblSiparisAdi);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 135);
            this.panel1.TabIndex = 0;
            // 
            // lblSiparisAdi
            // 
            this.lblSiparisAdi.AutoSize = true;
            this.lblSiparisAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisAdi.Location = new System.Drawing.Point(3, 21);
            this.lblSiparisAdi.Name = "lblSiparisAdi";
            this.lblSiparisAdi.Size = new System.Drawing.Size(88, 18);
            this.lblSiparisAdi.TabIndex = 0;
            this.lblSiparisAdi.Text = "Sipariş Adı";
            // 
            // txtSiparisFiyati
            // 
            this.txtSiparisFiyati.Location = new System.Drawing.Point(3, 49);
            this.txtSiparisFiyati.Name = "txtSiparisFiyati";
            this.txtSiparisFiyati.Size = new System.Drawing.Size(233, 20);
            this.txtSiparisFiyati.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(161, 75);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // Guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 179);
            this.Controls.Add(this.panel1);
            this.Name = "Guncelleme";
            this.Text = "Guncelleme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSiparisFiyati;
        private System.Windows.Forms.Label lblSiparisAdi;
    }
}