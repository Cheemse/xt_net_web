using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of levels");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < n - j - 1; k++)
                        Console.Write(' ');

                    for (int k = 0; k < j * 2 + 1; k++)
                        Console.Write('*');

                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}