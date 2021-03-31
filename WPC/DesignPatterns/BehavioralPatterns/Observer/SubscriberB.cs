using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Observer
{
    public class SubscriberB : Subscriber
    {
        public override void OnNext(int value)
        {
            if(value < 2 || value > 8 || value == 5)
                Console.WriteLine($"{GetType().Name}: reaguje na zmianę");
        }
    }
}
