namespace L2RKamael.Packets.Status
{
    internal class PacketSightEnterNotify : IL2RPacket
    {
        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        public PacketSightEnterNotify(IL2RPacket packet)
        {
        }
    }
}