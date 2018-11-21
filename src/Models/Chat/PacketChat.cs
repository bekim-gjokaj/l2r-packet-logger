using Kamael.Packets.ExtensionMethods;
using Kamael.Packets.Status;
using System;
using System.Collections.Generic;

namespace Kamael.Packets.Chat
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketChat : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketChat" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketChat(IL2RPacket packet)
        {
            ChatUID = packet.ReadUInt64();
            PlayerUID = packet.ReadUInt64();
            PlayerName = packet.ReadString();
            Race = CSV.race.RaceName(packet.ReadInt32());
            PlayerClass = CSV.Class.className(packet.ReadUInt32());
            //MsgTime = packet.ReadDate();
            Message = packet.ReadString();
            Level = packet.ReadUInt16();
            EmblemSymbolID = packet.ReadUInt32();
            EmblemBackgroundID = packet.ReadUInt32();

            LinkWorldBossID = packet.ReadUInt32();
            LinkWorldBossDieID = packet.ReadUInt32();
            LinkWorldBossDespawnID = packet.ReadUInt32();

            LinkItem = packet.ReadUInt16();
            if (LinkItem > 0)
            {
                LinkItemList.Add(new PacketLinkItem(packet));
            }

            ushort LinkDungeon = packet.ReadUInt16();
            if (LinkDungeon > 0)
            {
                LinkDungeonList.Add(new PacketLinkDungeon(packet));
            }

            ushort LinkGuildDungeon = packet.ReadUInt16();
            if (LinkGuildDungeon > 0)
            {
                LinkGuildList.Add(new PacketLinkGuildDungeon(packet));
            }

            LinkVoice = packet.ReadString();
            LinkType = packet.ReadByte();
            LinkSpotID = packet.ReadUInt32();
            LanguageType = packet.ReadByte();
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
        /// Gets or sets the chat uid.
        /// </summary>
        /// <value>
        /// The chat uid.
        /// </value>
        private ulong ChatUID { get; set; }

        /// <summary>
        /// Gets or sets the emblem background identifier.
        /// </summary>
        /// <value>
        /// The emblem background identifier.
        /// </value>
        private uint EmblemBackgroundID { get; set; }

        /// <summary>
        /// Gets or sets the emblem symbol identifier.
        /// </summary>
        /// <value>
        /// The emblem symbol identifier.
        /// </value>
        private uint EmblemSymbolID { get; set; }

        /// <summary>
        /// Gets or sets the type of the language.
        /// </summary>
        /// <value>
        /// The type of the language.
        /// </value>
        private byte LanguageType { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the link dungeon list.
        /// </summary>
        /// <value>
        /// The link dungeon list.
        /// </value>
        private List<PacketLinkDungeon> LinkDungeonList { get; set; }

        /// <summary>
        /// Gets or sets the link guild list.
        /// </summary>
        /// <value>
        /// The link guild list.
        /// </value>
        private List<PacketLinkGuildDungeon> LinkGuildList { get; set; }

        /// <summary>
        /// Gets or sets the link item.
        /// </summary>
        /// <value>
        /// The link item.
        /// </value>
        private ushort LinkItem { get; set; }

        /// <summary>
        /// Gets or sets the link item list.
        /// </summary>
        /// <value>
        /// The link item list.
        /// </value>
        private List<PacketLinkItem> LinkItemList { get; set; }

        /// <summary>
        /// Gets or sets the link spot identifier.
        /// </summary>
        /// <value>
        /// The link spot identifier.
        /// </value>
        private uint LinkSpotID { get; set; }

        /// <summary>
        /// Gets or sets the type of the link.
        /// </summary>
        /// <value>
        /// The type of the link.
        /// </value>
        private byte LinkType { get; set; }

        /// <summary>
        /// Gets or sets the link voice.
        /// </summary>
        /// <value>
        /// The link voice.
        /// </value>
        private string LinkVoice { get; set; }

        /// <summary>
        /// Gets or sets the link world boss despawn identifier.
        /// </summary>
        /// <value>
        /// The link world boss despawn identifier.
        /// </value>
        private uint LinkWorldBossDespawnID { get; set; }

        /// <summary>
        /// Gets or sets the link world boss die identifier.
        /// </summary>
        /// <value>
        /// The link world boss die identifier.
        /// </value>
        private uint LinkWorldBossDieID { get; set; }

        /// <summary>
        /// Gets or sets the link world boss identifier.
        /// </summary>
        /// <value>
        /// The link world boss identifier.
        /// </value>
        private uint LinkWorldBossID { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        private string Message { get; set; }

        /// <summary>
        /// Gets or sets the MSG time.
        /// </summary>
        /// <value>
        /// The MSG time.
        /// </value>
        private DateTime MsgTime { get; set; }

        /// <summary>
        /// Gets or sets the player class.
        /// </summary>
        /// <value>
        /// The player class.
        /// </value>
        private string PlayerClass { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        private string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the player uid.
        /// </summary>
        /// <value>
        /// The player uid.
        /// </value>
        private ulong PlayerUID { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        /// <value>
        /// The race.
        /// </value>
        private string Race { get; set; }
    }
}