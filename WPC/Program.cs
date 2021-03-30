using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.SOLID.L;

namespace WPC
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.CreationalPatterns.FactoryMethod.Client.Execute();

            /*Rectangle rectangle = new Square();

            FillAndCalculate(rectangle, 3, 5);*/

            Console.ReadLine();
        }

        public static void FillAndCalculate(Rectangle rectangle, int a, int b)
        {
            rectangle.A = a;
            rectangle.B = b;

            Console.WriteLine($"{a} * {b} = {rectangle.Area}");
        }
    }
}
