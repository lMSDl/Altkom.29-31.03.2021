using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            MessageAbstraction message = new ShortMessageAbstraction();
            message.MessageSender = new SmsGate();

            message.Send(Console.ReadLine());
            message.MessageSender = new EmailGate();
            message.Send(Console.ReadLine());

        }
    }
}
