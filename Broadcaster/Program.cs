using System;

namespace Broadcaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new MessageServer();
            var client1 = new MessageClient("Ludvigsen", server);
            var client2 = new MessageClient("Knutsen", server, 50);
            client1.Send("Hallo!");
            client2.Send("Hallo!");
            client1.Send("Hvordan står det til?");
            client2.Send("Bare bra");
            client1.Send("Hei på deg!");
            client2.Send("Hei på deg, Ludvigsen!");
        }
    }
}
