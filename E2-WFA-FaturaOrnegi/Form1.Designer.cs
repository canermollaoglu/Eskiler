namespace E2_WFA_FaturaOrnegi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.TextBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.lstKullanilanSuMiktarı = new System.Windows.Forms.ListBox();
            this.rbMesken = new System.Windows.Forms.RadioButton();
            this.rbUmumi = new System.Windows.Forms.RadioButton();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSonIndex);
            this.panel1.Controls.Add(this.txtIlkIndex);
            this.panel1.Location = new System.Drawing.Point(84, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 59);
            this.panel1.TabIndex = 16;
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Location = new System.Drawing.Point(3, 3);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(368, 20);
            this.txtSonIndex.TabIndex = 1;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.Location = new System.Drawing.Point(3, 31);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(368, 20);
            this.txtIlkIndex.TabIndex = 3;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.Location = new System.Drawing.Point(320, 191);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(134, 186);
            this.lstFaturaTutari.TabIndex = 21;
            // 
            // lstKullanilanSuMiktarı
            // 
            this.lstKullanilanSuMiktarı.FormattingEnabled = true;
            this.lstKullanilanSuMiktarı.Location = new System.Drawing.Point(166, 191);
            this.lstKullanilanSuMiktarı.Name = "lstKullanilanSuMiktarı";
            this.lstKullanilanSuMiktarı.Size = new System.Drawing.Size(134, 186);
            this.lstKullanilanSuMiktarı.TabIndex = 20;
            // 
            // rbMesken
            // 
            this.rbMesken.AutoSize = true;
            this.rbMesken.Location = new System.Drawing.Point(97, 20);
            this.rbMesken.Name = "rbMesken";
            this.rbMesken.Size = new System.Drawing.Size(63, 17);
            this.rbMesken.TabIndex = 1;
            this.rbMesken.Text = "Mesken";
            this.rbMesken.UseVisualStyleBackColor = true;
            // 
            // rbUmumi
            // 
            this.rbUmumi.AutoSize = true;
            this.rbUmumi.Checked = true;
            this.rbUmumi.Location = new System.Drawing.Point(6, 20);
            this.rbUmumi.Name = "rbUmumi";
            this.rbUmumi.Size = new System.Drawing.Size(57, 17);
            this.rbUmumi.TabIndex = 0;
            this.rbUmumi.TabStop = true;
            this.rbUmumi.Text = "Umumi";
            this.rbUmumi.UseVisualStyleBackColor = true;
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.Location = new System.Drawing.Point(12, 191);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(134, 186);
            this.lstAdSoyad.TabIndex = 19;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(379, 145);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fatura Tutarı";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbMesken);
            this.gb1.Controls.Add(this.rbUmumi);
            this.gb1.Location = new System.Drawing.Point(86, 98);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(368, 43);
            this.gb1.TabIndex = 17;
            this.gb1.TabStop = false;
            this.gb1.Text = "Kullanım Yeri";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(86, 6);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(368, 20);
            this.txtAdSoyad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "İlk İndex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Son İndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kullanılan Su Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adı Soyadı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstKullanilanSuMiktarı);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSonIndex;
        private System.Windows.Forms.TextBox txtIlkIndex;
        private System.Windows.Forms.ListBox lstFaturaTutari;
        private System.Windows.Forms.ListBox lstKullanilanSuMiktarı;
        private System.Windows.Forms.RadioButton rbMesken;
        private System.Windows.Forms.RadioButton rbUmumi;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

