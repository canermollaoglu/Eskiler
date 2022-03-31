using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReadline
{
    class Program
    {
        static void Main(string[] args)
        {
            //Readline değeri okur ve geriye string değer döner. String degisken tiplerini okur.
            //Read metodu int döner ve string dısındaki tipleri okumak için kullanılır.

            //Yukarıdan System'i silip usingleri ve referansları anlat.

            string ad;
            Console.Write("Adınızı Girin: ");
            ad = Console.ReadLine();
            Console.Clear();    //ekranı temizler
            Console.WriteLine(ad.ToUpper());      

            Console.ReadKey();
        }
    }
}
