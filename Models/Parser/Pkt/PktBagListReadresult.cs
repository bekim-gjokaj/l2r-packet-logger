namespace L2RKamael.Parser.Pkt
{
    internal class PktBagListReadResult
    {
        public Packet(PacketReader packet)
        {
            

            packet.Skip(2);

            ushort BagCount = packet.ReadUInt16();
            for (int i = 0; i < BagCount; i++)
            {
                PktBagInfo.Packet(packet);
            }
        }
    }
}