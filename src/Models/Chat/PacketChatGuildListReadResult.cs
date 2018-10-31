using Kamael.Packets;
using System;
using System.IO;

namespace Kamael.Packets.Chat
{
    public class PacketChatGuildListReadResult : IL2RPacket
    {
        public byte[] _bytes { get; set; }
        public int _index { get; set; }
        public ulong unk1 { get; set; }
        public ulong PlayerID  { get; set; }
        public string PlayerName { get; set; }
        public uint unk2 { get; set; }
        public uint unk3 { get; set; }
        public DateTime MessageTime { get; set; }
        public string Message { get; set; }
        public uint unk4  { get; set; }
        public byte unk5  { get; set; }
        public byte unk6  { get; set; }
        public PacketChatGuildListReadResult(L2RPacket packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\GuildChat.csv", true))
            {
                if (stm.BaseStream.Length < 1)
                {
                    stm.WriteLineAsync("Time,Name,Message,type,unk1,unk2,unk3,unk4,unk5,unk6");
                }

                packet.Skip(11);

                ushort numMessages = packet.ReadUInt16();

                for (int i = 0; i < 1; i++)
                {
                    unk1 = packet.ReadUInt64();
                    PlayerID = packet.ReadUInt64();
                    PlayerName = packet.ReadString();
                    unk2 = packet.ReadUInt32();
                    unk3 = packet.ReadUInt32();
                    MessageTime = packet.ReadDate();
                    Message = packet.ReadString();
                    unk4 = packet.ReadUInt32();
                    packet.Skip(27);
                    unk5 = packet.ReadByte();
                    unk6 = packet.ReadByte();
                    stm.WriteLineAsync(MessageTime + "," + PlayerName + "," + Message + ",GuildRead," + unk1 + "," + unk2 + "," + unk3 + "," + unk4 + "," + unk5 + "," + unk6);
                }
            }
        }
    }
}