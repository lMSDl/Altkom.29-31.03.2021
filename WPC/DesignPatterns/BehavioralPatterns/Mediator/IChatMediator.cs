using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Mediator
{
    public interface IChatMediator
    {
        void Join(ChatMember member);
        void Quit(ChatMember member);
        void Notify(string nick, string to, string message);
        void Notify(string nick, string message);
    }
}
