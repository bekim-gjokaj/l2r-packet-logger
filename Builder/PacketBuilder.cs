namespace Kamael.Packets.Builder
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class PacketBuilder
    {
        public abstract IL2RPacket GetPacket(ushort PacketID, IL2RPacket RawPacket);

        public abstract void BuildPart();

        public abstract L2RPacket Construct();
    }
}