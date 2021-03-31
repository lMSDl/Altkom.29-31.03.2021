using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Mediator
{
    public class EchoBotMember : ChatMember
    {
        public EchoBotMember(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Chat?.Notify(Nick, from, message);
            else
                Chat?.Notify(Nick, message);
                
        }
    }
}
