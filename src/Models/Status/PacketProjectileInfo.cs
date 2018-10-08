namespace L2RKamael.Parser.Pkt
{
    internal class PktProjectileInfo
    {
        public Packet(PacketReader packet)
        {
            ulong ProjectileUID = packet.ReadUInt64();
            uint ProjectileID = packet.ReadUInt32();
            uint SkillInfoID = packet.ReadUInt32();
            ulong OwnerUID = packet.ReadUInt64();
            float CurrentXPos = packet.ReadSingle();
            float CurrentYPos = packet.ReadSingle();
            float DestinationXPos = packet.ReadSingle();
            float DestinationYPos = packet.ReadSingle();
            float Speed = packet.ReadSingle();
            float Direction1 = packet.ReadSingle(); // Supposed to be direction
            float Direction2 = packet.ReadSingle(); // but I dont understand it.
            ulong TargetUID = packet.ReadUInt64();
            uint HitRemaiNtime = packet.ReadUInt32();
        }
    }
}