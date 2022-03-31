using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Metodlar_AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            string cvp;
            do
            {
                Console.Clear();
                double gelenCevap = GirisAl("1) Karenin Alanı\n2) Dikdörtgenin Alanı\n3) Dairenin Alanı\n4) Yamuk Alanı");

                /*secici (gelenCevap) byte, short, ushort, int, long, ulong, char, string ya da enum tiplerinden biri olmalıdır.*/
                switch (gelenCevap.ToString())
                {
                    case "1":
                        //Kare Alanı
                        Console.WriteLine("Kare'nin alanı={0}", AlanHesapla(GirisAl("Kenar Uzunluğu Giriniz")));
                        break;
                    case "2":
                        //Dikdortgen Alanı
                        Console.WriteLine("Dikdörtgen alanı={0}", AlanHesapla(GirisAl("Kısa kenar giriniz"), GirisAl("Uzun kenar giriniz")));
                        break;
                    case "3":
                        //Daire Alanı
                        Console.WriteLine(string.Format("Dairenin Alanı = {0:0.00}", AlanHesapla(Convert.ToInt32(GirisAl("Yarıçap Değerini giriniz")))));
                        // goto case "1"; tekrar farklı bir case'e yonlendirme yapar
                        break;
                    case "4":
                        //Yamuk Alanı
                        Console.WriteLine(string.Format("Yamuğun Alanı = {0:0.00}", AlanHesapla(GirisAl("Alt kenarı giriniz"), GirisAl("Üst Kenarı giriniz"), GirisAl("Yüksekliği giriniz"))));
                        break;
                    default:
                        break;
                }



                #region AlanHesaplari
                if (gelenCevap == 1)
                {
                    //Kare Alanı
                    Console.WriteLine("Kare'nin alanı={0}", AlanHesapla(GirisAl("Kenar Uzunluğu Giriniz")));
                }
                else if (gelenCevap == 2)
                {
                    //Dikdortgen Alanı
                    Console.WriteLine("Dikdörtgen alanı={0}", AlanHesapla(GirisAl("Kısa kenar giriniz"), GirisAl("Uzun kenar giriniz")));
                }
                else if (gelenCevap == 3)
                {
                    //Daire Alanı
                    Console.WriteLine(string.Format("Dairenin Alanı = {0:0.00}", AlanHesapla(Convert.ToInt32(GirisAl("Yarıçap Değerini giriniz")))));

                }
                else if (gelenCevap == 4)
                {
                    //Yamuk Alanı
                    Console.WriteLine(string.Format("Yamuğun Alanı = {0:0.00}", AlanHesapla(GirisAl("Alt kenarı giriniz"), GirisAl("Üst Kenarı giriniz"), GirisAl("Yüksekliği giriniz"))));
                }
                #endregion

                Console.WriteLine("Tekrar hesaplanacak mı? E/H?");
                 cvp = Console.ReadLine();
                
            } while (cvp.ToLower()=="e");

            Console.Read();
        }

        /// <summary>
        /// Kare alanı hesaplar
        /// </summary>
        /// <param name="kenarUzunlugu"></param>
        private static double AlanHesapla(double kenarUzunlugu)
        {
            return kenarUzunlugu * kenarUzunlugu;
        }

        /// <summary>
        /// Dikdörtgen alanı hesaplar
        /// </summary>
        /// <param name="kisaKenar">Kısa kenar giriniz</param>
        /// <param name="uzunKenar">Uzun kenar giriniz</param>
        private static double AlanHesapla(double kisaKenar, double uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }
        /// <summary>
        /// Daire alanı hesaplar
        /// </summary>
        /// <param name="yariCap">Yarıcap bilgisi</param>
        /// <param name="Pi">Pi sayısı</param>
        private static double AlanHesapla(int yariCap, double Pi = Math.PI)
        {
            return yariCap * yariCap * Pi;
        }
        /// <summary>
        /// Yamuk alanı hesaplar
        /// </summary>
        /// <param name="altKenar">Alt kenar uzunluğu</param>
        /// <param name="ustKenar">Ust kenar uzunluğu</param>
        /// <param name="yukseklik">Yükseklik bilgisi</param>
        private static double AlanHesapla(double altKenar, double ustKenar, double yukseklik)
        {
            return (altKenar + ustKenar) * yukseklik / 2;
        }

        /// <summary>
        /// Klavyeden girilen değeri double'a cevirir.
        /// </summary>
        /// <param name="mesaj">Kullanıcıya gösterilecek olan mesajı giriniz</param>
        static double GirisAl(string mesaj)
        {
            Console.WriteLine(mesaj);
            double sayi = 0;
            try
            {
                sayi = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sayi;
        }
    }
}
