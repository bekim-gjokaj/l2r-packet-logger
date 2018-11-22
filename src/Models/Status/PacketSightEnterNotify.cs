using Kamael.Packets;
using Kamael.Packets.Character;
using Kamael.Packets.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace L2RKamael.Packets.Status
{
    public class PacketSightEnterNotify : IL2RPacket
    {
        public byte[] _bytes { get; set; }
        public int _index { get; set; }
        public List<PacketOtherPlayer> Players = new List<PacketOtherPlayer>();

        public PacketSightEnterNotify(IL2RPacket packet)
        {



            UInt16 PlayerCount = packet.ReadUInt16();
            for (int i = 0; i < PlayerCount; i++)
            {
                Players.Add(new PacketOtherPlayer(packet));
            }

            UInt16 NPCCount = packet.ReadUInt16();
            for (int i = 0; i < NPCCount; i++)
            {
                //PktNpcCreateInfo.Packet(packet);
            }

            UInt16 ProjectileCount = packet.ReadUInt16();
            for (int i = 0; i < ProjectileCount; i++)
            {
                //PktProjectileInfo.Packet(packet);
            }

            UInt16 GroundObjectCount = packet.ReadUInt16();
            for (int i = 0; i < GroundObjectCount; i++)
            {
                //PktGroundObjectInfo.Packet(packet);
            }

            UInt16 GadgetCount = packet.ReadUInt16();
            for (int i = 0; i < GadgetCount; i++)
            {
                //PktGadget.Packet(packet);
            }

            UInt16 ActorOwerInfoCount = packet.ReadUInt16();
            for (int i = 0; i < ActorOwerInfoCount; i++)
            {
                //PktActorOwnerInfo.Packet(packet);
            }


            UInt16 BossNpcCombatStartTimeCount = packet.ReadUInt16();
            for (int i = 0; i < BossNpcCombatStartTimeCount; i++)
            {
                //UInt64 BossUID = packet.ReadUInt64();
                //DateTime Time = packet.ReadDate();
            }
        }
    }
}