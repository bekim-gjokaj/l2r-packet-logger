using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktMonsterBookListReadresult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktMonsterBookListReadresult.csv", true))
            {
                packet.Skip(2);

                ushort TotalCodex = packet.ReadUInt16();
                fileStream.WriteLine("Codex Entries: " + TotalCodex);
                fileStream.WriteLine("\nCodexID,Unk1,Level,Cores");

                for (int j = 0; j < TotalCodex; j++)
                {
                    ushort CodexID = packet.ReadUInt16();
                    ushort Cores = packet.ReadUInt16();
                    ushort Level = packet.ReadUInt16();
                    ushort Unk1 = packet.ReadUInt16();
                    fileStream.WriteLine(CodexID + "," + Cores + "," + Level + "," + Unk1);
                }

                ushort TotalCodexGroup = packet.ReadUInt16();
                fileStream.WriteLine("Codex Pages: " + TotalCodexGroup);
                for (int j = 0; j < TotalCodexGroup; j++)
                {
                    ushort Unk1 = packet.ReadUInt16();
                    ushort CodexGroup = packet.ReadUInt16();
                    byte spacer = packet.ReadByte();
                    ushort Unk2 = packet.ReadUInt16();
                    ushort Unk3 = packet.ReadUInt16();
                }
            }
        }
    }
}