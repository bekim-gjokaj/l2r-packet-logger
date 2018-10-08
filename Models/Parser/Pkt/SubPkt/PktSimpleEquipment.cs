namespace L2RKamael.Parser.Pkt
{
    internal class PktSimpleEquipment
    {
        public Packet(PacketReader packet)
        {
            

            uint ItemInfoID = packet.ReadUInt32();
            byte EnchantLevel = packet.ReadByte();
        }
    }
}