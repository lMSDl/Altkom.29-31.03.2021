using System;

namespace WPC.DesignPatterns.BehavioralPatterns.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large coffee");
            Context.TransitionTo(new WorkingState(8));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small coffee");
            Context.TransitionTo(new WorkingState(5));
        }

        protected override void Init()
        {
        }
    }
}