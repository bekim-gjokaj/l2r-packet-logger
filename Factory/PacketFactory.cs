namespace Kamael.Packets.Factory
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class PacketFactory
    {
        public abstract IL2RPacket GetPacket(ushort PacketID, IL2RPacket RawPacket);
    }
}