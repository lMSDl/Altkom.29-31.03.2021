using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public override void Send(string message)
        {
            base.Send(message.Substring(0, 10));
        }
    }
}
