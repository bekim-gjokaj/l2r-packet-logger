using Kamael.Packets.ExtensionMethods;
using System.IO;

namespace Kamael.Packets.Clan
{
    /// <summary>
    ///
    /// </summary>
    internal class PacketGuildMemberListReadresult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketGuildMemberListReadresult" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketGuildMemberListReadresult(IL2RPacket packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildMemberList.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                packet.Skip(2);

                ClanID = packet.ReadUInt64();
                MemberCount = packet.ReadUInt16();

                //Writes header for the PktGuildMemberListReadresult
                fileStream.WriteLineAsync("Clan ID,Name,Member Count\n" + ClanID + "," +
                    /* The following is a formula for spreadsheets that will look up the clan name from the DetailedGuildInfo
                     * output if both are imported into the same spreadsheet. It likely should be removed at a later date.*/
                    "\"=VLOOKUP(OFFSET(INDIRECT(ADDRESS(ROW(), COLUMN())),0,-1),DetailedGuildInfo!A:C,3,FALSE)\","
                    + MemberCount + "\n");
                fileStream.WriteLineAsync("Player ID," + "Player Name," + "Level," + "Combat Power," +
                    "Role," + "Class," + "Offline," + "Contribution," + "Total Contributions," +
                    "Checked in," + "Rewards Count," + "World," + "Introduction");

                // Parses the PktGuildMemberListReadresult
                //while (packet.Remaining > 0)
                //{
                PlayerID = packet.ReadUInt64();
                PlayerName = packet.ReadString();
                ClanRole = CSV.guildMemberGrade.guildMemberGradeName(packet.ReadByte());
                Race = CSV.race.RaceName(packet.ReadInt32());
                PlayerClass = CSV.Class.className(packet.ReadUInt16());
                UnkA = packet.ReadByte();
                UnkB = packet.ReadByte();
                Level = packet.ReadUInt16();
                Offline = Misc.Misc.CalcTime(packet.ReadUInt64());
                Contribution = packet.ReadUInt32();
                TotalContribution = packet.ReadUInt32();
                IGreet = packet.ReadByte();
                TheyGreet = packet.ReadByte();
                Checkin = packet.ReadByte();
                PlayerCP = packet.ReadUInt32();
                Unk1 = packet.ReadUInt32();
                RewardCount = packet.ReadByte();
                WorldID = CSV.world.worldName(packet.ReadUInt16());
                introLength = packet.ReadUInt16();
                Introduction = packet.ReadString();
                //    packet.Skip(1);

                //    fileStream.WriteLineAsync(PlayerID + "," + PlayerName + "," + Level + "," + PlayerCP + "," +
                //        ClanRole + "," + PlayerClass + "," + Offline + "," + Contribution + "," + TotalContribution + ", " +
                //        Checkin + "," + RewardCount + "," + WorldID + "," + Introduction);
                //}
                //fileStream.WriteLineAsync("\n\n");
            };
        }

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
        /// Gets or sets the checkin.
        /// </summary>
        /// <value>
        /// The checkin.
        /// </value>
        private byte Checkin { get; set; }

        /// <summary>
        /// Gets or sets the clan identifier.
        /// </summary>
        /// <value>
        /// The clan identifier.
        /// </value>
        private ulong ClanID { get; set; }

        /// <summary>
        /// Gets or sets the clan role.
        /// </summary>
        /// <value>
        /// The clan role.
        /// </value>
        private string ClanRole { get; set; }

        /// <summary>
        /// Gets or sets the contribution.
        /// </summary>
        /// <value>
        /// The contribution.
        /// </value>
        private uint Contribution { get; set; }

        /// <summary>
        /// Gets or sets the i greet.
        /// </summary>
        /// <value>
        /// The i greet.
        /// </value>
        private byte IGreet { get; set; }

        /// <summary>
        /// Gets or sets the introduction.
        /// </summary>
        /// <value>
        /// The introduction.
        /// </value>
        private string Introduction { get; set; }

        /// <summary>
        /// Gets or sets the length of the intro.
        /// </summary>
        /// <value>
        /// The length of the intro.
        /// </value>
        private ushort introLength { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the member count.
        /// </summary>
        /// <value>
        /// The member count.
        /// </value>
        private ushort MemberCount { get; set; }

        /// <summary>
        /// Gets or sets the offline.
        /// </summary>
        /// <value>
        /// The offline.
        /// </value>
        private string Offline { get; set; }

        /// <summary>
        /// Gets or sets the player class.
        /// </summary>
        /// <value>
        /// The player class.
        /// </value>
        private string PlayerClass { get; set; }

        /// <summary>
        /// Gets or sets the player cp.
        /// </summary>
        /// <value>
        /// The player cp.
        /// </value>
        private uint PlayerCP { get; set; }

        /// <summary>
        /// Gets or sets the player identifier.
        /// </summary>
        /// <value>
        /// The player identifier.
        /// </value>
        private ulong PlayerID { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        private string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        /// <value>
        /// The race.
        /// </value>
        private string Race { get; set; }

        /// <summary>
        /// Gets or sets the reward count.
        /// </summary>
        /// <value>
        /// The reward count.
        /// </value>
        private byte RewardCount { get; set; }

        /// <summary>
        /// Gets or sets the they greet.
        /// </summary>
        /// <value>
        /// The they greet.
        /// </value>
        private byte TheyGreet { get; set; }

        /// <summary>
        /// Gets or sets the total contribution.
        /// </summary>
        /// <value>
        /// The total contribution.
        /// </value>
        private uint TotalContribution { get; set; }

        /// <summary>
        /// Gets or sets the unk1.
        /// </summary>
        /// <value>
        /// The unk1.
        /// </value>
        private uint Unk1 { get; set; }

        /// <summary>
        /// Gets or sets the unk a.
        /// </summary>
        /// <value>
        /// The unk a.
        /// </value>
        private byte UnkA { get; set; }

        /// <summary>
        /// Gets or sets the unk b.
        /// </summary>
        /// <value>
        /// The unk b.
        /// </value>
        private byte UnkB { get; set; }

        /// <summary>
        /// Gets or sets the world identifier.
        /// </summary>
        /// <value>
        /// The world identifier.
        /// </value>
        private string WorldID { get; set; }
    }
}