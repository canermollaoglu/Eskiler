using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H1_Koleksiyonlar
{
    public partial class ArrayList : Form
    {
        public ArrayList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            KOLEKSİYONLAR
            System.Collections namespace'i altında yer alırlar. Koleksiyonlar icerisinde aynı türden veriler bir arada saklanabileceği gibi farklı turden veriler de bir arada saklanabilir. 
            Eleman sayısı belirlemeden, herhangi bir eleman sınırı koymadan kullanabiliriz. Bellekte kapladığı alan icinde yer alan eleman sayısına göre belirlenir.
            Koleksiyonlar Generic, Non Generic ve Speciliazed koleksiyonlar olmak üzere 3 gruba ayrılırlar.

            Non Generic (Generic Olmayan) Koleksiyonlar (ArrayList - Hashtable - SortedList)
            Farklı türdeki verileri saklayabilir, icerisine aktarılan değerler boxing islemi ile object turune donusturulerek tanımlandığı koleksiyon turleridir.
            */         
        }

        System.Collections.ArrayList isimler = new System.Collections.ArrayList();
        private void btnArrayList_Click(object sender, EventArgs e)
        {
            //ARRAY LIST
            //Eleman sayısı belirlenmez.
            //İcine atılan değerler boxing islemi ile objeye donusturulur.
            //System.Collections namespace'i altında bulunur.

            //Add Metodu
            isimler.Add("Ali");
            isimler.Add("Hasan");
            isimler.Add("Mehmet");

            isimler[0] = "Caner";

            ListeyeYaz(isimler);
        }

        private void ListeyeYaz(System.Collections.ArrayList isimler)
        {
            foreach (object item in isimler)
            {
                lstListe.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Belirli bir indexe ekleme yapar
            isimler.Insert(0, "Abdullah");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnFixed_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList yeniisimler = System.Collections.ArrayList.FixedSize(isimler);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            isimler.Sort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList rakamlar = new System.Collections.ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(9);
            rakamlar.Add(7);
            rakamlar.Sort();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compare compoption = new Compare();

            System.Collections.ArrayList rakamlar = new System.Collections.ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(9);
            rakamlar.Add(7);

            rakamlar.Sort(compoption);

            ListeyeYaz(rakamlar);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList rakamlar = new System.Collections.ArrayList();
            rakamlar.Add(8);
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(9);
            rakamlar.Add(7);
            rakamlar.Sort();
            for (int i = 0; i <= rakamlar.Count - 1; i++)
            {
                ListeyeYaz(rakamlar);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList nickname = new System.Collections.ArrayList();
            nickname.Add("Caner");
            nickname.Add(123);
            nickname.Add("a");
            nickname.Remove(123);

            ListeyeYaz(nickname);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList bilgi = new System.Collections.ArrayList();
            bilgi.Add("Caner");
            bilgi.Add(123);
            bilgi.Add("a");
            bilgi.RemoveAt(bilgi.Count - 1);

            ListeyeYaz(bilgi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isimler.Clear();
            ListeyeYaz(isimler);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList isimler = new System.Collections.ArrayList();
            isimler.Add("Hasan");
            isimler.Add("Murat");
            isimler.Add("Ahmet");
            isimler.Add("Cemal");
            isimler.Reverse();

            ListeyeYaz(isimler);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            /*
            Capacity bir dizi icin tahsis edilmis eleman kapasitesini verir. Count degeri Capacity değerine ulastığında capasite otomatik olarak 2 kat arttırılmış olur. Kapasite arttırımı 4 un katları seklinde gercekleşir.
            
            */
            System.Collections.ArrayList rakamlar = new System.Collections.ArrayList();
            rakamlar.Add(1);
            lstListe.Items.Add("Eleman Sayısı= " + rakamlar.Count);
            lstListe.Items.Add("Kapasite= " + rakamlar.Capacity);      
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            lstListe.Items.Add("Eleman Sayısı= " + rakamlar.Count);
            lstListe.Items.Add("Kapasite= " + rakamlar.Capacity);
            rakamlar.Remove(5);
            rakamlar.Remove(4);
            lstListe.Items.Add("Yeni Eleman Sayısı= " + rakamlar.Count);
            lstListe.Items.Add("Yeni Kapasite= " + rakamlar.Capacity);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("C#");
            diller.Add("Vb.Net");
            diller.Add("Asp.Net");

            string[] yenidizi = (string[])diller.ToArray(typeof(string));

            foreach (string eleman in yenidizi)
            {
                lstListe.Items.Add(eleman);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");

            // ArrayList digerdiller = diller;
            System.Collections.ArrayList digerdiller = new System.Collections.ArrayList();
            digerdiller = (System.Collections.ArrayList)diller.Clone();

            diller.Remove("ASP.Net");

            ListeyeYaz(diller);
            ListeyeYaz(digerdiller);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //GetRange 
            //Bir dizinin belirtilen kısmını geriye donduren bir metoddur.

            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("Visual C++");
            diller.Add("ASP.Net");

            System.Collections.ArrayList digerdiller = diller.GetRange(0, 2);
            ListeyeYaz(digerdiller);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //AddRange
            //Bir diziye belirtilen baska bir diziyi eklemek için kullanılan bir metoddur.
            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");

            System.Collections.ArrayList digerdiller = new System.Collections.ArrayList();
            digerdiller.Add("Python");
            digerdiller.Add("F#");
            digerdiller.Add("C++");

            diller.AddRange(digerdiller);

            ListeyeYaz(diller);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Insert Range
            //Belirtilen bir diziyi, belirtilen index numarasından itibaren baska bir diziye ekleme amacı ile kullanılan metoddur.

            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");

            System.Collections.ArrayList digerdiller = new System.Collections.ArrayList();
            digerdiller.Add("Python");
            digerdiller.Add("F#");
            digerdiller.Add("C++");

            diller.InsertRange(2, digerdiller);

            ListeyeYaz(diller);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //RemoveRange
            //Belirtilen index numarasından itibaren belirtilen sayıdaki elemanı diziden silme amacı ile kullanılan metoddur.

            System.Collections.ArrayList diller = new System.Collections.ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("ASP.Net");
            diller.RemoveRange(0, 2);

            ListeyeYaz(diller);


        }
    }
}
