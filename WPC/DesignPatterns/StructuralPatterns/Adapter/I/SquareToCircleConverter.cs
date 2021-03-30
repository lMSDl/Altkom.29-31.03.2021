using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.I
{
    public class SquareToCircleConverter
    {
        public static Circle Convert(Square square)
        {
            return new Circle() { Radius = square.Width * (float)Math.Sqrt(2) / 2 };
        }
    }
}
