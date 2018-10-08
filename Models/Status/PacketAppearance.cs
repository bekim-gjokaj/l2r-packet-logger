using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Status
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketAppeareance : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketAppeareance"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketAppeareance(IL2RPacket packet)
        {
            HairID = packet.ReadByte();
            HairStyleID = packet.ReadByte();
            HairColorID = packet.ReadByte();
        }

        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the hair color identifier.
        /// </summary>
        /// <value>
        /// The hair color identifier.
        /// </value>
        private byte HairColorID { get; set; }

        /// <summary>
        /// Gets or sets the hair identifier.
        /// </summary>
        /// <value>
        /// The hair identifier.
        /// </value>
        private byte HairID { get; set; }

        /// <summary>
        /// Gets or sets the hair style identifier.
        /// </summary>
        /// <value>
        /// The hair style identifier.
        /// </value>
        private byte HairStyleID { get; set; }
    }
}