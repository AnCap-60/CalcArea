using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLib
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public override double GetSquare() => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(radius, 0.0);

            Radius = radius;
        }
    }
}
