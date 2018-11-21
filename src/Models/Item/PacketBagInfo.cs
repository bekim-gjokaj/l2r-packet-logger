using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    public class PacketBagInfo : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketBagInfo"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketBagInfo(IL2RPacket packet)
        {
            Type = packet.ReadByte();
            EnabledSlotCount = packet.ReadUInt16();
            ExpandedCount = packet.ReadUInt16();
            ItemCount = packet.ReadUInt16();
            for (int j = 0; j < ItemCount; j++)
            {
                ItemList.Add(new PacketItem(packet));
            }
        }

        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the enabled slot count.
        /// </summary>
        /// <value>
        /// The enabled slot count.
        /// </value>
        private ushort EnabledSlotCount { get; set; }

        /// <summary>
        /// Gets or sets the expanded count.
        /// </summary>
        /// <value>
        /// The expanded count.
        /// </value>
        private ushort ExpandedCount { get; set; }

        /// <summary>
        /// Gets or sets the item count.
        /// </summary>
        /// <value>
        /// The item count.
        /// </value>
        private ushort ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the item list.
        /// </summary>
        /// <value>
        /// The item list.
        /// </value>
        private List<PacketItem> ItemList { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        private byte Type { get; set; }
    }
}