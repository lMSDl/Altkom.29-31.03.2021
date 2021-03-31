using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.ChainOfResponsibility.I
{
    public class BaseHandler<T> where T : BaseHandler<T>
    {
        protected T NextHandler { get; }
        public BaseHandler(T nextHandler)
        {
            NextHandler = nextHandler;
        }
    }
}
