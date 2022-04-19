using System.Collections.Generic;

namespace Broadcaster
{
    internal class MessageServer
    {
        private readonly List<MessageClient> _clients;

        public MessageServer()
        {
            _clients = new List<MessageClient>();
        }

        public void Register(MessageClient messageClient)
        {
            _clients.Add(messageClient);
        }

        public void Send(string client, string message)
        {
            var text = $"{client}> {message}";
            foreach (var messageClient in _clients)
            {
                messageClient.Receive(text);
            }
        }
    }
}
