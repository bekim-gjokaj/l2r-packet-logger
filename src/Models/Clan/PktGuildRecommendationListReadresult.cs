using Kamael.Packets.ExtensionMethods;
using System.IO;

namespace Kamael.Packets.Parser.Parsers
{
    /// <summary>
    ///
    /// </summary>
    public class PacketGuildRecommendationListReadresult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketGuildRecommendationListReadresult"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketGuildRecommendationListReadresult(IL2RPacket packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildRankings.csv", true))
            {
                packet.Skip(2);

                NumberofGuilds = packet.ReadUInt16();

                fileStream.WriteLineAsync("Ranking,Name,Leader,Level,Exp,Reputation,Members,ClanCP,Wins,Draws,Losses,LevelReq,Closed,Intro");

                for (int j = 0; j < NumberofGuilds; j++)
                {
                    ClanID = packet.ReadUInt64();
                    Name = packet.ReadString();
                    Unk1 = packet.ReadUInt32();
                    Unk2 = packet.ReadUInt32();
                    Intro = packet.ReadString();
                    Level = packet.ReadUInt16();
                    Exp = packet.ReadUInt32();
                    Reputation = packet.ReadUInt32();
                    Ranking = packet.ReadUInt32();
                    Unk3 = packet.ReadUInt32();
                    Members = packet.ReadUInt16();
                    Leader = packet.ReadString();
                    Unk4 = packet.ReadUInt32();
                    Unk5 = packet.ReadUInt32();
                    Closed = packet.ReadByte();
                    LevelReq = packet.ReadUInt16();
                    Wins = packet.ReadUInt16();
                    Draws = packet.ReadUInt16();
                    Losses = packet.ReadUInt16();
                    ClanCP = packet.ReadUInt32();
                    Unk7 = packet.ReadUInt32();
                    Unk8 = packet.ReadUInt32();
                    Unk9 = packet.ReadUInt32();
                    Spacer = packet.ReadByte();

                    fileStream.WriteLineAsync(Ranking + "," + Name + "," + Leader + "," + Level + "," +
                        Exp + "," + Reputation + "," + Members + "," + ClanCP + "," + Wins + "," +
                        Draws + "," + Losses + "," + LevelReq + "," + Closed + ",\"" + Intro + "\"");
                }
            }
        }

        private ushort NumberofGuilds { get; set; }

        /// <summary>
        /// Gets or sets the clan cp.
        /// </summary>
        /// <value>
        /// The clan cp.
        /// </value>
        private uint ClanCP { get; set; }

        /// <summary>
        /// Gets or sets the clan identifier.
        /// </summary>
        /// <value>
        /// The clan identifier.
        /// </value>
        private ulong ClanID { get; set; }

        /// <summary>
        /// Gets or sets the closed.
        /// </summary>
        /// <value>
        /// The closed.
        /// </value>
        private byte Closed { get; set; }

        /// <summary>
        /// Gets or sets the draws.
        /// </summary>
        /// <value>
        /// The draws.
        /// </value>
        private ushort Draws { get; set; }

        /// <summary>
        /// Gets or sets the exp.
        /// </summary>
        /// <value>
        /// The exp.
        /// </value>
        private uint Exp { get; set; }

        /// <summary>
        /// Gets or sets the intro.
        /// </summary>
        /// <value>
        /// The intro.
        /// </value>
        private string Intro { get; set; }

        /// <summary>
        /// Gets or sets the leader.
        /// </summary>
        /// <value>
        /// The leader.
        /// </value>
        private string Leader { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the level req.
        /// </summary>
        /// <value>
        /// The level req.
        /// </value>
        private ushort LevelReq { get; set; }

        /// <summary>
        /// Gets or sets the losses.
        /// </summary>
        /// <value>
        /// The losses.
        /// </value>
        private ushort Losses { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        private ushort Members { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        private string Name { get; set; }

        /// <summary>
        /// Gets or sets the ranking.
        /// </summary>
        /// <value>
        /// The ranking.
        /// </value>
        private uint Ranking { get; set; }

        /// <summary>
        /// Gets or sets the reputation.
        /// </summary>
        /// <value>
        /// The reputation.
        /// </value>
        private uint Reputation { get; set; }

        /// <summary>
        /// Gets or sets the spacer.
        /// </summary>
        /// <value>
        /// The spacer.
        /// </value>
        private byte Spacer { get; set; }

        /// <summary>
        /// Gets or sets the unk1.
        /// </summary>
        /// <value>
        /// The unk1.
        /// </value>
        private uint Unk1 { get; set; }

        /// <summary>
        /// Gets or sets the unk2.
        /// </summary>
        /// <value>
        /// The unk2.
        /// </value>
        private uint Unk2 { get; set; }

        /// <summary>
        /// Gets or sets the unk3.
        /// </summary>
        /// <value>
        /// The unk3.
        /// </value>
        private uint Unk3 { get; set; }

        /// <summary>
        /// Gets or sets the unk4.
        /// </summary>
        /// <value>
        /// The unk4.
        /// </value>
        private uint Unk4 { get; set; }

        /// <summary>
        /// Gets or sets the unk5.
        /// </summary>
        /// <value>
        /// The unk5.
        /// </value>
        private uint Unk5 { get; set; }

        /// <summary>
        /// Gets or sets the unk7.
        /// </summary>
        /// <value>
        /// The unk7.
        /// </value>
        private uint Unk7 { get; set; }

        /// <summary>
        /// Gets or sets the unk8.
        /// </summary>
        /// <value>
        /// The unk8.
        /// </value>
        private uint Unk8 { get; set; }

        /// <summary>
        /// Gets or sets the unk9.
        /// </summary>
        /// <value>
        /// The unk9.
        /// </value>
        private uint Unk9 { get; set; }

        /// <summary>
        /// Gets or sets the wins.
        /// </summary>
        /// <value>
        /// The wins.
        /// </value>
        private ushort Wins { get; set; }
    }
}