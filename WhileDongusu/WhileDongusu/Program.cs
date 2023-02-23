using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int sayi = random.Next(0,100);
            Console.WriteLine("0-100 Arasında Bir Tahminde Bulunun");
            int tahmin = 0;
            while (tahmin != sayi)
            {
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (sayi > tahmin)
                {
                    Console.WriteLine("Yukarı");

                }
                if (sayi < tahmin)
                {
                    Console.WriteLine("Aşağı");
                }
                
            }
            Console.WriteLine("Doğru Bildiniz");
            Console.ReadKey();
        }
    }
}
