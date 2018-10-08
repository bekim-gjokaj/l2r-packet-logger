namespace L2RKamael.Parser.Pkt
{
    internal class PktGroundObjectInfo
    {
        public Packet(PacketReader packet)
        {
            

            ulong GroundObjectUID = packet.ReadUInt64();
            uint GroundObjectID = packet.ReadUInt32();
            uint SkillInfoID = packet.ReadUInt32();
            ulong OwnerUID = packet.ReadUInt64();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            uint ElapsedTime = packet.ReadUInt32();
        }
    }
}