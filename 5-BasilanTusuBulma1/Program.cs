using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_BasilanTusuBulma1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir tuşa basın ardından enter tuşuna basın");
            char karakter = (char)Console.Read();//geriye ilk karakterin ascii kodunu döner.
           // string karakter = Console.ReadLine();
            Console.WriteLine("Basılan tuş: " + karakter.ToString().ToUpper());

            //bunu ne için yaparız. basılan karakter e ise bir işlem yap demek istiyorsak mesela E/H? şeklinde sorgulayabiliriz.

            //read metodu ile basılan tuslar yakalanır ancak f1, spacebar, enter gibi tuslar yakalanamaz bunu icin readkey metodu ile ConsoleKeyInfo yapısı kullanılır.

            Console.WriteLine("Bir tuşa basınız");

            //Console.ReadKey önce metod yazılır sonra geridönüş tipi öğrencilere anlatılarak ConsoleKeyInfo yapısı turunde bir değisken oluşturulur.
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);
            Console.WriteLine(keyInfo.Key.ToString() + " tuşuna bastınız");


            Console.ReadKey();

        }
    }
}
