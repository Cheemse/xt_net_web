using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._8
{
    class Program
    {

        const int l = 3;

        static void ArrPrint(int[,,] arr)
        {
            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    for (int k = 0; k < l; k++)
                        Console.Write(arr[i, j, k] + " ");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {   
            
            Random r = new Random();

            int[,,] arr = new int[l,l,l];
            
            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    for (int k = 0; k < l; k++)
                    {
                        arr [i, j, k] = r.Next(-100,101);  
                    }
            Console.WriteLine("Example of array");
            ArrPrint(arr);
            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    for (int k = 0; k < l; k++)
                        arr[i, j, k] = (arr[i, j, k] > 0) ? 0 : arr[i, j, k];
            Console.WriteLine("New version of array");
            ArrPrint(arr);
            Console.ReadKey();
        }
    }
}
