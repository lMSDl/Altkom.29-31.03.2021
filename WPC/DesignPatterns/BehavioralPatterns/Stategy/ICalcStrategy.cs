using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Stategy
{
    public interface ICalcStrategy
    {
        float Calc(float value1, float value2);
    }
}
