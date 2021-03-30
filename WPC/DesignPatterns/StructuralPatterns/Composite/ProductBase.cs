﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Composite
{
    public abstract class ProductBase : IComponent
    {
        public string Name { get; }

        protected ProductBase(string name)
        {
            Name = name;
        }

        public abstract float GetPrice();
    }
}
