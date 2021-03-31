using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string> { "a", "b", "c", "d", "e" };

            var buffer = new Buffer<string>(list);

            //list.ToObservable().Buffer(2, 1).Where(x => x.Count == 2).ForEach(x => Console.WriteLine((x[0] + x[1])));

            var list2 = new List<string>();
            var iterator = buffer.GetEnumerator();
            while(iterator.MoveNext())
            {
                var element = iterator.Current;
                list2.Add(element.Item1 + element.Item2);
                Console.WriteLine(list2.Last());
            }

            foreach(var item in new Buffer<string>(list2))
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }
        }
    }
}
