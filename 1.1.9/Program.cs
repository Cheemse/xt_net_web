using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._9
{
    class Program
    {   
        
        const int l = 50;
        static void ArrPrint(int[] arr)
        {
            for (int i = 0; i < l; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int sum = 0;
            int[] arr = new int[l];

            for (int i = 0; i < l; i++)
                arr[i] = r.Next(-100,101);
            Console.WriteLine("Array");
            ArrPrint(arr);
            Console.WriteLine();
            
            for (int i = 0; i < l; i++)
                if (arr[i] > 0)
                sum += arr[i];

            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
