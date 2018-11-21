using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    public class PacketActorOwnerInfo : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketActorOwnerInfo" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketActorOwnerInfo(IL2RPacket packet)
        {
            ActorUID = packet.ReadUInt64();
            ActorType = packet.ReadByte(); // Could be UInt
            OwnerNamer = packet.ReadString();
        }

        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the type of the actor.
        /// </summary>
        /// <value>
        /// The type of the actor.
        /// </value>
        private byte ActorType { get; set; }

        /// <summary>
        /// Gets or sets the actor uid.
        /// </summary>
        /// <value>
        /// The actor uid.
        /// </value>
        private ulong ActorUID { get; set; }

        /// <summary>
        /// Gets or sets the owner namer.
        /// </summary>
        /// <value>
        /// The owner namer.
        /// </value>
        private string OwnerNamer { get; set; }
    }
}