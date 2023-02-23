using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            not1 = 60;
            not2 = 50;
            not3 = 30;
            if (((not1 + not2 + not3) / 3) >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
        Console.ReadKey();
        }
    }
}
