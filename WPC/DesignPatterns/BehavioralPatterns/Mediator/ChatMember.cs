﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Mediator
{
    public abstract class ChatMember
    {
        public string Nick { get; }
        private IChatMediator _chat;

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public IChatMediator Chat
        {
            get => _chat;
            set
            {
                if (_chat != null)
                    _chat.Quit(this);
                _chat = value;
                if (_chat != null)
                    _chat.Join(this);
            }
        }

        public void Send(string message)
        {
            Chat?.Notify(Nick, message);
        }
        public void Send(string to, string message)
        {
            Chat?.Notify(Nick, to, message);
        }

        public virtual void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Console.WriteLine($"{from} to {Nick}: {message}");
            else
                Console.WriteLine($"{from}: {message}");
        }
    }
}
