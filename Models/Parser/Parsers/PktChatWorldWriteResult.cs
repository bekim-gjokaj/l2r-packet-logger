using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktChatWorldWriteResult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\PartyChat.csv", true))
            {
                if (stm.BaseStream.Length < 1)
                {
                    stm.WriteLine("Time,Name,Message,type,unk1,unk2,unk3,unk4,unk5,unk6,unk7,unk8");
                }

                packet.Skip(2);

                ulong unk1 = packet.ReadUInt64();
                ulong PlayerID = packet.ReadUInt64();
                string PlayerName = packet.ReadString();
                uint unk2 = packet.ReadUInt32();
                uint unk3 = packet.ReadUInt32();
                DateTime MessageTime = packet.ReadDate();
                string Message = packet.ReadString();
                ushort unk4 = packet.ReadUInt16();
                uint unk5 = packet.ReadUInt32();
                uint unk6 = packet.ReadUInt32();
                packet.Skip(21);
                byte unk7 = packet.ReadByte();
                byte unk8 = packet.ReadByte();
                stm.WriteLine(MessageTime + "," + PlayerName + "," + Message + ",WorldNotify," + unk1 + "," + unk2 + "," + unk3 + "," + unk4 + "," + unk5 + "," + unk6 + "," + unk7 + "," + unk8);
            }
        }
    }
}