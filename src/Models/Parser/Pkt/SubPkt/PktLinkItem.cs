namespace L2RKamael.Parser.Pkt
{
    internal class PktLinkItem
    {
        public Packet(PacketReader packet)
        {
            

            byte Level = packet.ReadByte();
            byte EnchantLevel = packet.ReadByte();
            byte LimitBreakCount = packet.ReadByte();
            ushort Count = packet.ReadUInt16();
            ushort BasicOptionLength = packet.ReadUInt16();
            string[] BasicOption = { "", "", "" };
            for (int k = 0; BasicOptionLength > k; k++)
            {
                PktItemOption.Packet(packet);
            }
            byte Bind = packet.ReadByte();
            byte AbilityLevel = packet.ReadByte();
        }
    }
}