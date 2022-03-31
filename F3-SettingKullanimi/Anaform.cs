using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3_SettingKullanimi
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string eskisifre = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(txtEskiSifre.Text) && !string.IsNullOrEmpty(txtYeniSifre1.Text) && !string.IsNullOrEmpty(txtYeniSifre2.Text))
            {
                if (eskisifre==txtEskiSifre.Text)
                {
                    if (txtYeniSifre1.Text==txtYeniSifre2.Text)
                    {
                        //Settingteki scope özelliği Application olursa kullanıcı tarafından değistirilemez o zaman uygulamanın ortak ayarı olur. 
                        Properties.Settings.Default.Password = txtYeniSifre1.Text;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Sifreniz basarı ile degistirildi");
                    }
                    else
                    {
                        MessageBox.Show("Yeni Sifreler Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Eski sifrenizi yanlış girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
        }
    }
}
