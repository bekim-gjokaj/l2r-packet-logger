namespace Kamael.Packets.Items
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketSimpleEquipment : IL2RPacket
    {
        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketSimpleEquipment"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketSimpleEquipment(IL2RPacket Packet)
        {
            L2RPacket packet = (L2RPacket)Packet;

            ItemInfoID = packet.ReadUInt32();
            EnchantLevel = packet.ReadByte();
        }

        /// <summary>
        /// Gets or sets the enchant level.
        /// </summary>
        /// <value>
        /// The enchant level.
        /// </value>
        private byte EnchantLevel { get; set; }

        /// <summary>
        /// Gets or sets the item information identifier.
        /// </summary>
        /// <value>
        /// The item information identifier.
        /// </value>
        private uint ItemInfoID { get; set; }
    }
}