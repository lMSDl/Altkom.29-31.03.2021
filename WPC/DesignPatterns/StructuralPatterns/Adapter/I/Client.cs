using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {

            ICircle circle = new Circle() { Radius = 5 };

            Console.WriteLine(Check(circle));

            var square = new Square() { Width = 8 };
            circle = new SquareToCircleAdapter(square);
            Console.WriteLine(Check(circle));
            circle = SquareToCircleConverter.Convert(square);
            Console.WriteLine(Check(circle));
        }

        public static bool Check(ICircle circle)
        {
            return circle.Radius <= 5;
        }
    }
}
