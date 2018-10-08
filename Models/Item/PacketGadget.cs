using Kamael.Packets.ExtensionMethods;

namespace Kamael.Packets.Item
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketGadget : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketGadget"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketGadget(IL2RPacket packet)
        {
            GadgetUID = packet.ReadUInt64();
            GadgetID = packet.ReadUInt32();
            XPos = packet.ReadSingle();
            YPos = packet.ReadSingle();
            ZPos = packet.ReadSingle();
            Direction = packet.ReadSingle();
            Active = packet.ReadByte();
            OwnerName = packet.ReadString();//This is a guess
            RemainCount = packet.ReadUInt32();
        }

        public byte[] _bytes { get; set; }
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// </summary>
        /// <value>
        /// The active.
        /// </value>
        private byte Active { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        private float Direction { get; set; }

        /// <summary>
        /// Gets or sets the gadget identifier.
        /// </summary>
        /// <value>
        /// The gadget identifier.
        /// </value>
        private uint GadgetID { get; set; }

        /// <summary>
        /// Gets or sets the gadget uid.
        /// </summary>
        /// <value>
        /// The gadget uid.
        /// </value>
        private ulong GadgetUID { get; set; }

        /// <summary>
        /// Gets or sets the name of the owner.
        /// </summary>
        /// <value>
        /// The name of the owner.
        /// </value>
        private string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the remain count.
        /// </summary>
        /// <value>
        /// The remain count.
        /// </value>
        private uint RemainCount { get; set; }

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