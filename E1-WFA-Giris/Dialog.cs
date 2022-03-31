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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        public string deger = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "dinamik buton";
            btn.Name = "btndinamikButon";
            this.Controls.Add(btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Formun DialogResult özelliğine bir değer yüklüyorum.
            /*
            Formların üzerlerinde hangi butona basıldıklarını tutan dialogresult denen bir nesne vardır. bu nesneye ok butonuna basıldığına dair bir veri atıyorum. 
            */
            this.DialogResult = DialogResult.OK;
            deger = "Tamam butonuna basıldı";         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bu butonun cancel butonu olduğunu belirlemiş olduk. Daha sonra bunu forma atayarak bu butona basıldığını anlatmış olduk.
            this.DialogResult = DialogResult.Cancel;
            deger = "İptal butonuna basıldı";
        }
    }
}