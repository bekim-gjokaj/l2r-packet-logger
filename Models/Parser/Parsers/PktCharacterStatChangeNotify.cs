using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktCharacterStatChangeNotify
    {
        public Packet(PacketReader packet)
        {
            if (packet.Remaining == 46)
            {
                using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLooted.csv", true))
                {
                    packet.Skip(38);
                    fileStream.Write("," + packet.ReadUInt32());
                    Globals.lootIndex = 2;
                }
            }
            else if (packet.Remaining == 37)
            {
                using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLooted.csv", true))
                {
                    packet.Skip(29);
                    fileStream.Write("," + packet.ReadUInt32());
                    Globals.lootIndex = 2;
                }
            }
            else
            {
            }
        }
    }
}