using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.NullObject
{
    public class Client
    {
        public static Output Output { get; set; } = new NullOutput();
        public static void Execute()
        {
            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'c':
                        Output = new ConsoleOutput();
                        break;
                    case 'd':
                        Output = new DebugOutput();
                        break;
                    default:
                        //Output = null;
                        Output = new NullOutput();
                        break;

                }
                /*if(Output != null)
                    Output.Show(Console.ReadLine());
                Output?.Show(Console.ReadLine());*/
                Output.Show(Console.ReadLine());
            }

        }
    }
}
