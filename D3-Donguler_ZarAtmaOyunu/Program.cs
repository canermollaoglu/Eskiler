using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Donguler_ZarAtmaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı 1 ile 6 arasında bir rakam girisi yapacak. Çift zar kaçıncı tahminde gelecek bunu bulduğumuzda denemeyi sonlandıracağız.
            //Ekran Çıktısı
            //1-6 arasında bir zar giriniz? 4
            //1. Deneme ==> 1-4
            //2. Deneme ==> 3-2
            //3. Deneme ==> 4-2
            //4. Deneme de CİFT GELDİ 4-4
            string gelenCevap = "";

            do
            {
                #region 1ELOYUNKODU
                //1 EL OYNAMAK İÇİN GEREKEN KOD
                Console.Clear();
                try
                {
                    Console.WriteLine("Bir sayı giriniz....");
                    int gelenZar = Convert.ToInt32(Console.ReadLine());

                    if (gelenZar < 1 || gelenZar > 6)
                    {
                        throw new Exception("1 ile 6 arasında değer girmelisiniz..");
                    }

                    int zar1;
                    int zar2;
                    int denemeSayisi = 1;

                    Random rnd = new Random();
                    do
                    {
                        zar1 = rnd.Next(1, 7);
                        zar2 = rnd.Next(1, 7);

                        Console.WriteLine("{0}. deneme ==>{1}-{2}", denemeSayisi, zar1, zar2);
                        denemeSayisi++;

                    } while (gelenZar != zar1 || gelenZar != zar2);

                    Console.WriteLine("{0}. deneme de CİFT GELDİ ==>{1}-{2}", denemeSayisi, zar1, zar2);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    try
                    {
                        Console.WriteLine("Tekrar oynamak ister misiniz E/H");
                        gelenCevap = Console.ReadLine();
                        if (gelenCevap.Length > 1 | gelenCevap.ToUpper() != "E")
                        {
                            if (gelenCevap.ToUpper() != "H")
                            {
                                throw new Exception("Yanlış giriş yaptınız! E ya da H girmelisiniz");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                #endregion

            } while (gelenCevap.ToUpper() == "E");

            Console.WriteLine("Yine Bekleriz...");
            Console.Beep();
            Environment.Exit(0);

            Console.Read();
        }
    }
}
