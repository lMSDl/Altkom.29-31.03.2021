using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public abstract class BaseVehicleBuilder : IBuilder<Vehicle>
    {
        protected Vehicle _vehicle;

        public BaseVehicleBuilder(Vehicle vehicle)
        {
            _vehicle = new Vehicle();
        }
        public BaseVehicleBuilder() : this(new Vehicle())
        {
        }

        public Vehicle Build()
        {
            return (Vehicle)_vehicle.Clone();
        }
    }
}
