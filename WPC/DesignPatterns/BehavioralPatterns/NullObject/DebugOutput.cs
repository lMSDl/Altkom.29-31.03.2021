using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.NullObject
{
    public class DebugOutput : Output
    {
        public override void Show(string message)
        {
            Debug.Write(message);
        }
    }
}
