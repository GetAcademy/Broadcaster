using System;
using System.Text;

namespace Broadcaster
{
    internal class MessageClient
    {
        private readonly string _name;
        private readonly MessageServer _messageServer;
        private int _col;
        private int _messageCount = 0;

        public MessageClient(string name, MessageServer messageServer, int col = 0)
        {
            _col = col;
            _name = name;
            _messageServer = messageServer;
            _messageServer.Register(this);
            Receive($"** {_name} **");
        }

        public void Receive(string message)
        {
            Console.CursorLeft = _col;
            Console.CursorTop = _messageCount;
            Console.WriteLine(message);
            _messageCount++;
        }

        public void Send(string message)
        {
            _messageServer.Send(_name, message);
        }
    }
}
