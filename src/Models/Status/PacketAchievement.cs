using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketAchievement : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketAchievement" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketAchievement(IL2RPacket packet)
        {
            EAchievementType = packet.ReadByte();
            AchievementInfoID = packet.ReadUInt32();
            EAchievementState = packet.ReadByte();
            TaskParam = packet.ReadUInt32();
        }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the achievement information identifier.
        /// </summary>
        /// <value>
        /// The achievement information identifier.
        /// </value>
        private uint AchievementInfoID { get; set; }

        /// <summary>
        /// Gets or sets the state of the e achievement.
        /// </summary>
        /// <value>
        /// The state of the e achievement.
        /// </value>
        private byte EAchievementState { get; set; }

        /// <summary>
        /// Gets or sets the type of the e achievement.
        /// </summary>
        /// <value>
        /// The type of the e achievement.
        /// </value>
        private byte EAchievementType { get; set; }

        /// <summary>
        /// Gets or sets the task parameter.
        /// </summary>
        /// <value>
        /// The task parameter.
        /// </value>
        private uint TaskParam { get; set; }
    }
}