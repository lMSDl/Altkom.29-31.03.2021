using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Bridge
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            shape.Color = new RedColor();
            shape.Color.Brightness = new Dark();

            Console.WriteLine(shape);

        }
    }
}
