using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter sentence modifier");
            string s2 = Console.ReadLine();

            for (int i = 0; i < s1.Length; i++)
                if (s2.Contains(s1.Substring(i, 1)))
                    Console.Write(s1[i].ToString() + s1[i].ToString());

                else
                    Console.Write(s1[i]);

            Console.WriteLine();

            Console.ReadKey();

        }


    }
            
}
