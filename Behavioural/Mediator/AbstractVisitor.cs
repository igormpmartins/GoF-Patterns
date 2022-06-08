using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AbstractVisitor
    {
        protected AbstractChatroom _currentChatroom = null;

        protected string _name = null;

        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{_name} --> {message}");
            _currentChatroom.Send(message, this); 
        }

        public abstract void Receive(string message);

        public void Enter(AbstractChatroom chatroom)
        {
            if (_currentChatroom != null)
                Leave();

            chatroom.Register(this);
            _currentChatroom = chatroom;
       }

        public void Leave()
        {
            if (_currentChatroom != null)
            {
                _currentChatroom.Unregister(this);
                _currentChatroom = null;
            }
        }

    }
}
