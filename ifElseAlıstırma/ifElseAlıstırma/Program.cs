using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseAlıstırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1;
            Console.Write("Bir Not Giriniz:");
            not1 = Convert.ToInt32(Console.ReadLine());
            if (not1>=50 && not1<=100)
            {
                Console.WriteLine("Geçti");
            }else
            if (not1 >= 0 && not1<=50)
            {
                Console.WriteLine("Kaldı");
            }else
            {
                Console.WriteLine("Lütfen Geçerli Bir Derğer Giriniz!");
            }

            Console.ReadKey();
        }
    }
}
