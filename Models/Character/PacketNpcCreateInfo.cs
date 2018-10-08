using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    internal class PacketNpcCreateInfo : IL2RPacket
    {
        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketNpcCreateInfo"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketNpcCreateInfo(IL2RPacket packet)
        {
            NPC.Add(new PacketNpc(packet));

            NPCMoving = packet.ReadUInt16();
            // PktNpcMoveInfo
            for (int i = 0; i < NPCMoving; i++)
            {
                NPCMoveInfo.Add(new PacketNpcMoveInfo(packet));
            }

            OwnerName = packet.ReadString();

            TargetID = packet.ReadUInt64();
        }

        /// <summary>
        /// Gets or sets the NPC.
        /// </summary>
        /// <value>
        /// The NPC.
        /// </value>
        private List<PacketNpc> NPC { get; set; }

        /// <summary>
        /// Gets or sets the NPC move information.
        /// </summary>
        /// <value>
        /// The NPC move information.
        /// </value>
        private List<PacketNpcMoveInfo> NPCMoveInfo { get; set; }

        /// <summary>
        /// Gets or sets the NPC moving.
        /// </summary>
        /// <value>
        /// The NPC moving.
        /// </value>
        private ushort NPCMoving { get; set; }

        /// <summary>
        /// Gets or sets the name of the owner.
        /// </summary>
        /// <value>
        /// The name of the owner.
        /// </value>
        private string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the target identifier.
        /// </summary>
        /// <value>
        /// The target identifier.
        /// </value>
        private ulong TargetID { get; set; }
    }
}