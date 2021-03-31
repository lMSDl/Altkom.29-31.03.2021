using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<Component, bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled && !Func(Parent))
                base.Click(false);
            else
                base.Click(true);
        }

    }
}
