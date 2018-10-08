using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktGuildInfoReadresult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\DetailedGuildInfo.csv", true))
            {
                // First two bytes are not used.
                packet.Skip(2);

                //Writes header for the PktGuildInfoReadresult
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("ID,Ranking,Name,Leader,Level,Exp,As Percentage, Reputation,Combat Power,Adena," +
                        "Proof of Blood,Red Star Stone,Members,Checked in Yesterday,Checked in Today," +
                        "Fortress Owned,Fortress Occupy Date,Wins,Draws,Losses,Require Approval," +
                        "Level Requirement,Intro,Notice");
                }

                ulong ID = packet.ReadUInt64();
                string Name = packet.ReadString();
                uint EmblemSymbolID = packet.ReadUInt32();
                uint EmblemBackgroundID = packet.ReadUInt32();
                ushort Level = packet.ReadUInt16();
                uint Exp = packet.ReadUInt32();
                ulong Adena = packet.ReadUInt64();
                ulong BloodCrystal = packet.ReadUInt64();
                string Intro = packet.ReadString();
                string Notice = packet.ReadString();
                byte IsPublic = packet.ReadByte();
                uint Ranking = packet.ReadUInt32();
                uint RankingTotal = packet.ReadUInt32();
                uint Reputation = packet.ReadUInt32();
                string LeaderName = packet.ReadString();
                ushort SquireCount = packet.ReadUInt16();
                ushort GuardCount = packet.ReadUInt16();
                ushort KnightCount = packet.ReadUInt16();
                ushort CaptainCount = packet.ReadUInt16();
                ushort ElderCount = packet.ReadUInt16();
                byte RequireApproval = packet.ReadByte();
                ushort LevelRequirement = packet.ReadUInt16();
                uint CastleOwned = packet.ReadUInt32();
                string FortressOwned = CSV.fortress.fortressName(packet.ReadInt32());
                uint RedStarStone = packet.ReadUInt32();
                packet.Skip(100); // Junk Data
                uint PacketID2 = packet.ReadUInt32();
                ulong ID2 = packet.ReadUInt64();
                string Name2 = packet.ReadString();
                uint Emblem2SymbolID = packet.ReadUInt32();
                uint Emblem2BackgroundID = packet.ReadUInt32();
                string Intro2 = packet.ReadString();
                ushort Level2 = packet.ReadUInt16();
                uint Exp2 = packet.ReadUInt32();
                ulong Reputation2 = packet.ReadUInt64();
                uint Spacer = packet.ReadUInt32();
                ushort Members = packet.ReadUInt16();
                string Leader2Name = packet.ReadString();
                ulong Adena2 = packet.ReadUInt64();
                byte RequireApproval2 = packet.ReadByte();
                ushort LevelRequirement2 = packet.ReadUInt16();
                ushort Wins = packet.ReadUInt16();
                ushort Draws = packet.ReadUInt16();
                ushort Losses = packet.ReadUInt16();
                ulong CombatPower2 = packet.ReadUInt64();
                ulong Unk3 = packet.ReadUInt64();
                byte Unk4 = packet.ReadByte();
                double FortressOccupyDate = Convert.ToDouble(packet.ReadUInt64());
                if (FortressOccupyDate > 0)
                {
                    FortressOccupyDate = FortressOccupyDate / 60 / 60 / 24 + 25569 - (5 / 24);
                }
                byte Unk5 = packet.ReadByte();
                ulong Unk6 = packet.ReadUInt64();
                byte Unk7 = packet.ReadByte();
                ushort Four = packet.ReadUInt16();
                byte Unk8 = packet.ReadByte();
                double SiegeDate = Convert.ToDouble(packet.ReadUInt64());
                SiegeDate = SiegeDate / 60 / 60 / 24 + 25569 - (5 / 24);
                double BidDate = Convert.ToDouble(packet.ReadUInt64());
                BidDate = BidDate / 60 / 60 / 24 + 25569 - (5 / 24);
                ulong CombatPower = packet.ReadUInt64();
                uint Seven = packet.ReadUInt32();
                byte Unk9 = packet.ReadByte();

                double CastleDate = Convert.ToDouble(packet.ReadUInt32());
                CastleDate = CastleDate / 60 / 60 / 24 + 25569 - (5 / 24);
                ushort Unk11 = packet.ReadUInt16();
                byte Unk12 = packet.ReadByte();
                byte Unk13 = packet.ReadByte();
                byte Unk14 = packet.ReadByte();
                byte Unk14_2 = packet.ReadByte();
                uint Unk15 = packet.ReadUInt32();
                uint Unk15_2 = packet.ReadUInt32();
                ushort CheckinYesterday = packet.ReadUInt16();
                ushort CheckinToday = packet.ReadUInt16();
                ushort Unk17 = packet.ReadUInt16();
                uint Unk18 = packet.ReadUInt32();
                uint Unk18_2 = packet.ReadUInt32();
                ushort Unk20 = packet.ReadUInt16();
                ushort Unk21 = packet.ReadUInt16();
                ushort Unk22 = packet.ReadUInt16();
                ushort Unk23 = packet.ReadUInt16();
                ushort Unk24 = packet.ReadUInt16();
                ushort Unk25 = packet.ReadUInt16();
                ushort Unk26 = packet.ReadUInt16();
                ushort Unk27 = packet.ReadUInt16();
                ushort Unk28 = packet.ReadUInt16();
                ushort Unk29 = packet.ReadUInt16();
                ushort Unk30 = packet.ReadUInt16();
                byte Unk32 = packet.ReadByte();

                // Calculates Total Members from Data given for all Clans
                int TMembers = SquireCount + GuardCount + KnightCount + CaptainCount + ElderCount + 1;
                // Calculates Percentage to next level.
                double ExpPer = Convert.ToDouble(CSV.guildLevelUp.guildLevelUpExp(Level));
                ExpPer = Exp / ExpPer * 100;

                fileStream.Write(ID + "," + Ranking + "," + Name + "," + LeaderName + "," + Level + "," + Exp + "," + ExpPer + "%," +
                    Reputation + "," + CombatPower + "," + Adena + "," + BloodCrystal + "," + RedStarStone + "," +
                     TMembers + "," + CheckinYesterday + "," + CheckinToday + "," +
                    FortressOwned + ",");
                if (FortressOccupyDate > 0)
                { fileStream.Write(FortressOccupyDate + "," + Wins + "," + Draws + "," + Losses + ","); }
                else
                { fileStream.Write(",,,,"); }
                fileStream.Write(RequireApproval + "," + LevelRequirement + ",\"" + Intro + "\",\"" + Notice + "\"\n");
            }
        }
    }
}