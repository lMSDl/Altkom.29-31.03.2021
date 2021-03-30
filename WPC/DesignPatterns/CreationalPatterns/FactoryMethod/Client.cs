using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new CustomElevator();

            for (int i = 0; i < 3; i++)
            {

            var action = GetAction();
            var floor = GetFloor();
            elevator.Execute(action, floor);
            }

            elevator.Execute("Custom", 5);
        }

        private static int GetFloor()
        {
            return new Random().Next(0, 10);
        }

        private static string GetAction()
        {
            return new string[] { "Down" , "Up", "GoTo" }.OrderBy(x => Guid.NewGuid()).First();
        }
    }
}
