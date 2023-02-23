using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre = "bjk";
            for(int i=0; i < 3; i++)
            {
                Console.Write("Şifre Giriniz... :");
                string sifreGir = Console.ReadLine();
                if (sifre == sifreGir)
                {
                    Console.WriteLine("Şifre Başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("Şifre Yanlış");
                    Console.WriteLine($"{2-i} hakkınız kaldı");
                }
            }
            Console.ReadKey();
        }
    }
}
