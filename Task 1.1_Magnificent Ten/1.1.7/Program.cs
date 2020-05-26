using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._7
{
    class Program
    {

        const int n = 15;
        static void MasOutput(int[] mas)
        {
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
          
        }
        static void Main(string[] args)
        {
            int[] mas = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
                 mas[i] = r.Next(0, 101);

            Console.WriteLine("Array example");
            MasOutput(mas);
            Console.WriteLine();

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                max = (max < mas[i]) ? mas[i] : max;
                min = (min > mas[i]) ? mas[i] : min;
            }

            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
                        
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array");

            MasOutput(mas);

            Console.ReadKey();
        }
    }
}
