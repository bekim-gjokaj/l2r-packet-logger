using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketBagListReadResult : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketBagListReadResult"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketBagListReadResult(IL2RPacket packet)
        {
            packet.Skip(2);

            ushort BagCount = packet.ReadUInt16();
            for (int i = 0; i < BagCount; i++)
            {
                BagInfoList.Add(new PacketBagInfo(packet));
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
        /// Gets or sets the bag information list.
        /// </summary>
        /// <value>
        /// The bag information list.
        /// </value>
        private List<PacketBagInfo> BagInfoList { get; set; }
    }
}