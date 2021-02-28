using System;

namespace PubSub
{
    public class Radar
    {
        public void Subscribe(Satelite satelite)
        {
            satelite.BroadcastEvent += ShowMessage;
        }

        public void Unsubcribe(Satelite satelite)
        {
            satelite.BroadcastEvent -= ShowMessage;
        }

        public void SendMessage(Satelite satelite, string message)
        {
            satelite.Broadcast(message);
        }

        public void ShowMessage(object sender, MessagePacket messagePacket)
        {
            Satelite satelite = (Satelite) sender;
            Console.WriteLine("Inbound message from: " + satelite.Name);
            Console.WriteLine(StringExtension.SateliteTransmissionFormat(messagePacket.Message, messagePacket.DateTime));
        }
    }
}
