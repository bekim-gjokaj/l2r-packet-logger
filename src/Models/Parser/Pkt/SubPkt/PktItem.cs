using System;

namespace L2RKamael.Parser.Pkt
{
    internal class PktItem

    {
        public Packet(PacketReader packet)
        {
            

            ulong UItemID = packet.ReadUInt64();
            string ItemID = Enum.Item.Enum(packet.ReadUInt32());
            uint Exp = packet.ReadUInt32();
            byte Level = packet.ReadByte();
            byte EnchantLevel = packet.ReadByte();
            byte LimitBreakCount = packet.ReadByte();
            byte LimitBreakAddRate = packet.ReadByte();
            ushort Count = packet.ReadUInt16();
            byte Liked = packet.ReadByte();
            DateTime LootedTime = packet.ReadDate();
            ushort BasicOptionLength = packet.ReadUInt16();
            string[] BasicOption = { "", "", "" };
            for (int k = 0; BasicOptionLength > k; k++)
            {
                PktItemOption.Packet(packet);
            }
            ushort SocketListLength = packet.ReadUInt16();
            string[] SocketList = { "", "", "", "", "", "" };
            for (int k = 0; SocketListLength > k; k++)
            {
                ulong SocketID = packet.ReadUInt64();
                string SocketName = Enum.Item.Enum(packet.ReadUInt32());
                packet.Skip(4);
                SocketList[k] = "\"" + SocketName + "\"";
                ushort SoulCrystalCount = packet.ReadUInt16();
                packet.Skip(1);
            }
            byte Bind = packet.ReadByte();
            byte AbilityLevel = packet.ReadByte();
            ushort AbilityUpgradeAddRate = packet.ReadUInt16();
            byte CraftFlag = packet.ReadByte();
            uint EventPeriodID = packet.ReadUInt32();
            ulong ExpireTime = packet.ReadUInt64();
        }
    }
}