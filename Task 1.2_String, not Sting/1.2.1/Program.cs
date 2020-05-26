using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your example sentence");

            string InpEx = Console.ReadLine();
            char[] spl = new char[] {'.', ',', ' ', ':', ';', '?', '!', '"'};
            string[] SplStr = InpEx.Split(spl, StringSplitOptions.RemoveEmptyEntries);

            string processunit = string.Join("", SplStr);
            int average = processunit.Length / SplStr.Length;
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
