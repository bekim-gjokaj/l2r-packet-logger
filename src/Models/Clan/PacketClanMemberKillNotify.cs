using System.IO;

namespace Kamael.Packets.Clan
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketClanMemberKillNotify : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketClanMemberKillNotify" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketClanMemberKillNotify(L2RPacket packet)
        {
            using (StreamWriter fileStreamer = new StreamWriter(@"Output\GuildPvp.Txt", true))
            {
                ClanName = packet.ReadString();
                PlayerName = packet.ReadString();
                Clan2Name = packet.ReadString();
                Player2Name = packet.ReadString();
                // Unknown Int32, Unknown byte
                fileStreamer.WriteLine(PlayerName + "(" + ClanName + ") Killed " + Player2Name + "(" + Clan2Name + ").");
            }
        }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public byte[] _bytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public int _index { get; set; }

        /// <summary>
        /// Gets or sets the name of the clan2.
        /// </summary>
        /// <value>
        /// The name of the clan2.
        /// </value>
        public string Clan2Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the clan.
        /// </summary>
        /// <value>
        /// The name of the clan.
        /// </value>
        public string ClanName { get; set; }

        /// <summary>
        /// Gets or sets the name of the player2.
        /// </summary>
        /// <value>
        /// The name of the player2.
        /// </value>
        public string Player2Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        public string PlayerName { get; set; }
    }
}