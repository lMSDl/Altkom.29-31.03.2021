using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Prototype
{
    class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                IdInfo = new IdInfo(),
                Addresses = new List<string>() { "00-001 Warszwa", "ul. Krakowska 16" },
            };

            var p2 = (Person)p1.Clone();

            Display(p1);
            Display(p2);
            p2.Name = "Ewa Ewowska";
            p2.IdInfo.IdNumber = Guid.NewGuid();
            p2.Addresses.Clear();
            Display(p1);
            Display(p2);
        }

        public static void Display(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
