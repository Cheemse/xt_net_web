using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Game_Development.Barriers
{
    internal class Swamp : Barrier
    {
        public override double X { get; set; }
        public override double Y { get; set; }

        public Swamp(double x, double y)
        {
        }

        public override void Effects()
        {
            throw new NotImplementedException();
        }

        public override double SpeedChanger()
        {
            throw new NotImplementedException();
        }
    }
}