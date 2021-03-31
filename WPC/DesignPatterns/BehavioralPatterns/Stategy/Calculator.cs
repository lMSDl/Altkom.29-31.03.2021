using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Stategy
{
    public class Calculator
    {
        public ICalcStrategy Strategy { private get; set; }

        public float? Calculate(float value1, float value2)
        {
            return Strategy?.Calc(value1, value2);
        }
    }
}
