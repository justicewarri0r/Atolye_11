using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarinTuttuguSayiyiBul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aklınızdan Bir Sayı Tutunuz...");
            Random rnd = new Random();
            int tahmin = rnd.Next(0, 100);
            Console.WriteLine($"Aklınızdan Tuttuğunuz Sayı {tahmin} mi e(evet),a(aşağı),y(yukarı)");
            string cevap = Console.ReadLine();
            int alt = 0, ust = 100;
            while(cevap !="e" && cevap != "E")
            {
                if (cevap == "a" || cevap == "A")
                {
                    ust = tahmin;
                    tahmin = rnd.Next(alt, tahmin);
                }
                else if (cevap == "y" || cevap == "Y")
                {
                    alt = tahmin;
                    tahmin = rnd.Next(tahmin, ust);
                }
                Console.WriteLine($"Aklınızdan Tuttuğunuz Sayı {tahmin} mi e(evet),a(aşağı),y(yukarı)");
                cevap = Console.ReadLine();

            }
            Console.WriteLine($"Tahmininiz = {tahmin} dir...");
            Console.ReadLine();
        }
    }
}
