using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.II
{
    public class Frame : Container
    {
        protected override void Click(bool handled)
        {
            System.Console.WriteLine($"Frame flashing! ({(handled ? "green" : "red")})");
            base.Click(handled);
        }
    }
}
