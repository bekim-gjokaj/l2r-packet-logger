namespace L2RKamael.Parser.Pkt
{
    internal class PktPktExpDisplayNotify
    {
        public Packet(PacketReader packet)
        {
            

            uint Exp = packet.ReadUInt32();
            uint Bonus = packet.ReadUInt32();
        }
    }
}