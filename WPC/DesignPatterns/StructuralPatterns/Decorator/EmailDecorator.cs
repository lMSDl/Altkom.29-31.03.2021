using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Decorator
{
    public class EmailDecorator : BaseDecorator
    {
        public EmailDecorator(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine("Wysłano wiadomość Email:" + message);
        }
    }
}
