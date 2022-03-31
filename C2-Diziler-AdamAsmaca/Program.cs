using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Diziler_AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = { "kalemtraş", "kahramanmaraş", "çanakkale", "jenaratör", "taşarabası", "afyonkarahisar", "karahindiba" };
            Random rnd = new Random();
            do //oyun tekrarı icin
            {
                Console.Clear();
                #region Ayar
                int rastgeleSayi = rnd.Next(0, sorular.Length);
                char[] soru = sorular[rastgeleSayi].ToArray();  //soruyu char array e ceviriyoruz.

                string[] cevap = new string[soru.Length];

                //cevap dizisinin tum gozlerine - koyuyoruz.
                for (int i = 0; i < cevap.Length; i++)
                {
                    cevap[i] = " _ ";
                }
                int kalanHak = 6;
                double kalanPuan = soru.Length * 100;
                int bilinenHarf = 0;
                #endregion

                #region biroyunicin
                do //bir oyun icin gereken kod
                {
                    Console.Clear();

                    if (kalanHak == 0) break;
                    if (bilinenHarf == soru.Length) break;

                    foreach (string item in cevap)
                    {
                        Console.Write(item);
                    }
                    //Console.WriteLine("\n\n" + kalanHak + " Hak " + kalanPuan + "\nTahmin Et!");
                    Console.WriteLine(string.Format("\n\n {0} Hak; {1} Puan\nTahmin Et!", kalanHak, kalanPuan));
                    string giris = Console.ReadLine();

                    if (giris.Length == 1)
                    {
                        bool tahminDogruMu = false;
                        for (int i = 0; i < soru.Length; i++)
                        {
                            if (soru[i].ToString() == giris)
                            {
                                cevap[i] = string.Format(" {0} ", giris);
                                tahminDogruMu = true;
                                bilinenHarf++;
                            }
                        }
                        if (!tahminDogruMu)
                        {
                            kalanHak--;
                            kalanPuan -= kalanPuan * 0.15;
                            //kalanPuan = kalanPuan - (kalanPuan * 0.15);
                        }
                    }
                    else
                    {
                        if (sorular[rastgeleSayi] != giris) //tüm kelimeyi tahmin ediyorsa bunun kontrolünü yapıyoruz.
                        {
                            kalanHak--;
                            kalanPuan -= kalanPuan * 0.15;
                        }
                        else break; //tüm kelimeyi 1 kere de doğru bildiyse artık donmeyi bırak
                    }
                } while (true);
                #endregion               

                if (kalanHak > 0)
                    Console.WriteLine(string.Format("Tebrikler Bildiniz! Puanınız => {0}", kalanPuan));
                if (kalanHak == 0)
                    Console.WriteLine(string.Format("Malesef bilemediniz, puanınız 0\nDoğru Cevap =>{0}", sorular[rastgeleSayi]));

                Console.WriteLine("Tekrar Oynamak İster Misiniz? E/H");
                if (Console.ReadLine().ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
