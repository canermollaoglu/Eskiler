using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabitler_ve_Degiskenler
{
    class Program
    {
        /*
        Sabitler:
        Sabitler içeriği sabit olan deger ve ifadelerin saklanması amacı ile kullanılırlar. 
        Const ve readonly ifadeleri kullanılarak tanımlamak mümkündür. Değerleri derleme anında değiştirilemez.

            const int sayi=10;

        Değiskenler:
        CTS Nedir? Common Type System 
        Olusturulan kod CLR icerisinde makine diline cevrilirken degiskenler CTS kurallarına göre cevrilir.
        Program içinde üretilen değerleri bellekte gecici olarak saklamak amacı ile kullanılır.
        [Degisken tipi] [Degisken Adı] = [ilk deger]
        ilk deger kullanımı zorunlu değildir.

            string ad;  //değiskene değer aktarımı yapılmazsa değiskenler varsayılan değerleri ile kullanılır. (null)
            string ad="Caner";
        */
        static void Main(string[] args)
        {
            const string sabitdeger = "Caner Mollaoğlu";
            string yazi = "Sabitler ve Değişkenler";

            Console.WriteLine(sabitdeger);
            Console.WriteLine(yazi);

            yazi = Console.ReadLine();
            Console.WriteLine(yazi);

            //  sabitdeger = "Yeni Sabit Değer";    //değeri değistirilemez.

            //Degisken tanımlama:
            //tanımlama harf ile baslamalıdır. diğer karakterler harf rakam ya da özel karakter olabilir.
            //degisken ismi en fazla 255 karakter olabilir.
            //bosluk bırakılmaz _kullanılır.
            //özel tanıtıcılar kullanılamaz. and or not
            
            //isimlendirme bicimleri:
            //PascalCase        camelCase       UpperCase
            
            //Değiskenler ve varsayılan değerleri:
            /*
            bool : false,
            byte, sbyte, int, short, uint, ulong, ushort :0
            char : '\0'
            decimal : 0.0M
            float: 0.0F
            double: 0.0D
            long: 0L
            string : Null
            */

            int a = 14, b, c;
            b = 100; c = 250;

            int toplam = b + c + a;

            char birHarf = 'A'; //karakter
            string ikinciHarf = "A";    //string

            //var ile değisken tanımlama:
            //var [degisken adı] = [ilk değer]

            //var ile değisken tanımlandığında ilk değer ataması o anda yapılmak zorundadır.
            //var isim;
            //isim = "ali"; böyle bir tanımlama yapamayız

            var adSoyad = "Ahmet";
            var yeniSayi = 105;
            var dogruMu = true;
            var ondalikSayi = 12.5;

            //GetType() metodu
            Console.WriteLine(adSoyad.GetType().ToString());
            Console.WriteLine(yeniSayi.GetType().ToString());
            Console.WriteLine(dogruMu.GetType().ToString());
            Console.WriteLine(ondalikSayi.GetType().ToString());

            //TypeOf() metodu
            //Herhangi bir değiskenin tipinin bir değisken turune ait olup olmadığını anlamak için kullanılabilir.

            Console.Clear();

            var ondalik_Sayi = 14.5;
            if (ondalik_Sayi.GetType()==typeof(byte))
            {
                Console.Write("Değisken türü: Byte");
            }
            else
            {
                Console.Write("Değisken türü Byte değil");
            }

            /*
            float           : 32 bit     yaklasik degerler verir
            double        : 64 bit    
            decimal       : 128 bit   kesin deger istersek bu tipi kullanmalıyız.
            */

            Console.ReadKey();
        }
    }
}
