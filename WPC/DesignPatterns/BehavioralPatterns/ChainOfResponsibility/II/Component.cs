using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.II
{
    public abstract class Component
    {
        public Component Parent { get; set; }
        public int ClickCounter { get; private set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            ClickCounter++;
            Parent?.Click(handled);
        }
    }
}
