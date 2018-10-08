namespace L2RKamael.Parser.Pkt
{
    internal class PktChatGuildWriteResult
    {
        public Packet(PacketReader packet)
        {
            

            packet.Skip(2);

            ulong LastChatID = packet.ReadUInt64();
            ushort numMessages = packet.ReadUInt16();

            for (int i = 0; i < numMessages; i++)
            {
                Parser.Pkt.PktChat.Packet(packet);
            }
        }
    }
}