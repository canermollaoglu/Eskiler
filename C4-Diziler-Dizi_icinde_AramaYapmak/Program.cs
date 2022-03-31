using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Diziler_Dizi_icinde_AramaYapmak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            student[0] = "Hasan";
            student[1] = "Ali";
            student[2] = "Ayşe";
            student[3] = "Fatma";
            student[4] = "Hüseyin";
            
            //Contains metodu
            //Dizi icinde bir elemanın var olup olmadığını true false olarak geriye doner.

            Console.WriteLine("Aranan kelimeyi giriniz!");
            string aranan = Console.ReadLine();

            if (student.Contains(aranan))
                Console.WriteLine("Aranan deger bulundu");
            else
                Console.WriteLine("Aranan deger BULUNAMADI");


            //IndexOf metodu
            //Dizi icerisinde bulunan elemanın index değerini geriye doner.
            //Fatma adlı ogrenciyi bul ve adını FatmaGül olarak değistir.
           
            int indexNo = Array.IndexOf(student, "Fatma");
            if (indexNo == -1)
                Console.WriteLine("ögrenci bulunamadı...");
            else
                student[indexNo] = "FatmaGül";


            //LastIndexOf Metodu
            //IndexOf gibi arama yapar ancak elemanlardan birden fazla var ise sonuncusunun index değerini doner.
            string denemeText = "Caner Mollaoğlu";
            char[] denemeHarfler = denemeText.ToCharArray();

            int lastIndexTest = Array.LastIndexOf(denemeHarfler, 'a');

            if (lastIndexTest!=-1)
                Console.WriteLine("son harf bulundu.index no: "+ lastIndexTest);
            else
                Console.WriteLine("bulunamadı");

            //BinarySearch Metodu ? ANLATILMADI
            //Array sort edildiyse arama yapar ve geriye index değerini doner.
            Array.Sort(student);
            int indexNumber = Array.BinarySearch(student,"Hasan");

            Console.ReadLine();
        }
    }
}
