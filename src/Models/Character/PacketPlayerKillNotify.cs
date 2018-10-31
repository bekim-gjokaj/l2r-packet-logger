﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketPlayerKillNotify : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketPlayerKillNotify" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketPlayerKillNotify(L2RPacket packet)
        {
            using (StreamWriter fileStreamer = new StreamWriter(@"Output\GuildPvp.Txt", true))
            {
                ClanName = packet.ReadString();
                PlayerName = packet.ReadString();
                Clan2Name = packet.ReadString();
                Player2Name = packet.ReadString();
                var region = GetRegionByCode(packet.ReadInt32());
                Region = region.Key;
                Channel = region.Value;
                var Unknown = packet.ReadByte();

                // Unknown Int32, Unknown byte
                fileStreamer.WriteLineAsync(PlayerName + "(" + ClanName + ") Killed " + Player2Name + "(" + Clan2Name + ").");
            }
        }


        private KeyValuePair<string, string> GetRegionByCode(Int32 Region)
        {

            var tmpRegion = Region.ToString();
            var regionLen = tmpRegion.Length - 3;

            string region = "";
            string chan = "";

            if (regionLen > 0 && regionLen > 3)
            {
                region = tmpRegion.Substring(0, regionLen);
                chan = tmpRegion.Substring(regionLen - 1, 1);

                switch (region)
                {
                    case "332800":
                        region = "Extraction Pit";
                        break;
                }

            }

            return new KeyValuePair<string, string>(region, chan);

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

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        public string Region { get; set; }

        public string Channel { get; set; }
    }
}