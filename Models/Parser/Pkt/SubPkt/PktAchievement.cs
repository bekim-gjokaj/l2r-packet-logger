namespace L2RKamael.Parser.Pkt
{
    internal class PktAchievement
    {
        public Packet(PacketReader packet)
        {
            

            byte EAchievementType = packet.ReadByte();
            uint AchievementInfoID = packet.ReadUInt32();
            byte EAchievementState = packet.ReadByte();
            uint TaskParam = packet.ReadUInt32();
        }
    }
}