using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_DizilerGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİLER ( ARRAYS)
            //Diziler ve koleksiyonlar .net icerisinde verileri guruplayarak saklamak için kullanılan yapılardır. 
            //Diziler icerisinde aynı türden veriler guruplanarak bir arada saklanabilir. ( tutulabilir )
            //Eleman sayıları oluşturulduklarında belirlenmelidir. Tanımlanmış olan eleman sayısı daha sonra Array.Resize metodu ile değistirilebilir.
            //Diziler System.Array namespace'i altında bulunurlar.
            //Eleman sayıları sabit ve dizi icerisine eklenen elemanlar herhangi bir donusturme islemine tutulmadığı için koleksiyonlara göre daha hızlı çalışırlar.

            //Hem değer tipinde hem de referans tipinde veriler dizi icerisinde saklanabilir. Dizi icerisinde veriler 0 numaralı index'ten itibaren saklanmaya başlanır.

            //Değisken türü[] Dizi değiskeni adı = new Değisken türü [Eleman Sayısı]

            int[] numara = new int[10]; //10 elemanlı integer turunde bir dizi tanımladık.

            string[] adSoyad = new string[5];
            adSoyad[0] = "Caner Mollaoğlu";
            adSoyad[1] = "Ahmet Aslan";
            adSoyad[2] = "Ali Veli";

            string[] isimListesi = { "Ahmet", "Hasan", "Ali", "Veli", "Metin" };
            Console.WriteLine(isimListesi[2]);

            int[] yeniDizi = new int[50];

            int sayac = 0;

            //diziyi dongu ile dolduralım
            for (int i = 0; i < 50; i += 2)
            {
                yeniDizi[sayac] = i;
                sayac++;
            }

            //dizinin tüm elemanlarını tek tek okuyarak ekrana basalım:
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                Console.WriteLine(yeniDizi[i]);
            }

            string metinDeger = "Bahçeşehir";
            char[] charListem = metinDeger.ToArray();   //string'i char'a cevirir.          

            //Array yeniden boyutlandırma

            string[] elemanListesi = new string[2];
            elemanListesi[0] = "Enes";
            elemanListesi[1] = "Metin";

            //elemanListesi = new string[3];
            //elemanListesi[2] = "Yeni İsim";

            //Console.WriteLine(elemanListesi[2]);
            Console.WriteLine(elemanListesi[0]);    //değer yok olur cünkü dizi yeniden oluşturulur.

            Array.Resize(ref elemanListesi, 4); //ram de gidip o diziyi bulur. 4 gozlu oldu ve icerisindeki değerler duruyor.

            //foreach ile dizi okuma
            foreach (string item in elemanListesi)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
