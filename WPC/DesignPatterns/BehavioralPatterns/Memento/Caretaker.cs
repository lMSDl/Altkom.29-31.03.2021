using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private Stack<IMemento<T>> _history = new Stack<IMemento<T>>();
        private T _originator;
        public Caretaker(T originator)
        {
            _originator = originator;
        }
        public void Save()
        {
            Console.WriteLine("Zapisywanie");
            _history.Push(new Memento<T>((T)_originator.Clone()));
        }

        public void Undo()
        {
            if (!_history.Any())
                return;
            var memento = _history.Pop();
            _originator.Restore(memento.State);
        }

        //public void Undo(DateTime dateTime)
        public void Undo(int skip)
        {
            if (!_history.Any())
                return;
            
            var memento = _history.Skip(skip).Take(1).SingleOrDefault();
            if(memento != null)
                _originator.Restore(memento.State);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Posiadam migawki:");
            _history.ToList().ForEach(x => builder.AppendLine(x.DateTime.ToString("U")));
            return builder.ToString();
        }
    }
}
