using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrtalama
{
    class Program
    {
        static double ort (int a,int b,int c,int d)
        {
            double  sonuc = (a + b + c + d)/4.0;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama hesaplama programına hoşgeldiniz.");
            Console.WriteLine("Lütfen ortalamasını almak isdeğiniz 4 değeri sırasıyla giriniz.");
            int a, b, c, d;
            Console.Write("1. sayıyı giriniz...");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz...");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı giriniz...");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("4. sayıyı giriniz...");
            d = Convert.ToInt32(Console.ReadLine());
            double cevap = ort (a,b,c,d);
            Console.WriteLine($"Ortalama:{cevap}");
            Console.ReadKey();

        }
    }
}
