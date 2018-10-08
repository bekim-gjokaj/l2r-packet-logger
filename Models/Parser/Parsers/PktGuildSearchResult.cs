using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktGuildSearchResult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildSearch.csv", true))
            {
                packet.Skip(2);

                ushort NumberofGuilds = packet.ReadUInt16();

                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("Ranking,Name,Leader,Level,Exp,Reputation,Members,ClanCP,LevelReq,Closed,Intro");
                }

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
                    ushort Unk7 = packet.ReadUInt16();
                    uint LevelReq = packet.ReadUInt32();
                    uint ClanCP = packet.ReadUInt32();
                    uint Unk8 = packet.ReadUInt32();
                    ushort Unk9 = packet.ReadUInt16();
                    ulong Unk0 = packet.ReadUInt64();
                    byte Spacer = packet.ReadByte();

                    fileStream.WriteLine(Ranking + "," + Name + "," + Leader + "," + Level + "," +
                        Exp + "," + Reputation + "," + Members + "," + ClanCP + "," + "," + LevelReq + "," + Closed + ",\"" + Intro + "\"");
                }
            }
        }
    }
}