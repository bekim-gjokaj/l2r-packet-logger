using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketLinkDungeon : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketLinkDungeon" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketLinkDungeon(IL2RPacket packet)
        {
            WorldID = packet.ReadUInt64();
            SummonGemID = packet.ReadUInt32();
        }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>

        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the summon gem identifier.
        /// </summary>
        /// <value>
        /// The summon gem identifier.
        /// </value>
        private uint SummonGemID { get; set; }

        /// <summary>
        /// Gets or sets the world identifier.
        /// </summary>
        /// <value>
        /// The world identifier.
        /// </value>
        private ulong WorldID { get; set; }
    }
}