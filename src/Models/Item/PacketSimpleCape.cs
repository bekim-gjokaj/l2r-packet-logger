using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketSimpleCape : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketSimpleCape"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketSimpleCape(IL2RPacket packet)
        {
            CapeInfoID = packet.ReadUInt32();
            CapeLevel = packet.ReadUInt16();
            ColorSymbolInfoID = packet.ReadUInt32();
            ColorBackgroundInfoID = packet.ReadUInt32();
        }

        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the cape information identifier.
        /// </summary>
        /// <value>
        /// The cape information identifier.
        /// </value>
        private uint CapeInfoID { get; set; }

        /// <summary>
        /// Gets or sets the cape level.
        /// </summary>
        /// <value>
        /// The cape level.
        /// </value>
        private ushort CapeLevel { get; set; }

        /// <summary>
        /// Gets or sets the color background information identifier.
        /// </summary>
        /// <value>
        /// The color background information identifier.
        /// </value>
        private uint ColorBackgroundInfoID { get; set; }

        /// <summary>
        /// Gets or sets the color symbol information identifier.
        /// </summary>
        /// <value>
        /// The color symbol information identifier.
        /// </value>
        private uint ColorSymbolInfoID { get; set; }
    }
}