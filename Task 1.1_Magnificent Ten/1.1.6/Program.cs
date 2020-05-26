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
        private enum FontStyle
        {
            Bold = 1,
            Italic = 2,
            Underline = 4,
            None = 0,
        }

        private static void Main()
        {
            FontStyle currentStyle = 0;
            while (true)
            {
                Console.WriteLine("Enter your preferred font style: \n \t 1: Bold \n \t 2: Italic \n \t 3: Underline");
                if (!int.TryParse(Console.ReadLine(), out var input))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                switch (input)
                {
                    case 0:
                        currentStyle = (FontStyle)0;
                        Console.WriteLine($"Current font style is {currentStyle}");
                        break;
                    case 1:
                        currentStyle ^= (FontStyle)1;
                        Console.WriteLine($"Current font style is {currentStyle}");
                        break;
                    case 2:
                        currentStyle ^= (FontStyle)2;
                        Console.WriteLine($"Current font style is {currentStyle}");
                        break;
                    case 3:
                        currentStyle ^= (FontStyle)4;
                        Console.WriteLine($"Current font style is {currentStyle}");
                        break;

                    default:
                        Console.WriteLine($"Current font style is None");
                        break;
                }
            }
        }
    }
}