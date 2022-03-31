using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Metodlar_ExtentionMetodlar
{
    public static class MyExtentions
    {
        /*
        İlk olarak metoduda static yapmamız gerek (böylece herhangi bir tanımlama yapmadan istediğimiz zaman erişebilelim) ikinci olarak ilk parametrenin başına this kelimesini koyuyoruz. Parametremizin başına this kelimesini koymakla CLR’a metodumuzun extension metod olduğunu bildirmiş oluyoruz.

            1. Public static bir sınıf oluşturulur.
            2. Yapmak istediğiniz işlemleri gerçekleştirecek metod yazılır.
            3. Diğer metodlar gibi cağırılmıyor. String bir değer yazıp . (nokta) ya basınca cıkıyorlar. 
            This ilk parametre olmak zorundadır.
            */
        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }

        //normal bir metod gibi string parametre metodun icerisine parametre olarak yazılmaz.


        /// <summary>
        /// girilen textin ilk harfini buyutmek için kullanılır.
        /// </summary>
        /// <param name="str">metin ifade</param>
        /// <param name="ilkharfbuyuk">true false</param>
        /// <returns></returns>
        /// 
        public static string toUpper(this string str, bool hepsiBuyuk)
        {
            if (hepsiBuyuk == true)
                return str.ToUpper();
            else
                return str;
        }
    }

}