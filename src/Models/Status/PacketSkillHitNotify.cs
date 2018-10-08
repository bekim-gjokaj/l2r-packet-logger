using L2RKamael.ExtensionMethods;
using L2RKamael.Packets;
using System;
using System.IO;

namespace L2RKamael.Parser.Parsers
{
    /// <summary>
    /// 
    /// </summary>
    internal class PacketSkillHitNotify
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketSkillHitNotify"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketSkillHitNotify(IL2RPacket packet)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Output\PktSkillHitNotify.csv", true))
            {
                if (fileStream.BaseStream.Length < 1)
                {
                    fileStream.WriteLine("ActorID,SkillInfoID,ComboCount,HitList,HitActorID,CritHit,Damage,ParryingDamage,ActorHP,MPDamage,MissList,MissActorID,MissType,Junk");
                }

                ActorID = packet.ReadUInt64();
                SkillInfoID = CSV.skill.skillName(packet.ReadInt32());
                ComboCount = packet.ReadUInt16();
                HitList = packet.ReadUInt16();
                HitActorID = new ulong[HitList];
                CritHit = new byte[HitList];
                Damage = new int[HitList];
                ParryingDamage = new int[HitList];
                ActorHP = new uint[HitList];
                MPDamage = new uint[HitList];

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

                //byte[] junkdata = packet.ReadBytes(packet.Remaining);

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
                    fileStream.Write(ActorID + "," + SkillInfoID + "," + ComboCount + "," + HitList + ",");
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
                    //fileStream.Write(string.Join(",", junkdata) + "\n");
                }
            }
        }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public int _index { get; set; }
        /// <summary>
        /// Gets or sets the actor hp.
        /// </summary>
        /// <value>
        /// The actor hp.
        /// </value>
        private uint[] ActorHP { get; set; }

        /// <summary>
        /// Gets or sets the actor identifier.
        /// </summary>
        /// <value>
        /// The actor identifier.
        /// </value>
        private ulong ActorID { get; set; }
        /// <summary>
        /// Gets or sets the combo count.
        /// </summary>
        /// <value>
        /// The combo count.
        /// </value>
        private ushort ComboCount { get; set; }

        /// <summary>
        /// Gets or sets the crit hit.
        /// </summary>
        /// <value>
        /// The crit hit.
        /// </value>
        private byte[] CritHit { get; set; }

        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        /// <value>
        /// The damage.
        /// </value>
        private int[] Damage { get; set; }

        /// <summary>
        /// Gets or sets the hit actor identifier.
        /// </summary>
        /// <value>
        /// The hit actor identifier.
        /// </value>
        private ulong[] HitActorID { get; set; }

        /// <summary>
        /// Gets or sets the hit list.
        /// </summary>
        /// <value>
        /// The hit list.
        /// </value>
        private ushort HitList { get; set; }

        /// <summary>
        /// Gets or sets the mp damage.
        /// </summary>
        /// <value>
        /// The mp damage.
        /// </value>
        private uint[] MPDamage { get; set; }

        /// <summary>
        /// Gets or sets the parrying damage.
        /// </summary>
        /// <value>
        /// The parrying damage.
        /// </value>
        private int[] ParryingDamage { get; set; }

        /// <summary>
        /// Gets or sets the skill information identifier.
        /// </summary>
        /// <value>
        /// The skill information identifier.
        /// </value>
        private string SkillInfoID { get; set; }
    }
}