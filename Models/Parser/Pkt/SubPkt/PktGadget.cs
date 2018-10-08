namespace L2RKamael.Parser.Pkt
{
    internal class PktGadget
    {
        public Packet(PacketReader packet)
        {
            

            ulong GadgetUID = packet.ReadUInt64();
            uint GadgetID = packet.ReadUInt32();
            float XPos = packet.ReadSingle();
            float YPos = packet.ReadSingle();
            float ZPos = packet.ReadSingle();
            float Direction = packet.ReadSingle();
            byte Active = packet.ReadByte();
            string OwnerName = packet.ReadString();//This is a guess
            uint RemainCount = packet.ReadUInt32();
        }
    }
}