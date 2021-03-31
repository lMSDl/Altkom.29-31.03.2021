using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Command
{
    public class CommandInvoker
    {
        private ICommand _command;
        private static readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }

        public static void Undo()
        {
            if(_commands.Any())
                _commands.Pop().Undo();
        }
    }
}
