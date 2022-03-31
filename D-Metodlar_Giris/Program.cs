using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Metodlar_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodlar
            //Bazen program yazarken bazı kodları tekrar tekrar yazmak gerekebilir. Bu tip durumlarda bu kod parcalarını yeniden yazmak yerine bu kod parcalarından metodlar oluşturarak bunları kullanabiliriz. C# icerisinde geriye değer donduren ve değer dondurmeyen olmak üzere 2 cesit metot yapısı kullanılır.

            //1-
            //Değer Döndürmeyen Metodlar: (parametresiz ve parametreli)

            /*
            <erisim bicimi> void <metod ismi>(parametre)
            {
                Metod icerisinde calısacak olan kodlar
            }
            */

            //Parametresiz
            RenkDegistir();

            //Parametreli
            //Klavyeden giris yaptıran bir metod yazalım.            
            GirisAl("Lütfen bir sayı giriniz...");

            bool[] boolDegerler = { true, true, false, false, false };
            string[] stringDizim = { "Asp.Net", "Html5", "C#" };

            //Overload:
            //Aynı isimde birden fazla metod oluşturmaktır. Metodlar aynı isimle çağırılırlar ancak bazı farklılıkları vardır. Parametre sayısı, parametre tipi, geri dönüş degeri gibi. 

            DiziSifirlama(true, boolDegerler);
            DiziSifirlama("", stringDizim);

            //2-
            //Değer Döndüren Metodlar:
            //2 integer sayısı alıp toplayan bir metod yapınız.

            int donenToplam = Toplam(4, 5);

            //Params parametresi gösterimi
            int sumResult = Toplam(4, 5,5,76,54,33);

            //Klavyeden 2 değer istesin bunları toplasın ve toplamı geri donsun.
            int toplamSonucu = KontrolluToplamYap();

            Console.WriteLine(toplamSonucu);       

            //Klavyeden girilen yazılı ve sözlü notlarına göre not hesabı yapan bir metod yazınız:
            //params anlatılıyor.
            byte gelenPuan = PuanHesapla(45, new byte[] { 80, 90, 100 });

            //Birden fazla dizi göndermek istiyorum. Birisi 1. dönem İkincisi 2. dönem sözlü notları olsun
            byte gelenPuan1 = PuanHesapla(45, new byte[] { 10, 20, 30 }, new byte[] { 10, 30, 20 }, new byte[] { 10, 30, 20 }, new byte[] { 10, 30, 20 });
            if (gelenPuan1 >= 50)
                Console.WriteLine("Geçti");
            else
                Console.WriteLine("Kaldı");

            int sum=Toplam(23, 45, 21, 23);
            int sum2 = Toplam(1, 2, 3, 4, 5, 6, 7, 8, 9, 12);

            int[][] yenidizim = {
                new int[] { 1,2,3},
                new int[] { 1,2,3},
                new int[] { 1,2,3}
            };

            Console.Read();
        }

        #region Metodlar
        //params ile istediğin kadar byte dizi girebilirsin
        static byte PuanHesapla(byte yazili, params byte[] sozlu)
        {
            int sozluToplam = 0;
            int not = 0;
            byte puan = 0;
            byte i = 0;

            for (i = 0; i < sozlu.Length; i++)
                sozluToplam += sozlu[0];

            if (i > 0) //yani sozlu notu olarak girilen birseyler var ise
                not = (yazili + sozluToplam) / (i + 1);

            if (not < 25)
                puan = 0;
            else if (not < 45)
                puan = 1;
            else if (not < 65)
                puan = 2;
            else if (not < 90)
                puan = 4;
            else if (not <= 100)
                puan = 5;
            else
                Console.WriteLine("Yanlış not girisi yaptınız");
            return puan;
        }

        static byte PuanHesapla(byte yazili, params byte[][] sozlu)
        {
            int sozluToplamBirinciDonem = 0;
            int sozluToplamIkinciDonem = 0;
            int not1 = 0;
            int not2 = 0;
            byte puan = 0;
            byte i = 0;

           // 1.donem sozlu notları toplamı
            for (i = 0; i < sozlu[0].Count(); i++)
                sozluToplamBirinciDonem += sozlu[0].ElementAt(i);

            if (i > 0)
                not1 = (yazili + sozluToplamBirinciDonem) / (i + 1);

          //  2.donem sozlu notları toplamı
            for (i = 0; i < sozlu[1].Count(); i++)
                sozluToplamIkinciDonem += sozlu[1].ElementAt(i);

            if (i > 0)
                not2 = (yazili + sozluToplamIkinciDonem) / (i + 1);

         //   1.donem ve 2.donem ortalaması 50 nin uzerinde ise gececek:

            if ((not1 + not2) / 2 >= 50)
                puan = 5;
            else
                puan = 0;

            return puan;
        }

        static int KontrolluToplamYap() //Recursive Metod Kendini cağıran metod
        {
            int sonuc = 0;
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi1;
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi2;
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sonuc = sayi1 + sayi2;
                return sonuc;
            }
            catch
            {
                Console.WriteLine("Tanımsız bir hata oluştu");
                return sonuc;
            }
            finally
            {
                Console.WriteLine("Yeniden sayı girisi yapmak ister misiniz?E/H");
                string cevap = Console.ReadLine().ToLower();
                if (cevap == "e")
                    KontrolluToplamYap();
            }
        }

        static int SayilariTopla(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Arkaplan ve yazı rengi degistirir.
        /// </summary>

        static void RenkDegistir()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }

        /// <summary>
        /// Ekrana girilen değeri yazdırır.
        /// </summary>
        /// <param name="girismetni">string metin giriniz.</param>
        static void GirisAl(string girismetni)
        {
            Console.WriteLine(girismetni);
        }


        /// <summary>
        /// Boolean dizileri istenilen değer ile doldurmak için kullanılır.
        /// </summary>
        /// <param name="deger">Boolean bir değer giriniz. true/false</param>
        /// <param name="dizi">Boolean bir diziyi ifade eder.</param>
        static void DiziSifirlama(bool deger, bool[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = deger;
            }
        }

        /// <summary>
        /// Integer dizileri istenilen deger ile doldurmak için kullanılır.
        /// </summary>
        /// <param name="deger">int bir deger giriniz.</param>
        /// <param name="dizi">Integer bir diziyi ifade eder.</param>
        static void DiziSifirlama(int deger, int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = deger;
            }
        }
        /// <summary>
        /// string dizileri istenilen deger ile doldurmak için kullanılır.
        /// </summary>
        /// <param name="deger">string bir deger giriniz.</param>
        /// <param name="dizi">string bir diziyi ifade eder.</param>
        static void DiziSifirlama(string deger, string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = deger;
            }
        }

        public static int Toplam(int deger1, int deger2, int deger3, int deger4)
        {
            return deger1 + deger2 + deger3 + deger4;
        }

        public static int Toplam(params int[] degerler)
        {
            int toplam = 0;
            for (int i = 0; i < degerler.Length; i++)
            {
                toplam += degerler[i];
            }

            return toplam;

            //Yukarıda Toplam metodunu her yeni bir toplam için yeni bir metot yazıp overload yapacağımıza metot karmaşasından kurtulurak tek metotda sınırsız yapı sağlarız
            //params yazıp tipide dizi tipinde belirterek sağlıyoruz
            //önemli bir nokta ise params parametre en sona yazılır ondan sonra yeni bir parametre olmaz zaten mantığınada ters
        }
        #endregion

    }
}
