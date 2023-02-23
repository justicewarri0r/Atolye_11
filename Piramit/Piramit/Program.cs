using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Oluşturmak istediğiniz priramitin satır sayısını giriniz:");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                for (int a = 1; a < p-i; a++)
                {
                    Console.Write(" ");
                }
                for (int d = 0; d < (i*2)+1 ; d++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
