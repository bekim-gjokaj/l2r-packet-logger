using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktPktExpDisplayNotify
    {
        public Packet(PacketReader packet)
        {
            Globals.lootIndex = 1;
            using (StreamWriter fileStreamer = new StreamWriter(@"Output\ItemsLooted.csv", true))
            {
                uint Exp = packet.ReadUInt32();
                uint Bonus = packet.ReadUInt32();
                fileStreamer.Write("\n" + Exp + "," + Bonus);
            }
        }
    }
}