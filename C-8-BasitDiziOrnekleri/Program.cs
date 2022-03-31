using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_8_BasitDiziOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] ogrenciListesi = new string[2, 3];

            //for (int satir = 0; satir < ogrenciListesi.GetLength(0); satir++)
            //{
            //    //for (int sutun = 0; sutun < ogrenciListesi.GetLength(1); sutun++)
            //    //{
            //    //    switch (sutun)
            //    //    {
            //    //        case 0:
            //    //            Console.WriteLine((satir + 1) + " . ogrenci Adını Giriniz");
            //    //            ogrenciListesi[satir, sutun] = Console.ReadLine();
            //    //            break;
            //    //        case 1:
            //    //            Console.WriteLine((satir + 1) + " . ogrenicin Soyadını giriniz");
            //    //            ogrenciListesi[satir, sutun] = Console.ReadLine();
            //    //            break;
            //    //        case 2:
            //    //            Console.WriteLine((satir + 1) + " . TcKimlik giriniz");
            //    //            ogrenciListesi[satir, sutun] = Console.ReadLine();
            //    //            break;
            //    //        default:
            //    //            break;
            //    //    }
            //    //}
            //}

            #region OgrenciListesi
            /*
           Klavyeden 2 ogrenci için ayrı ayrı ad, soyad ve tckimlik bilgisi isteyiniz. Bu bilgileri bir diziye kaydediniz. Daha sonra tüm bilgiyi Ogrenci Listesi Baslığı altında ekrana yazdırınız.
           */
            //string[,] yenidizi = new string[2, 3];            
            //string[,] ogrenciler = new string[2, 3];
            //for (int i = 0; i < ogrenciler.GetLength(0); i++)
            //{
            //    Console.Write(i + 1 + ". Öğrencinin adını giriniz:");
            //    ogrenciler[i, 0] = Console.ReadLine();
            //    Console.Write(i + 1 + ". Öğrencinin soyadını giriniz:");
            //    ogrenciler[i, 1] = Console.ReadLine();
            //    Console.Write(i + 1 + ". Öğrencinin TCno giriniz:");
            //    ogrenciler[i, 2] = Console.ReadLine();
            //}

            //Console.WriteLine("------Öğrenci Tablosu-------");

            //for (int i = 0; i < ogrenciler.GetLength(0); i++)
            //{
            //    Console.WriteLine(ogrenciler[i, 0] + " " + ogrenciler[i, 1] + " " + ogrenciler[i, 2]);

            //}

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //#endregion


            #region DizidenRandomSecim
            /*
            String bir dizi icerisinden Random olarak bir secim yaptırınız. Secimin karakter sayısı kadar ekrana - isareti yazdırınız.            
            */

            //string eh = "e";
            //Random rnd = new Random();
            //int secilenSayi;
            //string[] dizi = { "ali", "veli", "hasan", "kemal", "fatma" };

            //while (eh == "e")
            //{
            //    secilenSayi = rnd.Next(dizi.Length);
            //    Console.WriteLine(dizi[secilenSayi]);

            //    for (int i = 0; i < dizi[secilenSayi].Length; i++)
            //    {
            //        Console.Write("- ");
            //    }

            //    Console.WriteLine("Yeniden oynamak istermisiniz e/h");
            //    eh = Console.ReadLine();
            //}

            //Console.Read();
            #endregion

            #region Yerdegistirme
            /*
            string bir dizi oluşturarak 2. eleman ile 5. elemanın yerlerini değistiriniz.
            */
            string[] dizi = { "ali", "veli", "hasan", "kemal", "fatma" };

            string metin = dizi[1];  //temp mantığı
            dizi[1] = dizi[4];
            dizi[4] = metin;

            #endregion

            #region SayısalUygulamasi
            /*
            6 ile 49 arasında 6 farklı rakam secimi yaptırarak ekrana yazdırınız. (dikkat edilmesi gereken: secilen bir sayısın bir daha secilmemesine dikkat ediniz)
            */

            #region Cozum1
            //string cevap;
            //Random rnd = new Random();

            //do
            //{
            //    int rndSayi;
            //    int[] dizi = new int[6];
            //    int j = 0;

            //    Console.Clear();
            //    do
            //    {
            //        rndSayi = rnd.Next(6, 50);
            //        if (!dizi.Contains(rndSayi))
            //        {
            //            dizi[j] = rndSayi;
            //            j++;
            //        }
            //        if (j == 6)
            //            break;
            //    } while (true);

            //    foreach (int item in dizi)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("Tekrar oynamak istiyor musunuz?");
            //    cevap = Console.ReadLine().ToString().ToUpper();
            //    if (cevap!="E")
            //    {
            //        break;
            //    }

            //} while (true);
            //Console.Clear();
            //Console.WriteLine("Bitti.");
            #endregion

            #region Cozum2

            int[] sayilar = new int[6];
            Random rnd = new Random();
            int randomSayi;

            for (int i = 0; i < sayilar.Length; i++)//sayilar dizisinin her bir gozunu doldurmak için kullandık.
            {
                do  //birbirinden farklı 6 rakam bulabilmek için doner.
                {
                    randomSayi = rnd.Next(6, 50);

                } while (sayilar.Contains(randomSayi) == true);
                //sayilar.Contains(randomSayi) dizi icerisinde random sayının var olup olmadığını kontrol eder
                sayilar[i] = randomSayi;
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion

            Console.Read();
        }
    }
}