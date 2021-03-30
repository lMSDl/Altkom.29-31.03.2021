﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Composite
{
    public class Container : ProductBase
    {
        private readonly ICollection<ProductBase> _content;

        public Container(string name) : base(name)
        {
            _content = new List<ProductBase>();
        }

        public void Add(ProductBase product)
        {
            _content.Add(product);
        }

        public override float GetPrice()
        {
            var price = _content.Sum(x => x.GetPrice());
            System.Console.WriteLine($"Wartość kontenera {Name} to: {price}");
            return price;
        }
    }
}
