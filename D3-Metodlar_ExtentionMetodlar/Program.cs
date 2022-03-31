using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Metodlar_ExtentionMetodlar
{
    class Program
    {
        /*
        Extension metod ilk olarak burada yeni bir public static class olarak tanımlanacak. Daha sonra yeni bir class olarak projeye eklenecek. Son asama olarak farklı bir projeye yazdığımız class'ın nasıl ekleneceğini göstereceğiz.
            */
        static void Main(string[] args)
        {
            string gelenDeger = "132";
            int a = gelenDeger.ToInt32();
           
            string denemeText = "Yeni bir metin geliyor..";
            string donusturulenText=denemeText.toUpper(true);

            Console.ReadLine();
        }
    }

}
