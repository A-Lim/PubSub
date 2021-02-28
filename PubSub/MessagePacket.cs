using System;

namespace PubSub
{
    public class MessagePacket: EventArgs
    {
        public string Message { get; set; }

        public DateTime DateTime { get; set; }

        public MessagePacket()
        {
            DateTime = DateTime.Now;
        }
    }
}
