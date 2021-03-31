using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Memento
{
    public interface IMemento<T>
    {
        T State { get; }
        DateTime DateTime { get; }
    }
}
