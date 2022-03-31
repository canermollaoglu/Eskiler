using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //int newNumber = 0;  ilk önce burada tanımlayarak her oyunda sıfırlanmak zorunda olduklarına dikkat cekelim.
            //int newSum = 0;

            do   //Evet Hayır Kontrolü için gereken döngü
            {
                int newNumber = 0;
                int newSum = 0;
                Console.Clear();

                do //1 OYUN İÇİN GEREKEN KOD
                {
                    Console.WriteLine("Bir sayi giriniz");
                    newNumber = Convert.ToInt32(Console.ReadLine());

                    newSum += newNumber;

                    if (newSum >= 200)
                    {
                        Console.WriteLine("Maximum değere ulaştınız..");
                        break;
                    }

                } while (true);   //dongu ne zamana kadar donecek?      sınırsız sayı girisi yapabiliyorum. 

                Console.WriteLine("Toplam: " + newSum);
                Console.WriteLine("Tekrar denemek ister misiniz? E/H");

                string answer = Console.ReadLine();
                if (answer.ToLower() != "e")
                break;

            } while (true);
        }
    }
}
