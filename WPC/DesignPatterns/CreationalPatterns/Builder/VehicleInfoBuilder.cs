using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Builder
{
    public class VehicleInfoBuilder : IVehicleBuilder<string>
    {
        public StringBuilder _stringBuilder = new StringBuilder();

        public VehicleInfoBuilder()
        {
            _stringBuilder.Append("Obiekt ma:");
        }

        public void SetDoors(int value)
        {
            _stringBuilder.Append($"{value} drzwi,");
        }

        public void SetEnginePower(int value)
        {
            _stringBuilder.Append($"silnik o mocy {value} HP,");
        }

        public void SetSeats(int value)
        {
            _stringBuilder.Append($"{value} siedzeń,");
        }

        public void SetTrunkCapacity(int value)
        {
            _stringBuilder.Append($"{value}l pojemności bagażnika,");
        }

        public void SetWheels(int value)
        {
            _stringBuilder.Append($"{value} kół,");
        }

        public string Build()
        {
            return _stringBuilder.ToString().Remove(_stringBuilder.Length - 1);
        }
    }
}
