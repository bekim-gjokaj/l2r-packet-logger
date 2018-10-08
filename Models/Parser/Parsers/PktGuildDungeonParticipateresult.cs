using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktGuildDungeonParticipateresult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\ClanDungeonResults.csv", true))
            {
                // Parses the header of the PktGuildMemberListReadresult
                // First two bytes are not used.
                packet.Skip(2);

                ushort itemCount = packet.ReadUInt16();

                // Doing Items as sloppy as I know how!
                int[] Unk1 = new int[itemCount];
                int[] Unk2 = new int[itemCount];
                int[] Unk3 = new int[itemCount];
                int[] Unk4 = new int[itemCount];
                byte[] Unk5 = new byte[itemCount];
                string[] ItemID = new string[itemCount];
                uint[] ItemCount = new uint[itemCount];
                for (int l = 0; l < itemCount; l++)
                {
                    Unk1[l] = packet.ReadInt32();
                    Unk2[l] = packet.ReadInt32();
                    ItemID[l] = Enum.Item.Enum(packet.ReadUInt32());
                    ItemCount[l] = packet.ReadUInt32();
                    Unk3[l] = packet.ReadInt32();
                    Unk4[l] = packet.ReadInt32();
                    Unk5[l] = packet.ReadByte();
                    Unk4[l] = packet.ReadInt16();
                }

                ushort PlayerCount = packet.ReadUInt16();
                // Doing it again for the players!
                long[] PlayerID = new long[PlayerCount];
                string[] Name = new string[PlayerCount];
                double[] Damage = new double[PlayerCount];
                byte[] Unk6 = new byte[PlayerCount];
                for (int l = 0; l < PlayerCount; l++)
                {
                    PlayerID[l] = packet.ReadInt64();
                    Name[l] = packet.ReadString();
                    Damage[l] = Convert.ToDouble(packet.ReadInt32());
                    Damage[l] = Damage[l] / 100;
                    Unk6[l] = packet.ReadByte();
                }

                ushort unk7 = packet.ReadUInt16();
                uint unk8 = packet.ReadUInt32();
                string Time = Misc.Misc.CalcTime(packet.ReadUInt32());
                uint unk9 = packet.ReadUInt32();

                //Write
                fileStream.WriteLine("Time: " + Time);
                fileStream.WriteLine("PlayerCount: " + PlayerCount);

                fileStream.WriteLine("\nItem ID, Item Count");
                for (int l = 0; l < itemCount; l++)
                {
                    fileStream.WriteLine(ItemID[l] + "," + ItemCount[l]);
                }

                fileStream.WriteLine("\nPlayer ID,Name,Damage");
                for (int l = 0; l < PlayerCount; l++)
                {
                    fileStream.WriteLine(PlayerID[l] + "," + Name[l] + "," + Damage[l] + "%");
                }
                fileStream.WriteLine("\n\n");
            }
        }
    }
}