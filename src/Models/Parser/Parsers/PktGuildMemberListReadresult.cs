using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktGuildMemberListReadresult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\GuildMemberList.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                packet.Skip(2);

                ulong ClanID = packet.ReadUInt64();
                ushort MemberCount = packet.ReadUInt16();

                //Writes header for the PktGuildMemberListReadresult
                fileStream.WriteLine("Clan ID,Name,Member Count\n" + ClanID + "," +
                    /* The following is a formula for spreadsheets that will look up the clan name from the DetailedGuildInfo
                     * output if both are imported into the same spreadsheet. It likely should be removed at a later date.*/
                    "\"=VLOOKUP(OFFSET(INDIRECT(ADDRESS(ROW(), COLUMN())),0,-1),DetailedGuildInfo!A:C,3,FALSE)\","
                    + MemberCount + "\n");
                fileStream.WriteLine("Player ID," + "Player Name," + "Level," + "Combat Power," +
                    "Role," + "Class," + "Offline," + "Contribution," + "Total Contributions," +
                    "Checked in," + "Rewards Count," + "World," + "Introduction");

                // Parses the PktGuildMemberListReadresult
                while (packet.Remaining > 0)
                {
                    ulong PlayerID = packet.ReadUInt64();
                    string PlayerName = packet.ReadString();
                    string ClanRole = CSV.guildMemberGrade.guildMemberGradeName(packet.ReadByte());
                    string Race = CSV.race.RaceName(packet.ReadInt32());
                    string PlayerClass = CSV.Class.className(packet.ReadUInt16());
                    byte UnkA = packet.ReadByte();
                    byte UnkB = packet.ReadByte();
                    ushort Level = packet.ReadUInt16();
                    string Offline = Misc.Misc.CalcTime(packet.ReadUInt64());
                    uint Contribution = packet.ReadUInt32();
                    uint TotalContribution = packet.ReadUInt32();
                    byte IGreet = packet.ReadByte();
                    byte TheyGreet = packet.ReadByte();
                    byte Checkin = packet.ReadByte();
                    uint PlayerCP = packet.ReadUInt32();
                    uint Unk1 = packet.ReadUInt32();
                    byte RewardCount = packet.ReadByte();
                    string WorldID = CSV.world.worldName(packet.ReadUInt16());
                    ushort introLength = packet.ReadUInt16();
                    string Introduction = packet.ReadString();
                    packet.Skip(1);

                    fileStream.WriteLine(PlayerID + "," + PlayerName + "," + Level + "," + PlayerCP + "," +
                        ClanRole + "," + PlayerClass + "," + Offline + "," + Contribution + "," + TotalContribution + ", " +
                        Checkin + "," + RewardCount + "," + WorldID + "," + Introduction);
                }
                fileStream.WriteLine("\n\n");
            }
        }
    }
}