using System.Collections.Generic;

namespace Kamael.Packets.Chat
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    internal class PacketChatPartyWriteNotify : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketChatPartyWriteNotify" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketChatPartyWriteNotify(IL2RPacket packet)
        {
            //Packet.skip(2);
            ChatList.Add(new PacketChat(packet));
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
        /// Gets or sets the chat list.
        /// </summary>
        /// <value>
        /// The chat list.
        /// </value>
        private List<PacketChat> ChatList { get; set; }
    }
}