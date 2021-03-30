using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Decorator
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine("Wysłano wiadomość SMS:" + message);
        }
    }
}
