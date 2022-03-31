using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Metodlar_RefveOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ref anahtar kelimesi  C# dilinde,işaretçilerin yerini tutar,ref anahtar kelimesi ile kullanılan değişkene mutlaka ilkleme işlemi yapılmış olmalıdır. Yani değişkene bir değer atanmış olmalıdır.
             */

            //Başlangıç değeri olan bir değişkenin değerini değiştiriyoruz.

            int sayi = 1;
            // DegerDegistir(sayi); //deger değismez.
            DegerDegistir(ref sayi);

            Console.WriteLine(sayi);


            /*
            Out Nedir?
Out anahtar kelimesi  C#  dilinde bir metoddan(fonksiyondan) birden fazla parametre döndürmek için kullanılır.Bu anahtar kelime yardımıyla bir metoddan çok sayıda parametre döndürme işlemi yapılır.Out anahtar kelimesi ile işaretlenmiş değişkenin ilkleme işlemine tabi tutulmuş olması gerekmemektedir.
            */

            int value;
            string str1, str2;
            outMethod(out value, out str1, out str2);   //out ile işaretlememin anlamı metod icerisinden bu değiskenlere değer gondereceğimdir.

            Console.WriteLine(value);
            Console.WriteLine(str1);
            Console.WriteLine(str2);


            //Ad ve Soyadı dısardan alınız:

            string ad, soyad, ad_soyad;

            Console.WriteLine("Ad giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad giriniz");
            soyad = Console.ReadLine();

            //bu ne demek:
            //ad değiskenini metod icerisine gonderiyorum.
            //soyad değiskeninin değerinin metod icerisinde değistireceğim.
            //ad_soyad değiskenine metod icerisinden değer ataması yapacağım.

            cumleBirlestir(ad, ref soyad, out ad_soyad);

            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(ad_soyad);

            Console.ReadLine();
        }

        private static void cumleBirlestir(string ad, ref string soyad, out string ad_soyad)
        {
            ad = "ABDULLAH";
            soyad = "KOCAMAN";
            ad_soyad = ad + " " + soyad;
        }

        //private static void DegerDegistir(int val)
        //{
        //    val = 15;
        //}

        private static void DegerDegistir(ref int val)
        {
            //method void  bir metod olmasına rağmen sayi'nin değeri değiştirilmiş.
            //burada val değeri sayi değerine referans verilmistir.
            //method içerisinde val değerinin değistirilmesi demek aynı zamandı sayi değiskeninin değerinin değistirilmesi demektir.
            //cünkü RAM'deki adresleri aynıdır.
            val = 15;
        }

        private static void outMethod(out int i, out string s1, out string s2)
        {
            i = 44;
            s1 = "Method içerisinden dışarıya değer ataması yapıldı.";
            s2 = null;
        }
    }
}
