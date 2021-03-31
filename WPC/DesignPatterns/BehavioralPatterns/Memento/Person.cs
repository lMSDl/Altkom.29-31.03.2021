using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int[] Photo { get; set; } = new int[1024 * 1024];

        public object Clone()
        {
            var clone = (Person) MemberwiseClone();
            clone.Photo = Photo.ToArray();
            return clone;
        }

        public void Restore(Person state)
        {
            Name = state.Name;
            BirthDate = state.BirthDate;
            Photo = state.Photo;
        }
    }
}