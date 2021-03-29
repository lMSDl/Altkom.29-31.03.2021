using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public class Client
    {
        public static void Execute()
        {
            //var vehicle = new Vehicle(4, 5, 4, 500, 100);

            var vehicle = new VehicleInfoBuilder()
            .SetWheels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100)
            .Build();

            Console.WriteLine(vehicle);
        }
    }
}
