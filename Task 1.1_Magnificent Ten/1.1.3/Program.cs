using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter height of triangle");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    Console.Write(' ');

                for (int j = 0; j < i * 2 + 1; j++)
                    Console.Write('*');

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
