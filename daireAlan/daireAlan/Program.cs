using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float p = 3.14f;
            float r = 10;
            float alan = r * r * p;
            float cevre = 2 * r * p;
            Console.WriteLine($"alan = {alan}");
            Console.WriteLine($"cevre = {cevre}");
            Console.Read();

        }
    }
}
