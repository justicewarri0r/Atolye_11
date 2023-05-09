using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlan
{
    class Program
    {
        //static void diktorgenAlan(int u,int k)
        //{
        //    int alan = u * k;
        //    Console.WriteLine($"Dikdörtgen Alan = {alan}");
        //}
        static int diktorgenAlan(int u, int k)
        {
            int alan = u * k;
            return  alan;
            
        }
        static void Main(string[] args)
        {
            int alan = diktorgenAlan(10, 20);
            Console.WriteLine($"Dikdörtgen Alan = {alan}");
            Console.ReadKey();
        }
    }
}
