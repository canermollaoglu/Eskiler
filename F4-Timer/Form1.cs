using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Timer:
            Zamanlama islemleri icin kullanılır.

            Interval : Zaman aralığını belirtir. Milisaniye cinsindendir. 1000 değerini aldığında 1 saniyeyi ifade eder. Maximum deger Int32.MaxValue degeridir.
            Enabled: True alırsa aktif olur. False ise pasif olur.

            Metodları:
            Start: baslatır. Stop: durdurur.

            enabled false ile pasif yapıldıktan sonra enabled true ile aktif yapıldıktan sonra sayma isleminde en başa döner. Ancak stop ile durdurulup start ile baslatılırsa sayma islemine kaldığı yerden devam edilir.

            Olayları:
            Tick    : Interval özelliğinde belirlenen zaman aralığına göre zamanlanan olaylar Tick olayı icerisinde gercekleşir.
            */
        }
    }
}
