using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            _chatMembers.Add(member);
        }

        public void Notify(string nick, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(nick, message, true);
        }

        public void Notify(string nick, string message)
        {
            var member = _chatMembers.SingleOrDefault(x => x.Nick == nick);
            List<ChatMember> list;
            if (member is EchoBotMember)
                list = _chatMembers.OfType<UserMember>().Cast<ChatMember>().ToList();
            else
                list = _chatMembers.Where(x => x.Nick != nick).ToList();

            list.ForEach(x => x.Receive(nick, message, false));
        }

        public void Quit(ChatMember member)
        {
            _chatMembers.Remove(member);
        }
    }
}
