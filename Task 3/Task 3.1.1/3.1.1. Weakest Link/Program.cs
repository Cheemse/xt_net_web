using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1.Weakest_Link
{ 
  class Program
  {
    private static void Main(string[] args)
    {
        int n = 9;
        var peoples = new Queue<int>(n);

        for (int i = 1; i <= n; i++)
        {
            peoples.Enqueue(i);
        }

        Console.WriteLine();
        FindCircleQueue(peoples);
    }

    private static void FindCircleQueue<T>(Queue<T> peoples)
    {
        int count = peoples.Count;
        int counter = 0;
        bool flag = false;
        do
        {
            var currentValue = peoples.Dequeue();
            Console.Write($"{currentValue} ");

            if ((!flag) && (count != 1))
            {
                peoples.Enqueue(currentValue);
            }

            counter++;
            if (count < counter + 1)
            {
                counter = 0;
                count = peoples.Count;
                Console.WriteLine();
            }

            flag = !flag;
        }
        while (peoples.Count != 0);
    }
           
   }
}