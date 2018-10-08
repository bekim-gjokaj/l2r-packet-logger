namespace L2RKamael.Parser.Pkt
{
    internal class PktChatPartyWriteNotify
    {
        public Packet(PacketReader packet)
        {
            

            //Packet.skip(2);
            Parser.Pkt.PktChat.Packet(packet);
        }
    }
}