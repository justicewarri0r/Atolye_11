using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Elma");
            Console.WriteLine("2.Armut");
            Console.WriteLine("3.Kiraz");
            Console.WriteLine("4.Karpuz");
            Console.WriteLine("Lütfen seçim yapınız (1,2,3,4)");
            int meyve = Convert.ToInt32(Console.ReadLine());
            if (meyve == 1)
            {
                Console.WriteLine("Elma Seçildi");
            }else
            if (meyve == 2)
            {
                Console.WriteLine("Armut Seçildi");
            }else
            if (meyve == 3)
            {
                Console.WriteLine("Kiraz Seçildi");
            }else
            if (meyve == 4)
            {
                Console.WriteLine("Karpuz Seçildi");
            }else
                Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            Console.ReadKey();
        }
    }
}
