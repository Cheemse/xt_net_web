using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence");
            string s = Console.ReadLine();

            StringBuilder strb = new StringBuilder(s.Length);
            strb = strb.Append(s);
                   
            strb[0] = Char.ToUpper(strb[0]);
                 for (int i = 0; i < strb.Length - 1; i++)
                 {
                      if (strb[i] == '.' || strb[i] == '!' || strb[i] == '?')
                          strb[i + 2] = Char.ToUpper(strb[i + 2]);
                 }

            Console.WriteLine("Final version of sentence: " + strb);

            Console.ReadKey();
        }
    }
}
