using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Custom_Paint
{
    public abstract class Figure : IFigure
    {
        public abstract string ShowInfo();

        public abstract double Length();
    }
}