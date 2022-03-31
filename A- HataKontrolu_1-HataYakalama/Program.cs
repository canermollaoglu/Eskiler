using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A__HataKontrolu_1_HataYakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hatalar program calısması esnasında oluşurlar ve programın calısmayı durdurmasına neden olurlar. Bu hatalar kullanıcı kaynaklı, yazılımcı kaynaklı ya da sistem kaynaklı olabilirler. Yapmamız gereken olusabilcek olan hataların analizini yaparak gerekirse kullanıcıyı bilgilendirecek mesajlar üretmektir.

            //Genel Kullanımı
            #region trycatchTanimlama
            //try
            //{
            //    //Hata oluşturabilecek kodlar
            //}
            //catch (Exception)
            //{
            //    //Hata oluştuğunda çalışacak kod satırları
            //}
            //finally
            //{
            //    //Hata olussa da oluşmasa da çalışacak olan kod satırları
            //}
            #endregion


            #region ilkOrnek
            ////try catch kullanmasaydım program patlar, donar, yanıt vermez. Geri dönüş olmaz.
            //try
            //{
            //    int sıfır = 0;
            //    int sonuc = 10 / sıfır;
            //}
            //catch
            //{
            //    Console.WriteLine("Hata oluştu");
            //}
            #endregion


            //Ancak bu sekilde yeterli bilgi veremem. Olusan hatanın cinsini söylemem gerekir. Bunuda EXCETION NESNESİ ile yaparım.

            //EXCEPTION NESNESİ
            //Oluşan hatalar exception nesnesinden üretilir. System sınıfının altında yer alır. 

            #region ExceptionYakalama
            //Not girisi yapalım. 45-100 arasıdaysa geçtiniz yazalım.
            //try
            //{
            //    byte not;
            //    Console.WriteLine("Not Giriniz");
            //    not = Convert.ToByte(Console.ReadLine());

            //    if (not>=45 & not<=100)
            //    {
            //        Console.WriteLine("Geçtiniz");
            //    }
            //    else if(not<45)
            //    {
            //        Console.WriteLine("Kaldınız");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Maximum not: 100 olmadır");
            //    }
            //}
            //catch
            //{
            //    //burada olusacak her türlü hatada aynı mesajı vermis olurum. 
            //    //byte sınırları dısında bir değer girip deneyelim?
            //    Console.WriteLine("Yanlış not girisi yaptınız");
            //}
            #endregion

            #region BirdenFazlaException
            //try
            //{
            //    byte not;
            //    Console.WriteLine("Not Giriniz");
            //    not = Convert.ToByte(Console.ReadLine());

            //    if (not >= 45 & not <= 100)
            //    {
            //        Console.WriteLine("Geçtiniz");
            //    }
            //    else if (not < 45)
            //    {
            //        Console.WriteLine("Kaldınız");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Maximum not: 100 olmadır");
            //    }
            //}
            ////catch(Exception ex)
            ////{   //OverFlow ve Format Exceptionlar gosterilir. ex.ToString(), ex.source, ex.message
            ////    Console.WriteLine(ex.Message);
            ////}

            ////Exception Nesnesinin Özellikleri
            ////Message : hata ile ilgili açıklama verir
            ////Source    : hatayı oluturan nesne ya da sınıf hakkında bilgi verir. mscorlib system isim alanının icinde bulunduğu sınıftır.
            ////TargetSite: Hatayı oluşturan metod hakkında bilgi verir.

            //catch (OverflowException)
            //{
            //    Console.WriteLine("Ongorulen sınırlar dısında bir giriş yaptınız. Girilen sayı: " + byte.MinValue + "--" + byte.MaxValue + "arasında olmalıdır.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen rakam giriniz");
            //}
            //finally
            //{
            //    //Hata verse de vermese de calısacaktır.
            //    Console.WriteLine("İşlem Tarihi: " + DateTime.Now.ToLongDateString());
            //}
            #endregion

            #region BirdenFazlaException
            int deger, sonuc, bolen;
            try
            {
                Console.Write("Sayıyı Giriniz:");
                deger = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bölen Sayıyı Giriniz:");
                bolen = Convert.ToInt32(Console.ReadLine());
                sonuc = deger / bolen;
            }
            // Sıfıra Bölme Hatası
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra Bölme Hatası");
                sonuc = int.MaxValue;
            }
            // Arithmetik Hata            
            catch (ArithmeticException) //bu overflowu da icerir
            {
                Console.WriteLine("Aritmetik Hata");
                sonuc = int.MaxValue;
            }           
            // Tanımlanmamış Hata 
            catch
            {
                Console.WriteLine("Tanımlanmamış Hata");
                sonuc = int.MaxValue;
            }
            Console.WriteLine("Sonuç = {0}", sonuc);
            #endregion
            Console.Read();
        }
    }
}
