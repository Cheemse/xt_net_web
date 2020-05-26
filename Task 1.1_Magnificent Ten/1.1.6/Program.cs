using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._6
{
    class Program
    {
       
            [Flags]
        enum font
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

        static void Main(string[] args)
        {
            int state = 0;

            while (true)
            {
                Console.Write("Параметры надписи: ");

                if (state == 0)
                    Console.Write(font.None);
                else
                {
                    if ((state & (int)font.Bold) != 0)
                        Console.Write(font.Bold + " ");

                    if ((state & (int)font.Italic) != 0)
                        Console.Write(font.Italic + " ");

                    if ((state & (int)font.Underline) != 0)
                        Console.Write(font.Underline + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Введите:");
                Console.WriteLine("\t1: bold");
                Console.WriteLine("\t2: italic");
                Console.WriteLine("\t3: underline");

                int n = int.Parse(Console.ReadLine());
                state ^= (1 << (n - 1));
            }
        }    
    }
}
