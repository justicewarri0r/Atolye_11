using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari3
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1 = 40;
            int not2 = 45;
            int not3 = 100;
            int ortalama = (not1 + not2 + not3)/ 3;
            if (not1>=50 && not2 >=50 && not3 >= 50)
            {
                Console.WriteLine("Öğrenci sınıfı geçmiştir....");
            }
            if (ortalama >=50)
                {
                Console.WriteLine("Öğrenci sınıfı ortalama ile geçmiştir....");
            }
            Console.ReadKey();
        }
    }
}
