using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._10
{
    class Program
    {
        const int l = 4;
        static void ArrPrint(int[,] arr)
        {
            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    Console.Write(arr[i,j] + " ");
        }
        static void Main(string[] args)
        {
            
            int sum = 0;
            int[,] arr = new int[l,l];
            Random r = new Random();

            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    arr[i, j] = r.Next(1,2);

            ArrPrint(arr);
            
            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    if ( (i+j) % 2 == 0)
                        sum += arr[i, j];


            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
