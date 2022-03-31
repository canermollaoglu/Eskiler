using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Extra_Bilgilendirme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir metin icerisinde bulunan büyükharf, küçükharf, rakam ve alfasayısal(rakam ve harf olmayan) karakterlerin sayısını bulunuz.

            Console.WriteLine("Bir satır yazıp enter'a basınız!");
            string gelenYazi = Console.ReadLine();

            //Kucukharf sayısı
            int kucukharfSayisi = 0;
            //her string bir char dizisidir vurgulanacak.
            foreach (char harf in gelenYazi)
                if (char.IsLower(harf)) kucukharfSayisi++;

            Console.WriteLine("Küçük harf sayısı: " + kucukharfSayisi);


            //Buyukharf sayısı
            int buyukharfSayisi = 0;
            //her string bir char dizisidir vurgulanacak.
            foreach (char harf in gelenYazi)
                if (char.IsUpper(harf)) buyukharfSayisi++;

            Console.WriteLine("Büyük harf sayısı: " + buyukharfSayisi);


            //Rakam sayısı
            int rakamSayisi = 0;
            //her string bir char dizisidir vurgulanacak.
            foreach (char harf in gelenYazi)
                if (char.IsDigit(harf)) rakamSayisi++;

            Console.WriteLine("Rakam sayısı: " + rakamSayisi);


            //AlfaSayısal sayısı
            int alfaSayisal = 0;
            //her string bir char dizisidir vurgulanacak.
            foreach (char harf in gelenYazi)
                if (!char.IsLetterOrDigit(harf)) alfaSayisal++;

            Console.WriteLine("Alfa Sayısal Olmayan harf sayısı: " + alfaSayisal);

            Console.Read();
        }
    }
}
