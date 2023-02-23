using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arabalar = new string[5];
            arabalar [0]= "Bmw";
            arabalar[1] = "Tesla";
            arabalar[2] = "Mercedes";
            arabalar[3] = "Togg";
            arabalar[4] = "Lamborghini";
            string[] cars = { "Lamborghini", "Rolce Royce", "Maserati", "Mustang", "Porsche", "Koenigsegg", "Mclaren", "Aston Martin", "GTR", "SUPRAAAAAA" };
            Console.WriteLine("Cars.lenght :"+cars.Length);
            for (int c = 0; c < cars.Length; c++)
            {
                Console.WriteLine(cars[c]);
            }
            Console.ReadKey();   
        }
    }
}
