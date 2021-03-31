using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.State
{
    public interface IState<T>
    {
        T Context { set; }
        void SmallCoffee();
        void LargeCoffee();
    }
}
