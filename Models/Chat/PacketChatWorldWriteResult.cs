using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Chat
{
    /// <summary>
    ///
    /// </summary>
    internal class PacketChatWorldWriteResult : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketChatWorldWriteResult" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketChatWorldWriteResult(IL2RPacket packet)
        {
            packet.Skip(2);

            ChatList.Add(new PacketChat(packet));
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
        /// Gets or sets the chat list.
        /// </summary>
        /// <value>
        /// The chat list.
        /// </value>
        private List<PacketChat> ChatList { get; set; }
    }
}