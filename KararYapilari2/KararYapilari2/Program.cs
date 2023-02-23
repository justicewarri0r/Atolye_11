using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari2
{
    class Program
    {
        static void Main(string[] args)
        {
            int malVarligi = 130000;
            if (malVarligi > 1000000){
                
                Console.WriteLine("Zengin");
            }
            if (malVarligi>=100000 && malVarligi < 1000000){
                Console.WriteLine("Orta Halli");
            }
            if (malVarligi < 100000)
            {
                Console.WriteLine("Fakir");
            }
            Console.ReadKey();
        }
    }
}
