namespace L2RKamael.Parser.Pkt
{
    internal class PktVector
    {
        

        public Packet(PacketReader packet)
        {
            float DestinationXPos = packet.ReadSingle();
            float DestinationYPos = packet.ReadSingle();
        }
    }
}