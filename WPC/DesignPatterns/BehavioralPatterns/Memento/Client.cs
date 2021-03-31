using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person()
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1989, 12, 12)
            };

            var caretaker = new Caretaker<Person>(person);
            caretaker.Save();
            Console.WriteLine(caretaker);
            
            person.Name = "Ewa Adamska";
            caretaker.Save();
            Console.WriteLine(caretaker);

            person.Name = "Ewa Ewowska";
            Console.WriteLine(person.Name);

            caretaker.Undo(1);
            Console.WriteLine(person.Name);
            Console.WriteLine(caretaker);

            caretaker.Undo();
            Console.WriteLine(person.Name);
            Console.WriteLine(caretaker);

            while (true)
            {
                caretaker.Save();
                Console.WriteLine(caretaker);
            }
        }
    }
}
