using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Dynamic_Array
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            int[] itemsCollection = new int[] { 1, 2, 3 };

            var array = new DynamicArray<int>(itemsCollection);
            array.Add(2);
            Console.WriteLine(array.Capacity);
            Console.WriteLine(array.Length);
        }
    }
}
