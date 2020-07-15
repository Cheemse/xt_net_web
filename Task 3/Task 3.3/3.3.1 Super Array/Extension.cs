using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._3._1_Super_Array
{
    public static class Extension
    {
        
        public delegate int ValSearching(int[] array);

        

        public static int Searcher(int[] array, ValSearching valuesSearching)
        {

            return valuesSearching.Invoke(array);
        }

        public static int ElemSum(int[] array)
        {

            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            return sum;
        }

        public static int Average(int[] array)
        {
            return ElemSum(array) / array.Length;
        }

        public static int FreqElem(int[] array)
        {
            int maxCount = 1;
            int PositionOfElem = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    PositionOfElem = i;
                }
            }

            if (PositionOfElem > -1)
            {
                return array[PositionOfElem];
            }
            else
            {
                return -1;
            }

        }
    }
}
