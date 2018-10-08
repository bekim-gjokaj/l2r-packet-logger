namespace L2RKamael.Parser.Pkt
{
    internal class PktAchievementListReadResult
    {
        public Packet(PacketReader packet)
        {
            

            packet.Skip(2);
            ushort AchievementCount = packet.ReadUInt16();
            for (int i = 0; i < AchievementCount; i++)
            {
                PktAchievement.Packet(packet);
            }
            uint AchievementPoints = packet.ReadUInt32();
            uint HeroicLevel = packet.ReadUInt32();
            byte HeroicLevelReward = packet.ReadByte();
            ulong RewardremainTimeSeconds = packet.ReadUInt64();
        }
    }
}