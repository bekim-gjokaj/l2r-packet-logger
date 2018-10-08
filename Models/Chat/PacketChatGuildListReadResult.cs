﻿using Kamael.Packets.ExtensionMethods;
using System.Collections.Generic;

namespace Kamael.Packets.Chat
{
    /// <summary>
    ///
    /// </summary>
    internal class PacketChatGuildListReadResult : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketChatGuildListReadResult"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketChatGuildListReadResult(IL2RPacket packet)
        {
            packet.Skip(2);

            IsPrevMessage = packet.ReadByte();
            LastChatID = packet.ReadUInt64();
            numMessages = packet.ReadUInt16();

            for (int i = 0; i < numMessages; i++)
            {
                ChatGuildListReadResultSet.Add(new PacketChatGuildListReadResult(packet));
            }
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
        /// Gets or sets the chat guild list read result set.
        /// </summary>
        /// <value>
        /// The chat guild list read result set.
        /// </value>
        private List<PacketChatGuildListReadResult> ChatGuildListReadResultSet { get; set; }

        /// <summary>
        /// Gets or sets the is previous message.
        /// </summary>
        /// <value>
        /// The is previous message.
        /// </value>
        private byte IsPrevMessage { get; set; }

        /// <summary>
        /// Gets or sets the last chat identifier.
        /// </summary>
        /// <value>
        /// The last chat identifier.
        /// </value>
        private ulong LastChatID { get; set; }

        /// <summary>
        /// Gets or sets the number messages.
        /// </summary>
        /// <value>
        /// The number messages.
        /// </value>
        private ushort numMessages { get; set; }
    }
}