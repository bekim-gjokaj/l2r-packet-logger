namespace L2RKamael.Parser.Pkt
{
    internal class PktChatWorldWriteResult
    {
        public Packet(PacketReader packet)
        {
            

            packet.Skip(2);

            Parser.Pkt.PktChat.Packet(packet);
        }
    }
}