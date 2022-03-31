using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum Yılınızı Giriniz");
            //Read için debug yaparak kontrol ederiz. 1985 girdiğimizde ilk karakterin ASCII karakter kodu olan 49 rakamını döner. bunun yerine readline kullan convert et
            // int yil = Console.Read();
            int yil = Convert.ToInt32(Console.ReadLine());
            //int32 int16 farkı nedir açıkla???
                //-int16 short'u ifade eder onun .net karsılığı int16 dır.
            
            Console.WriteLine("Yaşınız " + DateTime.Now.Year + "-" + yil + "="+(DateTime.Now.Year - yil));

            //yer tutucu ile tekrar yazdırılacak
            Console.WriteLine("Yaşınız: {0}-{1}={2}", DateTime.Now.Year, yil, DateTime.Now.Year - yil);
            Console.ReadKey();
        }
    }
}
