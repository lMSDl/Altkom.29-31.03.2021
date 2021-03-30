using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Flyweight
{
    public class CarFlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public CarFlyweightFactory(IEnumerable<CarFlyweight> flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => Generatekey(x));
        }

        private string Generatekey(CarFlyweight carFlyweight)
        {
            return string.Join("_", carFlyweight.GetType().GetProperties().OrderBy(x => x.Name).Select(x => x.GetValue(carFlyweight).ToString()));
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"{GetType().Name}: Posiadamy {_flyweights.Count} elementów:");
            _flyweights.ToList().ForEach(x => Console.WriteLine(x.Key));
        }

        public CarFlyweight GetFlyweight(CarFlyweight flyweight)
        {
            var key = Generatekey(flyweight);

            if (_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"{GetType().Name}: Używamy istniejącego elementu ({key})");
                return _flyweights[key];
            }

            Console.WriteLine($"{GetType().Name}: Składujemy element ({key})");
            _flyweights.Add(key, flyweight);
            return flyweight;
        }
    }
}
