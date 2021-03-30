using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            var objectPool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acquire();
                if (item == null)
                {
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }

            /*var counter = 0;
            while (true)
            {
                if (counter > 1000)
                    continue;
                var item = new Item() { IsVisible = true };
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; counter--; });
                counter++;
            }*/
        }
    }
}
