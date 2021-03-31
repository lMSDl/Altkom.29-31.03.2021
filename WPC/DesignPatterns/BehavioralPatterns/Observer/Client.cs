using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Observer
{
    public class Client
    {
        public static void Execute()
        {
            var subject = new Publisher();
                var observerA = new SubscriberA();
                var observerB = new SubscriberB();

            subject.Subscribe(observerA);
            subject.Subscribe(observerB);

            subject.Work();
                subject.Work();

                subject.Work();

                Console.WriteLine("Ręczna zmiana stanu");
                subject.Index = -1;

            subject.Dispose();
        }
    }
}
