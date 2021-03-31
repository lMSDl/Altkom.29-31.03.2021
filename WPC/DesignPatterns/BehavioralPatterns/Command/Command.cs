using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Command
{
    public abstract class Command : ICommand
    {
        protected Garden _garden;
        protected string _plant;

        public Command(Garden garden, string plant)
        {
            _garden = garden;
            _plant = plant;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}
