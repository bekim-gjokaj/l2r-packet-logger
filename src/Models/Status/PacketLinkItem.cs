using Kamael.Packets.ExtensionMethods;
using Kamael.Packets.Item;
using System.Collections.Generic;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketLinkItem : IL2RPacket
    {
        /// <summary>
        /// The basic option
        /// </summary>
        private readonly string[] BasicOption = { "", "", "" };

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketLinkItem" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketLinkItem(IL2RPacket packet)
        {
            Level = packet.ReadByte();
            EnchantLevel = packet.ReadByte();
            LimitBreakCount = packet.ReadByte();
            Count = packet.ReadUInt16();
            BasicOptionLength = packet.ReadUInt16();

            for (int k = 0; BasicOptionLength > k; k++)
            {
                ItemOptionList.Add(new PacketItemOption(packet));
            }
            Bind = packet.ReadByte();
            AbilityLevel = packet.ReadByte();
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
        /// Gets or sets the ability level.
        /// </summary>
        /// <value>
        /// The ability level.
        /// </value>
        private byte AbilityLevel { get; set; }

        /// <summary>
        /// Gets or sets the length of the basic option.
        /// </summary>
        /// <value>
        /// The length of the basic option.
        /// </value>
        private ushort BasicOptionLength { get; set; }

        /// <summary>
        /// Gets or sets the bind.
        /// </summary>
        /// <value>
        /// The bind.
        /// </value>
        private byte Bind { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        private ushort Count { get; set; }

        /// <summary>
        /// Gets or sets the enchant level.
        /// </summary>
        /// <value>
        /// The enchant level.
        /// </value>
        private byte EnchantLevel { get; set; }

        /// <summary>
        /// Gets or sets the item option list.
        /// </summary>
        /// <value>
        /// The item option list.
        /// </value>
        private List<PacketItemOption> ItemOptionList { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private byte Level { get; set; }

        /// <summary>
        /// Gets or sets the limit break count.
        /// </summary>
        /// <value>
        /// The limit break count.
        /// </value>
        private byte LimitBreakCount { get; set; }
    }
}