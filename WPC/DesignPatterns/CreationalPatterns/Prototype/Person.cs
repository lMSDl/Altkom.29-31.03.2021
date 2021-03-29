﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Prototype
{
    class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
        public IdInfo IdInfo { get; set; }

        public object Clone() //DeepClone
        {
            var clone = (Person)MemberwiseClone();
            clone.Addresses = new List<string>(Addresses);
            clone.IdInfo = (IdInfo)IdInfo.Clone();

            return clone;
        }
        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }
}
