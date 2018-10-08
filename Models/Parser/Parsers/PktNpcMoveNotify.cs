using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktNpcMoveNotify
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktNpcMoveNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("NPCID,X Coord, Y Coord, Unk1, Unk2, Move Type,Destination X Coord, Destination Y Coord");
                }

                ulong NPCID = packet.ReadUInt64();
                float xpos = packet.ReadSingle();
                float ypos = packet.ReadSingle();
                float unk1 = packet.ReadSingle();
                float unk2 = packet.ReadSingle();
                ushort movetype = packet.ReadUInt16();
                float dxpos = packet.ReadSingle();
                float dypos = packet.ReadSingle();

                fileStream.WriteLine(NPCID + "," + xpos + "," + ypos + "," + unk1 + "," + unk2 + "," + movetype + "," + dxpos + "," + dypos);
            }
        }
    }
}