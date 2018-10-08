namespace Kamael.Packets
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.L2RPacketBase" />
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class L2RPacket : L2RPacketBase, IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader" /> class.
        /// </summary>
        public L2RPacket()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader" /> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        public L2RPacket(byte[] bytes)
            : this(bytes, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader" /> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="index">The index.</param>
        public L2RPacket(byte[] bytes, int index)
        {
            _bytes = bytes;
            _index = index;
        }
        
    }
}