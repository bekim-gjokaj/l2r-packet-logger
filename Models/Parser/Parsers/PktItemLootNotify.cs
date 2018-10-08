using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktItemLootNotify
    {
        public Packet(PacketReader packet)
        {
            string itemlist = "";
            packet.Skip(2);
            ushort ComplexCounter = packet.ReadUInt16();
            for (int j = 0; j < ComplexCounter; j++)
            {
                ulong UItemID = packet.ReadUInt64();
                string ItemID = Enum.Item.Enum(packet.ReadUInt32());
                packet.Skip(4);//Junk
                uint Count = packet.ReadUInt32();
                byte Unknown = packet.ReadByte();
                packet.Skip(2);//Junk?
                DateTime LootTime = packet.ReadDate();
                packet.Skip(2);//Junk?
                ushort UnkCounter = packet.ReadUInt16(); // All data seems blank
                for (int i = 0; i < UnkCounter; i++)
                {
                    packet.Skip(19);
                }
                byte UnkBool1 = packet.ReadByte();//One of these must be bind
                byte UnkBool2 = packet.ReadByte();
                packet.Skip(7);

                itemlist += ",\"" + ItemID + "\"," + Count;
            }
            ushort SimpleCounter = packet.ReadUInt16();
            for (int j = 0; j < SimpleCounter; j++)
            {
                ulong UItemID = packet.ReadUInt64();
                string ItemID = Enum.Item.Enum(packet.ReadUInt32());
                ushort Count = packet.ReadUInt16();
                DateTime LootTime = packet.ReadDate();
                byte Bind = packet.ReadByte();//One of these must be bind
                uint EventPeriodID = packet.ReadUInt32();

                itemlist += ",\"" + ItemID + "\"," + Count;
            }
            ushort MultiCounter = packet.ReadUInt16();
            for (int j = 0; j < MultiCounter; j++)
            {
                ulong UItemID = packet.ReadUInt64();
                ushort Count = packet.ReadUInt16();
                ushort Stack = packet.ReadUInt16();
                itemlist += "," + UItemID + "," + Count;
            }
            packet.Skip(2);
            byte LooterType = packet.ReadByte();
            uint NPCInfoID = packet.ReadUInt32();
            using (StreamWriter fileStream = new StreamWriter(@"Output\ItemsLooted.csv", true))
            {
                if (Globals.lootIndex == 1)
                {
                    fileStream.Write(",");
                }

                fileStream.Write("," + NPCInfoID + "," + itemlist);
            }
        }
    }
}