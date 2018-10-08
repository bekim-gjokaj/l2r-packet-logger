using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="IL2RPacket" />
    internal class PacketItemSoulCrystal : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketItemSocket" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketItemSoulCrystal(IL2RPacket packet)
        {
            SoulCrystalID = packet.ReadUInt64();
            SoulCrystalName = Enum.Item.Enum(packet.ReadUInt32());
            SoulCrystalEXP = packet.ReadInt32();
            SoulCrystalLevel = packet.ReadByte();
            SoulCrystalCount = packet.ReadUInt16();
            for (int i = 0; i < SoulCrystalCount; i++)
            {
                ItemOptionList.Add(new PacketItemOption(packet));
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

        private List<PacketItemOption> ItemOptionList { get; set; }

        /// <summary>
        /// Gets or sets the socket count.
        /// </summary>
        /// <value>
        /// The socket count.
        /// </value>
        private ushort SoulCrystalCount { get; set; }

        /// <summary>
        /// Gets or sets the soul crystal exp.
        /// </summary>
        /// <value>
        /// The soul crystal exp.
        /// </value>
        private int SoulCrystalEXP { get; set; }

        /// <summary>
        /// Gets or sets the soul crystal identifier.
        /// </summary>
        /// <value>
        /// The soul crystal identifier.
        /// </value>
        private ulong SoulCrystalID { get; set; }

        /// <summary>
        /// Gets or sets the soul crystal level.
        /// </summary>
        /// <value>
        /// The soul crystal level.
        /// </value>
        private byte SoulCrystalLevel { get; set; }

        /// <summary>
        /// Gets or sets the name of the soul crystal.
        /// </summary>
        /// <value>
        /// The name of the soul crystal.
        /// </value>
        private string SoulCrystalName { get; set; }
    }
}