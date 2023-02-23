using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsimTekrarla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen İsim Giriniz : ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine($"{isim}");
            }
            Console.ReadKey();
        }
    }
}
