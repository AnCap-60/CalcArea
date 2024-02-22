using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLib
{
    public class Triangle : Polygon
    {
        public bool IsRectangular
        {
            get
            {
                var sorted = Sides.Order().ToArray();
                return (sorted[0] * sorted[0] + sorted[1] * sorted[1] - sorted[2] * sorted[2]) < 1e-10;
            }
        }

        public Triangle(params double[] sides) : base(sides)
        {
            ArgumentOutOfRangeException.ThrowIfNotEqual(sides.Length, 3, "Incorrect sides for triangle");

            // Можно было бы сделать проверку каждой стороны на положительность, но это затронуло бы быстродействие
        }

        public override double GetSquare()
        {
            double a = Sides[0], b = Sides[1], c = Sides[2];
            double p = (a + b + c) / 2;
            return Math.Sqrt
            (
                p * (p - a) * (p - b) * (p - c)
            );
        }
    }
}
