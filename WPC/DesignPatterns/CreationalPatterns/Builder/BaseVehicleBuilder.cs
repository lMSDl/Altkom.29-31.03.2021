using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public abstract class BaseVehicleBuilder : IVehicleBuilder<Vehicle>
    {
        protected Vehicle _vehicle;

        public BaseVehicleBuilder()
        {
            _vehicle = new Vehicle();
        }

        public abstract Vehicle Build();
        public abstract IVehicleBuilder<Vehicle> SetDoors(int value);
        public abstract IVehicleBuilder<Vehicle> SetEnginePower(int value);
        public abstract IVehicleBuilder<Vehicle> SetSeats(int value);
        public abstract IVehicleBuilder<Vehicle> SetTrunkCapacity(int value);
        public abstract IVehicleBuilder<Vehicle> SetWheels(int value);
    }
}
