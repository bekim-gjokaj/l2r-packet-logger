namespace L2RKamael.Parser.Pkt
{
    internal class PktItemOption

    {
        public Packet(PacketReader packet)
        {
            

            string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
            uint IOvalue = packet.ReadUInt32();
        }
    }
}