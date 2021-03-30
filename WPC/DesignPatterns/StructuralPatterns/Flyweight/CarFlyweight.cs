using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Flyweight
{
    public class CarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Operate(Car car)
        {
            var shared = JsonConvert.SerializeObject(this);
            var unique = JsonConvert.SerializeObject(car);

            System.Console.WriteLine($"{GetType().Name}: Shared: {shared}; Unique: {unique}");
        }
    }
}
