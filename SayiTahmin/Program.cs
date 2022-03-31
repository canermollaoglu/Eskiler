using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(0, 101);
            Console.Clear();
            int girilenSayi = 0;
            int sayac = 1;

            do //tekrar denemek için sorulan soru dongusu
            {
                do //bilene kadar donecek olan döngü
                {
                    try
                    {
                        Console.WriteLine(sayac + ". deneme: 0-100 arası bir sayı tahmin edin");
                        girilenSayi = int.Parse(Console.ReadLine());
                        if (girilenSayi < 0 || girilenSayi > 100)
                            throw new Exception("0-100 arası sayı gir");
                        else if (girilenSayi > rastgeleSayi)
                        {
                            Console.WriteLine("Aşağı");     //bir sonra ki deneme için sayac 1 arttırılıyor.
                            sayac++;
                        }
                        else if (girilenSayi < rastgeleSayi)
                        {
                            Console.WriteLine("Yukarı");    //bir sonra ki deneme için sayac 1 arttırılıyor.
                            sayac++;
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler " + sayac + ". denemede bildiniz");
                            break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        sayac++;
                    }
                } while (true); //bilene kadar donecek olan döngü sonu

                Console.WriteLine("Tekrar denemek ister misiniz? E/H");
                if (Console.ReadLine().ToLower() != "e")
                    break;

            } while (true); //tekrar denemek için sorulan soru dongusu


            Console.Read();
        }
    }
}
