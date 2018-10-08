namespace L2RKamael.Parser.Pkt
{
    internal class PktCharacterStatChangeNotify
    {
        public Packet(PacketReader packet)
        {
            

            packet.Skip(2);
            ulong CharacterUID = packet.ReadUInt64();
            ushort ActorStatCount = packet.ReadUInt16();
            for (int i = 0; i < ActorStatCount; i++)
            {
                //PktActorStatList
                byte StatType = packet.ReadByte();
                int Change = packet.ReadInt32();
                int Value = packet.ReadInt32();
            }
        }
    }
}