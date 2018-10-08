using System;

namespace Kamael.Packets.Items
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketItemList : IL2RPacket
    {
        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the bag count.
        /// </summary>
        /// <value>
        /// The bag count.
        /// </value>
        private ushort BagCount { get; set; }

        /// <summary>
        /// Gets or sets the type of the bag.
        /// </summary>
        /// <value>
        /// The type of the bag.
        /// </value>
        private byte BagType { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the inven.
        /// </summary>
        /// <value>
        /// The maximum size of the inven.
        /// </value>
        private ushort MaxInvenSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the exp inven.
        /// </summary>
        /// <value>
        /// The size of the exp inven.
        /// </value>
        private ushort ExpInvenSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the used inven.
        /// </summary>
        /// <value>
        /// The size of the used inven.
        /// </value>
        private ushort UsedInvenSize { get; set; }

        /// <summary>
        /// Gets or sets the u item identifier.
        /// </summary>
        /// <value>
        /// The u item identifier.
        /// </value>
        private ulong UItemID { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        private string ItemID { get; set; }

        /// <summary>
        /// Gets or sets the exp.
        /// </summary>
        /// <value>
        /// The exp.
        /// </value>
        private uint Exp { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private byte Level { get; set; }

        /// <summary>
        /// Gets or sets the enchant level.
        /// </summary>
        /// <value>
        /// The enchant level.
        /// </value>
        private byte EnchantLevel { get; set; }

        /// <summary>
        /// Gets or sets the limit break count.
        /// </summary>
        /// <value>
        /// The limit break count.
        /// </value>
        private byte LimitBreakCount { get; set; }

        /// <summary>
        /// Gets or sets the limit break add rate.
        /// </summary>
        /// <value>
        /// The limit break add rate.
        /// </value>
        private byte LimitBreakAddRate { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        private ushort Count { get; set; }

        /// <summary>
        /// Gets or sets the liked.
        /// </summary>
        /// <value>
        /// The liked.
        /// </value>
        private byte Liked { get; set; }

        /// <summary>
        /// Gets or sets the looted time.
        /// </summary>
        /// <value>
        /// The looted time.
        /// </value>
        private DateTime LootedTime { get; set; }

        /// <summary>
        /// Gets or sets the length of the basic option.
        /// </summary>
        /// <value>
        /// The length of the basic option.
        /// </value>
        private ushort BasicOptionLength { get; set; }

        /// <summary>
        /// The basic option
        /// </summary>
        private readonly string[] BasicOption = { "", "", "" };

        /// <summary>
        /// Gets or sets the length of the socket list.
        /// </summary>
        /// <value>
        /// The length of the socket list.
        /// </value>
        private ushort SocketListLength { get; set; }

        /// <summary>
        /// The socket list
        /// </summary>
        private readonly string[] SocketList = { "", "", "", "", "", "" };

        /// <summary>
        /// Gets or sets the bind.
        /// </summary>
        /// <value>
        /// The bind.
        /// </value>
        private byte Bind { get; set; }

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
        /// Gets or sets the craft flag.
        /// </summary>
        /// <value>
        /// The craft flag.
        /// </value>
        private byte CraftFlag { get; set; }

        /// <summary>
        /// Gets or sets the event period identifier.
        /// </summary>
        /// <value>
        /// The event period identifier.
        /// </value>
        private uint EventPeriodID { get; set; }

        /// <summary>
        /// Gets or sets the expire time.
        /// </summary>
        /// <value>
        /// The expire time.
        /// </value>
        private ulong ExpireTime { get; set; }

        /// <summary>
        /// The enchant level plus
        /// </summary>
        private readonly string EnchantLevelPlus = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketItemList"/> class.
        /// </summary>
        public PacketItemList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketItemList" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketItemList(IL2RPacket packet)
        {
            PacketReader pckt = (PacketReader)packet;

            BagCount = pckt.ReadUInt16();
            BagType = pckt.ReadByte();
            MaxInvenSize = pckt.ReadUInt16();
            ExpInvenSize = pckt.ReadUInt16();
            UsedInvenSize = pckt.ReadUInt16();

            for (int j = 0; j < UsedInvenSize; j++)
            {
                UItemID = pckt.ReadUInt64();
                ItemID = Enum.Item.Enum(pckt.ReadUInt32());
                Exp = pckt.ReadUInt32();
                Level = pckt.ReadByte();
                EnchantLevel = pckt.ReadByte();
                LimitBreakCount = pckt.ReadByte();
                LimitBreakAddRate = pckt.ReadByte();
                Count = pckt.ReadUInt16();
                Liked = pckt.ReadByte();
                LootedTime = pckt.ReadDate();
                BasicOptionLength = pckt.ReadUInt16();

                for (int k = 0; BasicOptionLength > k; k++)
                {
                    string ItemOption = CSV.itemOption.itemOptionName(pckt.ReadInt32());
                    uint IOvalue = pckt.ReadUInt32();
                    BasicOption[k] = "\"" + ItemOption + "(+" + IOvalue + ")\"";
                }

                SocketListLength = pckt.ReadUInt16();
                for (int k = 0; SocketListLength > k; k++)
                {
                    ulong SoulCrystalID = pckt.ReadUInt64();
                    string SoulCrystalName = Enum.Item.Enum(pckt.ReadUInt32());
                    int SoulCrystalEXP = pckt.ReadInt32();
                    byte SoulCrystalLevel = pckt.ReadByte();
                    ushort SoulCrystalCount = pckt.ReadUInt16();
                    for (int i = 0; i < SoulCrystalCount; i++)
                    {
                        string ItemOption = CSV.itemOption.itemOptionName(pckt.ReadInt32());
                        uint IOvalue = pckt.ReadUInt32();
                    }
                    SocketList[k] = "\"" + SoulCrystalName + "\"";
                }

                Bind = pckt.ReadByte();
                AbilityLevel = pckt.ReadByte();
                AbilityUpgradeAddRate = pckt.ReadUInt16();
                CraftFlag = pckt.ReadByte();
                EventPeriodID = pckt.ReadUInt32();
                ExpireTime = pckt.ReadUInt64();
                if (EnchantLevel > 0)
                {
                    EnchantLevelPlus = "+" + EnchantLevel + " ";
                }
            }
        }
    }
}