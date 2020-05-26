using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence");
            string InpEx = Console.ReadLine();
            char[] spl = new char[] { '.', ',', ' ', ':', ';', '?', '!', '"' };
            string[] SplStr = InpEx.Split(spl, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            for (int i = 0; i < SplStr.Length; i++)
            {
                if (char.IsLower(SplStr[i][0]))
                    
                    sum++;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
