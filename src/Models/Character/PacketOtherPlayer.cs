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
            //pushing a change to be sure
            PlayerUID = packet.ReadUInt64();
            //uint unk1 = packet.ReadUInt32();
            //byte unk2 = packet.ReadByte();
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
            AppearanceList = new List<PacketAppeareance>();
            AppearanceList.Add(new PacketAppeareance(packet));

            EquipCount = packet.ReadUInt16();
            // PktSimpleEquipment
            SimpleEquipList = new List<PacketSimpleEquipment>();
            for (int i = 0; i < EquipCount; i++)
            {
                SimpleEquipList.Add(new PacketSimpleEquipment(packet));
                
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
            PartyEmblemList = new List<PacketPartyEmblem>();
            if (SetEmblem > 0)
            {
                PartyEmblemList.Add(new PacketPartyEmblem(packet));
            }

            //PktSimpleCape
            SimpleCapeList = new List<PacketSimpleCape>();
            SimpleCapeList.Add(new PacketSimpleCape(packet));

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
        public List<PacketAppeareance> AppearanceList { get; set; }

        /// <summary>
        /// Gets or sets the buff count.
        /// </summary>
        /// <value>
        /// The buff count.
        /// </value>
        public ushort BuffCount { get; set; }

        /// <summary>
        /// Gets or sets the buff information list.
        /// </summary>
        /// <value>
        /// The buff information list.
        /// </value>
        public List<PacketBuffInfo> BuffInfoList { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>
        /// The class.
        /// </value>
        public uint Class { get; set; }

        /// <summary>
        /// Gets or sets the combat mode.
        /// </summary>
        /// <value>
        /// The combat mode.
        /// </value>
        public byte CombatMode { get; set; }

        /// <summary>
        /// Gets or sets the control gadget identifier.
        /// </summary>
        /// <value>
        /// The control gadget identifier.
        /// </value>
        public ulong ControlGadgetID { get; set; }

        /// <summary>
        /// Gets or sets the current barrier.
        /// </summary>
        /// <value>
        /// The current barrier.
        /// </value>
        public uint CurBarrier { get; set; }

        /// <summary>
        /// Gets or sets the current hp.
        /// </summary>
        /// <value>
        /// The current hp.
        /// </value>
        public uint CurHP { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public float Direction { get; set; }

        /// <summary>
        /// Gets or sets the equip count.
        /// </summary>
        /// <value>
        /// The equip count.
        /// </value>
        public uint EquipCount { get; set; }

        /// <summary>
        /// Gets or sets the equipped title information identifier.
        /// </summary>
        /// <value>
        /// The equipped title information identifier.
        /// </value>
        public uint EquippedTitleInfoID { get; set; }

        /// <summary>
        /// Gets or sets the guilded.
        /// </summary>
        /// <value>
        /// The guilded.
        /// </value>
        public byte Guilded { get; set; }

        /// <summary>
        /// Gets or sets the is costume hidden.
        /// </summary>
        /// <value>
        /// The is costume hidden.
        /// </value>
        public byte IsCostumeHidden { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the maximum barrier.
        /// </summary>
        /// <value>
        /// The maximum barrier.
        /// </value>
        public uint MaxBarrier { get; set; }

        /// <summary>
        /// Gets or sets the maximum hp.
        /// </summary>
        /// <value>
        /// The maximum hp.
        /// </value>
        public uint MaxHP { get; set; }

        /// <summary>
        /// Gets or sets the move speed.
        /// </summary>
        /// <value>
        /// The move speed.
        /// </value>
        public uint MoveSpeed { get; set; }

        /// <summary>
        /// Gets or sets the party emblem list.
        /// </summary>
        /// <value>
        /// The party emblem list.
        /// </value>
        public List<PacketPartyEmblem> PartyEmblemList { get; set; }

        /// <summary>
        /// Gets or sets the state of the pk attack.
        /// </summary>
        /// <value>
        /// The state of the pk attack.
        /// </value>
        public byte PKAttackState { get; set; }

        /// <summary>
        /// Gets or sets the pk mode list.
        /// </summary>
        /// <value>
        /// The pk mode list.
        /// </value>
        public List<PacketPKMode> PKModeList { get; set; }

        /// <summary>
        /// Gets or sets the pk point.
        /// </summary>
        /// <value>
        /// The pk point.
        /// </value>
        public uint PKPoint { get; set; }

        /// <summary>
        /// Gets or sets the pk status.
        /// </summary>
        /// <value>
        /// The pk status.
        /// </value>
        public byte PKStatus { get; set; }

        /// <summary>
        /// Gets or sets the player guild list.
        /// </summary>
        /// <value>
        /// The player guild list.
        /// </value>
        public List<PacketPlayerGuild> PlayerGuildList { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the player uid.
        /// </summary>
        /// <value>
        /// The player uid.
        /// </value>
        public ulong PlayerUID { get; set; }

        /// <summary>
        /// Gets or sets the race.
        /// </summary>
        /// <value>
        /// The race.
        /// </value>
        public uint Race { get; set; }

        /// <summary>
        /// Gets or sets the riding pet grade.
        /// </summary>
        /// <value>
        /// The riding pet grade.
        /// </value>
        public byte RidingPetGrade { get; set; }

        /// <summary>
        /// Gets or sets the riding pet information identifier.
        /// </summary>
        /// <value>
        /// The riding pet information identifier.
        /// </value>
        public uint RidingPetInfoID { get; set; }

        /// <summary>
        /// Gets or sets the riding pet level.
        /// </summary>
        /// <value>
        /// The riding pet level.
        /// </value>
        public uint RidingPetLevel { get; set; }

        /// <summary>
        /// Gets or sets the simple cape list.
        /// </summary>
        /// <value>
        /// The simple cape list.
        /// </value>
        public List<PacketSimpleCape> SimpleCapeList { get; set; }

        /// <summary>
        /// Gets or sets the simple equip list.
        /// </summary>
        /// <value>
        /// The simple equip list.
        /// </value>
        public List<PacketSimpleEquipment> SimpleEquipList { get; set; }

        /// <summary>
        /// Gets or sets the soul shot enabled.
        /// </summary>
        /// <value>
        /// The soul shot enabled.
        /// </value>
        public byte SoulShotEnabled { get; set; }

        /// <summary>
        /// Gets or sets the team identifier.
        /// </summary>
        /// <value>
        /// The team identifier.
        /// </value>
        public ulong TeamID { get; set; }

        /// <summary>
        /// Gets or sets the x position.
        /// </summary>
        /// <value>
        /// The x position.
        /// </value>
        public float XPos { get; set; }

        /// <summary>
        /// Gets or sets the y position.
        /// </summary>
        /// <value>
        /// The y position.
        /// </value>
        public float YPos { get; set; }

        /// <summary>
        /// Gets or sets the z position.
        /// </summary>
        /// <value>
        /// The z position.
        /// </value>
        public float ZPos { get; set; }

        public string tmpClanName { get; set; }
    }
}