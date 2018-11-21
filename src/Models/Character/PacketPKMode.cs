using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    public class PacketPKMode : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketPKMode"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketPKMode(IL2RPacket packet)
        {
            PkStatus = packet.ReadByte();
            Monster = packet.ReadByte();
            Guild = packet.ReadByte();
            Alliance = packet.ReadByte();
            Friends = packet.ReadByte();
            EtcPlayer = packet.ReadByte();
            BadPlayer = packet.ReadByte();
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
        /// Gets or sets the alliance.
        /// </summary>
        /// <value>
        /// The alliance.
        /// </value>
        private byte Alliance { get; set; }

        /// <summary>
        /// Gets or sets the bad player.
        /// </summary>
        /// <value>
        /// The bad player.
        /// </value>
        private byte BadPlayer { get; set; }

        /// <summary>
        /// Gets or sets the etc player.
        /// </summary>
        /// <value>
        /// The etc player.
        /// </value>
        private byte EtcPlayer { get; set; }

        /// <summary>
        /// Gets or sets the friends.
        /// </summary>
        /// <value>
        /// The friends.
        /// </value>
        private byte Friends { get; set; }

        /// <summary>
        /// Gets or sets the guild.
        /// </summary>
        /// <value>
        /// The guild.
        /// </value>
        private byte Guild { get; set; }

        /// <summary>
        /// Gets or sets the monster.
        /// </summary>
        /// <value>
        /// The monster.
        /// </value>
        private byte Monster { get; set; }

        /// <summary>
        /// Gets or sets the pk status.
        /// </summary>
        /// <value>
        /// The pk status.
        /// </value>
        private byte PkStatus { get; set; }
    }
}