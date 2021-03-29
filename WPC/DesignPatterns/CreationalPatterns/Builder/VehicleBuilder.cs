using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public class VehicleBuilder : BaseVehicleBuilder
    {
        public override IVehicleBuilder<Vehicle> SetDoors(int value)
        {
            _vehicle.Doors = value;
            return this;
        }

        public override IVehicleBuilder<Vehicle> SetEnginePower(int value)
        {
            _vehicle.EnginePower = value;
            return this;
        }

        public override IVehicleBuilder<Vehicle> SetSeats(int value)
        {
            _vehicle.Seats = value;
            return this;
        }

        public override IVehicleBuilder<Vehicle> SetTrunkCapacity(int value)
        {
            _vehicle.TrunkCapacity = value;
            return this;
        }

        public override IVehicleBuilder<Vehicle> SetWheels(int value)
        {
            _vehicle.Wheels = value;
            return this;
        }

        public override Vehicle Build()
        {
            return _vehicle;
        }
    }
}
