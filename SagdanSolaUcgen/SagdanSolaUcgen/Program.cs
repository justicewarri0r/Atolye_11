using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagdanSolaUcgen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10 - i; a++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c <= i; c++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
