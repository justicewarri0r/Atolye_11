using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSıralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 23, 45, 68, 54, 99, 43, 67 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i]+",");
            }
            Console.ReadKey();
        }
    }
}
