using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DordeBolunen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (ulong a = 4; a < 100; a++)
            {
                if (a % 4 == 0)
                {
                    Console.WriteLine($"{a}");
                }
            }
            Console.ReadKey();
        }
    }
}
