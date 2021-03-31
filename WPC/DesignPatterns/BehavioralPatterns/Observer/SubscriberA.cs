using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Observer
{
    public class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            Thread.Sleep(10000);
            if(value < 5)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}
