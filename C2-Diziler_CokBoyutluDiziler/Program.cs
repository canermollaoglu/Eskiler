using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Diziler_CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çok boyutlu diziler:

            //3 eleman x 2 boyutlu      
            string[,] ogrenciIsimleri = new string[3, 2];

                              //0                                                  //1                                                  //2
            string[,] Liste = { { "Ahmet", "Aktaş","5c","21121231" }, { "Mehmet", "Uslu", "5c", "21121231" }, { "Veli", "Güneş", "5c", "21121231" } };
            //3 elemanlı her eleman icin 4 boyut var.
            /*
            0-0     0-1     0-2     0-3    
            1-0     1-1     1-2     1-3
            2-0     2-1     2-2     2-3
            */

            int boyut = Liste.Length;       //12 doner
            int elemanSayisi=Liste.GetLength(0);    //satir sayısı  3 doner
            int boyutSayisi=Liste.GetLength(1);     //sutun sayısı  4 doner

            //2 satır 0-1
            //Her satırda 3 eleman var 0-1-2
            //Her eleman 4 boyutludur   0-1-2-3
            int[,,] yeniListem = new int[2,3,4];
            yeniListem[0, 0, 0] = 100;
            yeniListem[0, 0, 1] = 200;
            yeniListem[0, 0, 2] = 300;
            yeniListem[0, 0, 3] = 400;

            yeniListem[0, 1, 0] = 500;
            yeniListem[0, 1, 1] = 600;
            yeniListem[0, 1, 2] = 700;
            yeniListem[0, 1, 3] = 800;

            yeniListem[0, 2, 0] = 900;
            yeniListem[0, 2, 1] = 1000;
            yeniListem[0, 2, 2] = 1100;
            yeniListem[0, 2, 3] = 1200;


            //Düzensiz Diziler (Jagged Array)

            int[][] duzensiz_dizi = {
                new int[] {1},
                new int[] {1,2,3,4},
                new int[] {1,2,3,4,5,6}
            };

            foreach (var satir in duzensiz_dizi)    //burada ki satır neyi ifade eder? tek tek arrayleri ifade eder. Bunlar içinde farklı bir foreach acabiliriz:
            {
                foreach (var eleman in satir)
                {
                    Console.Write("{0}", eleman);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
