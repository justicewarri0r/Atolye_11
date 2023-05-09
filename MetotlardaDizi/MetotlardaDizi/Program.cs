using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlardaDizi
{
    class Program
    {
        static int dizi(int[] sayi)
        {
            
            int enBuyuk = sayi[0];
            for (int i = 0; i < sayi.Length; i++)
            {
                if (enBuyuk < sayi[i])
                {
                    enBuyuk = sayi[i];
                }

            }
            return enBuyuk;
            

        }

        static void Main(string[] args)
        {
           int[] sayilar = new int[5];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i + 1}. Sayıyı giriniz :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------");
            int enBuyuk = dizi (sayilar);
            Console.WriteLine($"Dizideki en büyük sayı : {enBuyuk}");
            Console.ReadKey();
            
        }
    }
}
