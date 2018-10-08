namespace L2RKamael.Parser.Pkt
{
    internal class PktAppearance
    {
        public Packet(PacketReader packet)
        {
            

            byte HairID = packet.ReadByte();
            byte HairStyleID = packet.ReadByte();
            byte HairColorID = packet.ReadByte();
        }
    }
}