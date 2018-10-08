namespace L2RKamael.Parser.Pkt
{
    internal class PktBagInfo
    {
        public Packet(PacketReader packet)
        {
            

            byte Type = packet.ReadByte();
            ushort EnabledSlotCount = packet.ReadUInt16();
            ushort ExpandedCount = packet.ReadUInt16();

            ushort ItemCount = packet.ReadUInt16();
            for (int j = 0; j < ItemCount; j++)
            {
                PktItem.Packet(packet);
            }
        }
    }
}