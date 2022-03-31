using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_WFA_Giris
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {         
            /*
            1-
            Kod ekranı tanıtımı yapılacak
            Proje adı   -   Nesne ismi  -   Nesneye ait olay(event) ismi

            2-
            Kontrollerin Yerleşimi ve Düzeni
            Format-> Align menusunden bahsedilecek

            3-
            FormLoad event'inden bahset

            4-
            İlk form olarak hangi form acılacak.
            
            Application.Run(new Anaform());
            
            ControlBox  : kapatma düğmesi
            Minimizebox=false ile simge durum kucultme duğmesini pasif yapar

            form acılırken calısan olaylar
            Form Olayları
            BindingContextChanged Olayı
            Load
            Visible
            Activated
            Shown
            Paint 

            form kapanırken calısan olaylar
            Form Closing
            Form Closed
            Deactivate
            */



            this.Text = "İlk Form Uygulaması";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Formlar arası gecisler Show, Hide, Visible, ShowDialog metodları kullanılabilir.
            */
            this.Hide();
            AltForm frm2 = new AltForm();
            frm2.Show();

            //show ve showdialog farkı anlatılacak.
            //showdialog'ta diğer formlara gecis yapılamaz.
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Dialog diyalog_formu = new Dialog();
            diyalog_formu.label1.Text = "Silmek istediğinizden emin misiniz?";
            diyalog_formu.Controls.Find("btndinamikButon",true);

            diyalog_formu.ShowDialog();
           // diyalog_formu.SendToBack();


            if (diyalog_formu.DialogResult == DialogResult.OK)
            {
                // MessageBox.Show("Dosyalar Silindi");
                label2.Text = diyalog_formu.deger;
            }

            if (diyalog_formu.DialogResult == DialogResult.Cancel)
            {
                // MessageBox.Show("Dosyalar Silindi");
                label2.Text = diyalog_formu.deger;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel Butonuna basıldı");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //tabstop propertysini kapattıktan sonra dene
            MessageBox.Show("ENTER Butonuna basıldı");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
