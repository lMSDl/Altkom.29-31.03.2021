using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Bridge.II
{
    class EmailGate : IMessageSenderImplementation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość wsyłana przez Email: {message}");
        }
    }
}
