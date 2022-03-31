using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Operatorler
{
    class Program
    {

        static void Main(string[] args)
        {
            //1-
            //Aritmatik operatörler : Matematiksel işlemlerde kullanılır.
            /*
            +      :Toplam
            -       : Çıkarma
            *       : Çarpma
            /       : Bölme
            %      : Mod
            */

            //2-Karşılastırma Operatörleri
            //<, > <=, >=, ==, !, !=, --> (uzaklasma) <-- (yakınlasma operatörü)
            //3-Mantıksal Operatörler
            // & (ve operatörü)
            //true değer olması için iki tarafında true olması gerekir.
            //true true ise true'ya düser. onun haricindeki tüm durumlarda false'a düser.
            int mSayi1 = 100, mSayi2 = 200;

            if (mSayi1 > 50 & mSayi2 > 300) //2 kosulda true ise true calısır
            {
                //true
            }
            else
            {
                //false
            }

            //| operatörü (ve ya)
            //ikisi birden false olduğunda false sonucunu verir. Onun haricinde tüm durumlarda true bölümü çalışır.
            if (mSayi1 < 30 | mSayi2 > 350) //kosullardan bir tanesi bile true olursa true çalışır
            {
                //true
            }
            else
            {
                //false
            }

            //&& (kosullu ve) operatörü
            //ilk kosul true döner ise eğer and islemi gerceklestirilir ve 2. kosula bakılır.
            //true true-- true
            //true false-- false
            //ilk deger false ise 2. kosula bakılmadan false döner.
            if (mSayi1 < 30 && mSayi2 > 350)
            {
                //true
            }
            else
            {
                //false
            }

            // ||(veya değil) operatörü
            //ilk değisken false ise or islemi gercekleşir, true ise ikinci değiskene bakılmadan true 
            //sonucunu döner.
            //false ise 2.ye bakılır.
            //true ise 2. ye bakılmadan true döner
            if (mSayi1 < 30 || mSayi2 > 350)    //ilk kosul false olduğu icin 2. kosula da bakılır.
            {
                //true
            }
            else
            {
                //false
            }

            //!(değil) operatörü
            //değeri tersine cevirir. 
            if (mSayi1 != 100)
            {
                Console.WriteLine("sayı 100 den farklıdır");
            }

            //?? (null coalescing) operatörü
            //x ?? y
            //Eğer ilk değisken null ise 2. deger hesaplanır. Aksi takdirde 2. değer isleme konulmaz.

            string ogrenciAdi = null;
            string bilgi = ogrenciAdi ?? "Adı girilmedi";   // ogreniciAdi null ise Adı girilmedi yaz. değilse dokunma.
            Console.WriteLine(bilgi);

            //?: (kosul) operatörü
            //x?y:z

            //Çıkmak istediğinizden emin misiniz? E/H yazdır. kullanıcı e ye basar ise program kapatılıyor, h ya basar ise calısmaya devam yazdır. 

            string girilenDurum;
            Console.WriteLine("Cıkmak istediğinizden emin misiniz? E/H");
            girilenDurum = Console.ReadLine();

            Console.WriteLine(girilenDurum.ToUpper() == "E" ? "Program Kapatılıyor" : "Çalışmaya Devam");
       
            //4- Aktarma Operatörleri
            // +=, -=, *=, /=
            //%= modunu alır ve kalan değeri soldaki değiskene atar.
            byte a = 10;
            byte b = 3;
            a %= b; //a esittir a mod b

            Console.ReadKey();

        }
    }
}
