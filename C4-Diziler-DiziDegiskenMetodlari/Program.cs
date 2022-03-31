using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Diziler_DiziDegiskenMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] egitimTuru = {".Net","Javascript","Html","Css3"};
            string ad = "Caner";
            //IsArray Metodu
            //bir değiskenin dizi değiskeni olup olmadığını anlamak amacıyla kullanılan metodtur. Geriye true false doner.

            Type tip = egitimTuru.GetType();
            Console.WriteLine(tip.IsArray);
            Console.WriteLine(ad.GetType().IsArray);

            //SetValue
            //Dizi elemanlarına değer atar
            egitimTuru.SetValue("Bootstrap", 3);

            //GetValue
            //Dizi elemanlarına erismek için kullanılır.
            string deger=egitimTuru.GetValue(0).ToString();

            //Join Metodu
            //Dizi elemanlarını belirtilen ayıracı kullanarak bir string değiskene aktarır.

            string tumEgitimler = string.Join(",", egitimTuru);

            //Copy Metodu
            //Bir dizinin iceriğini baska bir diziye kopyalar.
            string[] kopyaDizi = new string[4];
            //Array.Copy(egitimTuru, kopyaDizi, 2);
            Array.Copy(egitimTuru, 1, kopyaDizi, 1, 2);



        }
    }
}
