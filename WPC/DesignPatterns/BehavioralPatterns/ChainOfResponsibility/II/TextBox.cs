using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.II
{
    public class TextBox : Container
    {
        public string InputText { get; set; }

        protected override void Click(bool handled)
        {
            if(!handled)
            {
                Console.WriteLine("TextBox has focus");
            }
            base.Click(true);
        }
    }
}
