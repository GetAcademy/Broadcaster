using System.Collections.Generic;

namespace Broadcaster.Server
{
    public class MessageServer
    {
        private readonly List<IMessageClient> _clients;

        public MessageServer()
        {
            _clients = new List<IMessageClient>();
        }

        public void Register(IMessageClient messageClient)
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
