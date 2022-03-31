using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_HataKontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ExceptionOlusturma(throw)
            Console.WriteLine("Lütfen bir sayı giriniz");
            string okunan = Console.ReadLine();
            int girilenSayi = 0;
            try
            {
                girilenSayi = int.Parse(okunan); //once sadece bununla goster
                if (!(girilenSayi > 0))
                    throw new Exception("Lütfen pozitif bir sayı giriniz"); //fırlatılacak hatayı kendim belirliyorum
                if (girilenSayi > 100)
                    throw new OverflowException("100 den buyuk bir sayı giremessiniz");

                Console.WriteLine("Tebrikler girilen sayı formatı doğru");
                //bu mesajı vermemeli ya da alttaki kodları calıstırmamalı
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally bölümü calısıyor--" + girilenSayi);
                Console.ReadLine();
            }
            #endregion

            #region ExceptionKontrolu
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //string okunan = Console.ReadLine();
            //int girilenSayi = 0;
            //try
            //{               
            //    girilenSayi = int.Parse(okunan); //once sadece bununla goster
            //    Console.WriteLine("Tebrikler girilen sayı formatı doğru");
            //    //bu mesajı vermemeli ya da alttaki kodları calıstırmamalı
            //}
            //catch (Exception ex)
            //{
            //    //is ve as operatörleri
            //    //is operatörü bir değisken tipinin belirlenen bir değisken tipi ile karsılaştırılması için kullanılır. bunun tipi acaba bu mu kontrolü
            //    //as operatörü ise referans tipli değiskenlerde (objelerde) donusum için kullanılır. 

            //    if (ex is OverflowException)
            //    {
            //        Console.WriteLine("Sayı belirlenen değerler dısında...");
            //    }

            //    if (ex is FormatException)
            //    {
            //        Console.WriteLine("Lütfen rakam giriniz...");
            //    }

            //}
            //finally
            //{
            //    Console.WriteLine("finally bölümü calısıyor--" + girilenSayi);
            //    Console.ReadLine();
            //}
            #endregion
        }
    }
}
