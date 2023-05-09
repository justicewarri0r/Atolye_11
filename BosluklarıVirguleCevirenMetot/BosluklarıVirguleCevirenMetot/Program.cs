using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosluklarıVirguleCevirenMetot
{
    class Program
    {
        static void dontUseSpace(string kelime)
        {
            string yedek =kelime.Replace(" ", ",");
            Console.WriteLine(yedek);
        }
        static void Main(string[] args)
        {
            Console.Write("Boşluklarını virgül yapmak isteginiz cümleyi yazınız...");
            dontUseSpace(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
