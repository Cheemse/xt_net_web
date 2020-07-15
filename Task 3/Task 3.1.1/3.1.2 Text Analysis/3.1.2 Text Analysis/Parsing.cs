using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2_Text_Analysis
{
    public class Parsing : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return string.Compare(x, y, true) == 0;
        }

        public int GetHashCode(string obj)
        {
            return obj.Length;
        }
    }
}
