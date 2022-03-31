using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birden fazla tekrarlanması gereken islemleri donguler yardımı ile yaparız. Gerceklestirilmesi gereken islemleri hem daha hızlı , hem daha az kod yazarak gelistirmemizi sağlar.

            //While Döngüsü
            //Dongu kosul cümlesi sonucu true olduğu surece calıstırılır ve sonuc false olduğunda dongunun bitmesi sağlanır. Dongunun artım ya da azalım değeri dongu icerisinde belirtilmelidir.

            //while (Şart)
            //{
            //    //Komutlar
            //    //Artım Değeri
            //}

            //0 den 10 a kadar olan sayıları ekrana yazdırınız.
            #region WhileGiris
            byte a = 0;

            while (a <= 10)
            {
                Console.WriteLine(a);
                a += 1;
            }
            #endregion

            Console.Clear();

            //#region ForGiris
            //Console.WriteLine("For baslıyor");

            ////FOR Döngüsü
            ////for (sayac degiskeni; şart ; artış ya da azalış değeri)
            ////{ 
            //        //Komutlar
            ////}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion

            Console.Clear();

            //Klavyeden girilen 3 sayıyı toplayarak ekrana yazınız.

            //#region 3sayiToplami
            //int Toplam = 0;
            //int Sayi;
            //int sayac = 1;

            //while (sayac <= 3)
            //{
            //    Console.WriteLine(sayac + ".sayıyı giriniz..");
            //    Sayi = Convert.ToInt32(Console.ReadLine());

            //    Toplam += Sayi;
            //    sayac += 1; //mutlaka sayac kontrolünü cıkmadan yap.
            //}

            //Console.WriteLine("Toplam Sonucu: " + Toplam);
            //#endregion

            Console.Clear();

            //Klavyeden 0 girilene kadar girilen sayıları toplayıp, 0 girildiğinde ekrana sonucu yazacak uygulamayı yazınız.

            //Aynı seyi tekrar tekrar yazıyorsan bil ki bir hata vardır.??
            int number=1;
            int sum = 0;

            #region AyniSeyiTekrarEtmeyelim
            Console.WriteLine("Bir sayı giriniz..");

            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Bir sayı giriniz..");
                //number = Convert.ToInt32(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine(sum);
            #endregion

            //Bunun yerine bu cözüm daha mantıklıdır.
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz..");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    sum += number;
            //} while (number != 0);

            //Console.WriteLine("Sayılar toplamı: " + sum);

            //Yani do while'ı dongu kosulu kontrol edilmeden önce tekrarlanacak olan kodların calıstırılmasını istiyorsam kullanabilirim.


            //Klavyeden girilen sayıları toplayan bir pogram yazalım. Toplam 200'u gectiğinde donguden cıkıp, Tekrar Denemek İster Misiniz? E/H? sorusunu sorun. 
            //E ye basarsa tekrar sayı girisine baslayabilsin.

            #region BelirliBirAndaDongudenCikma
            //Bunun icin break keyword'u kullanılır.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //    // break;
            //    if (i==3)
            //    {
            //        break;
            //    }
            //}
            #endregion

            //Console.Clear();        
            Console.Read();

        }
    }
}
