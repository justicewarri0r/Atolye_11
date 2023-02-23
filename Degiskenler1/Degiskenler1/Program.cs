using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 34;
            byte y = 5;
            int toplam = x + y;
            Console.WriteLine($"toplam        = {toplam}");
            int carpim = x * y;
            Console.WriteLine("çarpım sonucu = {0}",carpim);
            Console.WriteLine($"çarpım sonucu = {carpim}");
            float bolum = (float)x / (float)y;
            Console.WriteLine($"bölüm sonucu  = {bolum}");
            int fark = x - y;
            Console.WriteLine($"fark          = {fark}");
            x = 10;
            y = 3;
            byte z = 2;
            int sonuc = (x + y) * z;
            Console.WriteLine($"işlem sonucu= {sonuc}");
            sonuc = x + y * z;
            Console.WriteLine($"parantezsiz işlem sonucu= {sonuc}");
            sonuc = (int)Math.Pow(x, y);
            Console.WriteLine($"{x} üssü {y} = {sonuc}");
            Console.ReadKey();
        }
    }
}
