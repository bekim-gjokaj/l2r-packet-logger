using System;

namespace L2RKamael.Parser.Pkt
{
    public class PktSightEnterNotify : IL2RPacket
    {
        public Packet(PacketReader packet)
        {
            

            ushort PlayerCount = packet.ReadUInt16();
            for (int i = 0; i < PlayerCount; i++)
            {
                PktOtherPlayer.Packet(packet);
            }

            ushort NPCCount = packet.ReadUInt16();
            for (int i = 0; i < NPCCount; i++)
            {
                PktNpcCreateInfo.Packet(packet);
            }

            ushort ProjectileCount = packet.ReadUInt16();
            for (int i = 0; i < ProjectileCount; i++)
            {
                PktProjectileInfo.Packet(packet);
            }

            ushort GroundObjectCount = packet.ReadUInt16();
            for (int i = 0; i < GroundObjectCount; i++)
            {
                PktGroundObjectInfo.Packet(packet);
            }

            ushort GadgetCount = packet.ReadUInt16();
            for (int i = 0; i < GadgetCount; i++)
            {
                PktGadget.Packet(packet);
            }

            ushort ActorOwerInfoCount = packet.ReadUInt16();
            for (int i = 0; i < ActorOwerInfoCount; i++)
            {
                PktActorOwnerInfo.Packet(packet);
            }

            ushort BossNpcCombatStartTimeCount = packet.ReadUInt16();
            for (int i = 0; i < BossNpcCombatStartTimeCount; i++)
            {
                ulong BossUID = packet.ReadUInt64();
                DateTime Time = packet.ReadDate();
            }
        }
    }
}