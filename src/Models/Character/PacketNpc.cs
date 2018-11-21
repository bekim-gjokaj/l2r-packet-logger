using Kamael.Packets.ExtensionMethods;
using Kamael.Packets.Status;
using System.Collections.Generic;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketNpc : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketNpc"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketNpc(IL2RPacket packet)
        {
            NPCUID = packet.ReadUInt64();
            NPCID = packet.ReadUInt32();
            XPos = packet.ReadSingle();
            YPos = packet.ReadSingle();
            ZPos = packet.ReadSingle();
            Direction = packet.ReadSingle();
            CurrentHP = packet.ReadUInt32();
            MaxHP = packet.ReadUInt32();
            MoveSpeed = packet.ReadUInt32();

            ushort BuffCount = packet.ReadUInt16();
            // PktBuffInfo
            for (int i = 0; i < BuffCount; i++)
            {
                BuffInfoList.Add(new PacketBuffInfo(packet));
            }

            byte CombatMode = packet.ReadByte();
            uint SpawnInfoId = packet.ReadUInt32();
            ulong TeamID = packet.ReadUInt64();
        }

        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the buff count.
        /// </summary>
        /// <value>
        /// The buff count.
        /// </value>
        private ushort BuffCount { get; set; }

        /// <summary>
        /// Gets or sets the buff information list.
        /// </summary>
        /// <value>
        /// The buff information list.
        /// </value>
        private List<PacketBuffInfo> BuffInfoList { get; set; }

        /// <summary>
        /// Gets or sets the combat mode.
        /// </summary>
        /// <value>
        /// The combat mode.
        /// </value>
        private byte CombatMode { get; set; }

        /// <summary>
        /// Gets or sets the current hp.
        /// </summary>
        /// <value>
        /// The current hp.
        /// </value>
        private uint CurrentHP { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        private float Direction { get; set; }

        /// <summary>
        /// Gets or sets the maximum hp.
        /// </summary>
        /// <value>
        /// The maximum hp.
        /// </value>
        private uint MaxHP { get; set; }

        /// <summary>
        /// Gets or sets the move speed.
        /// </summary>
        /// <value>
        /// The move speed.
        /// </value>
        private uint MoveSpeed { get; set; }

        /// <summary>
        /// Gets or sets the npcid.
        /// </summary>
        /// <value>
        /// The npcid.
        /// </value>
        private uint NPCID { get; set; }

        /// <summary>
        /// Gets or sets the npcuid.
        /// </summary>
        /// <value>
        /// The npcuid.
        /// </value>
        private ulong NPCUID { get; set; }

        /// <summary>
        /// Gets or sets the spawn information identifier.
        /// </summary>
        /// <value>
        /// The spawn information identifier.
        /// </value>
        private uint SpawnInfoId { get; set; }

        /// <summary>
        /// Gets or sets the team identifier.
        /// </summary>
        /// <value>
        /// The team identifier.
        /// </value>
        private ulong TeamID { get; set; }

        /// <summary>
        /// Gets or sets the x position.
        /// </summary>
        /// <value>
        /// The x position.
        /// </value>
        private float XPos { get; set; }

        /// <summary>
        /// Gets or sets the y position.
        /// </summary>
        /// <value>
        /// The y position.
        /// </value>
        private float YPos { get; set; }

        /// <summary>
        /// Gets or sets the z position.
        /// </summary>
        /// <value>
        /// The z position.
        /// </value>
        private float ZPos { get; set; }
    }
}