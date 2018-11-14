using System.Collections.Generic;
using System.IO;

namespace Kamael.Packets.Clan
{
    /// <summary>
    ///
    /// </summary>
    public class PacketGuildMemberListReadResult : IL2RPacket
    {
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
        /// Gets or sets the clan identifier.
        /// </summary>
        /// <value>
        /// The clan identifier.
        /// </value>
        public ulong ClanID { get; set; }

        /// <summary>
        /// Gets or sets the member count.
        /// </summary>
        /// <value>
        /// The member count.
        /// </value>
        public ushort MemberCount { get; set; }

        public List<PacketGuildMemberItem> Members { get; set; }

        public PacketGuildMemberListReadResult()
        {
        }
            /// <summary>
            /// Initializes a new instance of the <see cref="PacketGuildMemberListReadResult" /> class.
            /// </summary>
            /// <param name="packet">The packet.</param>
            public PacketGuildMemberListReadResult(L2RPacket packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildMemberList.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                packet.Skip(2);

                ClanID = packet.ReadUInt64();
                MemberCount = packet.ReadUInt16();

                // Parses the PktGuildMemberListReadresult
                while (packet.Remaining > 0)
                {
                    PacketGuildMemberItem item = new PacketGuildMemberItem();
                    item.PlayerID = packet.ReadUInt64();
                    item.PlayerName = packet.ReadString();
                    item.ClanRole = CSV.guildMemberGrade.guildMemberGradeName(packet.ReadByte());
                    item.Race = CSV.race.RaceName(packet.ReadInt32());
                    item.PlayerClass = CSV.Class.className(packet.ReadUInt16());
                    item.UnkA = packet.ReadByte();
                    item.UnkB = packet.ReadByte();
                    item.Level = packet.ReadUInt16();
                    item.Offline = Misc.Misc.CalcTime(packet.ReadUInt64());
                    item.Contribution = packet.ReadUInt32();
                    item.TotalContribution = packet.ReadUInt32();
                    item.IGreet = packet.ReadByte();
                    item.TheyGreet = packet.ReadByte();
                    item.Checkin = packet.ReadByte();
                    item.PlayerCP = packet.ReadUInt32();
                    item.Unk1 = packet.ReadUInt32();
                    item.RewardCount = packet.ReadByte();
                    item.WorldID = CSV.world.worldName(packet.ReadUInt16());
                    item.introLength = packet.ReadUInt16();
                    item.Introduction = packet.ReadString();
                    packet.Skip(1);

                    Members.Add(item);

                    fileStream.WriteLineAsync(item.PlayerID + "," + item.PlayerName + "," + item.Level + "," + item.PlayerCP + "," +
                        item.ClanRole + "," + item.PlayerClass + "," + item.Offline + "," + item.Contribution + "," + item.TotalContribution + ", " +
                        item.Checkin + "," + item.RewardCount + "," + item.WorldID + "," + item.Introduction);
                }
                fileStream.WriteLineAsync("\n\n");
            };
        }
    }

    public class PacketGuildMemberItem
    {
        /// <summary>
        /// Gets or sets the checkin.
        /// </summary>
        /// <value>
        /// The checkin.
        /// </value>
        public byte Checkin { get; set; }

        /// <summary>
        /// Gets or sets the clan role.
        /// </summary>
        /// <value>
        /// The clan role.
        /// </value>
        public string ClanRole { get; set; }

        /// <summary>
        /// Gets or sets the contribution.
        /// </summary>
        /// <value>
        /// The contribution.
        /// </value>
        public uint Contribution { get; set; }

        /// <summary>
        /// Gets or sets the i greet.
        /// </summary>
        /// <value>
        /// The i greet.
        /// </value>
        public byte IGreet { get; set; }

        /// <summary>
        /// Gets or sets the introduction.
        /// </summary>
        /// <value>
        /// The introduction.
        /// </value>
        public string Introduction { get; set; }

        /// <summary>
        /// Gets or sets the length of the intro.
        /// </summary>
        /// <value>
        /// The length of the intro.
        /// </value>
        public ushort introLength { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the offline.
        /// </summary>
        /// <value>
        /// The offline.
        /// </value>
        public string Offline { get; set; }

        /// <summary>
        /// Gets or sets the player class.
        /// </summary>
        /// <value>
        /// The player class.
        /// </value>
        public string PlayerClass { get; set; }

        /// <summary>
        /// Gets or sets the player cp.
        /// </summary>
        /// <value>
        /// The player cp.
        /// </value>
        public uint PlayerCP { get; set; }

        /// <summary>
        /// Gets or sets the player identifier.
        /// </summary>
        /// <value>
        /// The player identifier.
        /// </value>
        public ulong PlayerID { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        /// <value>
        /// The race.
        /// </value>
        public string Race { get; set; }

        /// <summary>
        /// Gets or sets the reward count.
        /// </summary>
        /// <value>
        /// The reward count.
        /// </value>
        public byte RewardCount { get; set; }

        /// <summary>
        /// Gets or sets the they greet.
        /// </summary>
        /// <value>
        /// The they greet.
        /// </value>
        public byte TheyGreet { get; set; }

        /// <summary>
        /// Gets or sets the total contribution.
        /// </summary>
        /// <value>
        /// The total contribution.
        /// </value>
        public uint TotalContribution { get; set; }

        /// <summary>
        /// Gets or sets the unk1.
        /// </summary>
        /// <value>
        /// The unk1.
        /// </value>
        public uint Unk1 { get; set; }

        /// <summary>
        /// Gets or sets the unk a.
        /// </summary>
        /// <value>
        /// The unk a.
        /// </value>
        public byte UnkA { get; set; }

        /// <summary>
        /// Gets or sets the unk b.
        /// </summary>
        /// <value>
        /// The unk b.
        /// </value>
        public byte UnkB { get; set; }

        /// <summary>
        /// Gets or sets the world identifier.
        /// </summary>
        /// <value>
        /// The world identifier.
        /// </value>
        public string WorldID { get; set; }
    }
}