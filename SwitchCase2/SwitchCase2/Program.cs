using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Üçgen Alanı");
                Console.WriteLine("2.Daire Alanı");
                Console.WriteLine("3.Dikdörtgen Alanı");
                Console.WriteLine("Lütfen Bir Sayı Giriniz...");
                int secim = Convert.ToInt32(Console.ReadLine());
                //Console.Clear();
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Yükselklik giriniz...");
                        int h1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Taban Uzunluğu giriniz...");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        float ucgenAlan = (float)r1 * (float)h1 / 2;
                        Console.WriteLine($"Üçgenin Alanı = {ucgenAlan}");
                        break;
                    case 2:
                        Console.WriteLine("Yarıçap giriniz...");
                        int r = Convert.ToInt32(Console.ReadLine());
                        float p = 3.14f;
                        float daireAlan = r * r * p;
                        Console.WriteLine($"Dairenin Alanı = {daireAlan}");
                        break;
                    case 3:
                        Console.WriteLine("Yükselklik giriniz...");
                        int h2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Taban Uzunluğu giriniz...");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        int alanDik = h2 * r2;
                        if (h2 == r2)
                        {
                            Console.WriteLine($"Karenin Alanı = {alanDik}");
                        }
                        else
                        {
                            Console.WriteLine($"Dikdörtgenin Alanı = {alanDik}");
                        }
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                        break;
                }
            }
        }
    }
}
