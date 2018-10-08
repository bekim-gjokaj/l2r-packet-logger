namespace L2RKamael.Parser.Pkt
{
    internal class PktLinkGuildDungeon
    {
        public Packet(PacketReader packet)
        {
            

            ulong DungeonInfoID = packet.ReadUInt64();
            uint GuildUID = packet.ReadUInt32();
        }
    }
}