namespace L2RKamael.Parser.Pkt
{
    internal class PktBuffInfo
    {
        public Packet(PacketReader packet)
        {
            

            // All of this is wrong but works to get past it.
            ulong SkillUID = packet.ReadUInt64();
            uint SkillID = packet.ReadUInt32();
            uint BuffID = packet.ReadUInt32();
            uint BuffLv = packet.ReadUInt32();
            ushort StackCount = packet.ReadUInt16();
            ulong EndTime = packet.ReadUInt64();
        }
    }
}