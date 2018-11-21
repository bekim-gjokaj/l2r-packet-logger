using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    public class PacketNpcMoveInfo : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketNpcMoveInfo"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketNpcMoveInfo(IL2RPacket packet)
        {
            //PktVector
            DestinationXPos = packet.ReadSingle();
            DestinationYPos = packet.ReadSingle();
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
        /// Gets or sets the destination x position.
        /// </summary>
        /// <value>
        /// The destination x position.
        /// </value>
        private float DestinationXPos { get; set; }

        /// <summary>
        /// Gets or sets the destination y position.
        /// </summary>
        /// <value>
        /// The destination y position.
        /// </value>
        private float DestinationYPos { get; set; }
    }
}