using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.State
{
    public abstract class State : IState<CoffeeMachine>
    {
        private CoffeeMachine context;

        public CoffeeMachine Context
        {
            protected get => context;
            set
            {
                context = value;
                if (context != null)
                    Init();
            }
        }

        public abstract void LargeCoffee();

        public abstract void SmallCoffee();
        protected abstract void Init();
    }
}
