using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    public class PacketBuffInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketBuffInfo" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketBuffInfo(IL2RPacket packet)
        {
            // All of this is wrong but works to get past it.
            SkillUID = packet.ReadUInt64();
            SkillID = packet.ReadUInt32();
            BuffID = packet.ReadUInt32();
            BuffLv = packet.ReadUInt32();
            StackCount = packet.ReadUInt16();
            EndTime = packet.ReadUInt64();
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
        /// Gets or sets the buff identifier.
        /// </summary>
        /// <value>
        /// The buff identifier.
        /// </value>
        private uint BuffID { get; set; }

        /// <summary>
        /// Gets or sets the buff lv.
        /// </summary>
        /// <value>
        /// The buff lv.
        /// </value>
        private uint BuffLv { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        private ulong EndTime { get; set; }

        /// <summary>
        /// Gets or sets the skill identifier.
        /// </summary>
        /// <value>
        /// The skill identifier.
        /// </value>
        private uint SkillID { get; set; }

        /// <summary>
        /// Gets or sets the skill uid.
        /// </summary>
        /// <value>
        /// The skill uid.
        /// </value>
        private ulong SkillUID { get; set; }

        /// <summary>
        /// Gets or sets the stack count.
        /// </summary>
        /// <value>
        /// The stack count.
        /// </value>
        private ushort StackCount { get; set; }
    }
}