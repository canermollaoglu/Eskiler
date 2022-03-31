using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33TipDonusumleri
{
    class Program
    {
        /*
        Tip Dönüşümleri:
        Tip dönüşümü demek veriyi bellekte bir yerden başka bir yere taşımak demektir. Durum böyle ise biz daha büyük yer kaplayan bir veriyi daha küçük yer kaplayan bir veriye çeviremeyiz.
        Örnek: int ... 4 byte ... 32 bit(+- 2milyar) ==> byte 8 bit (0-255) ==> short 16 bit (+- 32768)

            ama int'i >> long(64 bit), float(32 bit), double(64 bit), decimal(128 bit) a cevirebiliriz. 

           
            Explicit Dönüşüm: (Acık Donusum)


            */
        static void Main(string[] args)
        {
            /*
             Dönüşüm Çeşitleri:
            .Net framework tip donusum islemlerinde baslıca 2 tip donusumu destekler.
            1-Implicit Dönüşüm:(Kapalı Donusum) 
            .Net Framework degisken tipleri üzerinde islem yaparken donusum islemlerini otomatik olarak yapar.
            */

            int sayi1 = 120;
            double sayi2 = 5;
            double sonuc = sayi1 + sayi2;   //.net burada dönüsumu kendisi yapar.
            // int sonuc2 = sayi1 + sayi2; double'ı inte ceviremez.
            Console.WriteLine(sonuc);


            byte a = 1;
            string b = 2.5 + " ";

            Console.WriteLine(a + b);   //burada string donusumunu .net kendisi yapar.


            /*
            2-Explicit Donusum(Açık Dönüşüm)
            Donusum isleminin hangi ture yapılacağı cesitli metodlarla kullanıcı tarafından yapılır.
            */

            int number1 = 5;
            double number2 = 2.5;
            double result = (double)number1 + number2;  //donusumu biz tanımladık
            Console.WriteLine(result);

            //int string dosunumu
            int quantity = 100;
            //string productName = (string)quantity;    bu sekilde açık donusum yapamayız
            //string productInfo = quantity.ToString() + " adet ürün bulunmaktadır.";
            string productInfo = quantity + " adet ürün bulunmaktadır.";
            Console.WriteLine(productInfo);

            object nesne = "123";
            string result2 = (string)nesne; //objeyi stringe cevirebiliriz cünkü tüm tipleri icerir.


            //Değiskenin tipini karşılaştırma is ve as 
            //is operatörü
            object obj = 20.5;

            if (obj is int) //geriye true ya da false değerleri döner.
            { Console.WriteLine("Değer int türündedir"); }
            else
            { Console.WriteLine("Değer int türünde değildir"); }

            //as operatörü
            //donusum esnasında geriye hata dönmek yerine null dondurur. Referans tipi degiskenler üzerinde kullanılır. (object, dynamic, string)

            //Winformda göstereceğiz:
            //Button btn=nesne as Button;

            //Parse Metodu
            //string turundeki bir veriyi belirtilen bir veri turune donusturmek için kullanılır. System sınıfına ait olan bir metodtur.
            //Kullanım Sekli: DeğiskenTürü.Parse(Donusturulecek deger)           

            DateTime t = new DateTime(2015, 06, 24);
            Console.WriteLine(t.ToLongDateString());

            string deger = "24/06/1985";
            DateTime newDate = DateTime.Parse(deger); //string datetime'a cevrildi.
            Console.WriteLine(newDate.ToLongDateString());

            //degisken null degere sahipse ArgumentNullException hatası
            //Farklı bir değisken turune sahipse FormatException hatası
            //Değisken değeri max-min value değerlerinin dısındaysa OverflowException hatası alınır.

            string s1 = "123";
            string s2 = null;
            string s3 = "123.45";
            string s4 = "12345678912345679584958";
            Console.WriteLine(Int32.Parse(s1));
            // Console.WriteLine(Int32.Parse(s2)); ArgumentNullException
            // Console.WriteLine(Int32.Parse(s3)); FormatException
            // Console.WriteLine(Int32.Parse(s4)); OverflowException

            //TryParse metodu
            //Parse ile aynı amaçta kullanılır ancak hata fırlatmaz yukarıdaki durumlar meydana gelirse geriye 0 değerini döner. Hata oluşmassa out ile başlayan parametreye değeri dondurur. 

            string stringtarih = "a";
            DateTime tarih;
            if (DateTime.TryParse(stringtarih, out tarih))    //geriye true false döner.
                                                              //değeri tarihe cevir cevirebilirsen tarih değiskenine at
            {
                Console.WriteLine(tarih.ToLongDateString());
            }
            else
            {
                Console.WriteLine("Değer dönüştürülemedi");

            }

            int num;
            string valueNumber = "125";
            Console.WriteLine(Int32.TryParse(valueNumber, out num));    //true doner.


            //Convert Metodu
            string isimDeneme = "Caner Mollaoğlu";
            byte[] dizim = { 1, 2, 3, 4, 5, 6 };
            string donusum = Convert.ToBase64String(dizim);   //base64 algoritmasına göre sifrelenmiştir.

            byte[] gelendizi = Convert.FromBase64String(donusum);



            Console.ReadKey();
        }
    }
}
