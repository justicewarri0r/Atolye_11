 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 23, 45, 68, 54, 99, 43, 67 };
            int enBuyuk = sayilar[0];
            int enKucuk = sayilar[1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk = sayilar[i];
                }
                if (enKucuk > sayilar[i])
                {
                    enKucuk = sayilar[i];
                }
            }
            Console.WriteLine("Dizideki en büyük sayı :{0}",enBuyuk);
            Console.WriteLine("Dizideki en küçük sayı :{0}",enKucuk);
            Console.ReadKey();
        }
    }
}
