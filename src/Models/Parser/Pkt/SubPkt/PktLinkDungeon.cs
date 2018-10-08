namespace L2RKamael.Parser.Pkt
{
    internal class PktLinkDungeon
    {
        public Packet(PacketReader packet)
        {
            

            ulong WorldID = packet.ReadUInt64();
            uint SummonGemID = packet.ReadUInt32();
        }
    }
}