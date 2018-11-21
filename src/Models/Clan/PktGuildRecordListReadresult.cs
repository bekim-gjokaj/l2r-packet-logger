using System.IO;

namespace Kamael.Packets.Clan
{
    public class PacketGuildRecordListReadresult
    {
        public PacketGuildRecordListReadresult(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\ClanDonations.txt", true))
            using (StreamWriter fileStream2 = new StreamWriter(@"Output\ClanDonations.csv", true))
            using (StreamWriter fileStream3 = new StreamWriter(@"Output\ClanRecords.txt", true))
            {
                if (fileStream2.BaseStream.Length < 1)
                {
                    fileStream.WriteLineAsync("Time,Name,Amount,Item");
                }

                packet.Skip(2);
                ushort RecordNumber = packet.ReadUInt16();
                for (int j = 0; j < RecordNumber; j++)
                {
                    ulong RecordID = packet.ReadUInt64();
                    byte GroupType = packet.ReadByte();
                    byte RecordType = packet.ReadByte();
                    string Name = packet.ReadString();
                    string Text1 = packet.ReadString();
                    string Text2 = packet.ReadString();
                    string Text3 = packet.ReadString();
                    System.DateTime dTime = packet.ReadDate();
                    string ResultText = Enum.ClanRecordType.Enum(RecordType, Text1, Text2, Text3);
                    string ResultTextSimple = Enum.ClanRecordTypeSimple.Enum(RecordType);

                    if (GroupType == 2)
                    {
                        fileStream.WriteLineAsync(dTime + ": " + Name + " - " + ResultText);
                        fileStream2.WriteLineAsync(dTime + "," + Name + "," + Text2 + "," + ResultTextSimple);
                    }
                    fileStream3.WriteLineAsync(dTime + ": " + Name + " - " + ResultText);
                }
            }
        }
    }
}