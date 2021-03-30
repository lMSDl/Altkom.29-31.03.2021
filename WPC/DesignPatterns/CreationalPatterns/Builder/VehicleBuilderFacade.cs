using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public class VehicleBuilderFacade : BaseVehicleBuilder
    {
        public VehicleBuilderFacade()
        {
        }

        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }



        public VehicleBuilder Components => new VehicleBuilder(_vehicle);
        public VehicleManufacturingInfoBuilder Manufacturing => new VehicleManufacturingInfoBuilder(_vehicle);
    }
}
