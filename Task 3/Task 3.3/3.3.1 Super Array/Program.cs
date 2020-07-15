using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3._3._1_Super_Array.Extension;

namespace _3._3._1_Super_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 1, 3, 4, 5, 2, 20, 12, 19, 9 };

            

            Console.WriteLine($"Sum of elements in array: {Searcher(array, ElemSum)}");
            Console.WriteLine($"Average in array: {Searcher(array, Average)}");
            Console.WriteLine($"Most frequent element: {Searcher(array, FreqElem)}");
        }
    }
}
