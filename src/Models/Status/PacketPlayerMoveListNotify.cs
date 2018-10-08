using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PacketPlayerMoveListNotify : IL2RPacket
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktPlayerMoveListNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("PlayerID,Move Type,Destination X Coord,Destination Y Coord");
                }

                ulong PlayerID = packet.ReadUInt64();
                ushort movetype = packet.ReadUInt16();
                float dxpos = packet.ReadSingle();
                float dypos = packet.ReadSingle();

                fileStream.WriteLine(PlayerID + "," + movetype + "," + dxpos + "," + dypos);
            }
        }
    }
}