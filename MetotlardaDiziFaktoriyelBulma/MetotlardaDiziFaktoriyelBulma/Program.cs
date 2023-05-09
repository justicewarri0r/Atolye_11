using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlardaDiziFaktoriyelBulma
{
    class Program
    {
        static int faktoriyel(int sayi)
        {
            
            int f = 1;

            for (int i = 1; i <= sayi; i++)
            {
                f = f * i;
            }

            return f;
        }
        static void Main(string[] args)
        {
            Console.Write("Faktoriyelinin hesaplanmasını istediğiniz sayıyı giniz:");
            int hectorsalamanca = faktoriyel(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(hectorsalamanca);
            Console.ReadKey();
        }
    }
}
