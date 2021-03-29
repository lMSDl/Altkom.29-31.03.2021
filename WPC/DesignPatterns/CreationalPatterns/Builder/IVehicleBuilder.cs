using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public interface IVehicleBuilder<T>
    {
        void SetWheels(int value);
        void SetSeats(int value);
        void SetDoors(int value);
        void SetTrunkCapacity(int value);
        void SetEnginePower(int value);
        T Build();
    }
}
