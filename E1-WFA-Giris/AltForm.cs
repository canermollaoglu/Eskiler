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
    public partial class AltForm : Form
    {
        public AltForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anaform frm = new Anaform();
            frm.Show();

            //this.Visible = false;
            //Anaform frm = new Anaform();
            //frm.Visible = true;
        }

        private void AltForm_Load(object sender, EventArgs e)
        {

        }
    }
}
