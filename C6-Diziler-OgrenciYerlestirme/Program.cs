using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Diziler_OgrenciYerlestirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciListesi = new string[5];
            ogrenciListesi[0] = "Caner";
            ogrenciListesi[1] = "Ali";
            ogrenciListesi[2] = "Ahmet";
            ogrenciListesi[3] = "Veli";
            ogrenciListesi[4] = "Mehmet";

            bool[] secilenOgrenciler = new bool[5];


            string[] egitimListesi = new string[3];
            egitimListesi[0] = "C#";
            egitimListesi[1] = "Asp.Net";
            egitimListesi[2] = "Html5";

            bool[] secilenEgitimler = new bool[3];
            string gelenCvp = "";

            Random rnd = new Random();

            try
            {
                do
                { //oyunu tekrar oynatıyor
                    string secilenOgrenci = "";
                    string secilenEgitim = "";
                    int sOgrenciIndex = 0;
                    int sEgitimIndex = 0;
                    Console.Clear();

                    for (int i = 0; i < secilenEgitimler.Length; i++)
                        secilenEgitimler[i] = false;

                    for (int i = 0; i < secilenOgrenciler.Length; i++)
                        secilenOgrenciler[i] = false;

                    for (int i = 0; i < ogrenciListesi.Length; i++) //tum ogrencileri dağıtacak
                        {
                            //daha once secilmeyen bir ogrenci bulur.
                            do
                            {
                                sOgrenciIndex = rnd.Next(0, ogrenciListesi.Length);
                                secilenOgrenci = ogrenciListesi[sOgrenciIndex];

                            } while (secilenOgrenciler[sOgrenciIndex] == true);

                            secilenOgrenciler[sOgrenciIndex] = true;    //ogrenci dağıtımı yapıldı.


                            //tum egitimlere en az 1 ogrenci verene kadar yeni bir eğitim bulacağız.
                            do
                            {
                                sEgitimIndex = rnd.Next(0, egitimListesi.Length);
                                secilenEgitim = egitimListesi[sEgitimIndex];

                                if (!secilenEgitimler.Contains(false))  //eğer dizide false kalmadıysa her eğitime en az 1 kisi dağıtılmış demektir. Artık rastgele eğitimlere ogrenci atayabiliriz.
                                    break;
                            } while (secilenEgitimler[sEgitimIndex] == true);

                            secilenEgitimler[sEgitimIndex] = true;

                            Console.WriteLine(secilenOgrenci + "==" + secilenEgitim);
                        }


                        Console.WriteLine("Tekrar dağıtmak ister misiniz? E/H");
                        gelenCvp = Console.ReadLine();
                } while (gelenCvp.ToLower()=="e");

                Console.WriteLine("İslem Sonlandırıldı");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}
