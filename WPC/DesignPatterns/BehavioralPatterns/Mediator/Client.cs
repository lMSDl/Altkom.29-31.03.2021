using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            ChatMember user1 = new UserMember("User1");
            ChatMember bot1 = new EchoBotMember("Bot1");
            ChatMember bot2 = new EchoBotMember("Bot2");
            ChatMember bot3 = new EchoBotMember("Bot3");

            user1.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;
            bot3.Chat = chat;

            string @string;
            do
            {
                @string = Console.ReadLine();
                var split = @string.Split(':');
                if (split.Length == 2)
                    user1.Send(split[0], split[1]);
                else
                    user1.Send(@string);

            } while (@string != "quit");
        }
    }
}
