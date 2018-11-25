using System;

namespace Kamael.Packets.Clan
{
    public class PacketClanInfoReadResult : IL2RPacket
    {
        public PacketClanInfoReadResult(L2RPacket packet)
        {
            //using (StreamWriter fileStream = new StreamWriter(@"Output\DetailedGuildInfo.csv", true))
            //{
            // First two bytes are not used.
            packet.Skip(2);

            ////Writes header for the PktGuildInfoReadresult
            //if (fileStream.BaseStream.Length < 1)
            //{
            //    fileStream.WriteLineAsync("ID,Ranking,Name,Leader,Level,Exp,As Percentage, Reputation,Combat Power,Adena," +
            //        "Proof of Blood,Red Star Stone,Members,Checked in Yesterday,Checked in Today," +
            //        "Fortress Owned,Fortress Occupy Date,Wins,Draws,Losses,Require Approval," +
            //        "Level Requirement,Intro,Notice");
            //}

            ID = packet.ReadUInt64();
            Name = packet.ReadString();
            EmblemSymbolID = packet.ReadUInt32();
            EmblemBackgroundID = packet.ReadUInt32();
            Level = packet.ReadUInt16();
            Exp = packet.ReadUInt32();
            Adena = packet.ReadUInt64();
            BloodCrystal = packet.ReadUInt64();
            Intro = packet.ReadString();
            Notice = packet.ReadString();
            IsPublic = packet.ReadByte();
            Ranking = packet.ReadUInt32();
            RankingTotal = packet.ReadUInt32();
            Reputation = packet.ReadUInt32();
            LeaderName = packet.ReadString();
            SquireCount = packet.ReadUInt16();
            GuardCount = packet.ReadUInt16();
            KnightCount = packet.ReadUInt16();
            CaptainCount = packet.ReadUInt16();
            ElderCount = packet.ReadUInt16();
            RequireApproval = packet.ReadByte();
            LevelRequirement = packet.ReadUInt16();
            CastleOwned = packet.ReadUInt32();
            FortressOwned = Convert.ToString(packet.ReadInt64());
            RedStarStone = packet.ReadUInt32();
            packet.Skip(100); // Junk Data
            PacketID2 = packet.ReadUInt32();
            ID2 = packet.ReadUInt64();
            Name2 = packet.ReadString();
            Emblem2SymbolID = packet.ReadUInt32();
            Emblem2BackgroundID = packet.ReadUInt32();
            //Intro2 = packet.ReadString();
            Level2 = packet.ReadUInt16();
            Exp2 = packet.ReadUInt32();
            Reputation2 = packet.ReadUInt64();
            Spacer = packet.ReadUInt32();
            Members = packet.ReadUInt16();
            //Leader2Name = packet.ReadString();
            Adena2 = packet.ReadUInt64();
            RequireApproval2 = packet.ReadByte();
            LevelRequirement2 = packet.ReadUInt16();
            Wins = packet.ReadUInt16();
            Draws = packet.ReadUInt16();
            Losses = packet.ReadUInt16();
            CombatPower2 = packet.ReadUInt64();
            Unk3 = packet.ReadUInt64();
            Unk4 = packet.ReadByte();
            FortressOccupyDate = Convert.ToDouble(packet.ReadUInt64());
            if (FortressOccupyDate > 0)
            {
                FortressOccupyDate = FortressOccupyDate / 60 / 60 / 24 + 25569 - (5 / 24);
            }
            Unk5 = packet.ReadByte();
            Unk6 = packet.ReadUInt64();
            Unk7 = packet.ReadByte();
            Four = packet.ReadUInt16();
            Unk8 = packet.ReadByte();
            SiegeDate = Convert.ToDouble(packet.ReadUInt64());
            SiegeDate = SiegeDate / 60 / 60 / 24 + 25569 - (5 / 24);
            BidDate = Convert.ToDouble(packet.ReadUInt64());
            BidDate = BidDate / 60 / 60 / 24 + 25569 - (5 / 24);
            CombatPower = packet.ReadUInt64();
            Seven = packet.ReadUInt32();
            Unk9 = packet.ReadByte();

            CastleDate = Convert.ToDouble(packet.ReadUInt32());
            CastleDate = CastleDate / 60 / 60 / 24 + 25569 - (5 / 24);
            Unk11 = packet.ReadUInt16();
            Unk12 = packet.ReadByte();
            Unk13 = packet.ReadByte();
            Unk14 = packet.ReadByte();
            Unk14_2 = packet.ReadByte();
            Unk15 = packet.ReadUInt32();
            Unk15_2 = packet.ReadUInt32();
            CheckinYesterday = packet.ReadUInt16();
            CheckinToday = packet.ReadUInt16();
            Unk17 = packet.ReadUInt16();
            Unk18 = packet.ReadUInt32();
            Unk18_2 = packet.ReadUInt32();
            Unk20 = packet.ReadUInt16();
            Unk21 = packet.ReadUInt16();
            Unk22 = packet.ReadUInt16();
            Unk23 = packet.ReadUInt16();
            Unk24 = packet.ReadUInt16();
            Unk25 = packet.ReadUInt16();
            Unk26 = packet.ReadUInt16();
            Unk27 = packet.ReadUInt16();
            Unk28 = packet.ReadUInt16();
            Unk29 = packet.ReadUInt16();
            Unk30 = packet.ReadUInt16();
            Unk32 = packet.ReadByte();

            // Calculates Total Members from Data given for all Clans
            TMembers = SquireCount + GuardCount + KnightCount + CaptainCount + ElderCount + 1;
            //// Calculates Percentage to next level.
            //ExpPer = Convert.ToDouble(CSV.guildLevelUp.guildLevelUpExp(Level));
            //ExpPer = Exp / ExpPer * 100;

            //fileStream.Write(ID + "," + Ranking + "," + Name + "," + LeaderName + "," + Level + "," + Exp + "," + ExpPer + "%," +
            //    Reputation + "," + CombatPower + "," + Adena + "," + BloodCrystal + "," + RedStarStone + "," +
            //     TMembers + "," + CheckinYesterday + "," + CheckinToday + "," +
            //    FortressOwned + ",");
            //if (FortressOccupyDate > 0)
            //{ fileStream.Write(FortressOccupyDate + "," + Wins + "," + Draws + "," + Losses + ","); }
            //else
            //{ fileStream.Write(",,,,"); }
            //fileStream.Write(RequireApproval + "," + LevelRequirement + ",\"" + Intro + "\",\"" + Notice + "\"\n");
            //}
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

        public ulong ID { get; set; }
        public string Name { get; set; }
        public uint EmblemSymbolID { get; set; }
        public uint EmblemBackgroundID { get; set; }
        public ushort Level { get; set; }
        public uint Exp { get; set; }
        public ulong Adena { get; set; }
        public ulong BloodCrystal { get; set; }
        public string Intro { get; set; }
        public string Notice { get; set; }
        public byte IsPublic { get; set; }
        public uint Ranking { get; set; }
        public uint RankingTotal { get; set; }
        public uint Reputation { get; set; }
        public string LeaderName { get; set; }
        public ushort SquireCount { get; set; }
        public ushort GuardCount { get; set; }
        public ushort KnightCount { get; set; }
        public ushort CaptainCount { get; set; }
        public ushort ElderCount { get; set; }
        public byte RequireApproval { get; set; }
        public ushort LevelRequirement { get; set; }
        public uint CastleOwned { get; set; }
        public string FortressOwned { get; set; }
        public uint RedStarStone { get; set; }
        public uint PacketID2 { get; set; }
        public ulong ID2 { get; set; }
        public string Name2 { get; set; }
        public uint Emblem2SymbolID { get; set; }
        public uint Emblem2BackgroundID { get; set; }
        public string Intro2 { get; set; }
        public ushort Level2 { get; set; }
        public uint Exp2 { get; set; }
        public ulong Reputation2 { get; set; }
        public uint Spacer { get; set; }
        public ushort Members { get; set; }
        public string Leader2Name { get; set; }
        public ulong Adena2 { get; set; }
        public byte RequireApproval2 { get; set; }
        public ushort LevelRequirement2 { get; set; }
        public ushort Wins { get; set; }
        public ushort Draws { get; set; }
        public ushort Losses { get; set; }
        public ulong CombatPower2 { get; set; }
        public ulong Unk3 { get; set; }
        public byte Unk4 { get; set; }
        public double FortressOccupyDate { get; set; }
        public byte Unk5 { get; set; }
        public ulong Unk6 { get; set; }
        public byte Unk7 { get; set; }
        public ushort Four { get; set; }
        public byte Unk8 { get; set; }
        public double SiegeDate { get; set; }
        public double BidDate { get; set; }
        public ulong CombatPower { get; set; }
        public uint Seven { get; set; }
        public byte Unk9 { get; set; }
        public double CastleDate { get; set; }
        public ushort Unk11 { get; set; }
        public byte Unk12 { get; set; }
        public byte Unk13 { get; set; }
        public byte Unk14 { get; set; }
        public byte Unk14_2 { get; set; }
        public uint Unk15 { get; set; }
        public uint Unk15_2 { get; set; }
        public ushort CheckinYesterday { get; set; }
        public ushort CheckinToday { get; set; }
        public ushort Unk17 { get; set; }
        public uint Unk18 { get; set; }
        public uint Unk18_2 { get; set; }
        public ushort Unk20 { get; set; }
        public ushort Unk21 { get; set; }
        public ushort Unk22 { get; set; }
        public ushort Unk23 { get; set; }
        public ushort Unk24 { get; set; }
        public ushort Unk25 { get; set; }
        public ushort Unk26 { get; set; }
        public ushort Unk27 { get; set; }
        public ushort Unk28 { get; set; }
        public ushort Unk29 { get; set; }
        public ushort Unk30 { get; set; }
        public byte Unk32 { get; set; }
        public int TMembers { get; set; }
        public double ExpPer { get; set; }
    }
}