using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler<DiscountHandler>, IDiscountHandler
    {
        public string Name { get; }
        private float _maxDiscount;
        private float _minPrice;

        public DiscountHandler(string name, float maxDiscount, float minPrice, DiscountHandler nextHandler) : base(nextHandler)
        {
            _maxDiscount = maxDiscount;
            _minPrice = minPrice;
            Name = name;
        }

        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public bool Discount(float value, float price)
        {
            if(_maxDiscount >= value && price >= _minPrice)
            {
                Console.WriteLine($"Rabat {value} przyznany przez {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}
