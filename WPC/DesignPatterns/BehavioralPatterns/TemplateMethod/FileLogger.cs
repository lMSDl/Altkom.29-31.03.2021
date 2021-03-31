using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class FileLogger : Logger<FileService>
    {
        protected override void SaveLog(FileService service, string messageToLog)
        {
            service.Write(messageToLog);
        }

        protected override FileService ConnectToService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
    }
}
