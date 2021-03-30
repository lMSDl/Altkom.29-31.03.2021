using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private INotification Notification { get; }

        public BaseDecorator(INotification notification)
        {
            Notification = notification;
        }

        public void Send(string message)
        {
            Notification.Send(message);
            ExtraSend(message);
        }

        protected abstract void ExtraSend(string message);
    }
}
