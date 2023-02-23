using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziyeElemanGirme
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0, ortalama = 0;
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i+1}. Sayıyı giriniz :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------------------------");
            Array.Sort(sayilar);
            for(int j=0; j < sayilar.Length; j++)
            {
                Console.WriteLine($"{j+1}. Sayı : {sayilar[j]}");
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                toplam = toplam + sayilar[i];
            }
            Console.WriteLine("----------------------------");
            ortalama = toplam / sayilar.Length;
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ortalama : " + ortalama);
            Console.ReadKey();
        }
    }
}