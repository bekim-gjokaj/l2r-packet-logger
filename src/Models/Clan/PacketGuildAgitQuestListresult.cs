using Kamael.Packets.ExtensionMethods;
using System;
using System.IO;

namespace Kamael.Packets.Clan
{
    /// <summary>
    ///
    /// </summary>
    public class PacketGuildAgitQuestListresult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketGuildAgitQuestListresult" /> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketGuildAgitQuestListresult(IL2RPacket packet)
        {
            using (StreamWriter stm = new StreamWriter(@"Output\QuestList.csv", true))
            {
                stm.WriteLineAsync("QuestId,State,PlayerId,Player,Rank,CompletedAt");

                packet.Skip(2);

                byte[] unkHeader = packet.ReadBytes(4);
                uint numQuests = packet.ReadUInt16();

                for (int i = 0; i < numQuests; i++)
                {
                    uint questId = packet.ReadUInt32();

                    byte[] unk = packet.ReadBytes(4);

                    string state = Enum.QuestState.Enum(packet.ReadByte());
                    ulong playerId = packet.ReadUInt64();
                    string player = packet.ReadString();
                    string rank = CSV.guildMemberGrade.guildMemberGradeName(packet.ReadByte());
                    DateTime completedTime = DateTime.Now;//packet.ReadDate();

                    stm.WriteLineAsync(questId + "," + state + "," + playerId + "," + player + "," + rank + "," + completedTime);
                }
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
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int _index { get; set; }
    }
}