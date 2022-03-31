using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region MathFonksiyonlar
            /*
          MATH FONKSIYONLARI
          􀂃Abs􀂃Ceiling& Floor􀂃Cos, Sin, Tan􀂃Exp􀂃Log􀂃Max& Min􀂃Pow􀂃Sqrt

          System.Math namespace'i altında bulunurlar.
          */

            Math.Abs(-123); //mutlak deger.
            Math.Abs(-123.34);

            Math.Ceiling(-12.231231);
            // Sonuç: -12
            Math.Ceiling(12.231231);
            // Sonuç: 13
            Math.Floor(-12.231231);
            // Sonuç: -13
            Math.Floor(12.231231);
            // Sonuç: 12

            /*
            • Cos, Sin, Tan
Bu fonksiyonlar temel trigonometrik işlemleri gerçekleştirir. Cos fonksiyonu verilen derecenin kosinüsünü, Sin sayının sinüsünü ve Tan sayının tanjantını hesaplar. Parametre olarak verilen derece radyan (360 derece) değeri olarak kabul edilir.
            */

            double Derece = 90;
            Math.Cos(Math.PI * Derece / 180);
            Math.Sin(Math.PI * Derece / 180);
            Math.Tan(Math.PI * Derece / 180);

            /*
            Bu fonksiyon, e sabitinin değerini (yaklaşık 2,718281 değerini), parametrede verilen sayı ile üssünü alır.
            */
            Math.Exp(4);
            // Sonuç yaklaşık: 54,59815

            /*
            • Log
Logaritmik hesaplamalar için kullanılan bir fonksiyondur. Taban parametresi verilmezse sayının e tabanında logaritmasını alır.
*/
            Math.Log(1000, 10);
            // Sonuç: 3
            Math.Log(Math.E);
            // Sonuç: 1

            Math.Max(100, 200);
            // Sonuç: 200
            Math.Min(100, 200);
            // Sonuç: 100

            Math.Pow(10, 3);
            // Sonuç: 1000

            Math.Sqrt(441); //Karekök
                            // Sonuç: 21

            #endregion

            #region TarihveZamanFonksiyonlari
            /*
TARİH VE ZAMAN FONKSİYONLARI
Tarih ve zaman fonksiyonları Date veri tipi üzerinde hesaplamalar yapan fonksiyonlardır. Bu fonksiyonlar System.DateTime uzay alanında tanımlıdır.

           CompareTo fonksiyonu, işlem yapılan tarih ile parametre olarak verilen tarihi karşılaştırır. 
           Parametredeki tarih küçükse -1, büyükse 1 veya eşitse 0 döndürür.
           */

            DateTime d = new DateTime(2015, 12, 24);
            MessageBox.Show(d.CompareTo(DateTime.Now).ToString());

            /*• DaysInMonth
İlk parametrede verilen yılın, ikinci parametrede verilen ayında kaç gün olduğunu döndürür.*/
            DateTime.DaysInMonth(2002, 2);
            // Sonuç: 28


            /*            
            • IsLeapYear
Verilen bir yılın artık yıl olup olmadığını hesaplar. Dönüş değeri True ya da False tipindedir.
*/
            DateTime.IsLeapYear(1200);
            // Sonuç: True

            DateTime dt = new DateTime(2005, 01, 29);
            dt.ToLongDateString();
            // Sonuç: 29 Ocak 2005 Cumartesi
            dt.ToLongTimeString();
            // Sonuç: 12:59:22

            #endregion

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            /*
          • CompareTo
Bu fonksiyon, işlemin yapılacağı değeri parametre olarak verilen değerle karşılaştırır. İki değer bir birine eşitse 0, parametredeki değer alfabetik olarak önde ise 1, değilse -1 değeri döndürülür.
          */

            string yazi1 = "Wissen";
            string yazi2 = txtCompare.Text;
            switch (yazi1.CompareTo(yazi2))
            {
                case 0:
                    MessageBox.Show("Yazılar birbirine eşit");
                    break;
                case 1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden sonra geliyor");
                    break;
                case -1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden önce geliyor");
                    break;
            }

        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            /*
            • Concat
String değerlerini birleştirmek için kullanılır. Parametre tipi params olduğu için, sınırsız String değişkeni birleştirilebilir.
            */

            string kurum = "Wissen";
            txtConcat.Text = String.Concat("Kurum: ", kurum, "Şubeler: ", "\n", "Beşiktaş ", "Çağlayan ", "Başakşehir");
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            /*
            • CopyTo
BU fonksiyon ile bir String değişkenin belli bir kısmı, bir karakter dizisine kopyalanır. Ayrıca kopyalanacak dizinin hangi indisten itibaren başlanacağı da belirtilir.
            */

            string yazi = "Bahçeşehir";
            char[] Karakterler = new char[11];
            // Yazının 5. karakterinden itibaren alınan 4 karakter,
            // karakterler dizisinin 3. indisinden başlanarak
            // diziye kopyalanır.
            yazi.CopyTo(5, Karakterler, 3, 4);
            foreach (char item in Karakterler)
            {
                txtCopyTo.Text += item;
            }
            // Karakterler dizisinin son hali:
            //
        }

        private void btnEndStart_Click(object sender, EventArgs e)
        {
            /*
            • EndsWith & StartsWith
Bu fonksiyonlar, String değişkeninin, parametrede verilen String değeriyle başladığını ya da bittiğini gösterir. Geriye dönüş değeri Boolean tipindedir.
            */          
            string HtmlTag = txtEndStart.Text;
            if (HtmlTag.StartsWith("<") & HtmlTag.EndsWith(">"))
            {
                MessageBox.Show("Yazım doğru");
            }
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            /*
            • SubString
Verilen bir String değerinin, bir bölümünü String olarak döndüren fonksiyondur. İstenen karakterlerin hangi indisten başlayacağı parametre olarak geçilir. Bu durumda, başlangıç karakterinden sona kadar okunur. Ancak fonksiyonun, kaç karakter okunacağını belirten bir parametre kabul eden aşırı yüklemesi de vardır
            */
            string yazi = txtSub.Text;  //Wissen Akademi
            MessageBox.Show(yazi.Substring(6));
            // Sonuç : Akademi
            MessageBox.Show(yazi.Substring(6, 2));
            // Sonuç : Ak

        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            /*
            • Trim, TrimEnd, TrimStart
Trim fonksiyonu, parametre olarak verilen bir karakteri, String değişkeninin başından ve sonundan kaldırır.
TrimEnd fonksiyonu parametrede verilen karakteri String değişkeninin sadece sonundan, TrimStart ise sadece başından kaldırır.
            */

            string yazi = txtTrim.Text; //----*/**/-*/Merhaba/*/*-*-*/----
            MessageBox.Show(yazi.Trim('-', '*','/'));
            // Sonuç: Merhaba
            MessageBox.Show(yazi.TrimEnd('-'));
            // Sonuç: ----*/**/-*/Merhaba/*/*-*-*/
            MessageBox.Show(yazi.TrimStart('-'));
            // Sonuç: */**/-*/Merhaba/*/*-*-*/----
        }
    }
}
