using System;

namespace PubSub
{
    public class Satelite
    {
        public string Name { get; set; }

        public event EventHandler<MessagePacket> BroadcastEvent;

        public Satelite(string name)
        {
            Name = name;
        }

        public void Broadcast(string message)
        {
            MessagePacket messagePacket = new MessagePacket();
            messagePacket.Message = message;

            BroadcastEvent?.Invoke(this, messagePacket);
        }
    }
}
