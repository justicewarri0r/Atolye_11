using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontor = 30;
            int y = 0;
            int z = 0;
            while (true)
            {
                Console.WriteLine("1.Kontor Yükleme");
                Console.WriteLine("2.Kontor Sorgulama");
                Console.WriteLine("3.Kontor Gönderme");
                Console.Write("Lütfen sayı giriniz...");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("5 Kontor 3.99TL");
                        Console.WriteLine("10 Kontor 7.99TL");
                        Console.WriteLine("20 Kontor 15.99TL");
                        Console.WriteLine("50 Kontor 47.99TL");
                        Console.Write("5 Kontor için 5,10 Kontor için 10,20 Kontor için 20,50 Kontor için 50 Tuşlayınız...");
                        y = Convert.ToInt32(Console.ReadLine());
                        kontor = 30 + y;
                        Console.WriteLine($"Mevcut Bakiye = {kontor}");
                        break;
                    case 2:
                        Console.WriteLine($"Mevcut Bakiye = {kontor}");
                        break;
                    case 3:
                        Console.Write("Göndermek İstediğiniz Kontor Miktarını giriniz...");
                        z = Convert.ToInt32(Console.ReadLine());
                        if (z == kontor || z <= kontor && z > 0)
                        {
                            kontor = kontor + y - z;
                            Console.Write("Kontor Göndermek istediğiniz numarayı giriniz...");
                            long telNo = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine($"Kalan Kontor = {kontor}");
                        }
                        else
                        {
                            Console.WriteLine($"Lütfen Geçerli Bir Değer Giriniz");
                        }
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
