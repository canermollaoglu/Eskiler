namespace E7_WFA_HepsiOrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.lblSepetToplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpIndirim = new System.Windows.Forms.GroupBox();
            this.rdbonbes = new System.Windows.Forms.RadioButton();
            this.rdbon = new System.Windows.Forms.RadioButton();
            this.rdbbes = new System.Windows.Forms.RadioButton();
            this.btnSiparisGec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.lstTumSiparisler = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rchTxtMesaj = new System.Windows.Forms.RichTextBox();
            this.btnMesajKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUrunSec = new System.Windows.Forms.ComboBox();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.btnUrunBilgisiGuncelle = new System.Windows.Forms.Button();
            this.cmbKategoriSec = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpIndirim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ SEÇİNİZ:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(16, 39);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(126, 21);
            this.cmbKategori.TabIndex = 1;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(16, 67);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(126, 199);
            this.lstUrunler.TabIndex = 2;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(177, 67);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(126, 121);
            this.lstSepet.TabIndex = 2;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(144, 112);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(32, 23);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = ">>";
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(174, 191);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(98, 13);
            this.lblUrunAdet.TabIndex = 0;
            this.lblUrunAdet.Text = "Toplam Ürün Adedi";
            // 
            // lblSepetToplam
            // 
            this.lblSepetToplam.AutoSize = true;
            this.lblSepetToplam.Location = new System.Drawing.Point(174, 215);
            this.lblSepetToplam.Name = "lblSepetToplam";
            this.lblSepetToplam.Size = new System.Drawing.Size(78, 13);
            this.lblSepetToplam.TabIndex = 0;
            this.lblSepetToplam.Text = "Sepet Toplamı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SEPET:";
            // 
            // grpIndirim
            // 
            this.grpIndirim.Controls.Add(this.rdbonbes);
            this.grpIndirim.Controls.Add(this.rdbon);
            this.grpIndirim.Controls.Add(this.rdbbes);
            this.grpIndirim.Location = new System.Drawing.Point(16, 273);
            this.grpIndirim.Name = "grpIndirim";
            this.grpIndirim.Size = new System.Drawing.Size(126, 121);
            this.grpIndirim.TabIndex = 4;
            this.grpIndirim.TabStop = false;
            this.grpIndirim.Text = "İndirim Miktarı Seçiniz:";
            // 
            // rdbonbes
            // 
            this.rdbonbes.AutoSize = true;
            this.rdbonbes.Location = new System.Drawing.Point(6, 79);
            this.rdbonbes.Name = "rdbonbes";
            this.rdbonbes.Size = new System.Drawing.Size(45, 17);
            this.rdbonbes.TabIndex = 0;
            this.rdbonbes.TabStop = true;
            this.rdbonbes.Text = "%15";
            this.rdbonbes.UseVisualStyleBackColor = true;
            // 
            // rdbon
            // 
            this.rdbon.AutoSize = true;
            this.rdbon.Location = new System.Drawing.Point(6, 56);
            this.rdbon.Name = "rdbon";
            this.rdbon.Size = new System.Drawing.Size(45, 17);
            this.rdbon.TabIndex = 0;
            this.rdbon.TabStop = true;
            this.rdbon.Text = "%10";
            this.rdbon.UseVisualStyleBackColor = true;
            // 
            // rdbbes
            // 
            this.rdbbes.AutoSize = true;
            this.rdbbes.Location = new System.Drawing.Point(6, 33);
            this.rdbbes.Name = "rdbbes";
            this.rdbbes.Size = new System.Drawing.Size(39, 17);
            this.rdbbes.TabIndex = 0;
            this.rdbbes.TabStop = true;
            this.rdbbes.Text = "%5";
            this.rdbbes.UseVisualStyleBackColor = true;
            // 
            // btnSiparisGec
            // 
            this.btnSiparisGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSiparisGec.Location = new System.Drawing.Point(177, 242);
            this.btnSiparisGec.Name = "btnSiparisGec";
            this.btnSiparisGec.Size = new System.Drawing.Size(126, 56);
            this.btnSiparisGec.TabIndex = 5;
            this.btnSiparisGec.Text = "Sipariş Geç";
            this.btnSiparisGec.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGenelToplam);
            this.panel1.Controls.Add(this.lstTumSiparisler);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(340, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 314);
            this.panel1.TabIndex = 6;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(4, 285);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(145, 20);
            this.txtGenelToplam.TabIndex = 6;
            // 
            // lstTumSiparisler
            // 
            this.lstTumSiparisler.FormattingEnabled = true;
            this.lstTumSiparisler.Location = new System.Drawing.Point(4, 6);
            this.lstTumSiparisler.Name = "lstTumSiparisler";
            this.lstTumSiparisler.Size = new System.Drawing.Size(145, 225);
            this.lstTumSiparisler.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(4, 233);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genel Toplam:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(523, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 314);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUrunBilgisiGuncelle);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMesajKaydet);
            this.tabPage2.Controls.Add(this.rchTxtMesaj);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rchTxtMesaj
            // 
            this.rchTxtMesaj.Location = new System.Drawing.Point(7, 6);
            this.rchTxtMesaj.Name = "rchTxtMesaj";
            this.rchTxtMesaj.Size = new System.Drawing.Size(247, 186);
            this.rchTxtMesaj.TabIndex = 0;
            this.rchTxtMesaj.Text = "";
            // 
            // btnMesajKaydet
            // 
            this.btnMesajKaydet.Location = new System.Drawing.Point(178, 199);
            this.btnMesajKaydet.Name = "btnMesajKaydet";
            this.btnMesajKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMesajKaydet.TabIndex = 1;
            this.btnMesajKaydet.Text = "KAYDET";
            this.btnMesajKaydet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKategoriSec);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Seçiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUrunSec);
            this.groupBox2.Location = new System.Drawing.Point(6, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Seçiniz";
            // 
            // cmbUrunSec
            // 
            this.cmbUrunSec.FormattingEnabled = true;
            this.cmbUrunSec.Location = new System.Drawing.Point(11, 30);
            this.cmbUrunSec.Name = "cmbUrunSec";
            this.cmbUrunSec.Size = new System.Drawing.Size(228, 21);
            this.cmbUrunSec.TabIndex = 0;
            // 
            // txtFiyatGuncelle
            // 
            this.txtFiyatGuncelle.Location = new System.Drawing.Point(5, 26);
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            this.txtFiyatGuncelle.Size = new System.Drawing.Size(239, 20);
            this.txtFiyatGuncelle.TabIndex = 1;
            // 
            // btnUrunBilgisiGuncelle
            // 
            this.btnUrunBilgisiGuncelle.Location = new System.Drawing.Point(182, 247);
            this.btnUrunBilgisiGuncelle.Name = "btnUrunBilgisiGuncelle";
            this.btnUrunBilgisiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunBilgisiGuncelle.TabIndex = 2;
            this.btnUrunBilgisiGuncelle.Text = "GÜNCELLE";
            this.btnUrunBilgisiGuncelle.UseVisualStyleBackColor = true;
            // 
            // cmbKategoriSec
            // 
            this.cmbKategoriSec.FormattingEnabled = true;
            this.cmbKategoriSec.Location = new System.Drawing.Point(13, 26);
            this.cmbKategoriSec.Name = "cmbKategoriSec";
            this.cmbKategoriSec.Size = new System.Drawing.Size(228, 21);
            this.cmbKategoriSec.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFiyatGuncelle);
            this.groupBox3.Location = new System.Drawing.Point(7, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Fiyat Bilgisi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSiparisGec);
            this.Controls.Add(this.grpIndirim);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblSepetToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUrunAdet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hepsi Orada Windows Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIndirim.ResumeLayout(false);
            this.grpIndirim.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.Label lblSepetToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpIndirim;
        private System.Windows.Forms.RadioButton rdbonbes;
        private System.Windows.Forms.RadioButton rdbon;
        private System.Windows.Forms.RadioButton rdbbes;
        private System.Windows.Forms.Button btnSiparisGec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.ListBox lstTumSiparisler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMesajKaydet;
        private System.Windows.Forms.RichTextBox rchTxtMesaj;
        private System.Windows.Forms.Button btnUrunBilgisiGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.ComboBox cmbUrunSec;
        private System.Windows.Forms.ComboBox cmbKategoriSec;
    }
}

