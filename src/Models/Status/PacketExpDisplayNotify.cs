using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketExpDisplayNotify : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketExpDisplayNotify" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketExpDisplayNotify(IL2RPacket packet)
        {
            Exp = packet.ReadUInt32();
            Bonus = packet.ReadUInt32();
        }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        public uint Bonus { get; set; }

        /// <summary>
        /// Gets or sets the exp.
        /// </summary>
        /// <value>
        /// The exp.
        /// </value>
        public uint Exp { get; set; }
    }
}