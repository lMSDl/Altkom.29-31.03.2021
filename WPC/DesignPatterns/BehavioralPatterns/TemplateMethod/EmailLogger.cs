using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class EmailLogger : Logger<IDisposable>
    {
        protected override void SaveLog(IDisposable service, string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override IDisposable ConnectToService()
        {
            return null;
        }
    }
}
