using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.HataYonetimi.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //MerhabaHataYonetimi();
            HataYonetimiInceleme();
        }

        static void MerhabaHataYonetimi()
        {
            Console.WriteLine("Sayı girişi yapınız");
            int sayi = int.Parse(Console.ReadLine());

            
        }
        //Try Catch her zaman kullanılmaz gerektiği noktalarda kullanılır. Uygulamayı yavaşlatır.
        static void HataYonetimiInceleme()
        {
            //try bloğunda kendi yazdığımız kodlar bulunur.
            try
            {
                //standart uygulama için yazdığımız kod blokları
                Console.WriteLine("Sayı girişi yapınız");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi == 10)
                {
                    throw new OzelHataSinifi();
                }
            }

            catch(OzelHataSinifi os)
            {
                Console.WriteLine("Özel hata sınıfı catch içerisinde yakalandı.");
            }
         
            catch (FormatException formatex)
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir.");
                Console.WriteLine(formatex.Message);
            }

            catch (Exception ex) //hata yönetiminde Exception class ı base class tır.
            {
                Console.WriteLine("Herhangi bir hata oluştu");
                Console.WriteLine(ex.Message);
                //cath bloğunda ise sistem içerisinde çalışma zamanında alınan hataların loglanmasına ve kullanıcıya açıklayıcı hata mesajı vermek için kullanılır.
            }
            finally
            {
                //try kısmında kodlarımız çalışır
                //catch => .....
                //finally => kod tarafında herhangi bir hata almasakta bizim finally çalışmaya devam eder.
                Console.WriteLine("Finally çalıştı");
            }

            Console.WriteLine("Uygulama bitti");
            Console.ReadLine();
        }
    }
}