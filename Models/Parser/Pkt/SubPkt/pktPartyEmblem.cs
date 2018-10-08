namespace L2RKamael.Parser.Pkt
{
    internal class pktPartyEmblem
    {
        public Packet(PacketReader packet)
        {
            

            string PartyName = packet.ReadString();
            byte Bool = packet.ReadByte();
        }
    }
}