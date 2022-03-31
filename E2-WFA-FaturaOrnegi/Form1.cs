using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_WFA_FaturaOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int ilkIndex = int.Parse(txtIlkIndex.Text);
                int sonIndex = int.Parse(txtSonIndex.Text);
                string adSoyad = txtAdSoyad.Text;
                if (ilkIndex > sonIndex)
                    throw new Exception("Son indeks değeri ilk indeks değerinden küçük olamaz!");

                lstAdSoyad.Items.Add(adSoyad);
                lstKullanilanSuMiktarı.Items.Add(string.Format("{0} m³", sonIndex - ilkIndex));
                lstFaturaTutari.Items.Add(string.Format("{0:C2}", Hesapla(ilkIndex, sonIndex, (rbMesken.Checked ? true : false))));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Temizle(this.Controls);
            }
        }

        private void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is Panel)
                    Temizle(item.Controls);
            }
            txtAdSoyad.Focus();
        }

        private decimal Hesapla(int ilkIndex, int sonIndex, bool meskenMi)
        {
            if (meskenMi)
            {
                return (sonIndex - ilkIndex) * 0.7m + (sonIndex - ilkIndex) * 0.2m;
            }
            else
            {
                return (sonIndex - ilkIndex) * 0.3m;
            }
        }
    }
}
