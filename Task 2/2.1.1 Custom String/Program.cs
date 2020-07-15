using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString

{
    class Program
    {
        static void Main(string[] args)
        {
            MyString mystring1 = new MyString("abc");
            MyString mystring2 = new MyString("abf");

            int k = mystring1 < mystring2;

            Console.WriteLine(k);
            
        }
    }
}