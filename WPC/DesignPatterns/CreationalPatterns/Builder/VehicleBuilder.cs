using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public class VehicleBuilder : BaseVehicleBuilder
    {
        public override void SetDoors(int value)
        {
            _vehicle.Doors = value;
        }

        public override void SetEnginePower(int value)
        {
            _vehicle.EnginePower = value;
        }

        public override void SetSeats(int value)
        {
            _vehicle.Seats = value;
        }

        public override void SetTrunkCapacity(int value)
        {
            _vehicle.TrunkCapacity = value;
        }

        public override void SetWheels(int value)
        {
            _vehicle.Wheels = value;
        }

        public override Vehicle Build()
        {
            return _vehicle;
        }
    }
}
