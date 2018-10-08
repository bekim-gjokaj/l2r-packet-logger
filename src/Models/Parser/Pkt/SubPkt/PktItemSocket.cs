namespace L2RKamael.Parser.Pkt
{
    internal class PktItemSocket

    {
        public Packet(PacketReader packet)
        {
            

            ulong SoulCrystalID = packet.ReadUInt64();
            string SoulCrystalName = Enum.Item.Enum(packet.ReadUInt32());
            int SoulCrystalEXP = packet.ReadInt32();
            byte SoulCrystalLevel = packet.ReadByte();
            ushort SoulCrystalCount = packet.ReadUInt16();
            for (int i = 0; i < SoulCrystalCount; i++)
            {
                PktItemOption.Packet(packet);
            }
        }
    }
}