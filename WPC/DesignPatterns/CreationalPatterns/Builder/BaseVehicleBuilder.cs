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
        public abstract void SetDoors(int value);
        public abstract void SetEnginePower(int value);
        public abstract void SetSeats(int value);
        public abstract void SetTrunkCapacity(int value);
        public abstract void SetWheels(int value);
    }
}
