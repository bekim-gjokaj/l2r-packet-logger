using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktBagListReadresult
    {
        public Packet(PacketReader packet)
        {
            

            using (StreamWriter fileStream = new StreamWriter(@"Output\Inventory.csv", true))
            {
                packet.Skip(2);

                ushort BagCount = packet.ReadUInt16();
                byte BagType = packet.ReadByte();
                ushort MaxInvenSize = packet.ReadUInt16();
                ushort ExpInvenSize = packet.ReadUInt16();
                ushort UsedInvenSize = packet.ReadUInt16();

                fileStream.WriteLine("Bag Number, Max Inv Size, Expanded Inv Size, Filled Inv Size");
                fileStream.WriteLine(BagCount + "," + MaxInvenSize + "," + ExpInvenSize + "," + UsedInvenSize + "\n");

                //Writes header for the PktBagListReadresult
                fileStream.WriteLine("UItemID,Time Looted,Name,Type,Level,Exp,Count,Liked," +
                    "Bind,Item Option,Item Option,Item Option,Socket 1," +
                    "Socket 2,Socket 3,Socket 4, Socket 5,Socket 6," +
                    "Limit Break Count,Limit Break Add Rate,Ability Level,Ability Upgrade Add Rate");

                for (int j = 0; j < UsedInvenSize; j++)
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
                        string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
                        uint IOvalue = packet.ReadUInt32();
                        BasicOption[k] = "\"" + ItemOption + "(+" + IOvalue + ")\"";
                    }
                    ushort SocketListLength = packet.ReadUInt16();
                    string[] SocketList = { "", "", "", "", "", "" };
                    for (int k = 0; SocketListLength > k; k++)
                    {
                        ulong SoulCrystalID = packet.ReadUInt64();
                        string SoulCrystalName = Enum.Item.Enum(packet.ReadUInt32());
                        int SoulCrystalEXP = packet.ReadInt32();
                        byte SoulCrystalLevel = packet.ReadByte();
                        ushort SoulCrystalCount = packet.ReadUInt16();
                        for (int i = 0; i < SoulCrystalCount; i++)
                        {
                            string ItemOption = CSV.itemOption.itemOptionName(packet.ReadInt32());
                            uint IOvalue = packet.ReadUInt32();
                        }
                        SocketList[k] = "\"" + SoulCrystalName + "\"";
                    }
                    byte Bind = packet.ReadByte();
                    byte AbilityLevel = packet.ReadByte();
                    ushort AbilityUpgradeAddRate = packet.ReadUInt16();
                    byte CraftFlag = packet.ReadByte();
                    uint EventPeriodID = packet.ReadUInt32();
                    ulong ExpireTime = packet.ReadUInt64();

                    string EnchantLevelPlus = "";

                    if (EnchantLevel > 0)
                    {
                        EnchantLevelPlus = "+" + EnchantLevel + " ";
                    }

                    fileStream.WriteLine(UItemID + "," + LootedTime + "," + EnchantLevelPlus + ItemID + "," + Level + "," + Exp + "," +
                        Count + "," + Liked + "," + Bind + "," + BasicOption[0] +
                        "," + BasicOption[1] + "," + BasicOption[2] +
                        "," + SocketList[0] + "," + SocketList[1] + "," + SocketList[2] + "," + SocketList[3] +
                        "," + SocketList[4] + "," + SocketList[5] + "," + LimitBreakCount + "," + LimitBreakAddRate + "," +
                        AbilityLevel + "," + AbilityUpgradeAddRate);
                }
                fileStream.WriteLine("\n\n");
            }
        }
    }
}