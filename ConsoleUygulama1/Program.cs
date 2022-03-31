using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsol ekranında kullanılan fonksiyonlar System.Console sınıfına ait olan 
            //fonksiyonlardır.

            //Konsol ekranında değer yazma ve okuma
            //Write         : kendisine gönderilen değeri aynı satırda yazar.
            //Writeline    : gönderilen değeri bir alt satırdan itibaren yazdırmak için kullanılır.

            Console.WriteLine("İlk uygulama");
            Console.Write("İlk ders");
            Console.WriteLine("Caner" + "\t" + "Mollaoğlu");
            //1-burada escape karakterlerinin listesi gösterilecek.
            /*
            /a = bip sesi verir
            \n = alt satıra geçer
            \t = yatayda bir tab miktarı boşluk
            \v = düşeyde bir tan miktarı boşluk
            \r = satır başına geçer
            \' = tek tırnak bırakmaya yarar
            \" = çift tırnak bırakmaya yarar
            \f = sonraki sayfaya geçer
            \? = soru işareti bırak 
            \\ = \  bırakmak için kullanılır
            */
            Console.WriteLine("\a");

            //2-char metodu belirtilen ASCII karakter kodunu karaktere dönüştürür.
            Console.WriteLine("İlk satır" + (char)65 + "Caner");

            //yer turucu placeholder anlatılacak string.Format ile aynı
            Console.WriteLine("{2},{0},{1}", 10, 20, 30);
            Console.WriteLine(string.Format("{2},{1},{0}",20,30,40));

            Console.ReadKey();
        }
    }
}
