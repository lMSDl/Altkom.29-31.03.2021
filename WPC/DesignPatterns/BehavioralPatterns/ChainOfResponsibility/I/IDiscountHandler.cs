using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        bool Discount(float value, float price);
    }
}
