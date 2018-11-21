using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    public class PacketGroundObjectInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketGroundObjectInfo"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketGroundObjectInfo(IL2RPacket packet)
        {
            GroundObjectUID = packet.ReadUInt64();
            GroundObjectID = packet.ReadUInt32();
            SkillInfoID = packet.ReadUInt32();
            OwnerUID = packet.ReadUInt64();
            XPos = packet.ReadSingle();
            YPos = packet.ReadSingle();
            ZPos = packet.ReadSingle();
            Direction = packet.ReadSingle();
            ElapsedTime = packet.ReadUInt32();
        }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        private float Direction { get; set; }

        /// <summary>
        /// Gets or sets the elapsed time.
        /// </summary>
        /// <value>
        /// The elapsed time.
        /// </value>
        private uint ElapsedTime { get; set; }

        /// <summary>
        /// Gets or sets the ground object identifier.
        /// </summary>
        /// <value>
        /// The ground object identifier.
        /// </value>
        private uint GroundObjectID { get; set; }

        /// <summary>
        /// Gets or sets the ground object uid.
        /// </summary>
        /// <value>
        /// The ground object uid.
        /// </value>
        private ulong GroundObjectUID { get; set; }

        /// <summary>
        /// Gets or sets the owner uid.
        /// </summary>
        /// <value>
        /// The owner uid.
        /// </value>
        private ulong OwnerUID { get; set; }

        /// <summary>
        /// Gets or sets the skill information identifier.
        /// </summary>
        /// <value>
        /// The skill information identifier.
        /// </value>
        private uint SkillInfoID { get; set; }

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