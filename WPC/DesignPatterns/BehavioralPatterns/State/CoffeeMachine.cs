using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.State
{
    public class CoffeeMachine
    {
        private IState<CoffeeMachine> _state;

        public CoffeeMachine()
        {
            TransitionTo(new HeatingUpState());
        }

        public void LargeCoffee()
        {
            _state.LargeCoffee();
        }

        public void SmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void TransitionTo(IState<CoffeeMachine> state)
        {
            Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}");
            if(_state != null)
                _state.Context = null;
            _state = state;
            _state.Context = this;
        }


    }
}
