﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height of triangle");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                   
            }
            Console.ReadKey();
        }
    }     
}
