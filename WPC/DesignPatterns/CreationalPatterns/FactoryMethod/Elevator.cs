using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class Elevator
    {
        public readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        }

        public void Execute(string action, int floor)
        {
            CreateOperation(action)?.Operate(floor);
        }

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public virtual IElevatorOperation CreateOperation(string action)
        {
            //return (IElevatorOperation)Activator.CreateInstance(Type.GetType($"{GetType().Namespace}.{nameof(Elevator)}{action}"));

            var operation = _operations.ContainsKey(action) ? _operations[action] : null;
            if (operation != null)
                return operation;

            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    operation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    operation = new ElevatorDown();
                    break;
                case nameof(ElevatorGoTo):
                    operation = new ElevatorDown();
                    break;
                default:
                    return null;
            }
            _operations[action] = operation;
            return operation;
        }
    }
}
