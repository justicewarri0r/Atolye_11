using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarYıldızKoy
{
    class Program
    {
        static void yıldızkoy (string isim)
        {
            for(int i = 0; i < isim.Length; i++)
            {
                Console.Write($"{isim[i]}*");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Kullanmak istediğiniz ismi girin:");
            yıldızkoy(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
