namespace Broadcaster.Server
{
    public interface IMessageClient
    {
        void Receive(string text);
    }
}
