using Kamael.Packets.ExtensionMethods;
using Kamael.Packets.Item;
using Kamael.Packets.Items;
using Kamael.Packets.Status;
using System.Collections.Generic;

namespace Kamael.Packets.Character
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Kamael.Packets.IL2RPacket" />
    public class PacketOtherPlayer : IL2RPacket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketOtherPlayer"/> class.
        /// </summary>
        /// <param name="packet">The packet.</param>
        public PacketOtherPlayer(IL2RPacket packet)
        {
            PlayerUID = packet.ReadUInt64();
            PlayerName = packet.ReadString();
            Race = packet.ReadUInt32();
            Class = packet.ReadUInt32();
            Level = packet.ReadUInt16();
            XPos = packet.ReadSingle();
            YPos = packet.ReadSingle();
            ZPos = packet.ReadSingle();
            Direction = packet.ReadSingle();
            CurHP = packet.ReadUInt32();
            MaxHP = packet.ReadUInt32();
            MoveSpeed = packet.ReadUInt32();
            BuffCount = packet.ReadUInt16();
            // PktBuffInfo
            BuffInfoList = new List<PacketBuffInfo>();
            for (int i = 0; i < BuffCount; i++)
            {
                ////PktBuffInfo.Packet(packet);
                BuffInfoList.Add(new PacketBuffInfo(packet));
            }

            CombatMode = packet.ReadByte();
            SoulShotEnabled = packet.ReadByte();
            PKStatus = packet.ReadByte();
            PKAttackState = packet.ReadByte();
            PKPoint = packet.ReadUInt32();

            //// PktAppearance
            //AppearanceList.Add(new PacketAppeareance(packet));

            EquipCount = packet.ReadUInt16();
            // PktSimpleEquipment
            SimpleEquipList = new List<PacketSimpleEquipment>();
            for (int i = 0; i < EquipCount; i++)
            {
                //SimpleEquipList.Add(new PacketSimpleEquipment(packet));
            }

            TeamID = packet.ReadUInt64();
            ControlGadgetID = packet.ReadUInt64();

            Guilded = packet.ReadByte();
            // PktPlayerGuild
            PlayerGuildList = new List<PacketPlayerGuild>();
            if (Guilded > 0)
            {
                PlayerGuildList.Add(new PacketPlayerGuild(packet));
            }

            RidingPetInfoID = packet.ReadUInt32();
            RidingPetLevel = packet.ReadUInt16();
            RidingPetGrade = packet.ReadByte();

            EquippedTitleInfoID = packet.ReadUInt32();

            //pktPartyEmblem
            byte SetEmblem = packet.ReadByte();
            if (SetEmblem > 0)
            {
                //PartyEmblemList.Add(new PacketPartyEmblem(packet));
            }

            //PktSimpleCape
            //SimpleCapeList.Add(new PacketSimpleCape(packet));

            //PktPKMode
            PKModeList = new List<PacketPKMode>();
            PKModeList.Add(new PacketPKMode(packet));

            CurBarrier = packet.ReadUInt32();
            MaxBarrier = packet.ReadUInt32();
            IsCostumeHidden = packet.ReadByte();
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
        /// Gets or sets the appearance list.
        /// </summary>
        /// <value>
        /// The appearance list.
        /// </value>
        private List<PacketAppeareance> AppearanceList { get; set; }

        /// <summary>
        /// Gets or sets the buff count.
        /// </summary>
        /// <value>
        /// The buff count.
        /// </value>
        private ushort BuffCount { get; set; }

        /// <summary>
        /// Gets or sets the buff information list.
        /// </summary>
        /// <value>
        /// The buff information list.
        /// </value>
        private List<PacketBuffInfo> BuffInfoList { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>
        /// The class.
        /// </value>
        private uint Class { get; set; }

        /// <summary>
        /// Gets or sets the combat mode.
        /// </summary>
        /// <value>
        /// The combat mode.
        /// </value>
        private byte CombatMode { get; set; }

        /// <summary>
        /// Gets or sets the control gadget identifier.
        /// </summary>
        /// <value>
        /// The control gadget identifier.
        /// </value>
        private ulong ControlGadgetID { get; set; }

        /// <summary>
        /// Gets or sets the current barrier.
        /// </summary>
        /// <value>
        /// The current barrier.
        /// </value>
        private uint CurBarrier { get; set; }

        /// <summary>
        /// Gets or sets the current hp.
        /// </summary>
        /// <value>
        /// The current hp.
        /// </value>
        private uint CurHP { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        private float Direction { get; set; }

        /// <summary>
        /// Gets or sets the equip count.
        /// </summary>
        /// <value>
        /// The equip count.
        /// </value>
        private uint EquipCount { get; set; }

        /// <summary>
        /// Gets or sets the equipped title information identifier.
        /// </summary>
        /// <value>
        /// The equipped title information identifier.
        /// </value>
        private uint EquippedTitleInfoID { get; set; }

        /// <summary>
        /// Gets or sets the guilded.
        /// </summary>
        /// <value>
        /// The guilded.
        /// </value>
        private byte Guilded { get; set; }

        /// <summary>
        /// Gets or sets the is costume hidden.
        /// </summary>
        /// <value>
        /// The is costume hidden.
        /// </value>
        private byte IsCostumeHidden { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the maximum barrier.
        /// </summary>
        /// <value>
        /// The maximum barrier.
        /// </value>
        private uint MaxBarrier { get; set; }

        /// <summary>
        /// Gets or sets the maximum hp.
        /// </summary>
        /// <value>
        /// The maximum hp.
        /// </value>
        private uint MaxHP { get; set; }

        /// <summary>
        /// Gets or sets the move speed.
        /// </summary>
        /// <value>
        /// The move speed.
        /// </value>
        private uint MoveSpeed { get; set; }

        /// <summary>
        /// Gets or sets the party emblem list.
        /// </summary>
        /// <value>
        /// The party emblem list.
        /// </value>
        private List<PacketPartyEmblem> PartyEmblemList { get; set; }

        /// <summary>
        /// Gets or sets the state of the pk attack.
        /// </summary>
        /// <value>
        /// The state of the pk attack.
        /// </value>
        private byte PKAttackState { get; set; }

        /// <summary>
        /// Gets or sets the pk mode list.
        /// </summary>
        /// <value>
        /// The pk mode list.
        /// </value>
        private List<PacketPKMode> PKModeList { get; set; }

        /// <summary>
        /// Gets or sets the pk point.
        /// </summary>
        /// <value>
        /// The pk point.
        /// </value>
        private uint PKPoint { get; set; }

        /// <summary>
        /// Gets or sets the pk status.
        /// </summary>
        /// <value>
        /// The pk status.
        /// </value>
        private byte PKStatus { get; set; }

        /// <summary>
        /// Gets or sets the player guild list.
        /// </summary>
        /// <value>
        /// The player guild list.
        /// </value>
        private List<PacketPlayerGuild> PlayerGuildList { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        private string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the player uid.
        /// </summary>
        /// <value>
        /// The player uid.
        /// </value>
        private ulong PlayerUID { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        /// <value>
        /// The race.
        /// </value>
        private uint Race { get; set; }

        /// <summary>
        /// Gets or sets the riding pet grade.
        /// </summary>
        /// <value>
        /// The riding pet grade.
        /// </value>
        private byte RidingPetGrade { get; set; }

        /// <summary>
        /// Gets or sets the riding pet information identifier.
        /// </summary>
        /// <value>
        /// The riding pet information identifier.
        /// </value>
        private uint RidingPetInfoID { get; set; }

        /// <summary>
        /// Gets or sets the riding pet level.
        /// </summary>
        /// <value>
        /// The riding pet level.
        /// </value>
        private uint RidingPetLevel { get; set; }

        /// <summary>
        /// Gets or sets the simple cape list.
        /// </summary>
        /// <value>
        /// The simple cape list.
        /// </value>
        private List<PacketSimpleCape> SimpleCapeList { get; set; }

        /// <summary>
        /// Gets or sets the simple equip list.
        /// </summary>
        /// <value>
        /// The simple equip list.
        /// </value>
        private List<PacketSimpleEquipment> SimpleEquipList { get; set; }

        /// <summary>
        /// Gets or sets the soul shot enabled.
        /// </summary>
        /// <value>
        /// The soul shot enabled.
        /// </value>
        private byte SoulShotEnabled { get; set; }

        /// <summary>
        /// Gets or sets the team identifier.
        /// </summary>
        /// <value>
        /// The team identifier.
        /// </value>
        private ulong TeamID { get; set; }

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