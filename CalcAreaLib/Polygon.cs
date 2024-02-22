using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLib
{
    public abstract class Polygon : Shape
    {
        public double[] Sides { get; }

        public Polygon(params double[] sides)
        {
            ArgumentNullException.ThrowIfNull(sides, "Sides were null");
            ArgumentOutOfRangeException.ThrowIfZero(sides.Length, "Empty, if you don't have sides, use non-Polygon-based classes instead");

            Sides = sides;
        }
    }
}
