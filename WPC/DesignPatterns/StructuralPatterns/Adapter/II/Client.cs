using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            var service = new DbPeopleService();
            service.Get().Select(x => new DbPersonAdapter(x)).ToList().ForEach(ToString);

            var adapter = new DbPeopleServiceAdapter(service);
            adapter.Get().ToList().ForEach(ToString);
        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
