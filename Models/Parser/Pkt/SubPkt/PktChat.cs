using System;

namespace L2RKamael.Parser.Pkt
{
    internal class PktChat
    {
        public Packet(PacketReader packet)
        {
            

            ulong ChatUID = packet.ReadUInt64();
            ulong PlayerUID = packet.ReadUInt64();
            string PlayerName = packet.ReadString();
            string Race = CSV.race.RaceName(packet.ReadInt32());
            string PlayerClass = CSV.Class.className(packet.ReadUInt32());
            DateTime MsgTime = packet.ReadDate();
            string Message = packet.ReadString();
            ushort Level = packet.ReadUInt16();
            uint EmblemSymbolID = packet.ReadUInt32();
            uint EmblemBackgroundID = packet.ReadUInt32();

            uint LinkWorldBossID = packet.ReadUInt32();
            uint LinkWorldBossDieID = packet.ReadUInt32();
            uint LinkWorldBossDespawnID = packet.ReadUInt32();

            ushort LinkItem = packet.ReadUInt16();
            if (LinkItem > 0)
            {
                Parser.Pkt.PktLinkItem.Packet(packet);
            }

            ushort LinkDungeon = packet.ReadUInt16();
            if (LinkDungeon > 0)
            {
                Parser.Pkt.PktLinkDungeon.Packet(packet);
            }

            ushort LinkGuildDungeon = packet.ReadUInt16();
            if (LinkGuildDungeon > 0)
            {
                Parser.Pkt.PktLinkGuildDungeon.Packet(packet);
            }

            string LinkVoice = packet.ReadString();
            byte LinkType = packet.ReadByte();
            uint LinkSpotID = packet.ReadUInt32();
            byte LanguageType = packet.ReadByte();
        }
    }
}