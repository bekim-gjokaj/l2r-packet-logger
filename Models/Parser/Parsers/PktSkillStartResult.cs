using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    internal class PktSkillStartResult
    {
        public Packet(PacketReader packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktSkillStartResult.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("TID,SkillInfoID,MP,TargetPosX,TargetPosY,ComboCount,HitList,HitActorID,CritHit,Damage,ParryingDamage,ActorHP,MPDamage,MissList,MissActorID,MissType,Junk");
                }

                packet.Skip(2);
                byte TID = packet.ReadByte();
                string SkillInfoID = CSV.skill.skillName(packet.ReadInt32());
                uint MP = packet.ReadUInt32();
                float TargetPosX = packet.ReadSingle();
                float TargetPosY = packet.ReadSingle();
                ushort ComboCount = packet.ReadUInt16();
                ushort HitList = packet.ReadUInt16();
                ulong[] HitActorID = new ulong[HitList];
                byte[] CritHit = new byte[HitList];
                int[] Damage = new int[HitList];
                int[] ParryingDamage = new int[HitList];
                uint[] ActorHP = new uint[HitList];
                uint[] MPDamage = new uint[HitList];

                for (int j = 0; j < HitList; j++)
                {
                    HitActorID[j] = packet.ReadUInt64();
                    CritHit[j] = packet.ReadByte();
                    Damage[j] = packet.ReadInt32();
                    ParryingDamage[j] = packet.ReadInt32();
                    ActorHP[j] = packet.ReadUInt32();
                    MPDamage[j] = packet.ReadUInt32();
                }

                ushort MissList = packet.ReadUInt16();
                ulong[] MissActorID = new ulong[MissList];
                byte[] MissType = new byte[MissList];

                for (int j = 0; j < MissList; j++)
                {
                    MissActorID[j] = packet.ReadUInt64();
                    MissType[j] = packet.ReadByte();
                }

                byte[] junkdata = packet.ReadBytes(packet.Remaining);

                /* Commented out until I figure this part out
                UInt16 PullList = packet.ReadUInt16();
                for (int j = 0; j < PullList; j++)
                {
                UInt64[] PullActorID = new UInt64[PullList];
                }

                UInt16 KBList = packet.ReadUInt16();
                for (int j = 0; j < KBList; j++)
                {
                UInt64[] PullActorID = new UInt64[KBList];
                }
                }*/

                ushort MaxArray = Math.Max(HitList, MissList);
                // MaxArray = Math.Max(MaxArray, PullList);
                // MaxArray = Math.Max(MaxArray, KBList);

                for (int j = 0; j < MaxArray; j++)
                {
                    fileStream.Write(TID + "," + SkillInfoID + "," + MP + "," + TargetPosX + "," + TargetPosY + "," + ComboCount + "," + HitList + ",");
                    if (HitList < MaxArray)
                    {
                        fileStream.Write(",,,,,,");
                    }
                    else
                    {
                        fileStream.Write(HitActorID[j] + "," + CritHit[j] + "," + Damage[j] + "," + ParryingDamage[j] + "," + ActorHP[j] + "," + MPDamage[j] + ",");
                    }
                    fileStream.Write(MissList + ",");
                    if (MissList < MaxArray)
                    {
                        fileStream.Write(",,");
                    }
                    else
                    {
                        fileStream.Write(MissActorID[j] + "," + MissType[j] + ",");
                    }
                    fileStream.Write(string.Join(",", junkdata) + "\n");
                }
            }
        }
    }
}