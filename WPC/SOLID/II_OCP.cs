using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID.O
{
    abstract class Shape
    {
        public abstract double Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override double Area => A * A;
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public override double Area => A * B;
    }

    class Circle : Shape
    {
        public int R { get; set; }
        public override double Area => Math.PI*R*R;
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
