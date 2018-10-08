using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktGuildRecommendationListReadresult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildRankings.csv", true))
            {
                packet.Skip(2);

                ushort NumberofGuilds = packet.ReadUInt16();

                fileStream.WriteLine("Ranking,Name,Leader,Level,Exp,Reputation,Members,ClanCP,Wins,Draws,Losses,LevelReq,Closed,Intro");

                for (int j = 0; j < NumberofGuilds; j++)
                {
                    ulong ClanID = packet.ReadUInt64();
                    string Name = packet.ReadString();
                    uint Unk1 = packet.ReadUInt32();
                    uint Unk2 = packet.ReadUInt32();
                    string Intro = packet.ReadString();
                    ushort Level = packet.ReadUInt16();
                    uint Exp = packet.ReadUInt32();
                    uint Reputation = packet.ReadUInt32();
                    uint Ranking = packet.ReadUInt32();
                    uint Unk3 = packet.ReadUInt32();
                    ushort Members = packet.ReadUInt16();
                    string Leader = packet.ReadString();
                    uint Unk4 = packet.ReadUInt32();
                    uint Unk5 = packet.ReadUInt32();
                    byte Closed = packet.ReadByte();
                    ushort LevelReq = packet.ReadUInt16();
                    ushort Wins = packet.ReadUInt16();
                    ushort Draws = packet.ReadUInt16();
                    ushort Losses = packet.ReadUInt16();
                    uint ClanCP = packet.ReadUInt32();
                    uint Unk7 = packet.ReadUInt32();
                    uint Unk8 = packet.ReadUInt32();
                    uint Unk9 = packet.ReadUInt32();
                    byte Spacer = packet.ReadByte();

                    fileStream.WriteLine(Ranking + "," + Name + "," + Leader + "," + Level + "," +
                        Exp + "," + Reputation + "," + Members + "," + ClanCP + "," + Wins + "," +
                        Draws + "," + Losses + "," + LevelReq + "," + Closed + ",\"" + Intro + "\"");
                }
            }
        }
    }
}