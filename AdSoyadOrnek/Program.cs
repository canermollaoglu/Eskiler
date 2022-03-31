using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSoyadOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //en son renk değisikliği yapabiliriz ancak console.clear yazmamız gerekir..
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Adınızı Giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("Yaşınızı Giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Adınız " + ad + " Yaşınız " + yas);

            Console.Clear();
            //farklı bir yazım yapalım - sola hizalı + sağa hizalı olur
            Console.WriteLine("Name: {0,-20}\nSurname {1,-20}", ad, yas);

            Console.ResetColor();   //rengi tekrar eskiye döndürüyor
            Console.WriteLine("Test");
            Console.Clear();

            Console.ReadKey();
        }
    }
}
