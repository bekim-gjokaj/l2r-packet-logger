namespace L2RKamael.Parser.Pkt
{
    internal class PktSimpleCape
    {
        public Packet(PacketReader packet)
        {
            

            uint CapeInfoID = packet.ReadUInt32();
            ushort CapeLevel = packet.ReadUInt16();
            uint ColorSymbolInfoID = packet.ReadUInt32();
            uint ColorBackgroundInfoID = packet.ReadUInt32();
        }
    }
}