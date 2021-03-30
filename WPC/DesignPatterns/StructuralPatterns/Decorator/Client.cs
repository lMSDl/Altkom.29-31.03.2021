using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            var test = Console.ReadLine();

            INotification notification = new Notification();
            Console.WriteLine("SMS?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new SmsDecorator(notification);
            Console.WriteLine("Email?");
            if (Console.ReadKey().KeyChar == 'y')
                notification = new EmailDecorator(notification);

            notification.Send(test);
        }
    }
}
