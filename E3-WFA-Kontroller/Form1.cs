using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_WFA_Kontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1 Form Load olduğunda label oluşturup forma ekleyelim.
            Label label1 = new Label();
            this.Controls.Add(label1);
            label1.Text = "Kod ile Label Kontrolü Forma Ekleniyor";
            label1.Font = new Font("Verdana", 12, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.AutoSize = true;

            txtMetinAlani.Font = new Font("Verdana", 12);
            //2 Textbox en fazla 250 karakter bilgi goruntulenebilir.
            //Multiline ozelliği anlatılacak
            //scrollbars seceneği vardır 
            //readonly ozelliği
            //font ve forecolor

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            //3 Textbox icerisini listboxa ekle
            for (int i = 0; i < txtmesaj.Lines.Length; i++)
            {
                lstSatirlar.Items.Add(txtmesaj.Lines[i]);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //4 temizle
            txtmesaj.Clear();
        }

        private void btnMetinAktar_Click(object sender, EventArgs e)
        {
            //5 metin ters cevir
            char[] str = txtMetin1.Text.ToCharArray();
            Array.Reverse(str);
            string strReversed = new string(str);
            txtMetin2.Text = strReversed;       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKes_Click(object sender, EventArgs e)
        {
          
        }
    }
}
