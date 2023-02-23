using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Notunuzu Giriniz...:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Notunuzu Giriniz...:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Notunuzu Giriniz...:");
            int not3 = Convert.ToInt32(Console.ReadLine());
            double ort = (not1 + not2 + not3) / 3;
            if (ort >= 85)
            {
                Console.WriteLine($"Ortalamanız = {ort} 5 aldınız");
            }
            if (ort<= 84 && ort >=70)
            {
                Console.WriteLine($"Ortalamanız = {ort} 4 aldınız");
            }
            if (ort <= 69 && ort >= 60)
            {
                Console.WriteLine($"Ortalamanız = {ort} 3 aldınız");
            }
            if (ort <= 59 && ort >= 50)
            {
                Console.WriteLine($"Ortalamanız = {ort} 2 aldınız");
            }
            if (ort <= 49 && ort >= 0)
            {
                Console.WriteLine($"Ortalamanız = { ort} 1 aldınız");
            }
            Console.WriteLine("Herhangi Tuşa Basınız");
            Console.ReadKey();
        }
    }
}
