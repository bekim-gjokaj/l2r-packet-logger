using Kamael.Packets.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    /// <seealso cref="Kamael.Models.IL2RPacket" />
    [Serializable]
    public class PacketItem : IL2RPacket
    {
        /// <summary>
        /// The packet identifier
        /// </summary>
        public ushort PacketId = 203;

        /// <summary>
        /// The socket list
        /// </summary>
        private readonly string[] SocketList = { "", "", "", "", "", "" };

        /// <summary>
        /// The item options
        /// </summary>
        private List<PacketItemOption> ItemOptions = new List<PacketItemOption>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketItem"/> class.
        /// </summary>
        public PacketItem()
        {
        }

        /// <summary>
        /// Processes the specified packet identifier.
        /// </summary>
        /// <param name="RawPacket">The raw packet.</param>
        /// <returns></returns>
        public PacketItem(IL2RPacket packet)
        {
            UItemID = packet.ReadUInt64();
            ItemID = Enum.Item.Enum(packet.ReadUInt32());
            Exp = packet.ReadUInt32();
            Level = packet.ReadByte();
            EnchantLevel = packet.ReadByte();
            LimitBreakCount = packet.ReadByte();
            LimitBreakAddRate = packet.ReadByte();
            Count = packet.ReadUInt16();
            Liked = packet.ReadByte();
            //LootedTime = packet.ReadDate();
            BasicOptionLength = packet.ReadUInt16();
            Bind = packet.ReadByte();
            AbilityLevel = packet.ReadByte();
            AbilityUpgradeAddRate = packet.ReadUInt16();
            CraftFlag = packet.ReadByte();
            EventPeriodID = packet.ReadUInt32();
            ExpireTime = packet.ReadUInt64();
            SocketListLength = packet.ReadUInt16();

            for (int k = 0; BasicOptionLength > k; k++)
            {
                ItemOptions.Add(new PacketItemOption(packet));
            }

            for (int k = 0; SocketListLength > k; k++)
            {
                SocketID = packet.ReadUInt64();
                SocketName = Enum.Item.Enum(packet.ReadUInt32());
                packet.Skip(4);
                SocketList[k] = "\"" + SocketName + "\"";
                SoulCrystalCount = packet.ReadUInt16();
                packet.Skip(1);
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
        /// Gets or sets the ability level.
        /// </summary>
        /// <value>
        /// The ability level.
        /// </value>
        private byte AbilityLevel { get; set; }

        /// <summary>
        /// Gets or sets the ability upgrade add rate.
        /// </summary>
        /// <value>
        /// The ability upgrade add rate.
        /// </value>
        private ushort AbilityUpgradeAddRate { get; set; }

        /// <summary>
        /// Gets or sets the basic option.
        /// </summary>
        /// <value>
        /// The basic option.
        /// </value>
        private string[] BasicOption { get; set; }

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
        /// Gets or sets the craft flag.
        /// </summary>
        /// <value>
        /// The craft flag.
        /// </value>
        private byte CraftFlag { get; set; }

        /// <summary>
        /// Gets or sets the enchant level.
        /// </summary>
        /// <value>
        /// The enchant level.
        /// </value>
        private byte EnchantLevel { get; set; }

        /// <summary>
        /// Gets or sets the event period identifier.
        /// </summary>
        /// <value>
        /// The event period identifier.
        /// </value>
        private uint EventPeriodID { get; set; }

        /// <summary>
        /// Gets or sets the exp.
        /// </summary>
        /// <value>
        /// The exp.
        /// </value>
        private uint Exp { get; set; }

        /// <summary>
        /// Gets or sets the expire time.
        /// </summary>
        /// <value>
        /// The expire time.
        /// </value>
        private ulong ExpireTime { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        private string ItemID { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private byte Level { get; set; }

        /// <summary>
        /// Gets or sets the liked.
        /// </summary>
        /// <value>
        /// The liked.
        /// </value>
        private byte Liked { get; set; }

        /// <summary>
        /// Gets or sets the limit break add rate.
        /// </summary>
        /// <value>
        /// The limit break add rate.
        /// </value>
        private byte LimitBreakAddRate { get; set; }

        /// <summary>
        /// Gets or sets the limit break count.
        /// </summary>
        /// <value>
        /// The limit break count.
        /// </value>
        private byte LimitBreakCount { get; set; }

        /// <summary>
        /// Gets or sets the looted time.
        /// </summary>
        /// <value>
        /// The looted time.
        /// </value>
        private DateTime LootedTime { get; set; }

        /// <summary>
        /// Gets or sets the socket identifier.
        /// </summary>
        /// <value>
        /// The socket identifier.
        /// </value>
        private ulong SocketID { get; set; }

        /// <summary>
        /// Gets or sets the length of the socket list.
        /// </summary>
        /// <value>
        /// The length of the socket list.
        /// </value>
        private ushort SocketListLength { get; set; }

        /// <summary>
        /// Gets or sets the name of the socket.
        /// </summary>
        /// <value>
        /// The name of the socket.
        /// </value>
        private string SocketName { get; set; }

        /// <summary>
        /// Gets or sets the socket count.
        /// </summary>
        /// <value>
        /// The socket count.
        /// </value>
        private ushort SoulCrystalCount { get; set; }

        /// <summary>
        /// Gets or sets the u item identifier.
        /// </summary>
        /// <value>
        /// The u item identifier.
        /// </value>
        private ulong UItemID { get; set; }
    }
}