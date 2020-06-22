using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Game_Development
{
    public abstract class Bonus : IGameObject, IMove, ITarget
    {
        public abstract double X { get; set; }
        public abstract double Y { get; set; }

        public abstract void Effects();

        public abstract double SpeedChanger();

        public abstract double XChanger(double x);

        public abstract double YChanger(double y);
    }
}
