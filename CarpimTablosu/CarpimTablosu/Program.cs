﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                for (int x = 1; x <= 10; x++)
                {  
                    Console.Write($"{x}x{i}={x*i}   ");  
                }
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
