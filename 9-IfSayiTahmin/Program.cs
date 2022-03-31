using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_IfSayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {

            //0 ile 10 arasında rastgele bir sayı üretin. Üretilen bu sayının tek mi cift mi olduğunu yazdırın.

            //kullanıcıdan byte olarak bir not girisi isteyiniz. Girilen not 100 buyuk ise "Yanlış not girisi yaptınız yapınız" değil ise 45>=gectiniz <45 ise kaldınız yazınız eğer notu 90 ile 100 arasında ise hem gectiniz hem de Başarılı yazdırınız.

            //klavyeden girilen 3 sayı karsılastırıp iclerinden en buyuk olanı bulunuz.

            int sayi1, sayi2, sayi3;
            Console.WriteLine("1. Notu Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Notu Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Notu Giriniz: ");
            sayi3 = Convert.ToInt32((Console.ReadLine()));

            if ((sayi1 > sayi2) & (sayi1 > sayi3))  //iki kosulda true ise true alanı calısır
                Console.WriteLine("Sayılardan en büyüğü Sayı1= " + sayi1);
            else if ((sayi2 > sayi1) & (sayi2 > sayi3))
                Console.WriteLine("Sayılardan en büyüğü Sayı2= " + sayi2);
            else if ((sayi1 < 0) | (sayi2 < 0) | (sayi3 < 0))   //kosulllardan bir tanesi bile true olursa true alanı calısır.
                Console.WriteLine("Sayılar 0'dan küçük olmamalı!");
            else
                Console.WriteLine("Sayılardan en büyüğü Sayı3= " + sayi3);
            Console.ReadKey();

            // 

        }
    }
}
