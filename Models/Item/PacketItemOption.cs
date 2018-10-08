using Kamael.Packets.ExtensionMethods;
using System;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    /// <seealso cref="Kamael.Models.IL2RPacket" />
    [Serializable]
    public class PacketItemOption : IL2RPacket
    {
        /// <summary>
        /// Processes the specified packet identifier.
        /// </summary>
        /// <param name="RawPacket">The raw packet.</param>
        /// <returns></returns>
        public PacketItemOption(IL2RPacket packet)
        {
            OptionName = CSV.itemOption.itemOptionName(packet.ReadInt32());
            IOvalue = packet.ReadUInt32();
        }

        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the i ovalue.
        /// </summary>
        /// <value>
        /// The i ovalue.
        /// </value>
        private uint IOvalue { get; set; }

        /// <summary>
        /// Gets or sets the item option.
        /// </summary>
        /// <value>
        /// The item option.
        /// </value>
        private string OptionName { get; set; }
    }
}