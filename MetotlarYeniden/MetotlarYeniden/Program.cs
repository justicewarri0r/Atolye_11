using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarYeniden
{
    class Program
    {
        int i = 0;

        static void selamla4()
        {
            Console.WriteLine("Naber");
        }
        static void islem()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını giriniz");
            Console.WriteLine("1 = selamla");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
        }
        static void gecersizdeger()
        {
            Console.WriteLine(" lütfen geçerli bir değer girin");
        }
        static void Main(string[] args)
        {
            islem();
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                selamla4();
            }
            else
            {
                gecersizdeger();
            }

            Console.ReadKey();
        }
    }
}
