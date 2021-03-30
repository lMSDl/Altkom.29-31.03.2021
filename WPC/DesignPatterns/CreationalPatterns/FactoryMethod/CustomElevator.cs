using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class CustomElevator : Elevator
    {
        public override IElevatorOperation CreateOperation(string action)
        {
            var operation = base.CreateOperation(action);
            if (operation == null)
                operation = new ElevatorCustom();
            return operation;
        }

        public class ElevatorCustom : IElevatorOperation
        {
            public void Operate(int floor)
            {
                Console.WriteLine($"Funckja klienta na piętrze {floor}");
            }
        }
    }
}
