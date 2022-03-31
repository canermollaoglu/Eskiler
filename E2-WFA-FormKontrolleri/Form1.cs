using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_WFA_FormKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item is CheckBox)
                {
                    if (item.Checked)
                    {
                        str += item.Text;
                    }
                }

            }

            MessageBox.Show(str);
        }
    }
}
