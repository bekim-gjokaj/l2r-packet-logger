using Kamael.Packets.Character;
using Kamael.Packets.Chat;
using Kamael.Packets.Clan;
using System;

/// <summary>
///
/// </summary>
namespace Kamael.Packets.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcretePacketFactory : PacketFactory
    {
        public override IL2RPacket GetPacket(ushort PacketID, IL2RPacket packet)
        {
            try
            {

                switch (PacketID)
                {

                    case 1569: return new PacketClanMemberKillNotify((L2RPacket)packet); // 0x622 //return new PacketGuildMemberKillNotify";

                    case 2127: return new PacketPlayerKillNotify((L2RPacket)packet); // 0x850


                    case 774:  return new PacketChatGuildListReadResult((L2RPacket)packet);     // 0x307//return new PacketChatGuildListReadResult";
                    case 776: return new PacketChatGuildWriteResult(packet);      // 0x309 //return new PacketChatGuildWriteResult";
                    case 779:  return new PacketChatGuildWriteResult(packet);     // 0x30C//return new PacketChatGuildMessageReadResult";



                    //case 0: break;//return new PacketVersion(packet);    // 0x1 //return new PacketVersion";
                    //case 1: break;//return PacketVersionResult(packet);    // 0x2 //return new PacketVersionResult";


                    //case 2: break; // 0x3 //return new PacketLogin"; 
                    //case 3:     // 0x4 //return new PacketLoginResult";
                    //    break;

                    //case 4:     // 0x5
                    //            //return new PacketLogout";
                    //    break;

                    //case 5:     // 0x6
                    //            //return new PacketLogoutResult";
                    //    break;

                    //case 6:     // 0x7
                    //            //return new PacketKeyChangeNotify";
                    //    break;

                    //case 7:     // 0x8
                    //            //return new PacketKeyChanged";
                    //    break;

                    //case 8:     // 0x9
                    //            //return new PacketKeyChangedResult";
                    //    break;

                    //case 9:     // 0xA
                    //            //return new PacketWithdrawUser";
                    //    break;

                    //case 10:        // 0xB
                    //                //return new PacketWithdrawUserResult";
                    //    break;

                    //case 11:        // 0xC
                    //                //return new PacketTimeSync";
                    //    break;

                    //case 12:        // 0xD
                    //                //return new PacketTimeSyncResult";
                    //    break;

                    //case 13:        // 0xE
                    //                //return new PacketKickout";
                    //    break;

                    //case 14:        // 0xF
                    //                //return new PacketKickoutNotify";
                    //    break;

                    //case 15:        // 0x10
                    //                //return new PacketKickoutResult";
                    //    break;

                    //case 16:        // 0x11
                    //                //return new PacketWaitingNumUpdateNotify";
                    //    break;

                    //case 17:        // 0x12
                    //                //return new PacketWaitingOverNotify";
                    //    break;

                    //case 18:        // 0x13
                    //                //return new PacketPlayerListRead";
                    //    break;

                    //case 19:        // 0x14
                    //                //return new PacketPlayerListReadResult";
                    //    break;

                    //case 20:        // 0x15
                    //                //return new PacketPlayerCreate";
                    //    break;

                    //case 21:        // 0x16
                    //                //return new PacketPlayerCreateResult";
                    //    break;

                    //case 22:        // 0x17
                    //                //return new PacketPlayerDelete";
                    //    break;

                    //case 23:        // 0x18
                    //                //return new PacketPlayerDeleteResult";
                    //    break;

                    //case 24:        // 0x19
                    //                //return new PacketPlayerSelect";
                    //    break;

                    //case 25:        // 0x1A
                    //                //return new PacketPlayerSelectResult";
                    //    break;

                    //case 26:        // 0x1B
                    //                //return new PacketSystemTutorialStart";
                    //    break;

                    //case 27:        // 0x1C
                    //                //return new PacketSystemTutorialStartResult";
                    //    break;

                    //case 28:        // 0x1D
                    //                //return new PacketMoveToSelectCharacter";
                    //    break;

                    //case 29:        // 0x1E
                    //                //return new PacketMoveToSelectCharacterResult";
                    //    break;

                    //case 30:        // 0x1F
                    //                //return new PacketNoticeListRead";
                    //    break;

                    //case 31:        // 0x20
                    //                //return new PacketNoticeListReadResult";
                    //    break;

                    //case 32:        // 0x21
                    //                //return new PacketPopupNoticeListRead";
                    //    break;

                    //case 33:        // 0x22
                    //                //return new PacketPopupNoticeListReadResult";
                    //    break;

                    //case 34:        // 0x23
                    //                //return new PacketPopupNoticeChangeNotify";
                    //    break;

                    //case 35:        // 0x24
                    //                //return new PacketRollNoticeNotify";
                    //    break;

                    //case 36:        // 0x25
                    //                //return new PacketConfineUserNotify";
                    //    break;

                    //case 37:        // 0x26
                    //                //return new PacketConfineUserKick";
                    //    break;

                    //case 38:        // 0x27
                    //                //return new PacketConfineUserKickResult";
                    //    break;

                    //case 39:        // 0x28
                    //                //return new PacketNoticeNotify";
                    //    break;

                    //case 40:        // 0x29
                    //                //return new PacketVersion2";
                    //    break;

                    //case 41:        // 0x2A
                    //                //return new PacketVersion2Result";
                    //    break;

                    //case 42:        // 0x2B
                    //                //return new PacketAccountLinkInfo";
                    //    break;

                    //case 43:        // 0x2C
                    //                //return new PacketAccountLinkInfoResult";
                    //    break;

                    //case 44:        // 0x2D
                    //                //return new PacketAccountLinkReward";
                    //    break;

                    //case 45:        // 0x2E
                    //                //return new PacketAccountLinkRewardResult";
                    //    break;

                    //case 46:        // 0x2F
                    //                //return new PacketNicknameCheck";
                    //    break;

                    //case 47:        // 0x30
                    //                //return new PacketNicknameCheckResult";
                    //    break;

                    //case 100:       // 0x65
                    //                //return new PacketWorldMoveReserve";
                    //    break;

                    //case 101:       // 0x66
                    //                //return new PacketWorldMoveReserveResult";
                    //    break;

                    //case 102:       // 0x67
                    //                //return new PacketWorldMoveStart";
                    //    break;

                    //case 103:       // 0x68
                    //                //return new PacketWorldMoveStartResult";
                    //    break;

                    //case 104:       // 0x69
                    //                //return new PacketWorldMoveFinish";
                    //    break;

                    //case 105:       // 0x6A
                    //                //return new PacketWorldMoveFinishResult";
                    //    break;

                    //case 106:       // 0x6B
                    //                //return new PacketWorldChannelList";
                    //    break;

                    //case 107:       // 0x6C
                    //                //return new PacketWorldChannelListResult";
                    //    break;

                    //case 108:       // 0x6D
                    //                //return new PacketWorldChannelMoveReserve";
                    //    break;

                    //case 109:       // 0x6E
                    //                //return new PacketWorldChannelMoveReserveResult";
                    //    break;

                    //case 110:       // 0x6F
                    //                //return new PacketWorldLeave";
                    //    break;

                    //case 111:       // 0x70
                    //                //return new PacketWorldLeaveResult";
                    //    break;

                    //case 112:       // 0x71
                    //                //return new PacketTeleportCastingStart";
                    //    break;

                    //case 113:       // 0x72
                    //                //return new PacketTeleportCastingStartResult";
                    //    break;

                    //case 114:       // 0x73
                    //                //return new PacketTeleportCastingStartNotify";
                    //    break;

                    //case 115:       // 0x74
                    //                //return new PacketTeleportDepartNotify";
                    //    break;

                    //case 116:       // 0x75
                    //                //return new PacketTeleportArriveNotify";
                    //    break;

                    //case 117:       // 0x76
                    //                //return new PacketWorldInfoUpdateNotify";
                    //    break;

                    //case 118:       // 0x77
                    //                //return new PacketMapPlayerPositionRead";
                    //    break;

                    //case 119:       // 0x78
                    //                //return new PacketMapPlayerPositionReadResult";
                    //    break;

                    //case 120:       // 0x79
                    //                //return new PacketMapWorldInfoRead";
                    //    break;

                    //case 121:       // 0x7A
                    //                //return new PacketMapWorldInfoReadResult";
                    //    break;

                    //case 122:       // 0x7B
                    //                //return new PacketAutoMoveTeleport";
                    //    break;

                    //case 123:       // 0x7C
                    //                //return new PacketAutoMoveTeleportResult";
                    //    break;

                    //case 124:       // 0x7D
                    //                //return new PacketWorldExit";
                    //    break;

                    //case 125:       // 0x7E
                    //                //return new PacketWorldExitResult";
                    //    break;

                    //case 126:       // 0x7F
                    //                //return new PacketBossWorldEnterInfo";
                    //    break;

                    //case 127:       // 0x80
                    //                //return new PacketBossWorldEnterInfoResult";
                    //    break;

                    //case 128:       // 0x81
                    //                //return new PacketBossWorldClosingNotify";
                    //    break;

                    //case 129:       // 0x82
                    //                //return new PacketBossStateRequest";
                    //    break;

                    //case 130:       // 0x83
                    //                //return new PacketBossStateRequestResult";
                    //    break;

                    //case 131:       // 0x84
                    //                //return new PacketTownExit";
                    //    break;

                    //case 132:       // 0x85
                    //                //return new PacketTownExitResult";
                    //    break;

                    //case 133:       // 0x86
                    //                //return new PacketBossTrophyTownEnterNotify";
                    //    break;

                    //case 134:       // 0x87
                    //                //return new PacketBossTrophyStatusNotify";
                    //    break;

                    //case 135:       // 0x88
                    //                //return new PacketCertainPointNotify";
                    //    break;

                    //case 200:       // 0xC9
                    //                //return new PacketPlayerMove";
                    //    break;

                    //case 201:       // 0xCA
                    //                //return new PacketPlayerMoveResult";
                    //    break;

                    //case 202:       // 0xCB
                    //                //return new PacketPlayerMoveNotify";
                    //                //PktPlayerMoveListNotify.Packet(packet);
                    //    break;

                    //case 203: return new PacketStatusMovement(packet); // 0xCC //"PktPlayerMoveListNotify";

                    //case 204:       // 0xCD
                    //                //return new PacketSightEnterNotify";
                    //    break;

                    //case 205:       // 0xCE
                    //                //return new PacketSightLeaveNotify";
                    //    break;

                    //case 206:       // 0xCF
                    //                //return new PacketNpcMoveNotify";
                    //                //PktNpcMoveNotify.Packet(packet);
                    //    break;

                    //case 207:       // 0xD0
                    //                //return new PacketCharacterDieNotify";
                    //    break;

                    //case 208:       // 0xD1
                    //                //return new PacketActorDestroyNotify";
                    //                //PktActorDestroyNotify.Packet(packet);
                    //    break;

                    //case 209:       // 0xD2
                    //                //return new PacketPlayerRevive";
                    //    break;

                    //case 210:       // 0xD3
                    //                //return new PacketPlayerReviveResult";
                    //    break;

                    //case 211:       // 0xD4
                    //                //return new PacketPlayerReviveNotify";
                    //    break;

                    //case 212:       // 0xD5
                    //                //return new PacketNpcSpawn";
                    //    break;

                    //case 213:       // 0xD6
                    //                //return new PacketNpcSpawnResult";
                    //    break;

                    //case 214:       // 0xD7
                    //                //return new PacketNpcCreateNotify";
                    //    break;

                    //case 215:       // 0xD8
                    //                //return new PacketCharacterKill";
                    //    break;

                    //case 216:       // 0xD9
                    //                //return new PacketCharacterKillResult";
                    //    break;

                    //case 217:       // 0xDA
                    //                //return new PacketNpcAllKill";
                    //    break;

                    //case 218:       // 0xDB
                    //                //return new PacketNpcAllKillResult";
                    //    break;

                    //case 219:       // 0xDC
                    //                //return new PacketCharacterLevelUpNotify";
                    //    break;

                    //case 220:       // 0xDD
                    //                //return new PacketCharacterMasteryLevelUpNotify";
                    //    break;

                    //case 221:       // 0xDE
                    //                //return new PacketPlayerNameChange";
                    //    break;

                    //case 222:       // 0xDF
                    //                //return new PacketPlayerNameChangeResult";
                    //    break;

                    //case 223:       // 0xE0
                    //                //return new PacketCharacterStatChangeNotify";
                    //                //PktCharacterStatChangeNotify.Packet(packet);
                    //    break;

                    //case 224:       // 0xE1
                    //                //return new PacketActorStateChange";
                    //    break;

                    //case 225:       // 0xE2
                    //                //return new PacketActorStateChangeResult";
                    //    break;

                    //case 226:       // 0xE3
                    //                //return new PacketActorStateChangeNotify";
                    //    break;

                    //case 227:       // 0xE4
                    //                //return new PacketActorTeamChangeNotify";
                    //    break;

                    //case 228:       // 0xE5
                    //                //return new PacketPlayerClassUpgrade";
                    //    break;

                    //case 229:       // 0xE6
                    //                //return new PacketPlayerClassUpgradeResult";
                    //    break;

                    //case 230:       // 0xE7
                    //                //return new PacketPlayerSocialActionInput";
                    //    break;

                    //case 231:       // 0xE8
                    //                //return new PacketPlayerSocialActionInputResult";
                    //    break;

                    //case 232:       // 0xE9
                    //                //return new PacketPlayerSocialActionNotify";
                    //    break;

                    //case 233:       // 0xEA
                    //                //return new PacketPlayerSubClassListRead";
                    //    break;

                    //case 234:       // 0xEB
                    //                //return new PacketPlayerSubClassListReadResult";
                    //    break;

                    //case 235:       // 0xEC
                    //                //return new PacketPlayerClassChange";
                    //    break;

                    //case 236:       // 0xED
                    //                //return new PacketPlayerClassChangeResult";
                    //    break;

                    //case 237:       // 0xEE
                    //                //return new PacketGadgetCreateNotify";
                    //    break;

                    //case 238:       // 0xEF
                    //                //return new PacketGadgetControlStart";
                    //    break;

                    //case 239:       // 0xF0
                    //                //return new PacketGadgetControlStartResult";
                    //    break;

                    //case 240:       // 0xF1
                    //                //return new PacketGadgetControlStartNotify";
                    //    break;

                    //case 241:       // 0xF2
                    //                //return new PacketGadgetControl";
                    //    break;

                    //case 242:       // 0xF3
                    //                //return new PacketGadgetControlResult";
                    //    break;

                    //case 243:       // 0xF4
                    //                //return new PacketGadgetControlNotify";
                    //    break;

                    //case 244:       // 0xF5
                    //                //return new PacketGadgetControlCancel";
                    //    break;

                    //case 245:       // 0xF6
                    //                //return new PacketGadgetControlCancelResult";
                    //    break;

                    //case 246:       // 0xF7
                    //                //return new PacketGadgetControlCancelNotify";
                    //    break;

                    //case 247:       // 0xF8
                    //                //return new PacketGadgetActiveNotify";
                    //    break;

                    //case 248:       // 0xF9
                    //                //return new PacketReconnectGadgetControlNotify";
                    //    break;

                    //case 249:       // 0xFA
                    //                //return new PacketPlayerInfoRead";
                    //    break;

                    //case 250:       // 0xFB
                    //                //return new PacketPlayerInfoReadResult";
                    //    break;

                    //case 251:       // 0xFC
                    //                //return new PacketNpcSightShowNotify";
                    //    break;

                    //case 252:       // 0xFD
                    //                //return new PacketPlayerStatDetailInfoRead";
                    //    break;

                    //case 253:       // 0xFE
                    //                //return new PacketPlayerStatDetailInfoReadResult";
                    //    break;

                    //case 254:       // 0xFF
                    //                //return new PacketPlayerGuildInfoRead";
                    //    break;

                    //case 255:       // 0x100
                    //                //return new PacketPlayerGuildInfoReadResult";
                    //    break;

                    //case 256:       // 0x101
                    //                //return new PacketEliminationInsert";
                    //    break;

                    //case 257:       // 0x102
                    //                //return new PacketEliminationInsertResult";
                    //    break;

                    //case 258:       // 0x103
                    //                //return new PacketEliminationGet";
                    //    break;

                    //case 259:       // 0x104
                    //                //return new PacketEliminationGetResult";
                    //    break;

                    //case 260:       // 0x105
                    //                //return new PacketEliminationDel";
                    //    break;

                    //case 261:       // 0x106
                    //                //return new PacketEliminationDelResult";
                    //    break;

                    //case 262:       // 0x107
                    //                //return new PacketContentUnlockListRead";
                    //    break;

                    //case 263:       // 0x108
                    //                //return new PacketContentUnlockListReadResult";
                    //    break;

                    //case 264:       // 0x109
                    //                //return new PacketContentUnlockRequest";
                    //    break;

                    //case 265:       // 0x10A
                    //                //return new PacketContentUnlockRequestResult";
                    //    break;

                    //case 266:       // 0x10B
                    //                //return new PacketUsableContentRemainCount";
                    //    break;

                    //case 267:       // 0x10C
                    //                //return new PacketUsableContentRemainCountResult";
                    //    break;

                    //case 268:       // 0x10D
                    //                //return new PacketMapAlarm";
                    //    break;

                    //case 269:       // 0x10E
                    //                //return new PacketMapAlarmResult";
                    //    break;

                    //case 270:       // 0x10F
                    //                //return new PacketMapAlarmNotify";
                    //    break;

                    //case 271:       // 0x110
                    //                //return new PacketPlayerBadgeNotify";
                    //    break;

                    //case 272:       // 0x111
                    //                //return new PacketBattleStartNotify";
                    //    break;

                    //case 273:       // 0x112
                    //                //return new PacketBattleEndNotify";
                    //    break;

                    //case 274:       // 0x113
                    //                //return new PacketTargetActorChange";
                    //    break;

                    //case 275:       // 0x114
                    //                //return new PacketTargetActorChangeResult";
                    //    break;

                    //case 276:       // 0x115
                    //                //return new PacketNotify";
                    //    break;

                    //case 277:       // 0x116
                    //                //return new PacketLevelUpGift";
                    //    break;

                    //case 278:       // 0x117
                    //                //return new PacketLevelUpGiftResult";
                    //    break;

                    //case 279:       // 0x118
                    //                //return new PacketUIOpenClose";
                    //    break;

                    //case 280:       // 0x119
                    //                //return new PacketUIOpenCloseResult";
                    //    break;

                    //case 281:       // 0x11A
                    //                //return new PacketBossMonsterKillNotify";
                    //    break;

                    //case 282:       // 0x11B
                    //                //return new PacketPlayerGuildDungeonSupportListRead";
                    //    break;

                    //case 283:       // 0x11C
                    //                //return new PacketPlayerGuildDungeonSupportListReadResult";
                    //    break;

                    //case 284:       // 0x11D
                    //                //return new PacketFieldBossExistNotify";
                    //    break;

                    //case 285:       // 0x11E
                    //                //return new PacketFieldBossKillNotify";
                    //    break;

                    //case 286:       // 0x11F
                    //                //return new PacketFieldBossItemLootNotify";
                    //    break;

                    //case 287:       // 0x120
                    //                //return new PacketExpDisplayNotify";
                    //                //PktPktExpDisplayNotify.Packet(packet);
                    //    break;

                    //case 288:       // 0x121
                    //                //return new PacketPlayerSelfIntroChange";
                    //    break;

                    //case 289:       // 0x122
                    //                //return new PacketPlayerSelfIntroChangeResult";
                    //    break;

                    //case 290:       // 0x123
                    //                //return new PacketBossNpcCombatStartTimeNotify";
                    //    break;

                    //case 291:       // 0x124
                    //                //return new PacketNpcTargetUpdateNotify";
                    //    break;

                    //case 300:       // 0x12D
                    //                //return new PacketAchievementListRead";
                    //    break;

                    //case 301:       // 0x12E
                    //                //return new PacketAchievementListReadResult";
                    //                //PktAchievementListReadResult.Packet(packet);
                    //    break;

                    //case 302:       // 0x12F
                    //                //return new PacketPeriodAchievementListRead";
                    //    break;

                    //case 303:       // 0x130
                    //                //return new PacketPeriodAchievementListReadResult";
                    //    break;

                    //case 304:       // 0x131
                    //                //return new PacketAchievementCompletedNotify";
                    //    break;

                    //case 305:       // 0x132
                    //                //return new PacketAchievementRewardGet";
                    //    break;

                    //case 306:       // 0x133
                    //                //return new PacketAchievementRewardGetResult";
                    //    break;

                    //case 307:       // 0x134
                    //                //return new PacketPeriodAchievementRewardGet";
                    //    break;

                    //case 308:       // 0x135
                    //                //return new PacketPeriodAchievementRewardGetResult";
                    //    break;

                    //case 309:       // 0x136
                    //                //return new PacketAchievementLevelRewardGet";
                    //    break;

                    //case 310:       // 0x137
                    //                //return new PacketAchievementLevelRewardGetResult";
                    //    break;

                    //case 311:       // 0x138
                    //                //return new PacketHeroicLevelUpNotify";
                    //    break;

                    //case 312:       // 0x139
                    //                //return new PacketLeaderboardScoreUpdatedNotify";
                    //    break;

                    //case 313:       // 0x13A
                    //                //return new PacketAchievementCompleteListRead";
                    //    break;

                    //case 314:       // 0x13B
                    //                //return new PacketAchievementCompleteListReadResult";
                    //    break;

                    //case 350:       // 0x15F
                    //                //return new PacketDailyActivityListRead";
                    //    break;

                    //case 351:       // 0x160
                    //                //return new PacketDailyActivityListReadResult";
                    //    break;

                    //case 352:       // 0x161
                    //                //return new PacketDailyActivityCompletedNotify";
                    //    break;

                    //case 353:       // 0x162
                    //                //return new PacketDailyActivityRewardGet";
                    //    break;

                    //case 354:       // 0x163
                    //                //return new PacketDailyActivityRewardGetResult";
                    //    break;

                    //case 355:       // 0x164
                    //                //return new PacketDailyActivityPointRewardGet";
                    //    break;

                    //case 356:       // 0x165
                    //                //return new PacketDailyActivityPointRewardGetResult";
                    //    break;

                    //case 400:       // 0x191
                    //                //return new PacketRuneInfoRead";
                    //    break;

                    //case 401:       // 0x192
                    //                //return new PacketRuneInfoReadResult";
                    //    break;

                    //case 402:       // 0x193
                    //                //return new PacketRuneLevelUp";
                    //    break;

                    //case 403:       // 0x194
                    //                //return new PacketRuneLevelUpResult";
                    //    break;

                    //case 450:       // 0x1C3
                    //                //return new PacketMonsterBookListRead";
                    //    break;

                    //case 451:       // 0x1C4
                    //                //return new PacketMonsterBookListReadResult";
                    //                //PktMonsterBookListReadresult.Packet(packet);
                    //    break;

                    //case 452:       // 0x1C5
                    //                //return new PacketMonsterCoreUse";
                    //    break;

                    //case 453:       // 0x1C6
                    //                //return new PacketMonsterCoreUseResult";
                    //    break;

                    //case 454:       // 0x1C7
                    //                //return new PacketMonsterCoreUseAll";
                    //    break;

                    //case 455:       // 0x1C8
                    //                //return new PacketMonsterCoreUseAllResult";
                    //    break;

                    //case 456:       // 0x1C9
                    //                //return new PacketMonsterBookGroupRewardGet";
                    //    break;

                    //case 457:       // 0x1CA
                    //                //return new PacketMonsterBookGroupRewardGetResult";
                    //    break;

                    //case 458:       // 0x1CB
                    //                //return new PacketMonsterCoreDecompose";
                    //    break;

                    //case 459:       // 0x1CC
                    //                //return new PacketMonsterCoreDecomposeResult";
                    //    break;

                    //case 460:       // 0x1CD
                    //                //return new PacketMonsterCoreShopList";
                    //    break;

                    //case 461:       // 0x1CE
                    //                //return new PacketMonsterCoreShopListResult";
                    //    break;

                    //case 462:       // 0x1CF
                    //                //return new PacketMonsterCoreShopBuy";
                    //    break;

                    //case 463:       // 0x1D0
                    //                //return new PacketMonsterCoreShopBuyResult";
                    //    break;

                    //case 464:       // 0x1D1
                    //                //return new PacketMonsterCoreShopRefresh";
                    //    break;

                    //case 465:       // 0x1D2
                    //                //return new PacketMonsterCoreShopRefreshResult";
                    //    break;

                    //case 500:       // 0x1F5
                    //                //return new PacketRestRewardGet";
                    //    break;

                    //case 501:       // 0x1F6
                    //                //return new PacketRestRewardGetResult";
                    //    break;

                    //case 502:       // 0x1F7
                    //                //return new PacketRestRewardChangeNotify";
                    //    break;

                    //case 550:       // 0x227
                    //                //return new PacketAttendanceRead";
                    //    break;

                    //case 551:       // 0x228
                    //                //return new PacketAttendanceReadResult";
                    //    break;

                    //case 552:       // 0x229
                    //                //return new PacketAttendanceAttend";
                    //    break;

                    //case 553:       // 0x22A
                    //                //return new PacketAttendanceAttendResult";
                    //    break;

                    //case 554:       // 0x22B
                    //                //return new PacketAttendanceDailyGet";
                    //    break;

                    //case 555:       // 0x22C
                    //                //return new PacketAttendanceDailyGetResult";
                    //    break;

                    //case 556:       // 0x22D
                    //                //return new PacketAttendanceWeeklyGet";
                    //    break;

                    //case 557:       // 0x22E
                    //                //return new PacketAttendanceWeeklyGetResult";
                    //    break;

                    //case 600:       // 0x259
                    //                //return new PacketSkillCastingStart";
                    //    break;

                    //case 601:       // 0x25A
                    //                //return new PacketSkillCastingStartResult";
                    //    break;

                    //case 602:       // 0x25B
                    //                //return new PacketSkillCastingStartNotify";
                    //    break;

                    //case 603:       // 0x25C
                    //                //return new PacketSkillStart";
                    //    break;

                    //case 604:       // 0x25D
                    //                //return new PacketSkillStartResult";
                    //                //PktSkillStartResult.Packet(packet);
                    //    break;

                    //case 605:       // 0x25E
                    //                //return new PacketSkillStartNotify";
                    //    break;

                    //case 606:       // 0x25F
                    //                //return new PacketSkillRotate";
                    //    break;

                    //case 607:       // 0x260
                    //                //return new PacketSkillRotateResult";
                    //    break;

                    //case 608:       // 0x261
                    //                //return new PacketSkillRotateNotify";
                    //    break;

                    //case 609:       // 0x262
                    //                //return new PacketSkillEffectFire";
                    //    break;

                    //case 610:       // 0x263
                    //                //return new PacketSkillEffectFireResult";
                    //    break;

                    //case 611:       // 0x264
                    //                //return new PacketSkillHitNotify";
                    //                //PktSkillHitNotify.Packet(packet);
                    //    break;

                    //case 612:       // 0x265
                    //                //return new PacketSkillMissNotify";
                    //    break;

                    //case 613:       // 0x266
                    //                //return new PacketSkillCoolTimeResetNotify";
                    //    break;

                    //case 614:       // 0x267
                    //                //return new PacketProjectileCreateNotify";
                    //    break;

                    //case 615:       // 0x268
                    //                //return new PacketProjectileMoveNotify";
                    //    break;

                    //case 616:       // 0x269
                    //                //return new PacketProjectileHit";
                    //    break;

                    //case 617:       // 0x26A
                    //                //return new PacketProjectileHitResult";
                    //    break;

                    //case 618:       // 0x26B
                    //                //return new PacketProjectileDestroyNotify";
                    //    break;

                    //case 619:       // 0x26C
                    //                //return new PacketGroundObjectCreateNotify";
                    //    break;

                    //case 620:       // 0x26D
                    //                //return new PacketGroundObjectDestroyNotify";
                    //    break;

                    //case 621:       // 0x26E
                    //                //return new PacketBuffAddNotify";
                    //    break;

                    //case 622:       // 0x26F
                    //                //return new PacketBuffRemoveNotify";
                    //    break;

                    //case 623:       // 0x270
                    //                //return new PacketBuffRemove";
                    //    break;

                    //case 624:       // 0x271
                    //                //return new PacketBuffRemoveResult";
                    //    break;

                    //case 625:       // 0x272
                    //                //return new PacketSkillListRead";
                    //    break;

                    //case 626:       // 0x273
                    //                //return new PacketSkillListReadResult";
                    //    break;

                    //case 627:       // 0x274
                    //                //return new PacketSkillUpgrade";
                    //    break;

                    //case 628:       // 0x275
                    //                //return new PacketSkillUpgradeResult";
                    //    break;

                    //case 629:       // 0x276
                    //                //return new PacketSkillDeckEquip";
                    //    break;

                    //case 630:       // 0x277
                    //                //return new PacketSkillDeckEquipResult";
                    //    break;

                    //case 631:       // 0x278
                    //                //return new PacketSkillBookUse";
                    //    break;

                    //case 632:       // 0x279
                    //                //return new PacketSkillBookUseResult";
                    //    break;

                    //case 633:       // 0x27A
                    //                //return new PacketSkillAcquireNotify";
                    //    break;

                    //case 634:       // 0x27B
                    //                //return new PacketSoulShotEnableChange";
                    //    break;

                    //case 635:       // 0x27C
                    //                //return new PacketSoulShotEnableChangeResult";
                    //    break;

                    //case 636:       // 0x27D
                    //                //return new PacketSoulShotEnableChangeNotify";
                    //    break;

                    //case 637:       // 0x27E
                    //                //return new PacketSoulShotItemDeleteNotify";
                    //    break;

                    //case 638:       // 0x27F
                    //                //return new PacketSkillCoolTimeNotify";
                    //    break;

                    //case 639:       // 0x280
                    //                //return new PacketSkillAutoRegistrationChange";
                    //    break;

                    //case 640:       // 0x281
                    //                //return new PacketSkillAutoRegistrationChangeResult";
                    //    break;

                    //case 641:       // 0x282
                    //                //return new PacketSkillAutoUseDeckChange";
                    //    break;

                    //case 642:       // 0x283
                    //                //return new PacketSkillAutoUseDeckChangeResult";
                    //    break;

                    //case 750:       // 0x2EF
                    //                //return new PacketChatChannelChange";
                    //    break;

                    //case 751:       // 0x2F0
                    //                //return new PacketChatChannelChangeResult";
                    //    break;

                    //case 752:       // 0x2F1
                    //                //return new PacketChatChannelChangeNotify";
                    //    break;

                    //case 753:       // 0x2F2
                    //                //return new PacketChatChannelListRead";
                    //    break;

                    //case 754:       // 0x2F3
                    //                //return new PacketChatChannelListReadResult";
                    //    break;

                    //case 755:       // 0x2F4
                    //                //return new PacketChatChannelWrite";
                    //    break;

                    //case 756:       // 0x2F5
                    //                //return new PacketChatChannelWriteResult";
                    //    break;

                    //case 757:       // 0x2F6
                    //                //return new PacketChatFriendRoomListRead";
                    //    break;

                    //case 758:       // 0x2F7
                    //                //return new PacketChatFriendRoomListReadResult";
                    //    break;

                    //case 759:       // 0x2F8
                    //                //return new PacketChatFriendRoomGet";
                    //    break;

                    //case 760:       // 0x2F9
                    //                //return new PacketChatFriendRoomGetResult";
                    //    break;

                    //case 761:       // 0x2FA
                    //                //return new PacketChatFriendRoomCreateNotify";
                    //    break;

                    //case 762:       // 0x2FB
                    //                //return new PacketChatFriendRoomLeave";
                    //    break;

                    //case 763:       // 0x2FC
                    //                //return new PacketChatFriendRoomLeaveResult";
                    //    break;

                    //case 764:       // 0x2FD
                    //                //return new PacketChatFriendRoomLeaveNotify";
                    //    break;

                    //case 765:       // 0x2FE
                    //                //return new PacketChatFriendListRead";
                    //    break;

                    //case 766:       // 0x2FF
                    //                //return new PacketChatFriendListReadResult";
                    //    break;

                    //case 767:       // 0x300
                    //                //return new PacketChatFriendWrite";
                    //    break;

                    //case 768:       // 0x301
                    //                //return new PacketChatFriendWriteResult";
                    //    break;

                    //case 769:       // 0x302
                    //                //return new PacketChatFriendWriteNotify";
                    //    break;

                    //case 770:       // 0x303
                    //                //return new PacketChatFriendMessageRead";
                    //    break;

                    //case 771:       // 0x304
                    //                //return new PacketChatFriendMessageReadResult";
                    //    break;

                    //case 772:       // 0x305
                    //                //return new PacketChatFriendMessageReadNotify";
                    //    break;

                    //case 773:       // 0x306
                    //                //return new PacketChatGuildListRead";
                    //    break;


                    //case 775:       // 0x308
                    //                //return new PacketChatGuildWrite";
                    //    break;

                    //case 777:       // 0x30A//return new PacketChatGuildWriteNotify";
                    //    break;// return new PacketChatGuildWriteNotify(packet);

                    //case 778:       // 0x30B //return new PacketChatGuildMessageRead";
                    //    break;// return new PacketChatGuildMessageRead(packet);

                    //case 780:       // 0x30D
                    //                //return new PacketChatSimpleRead";
                    //    break;

                    //case 781:       // 0x30E
                    //                //return new PacketChatSimpleReadResult";
                    //    break;

                    //case 782:       // 0x30F
                    //                //return new PacketChatWorldWrite";
                    //    break;

                    //case 783:       // 0x310
                    //                //return new PacketChatWorldWriteResult";
                    //    break;

                    //case 784:       // 0x311
                    //                //return new PacketChatWorldWriteNotify";
                    //                //PktChatWorldWriteNotify.Packet(packet);
                    //    break;

                    //case 785:       // 0x312
                    //                //return new PacketChatPartyWrite";
                    //    break;

                    //case 786:       // 0x313
                    //                //return new PacketChatPartyWriteResult";
                    //                //PktChatPartyWriteResult.Packet(packet);
                    //    break;

                    //case 787:       // 0x314
                    //                //return new PacketChatPartyWriteNotify";
                    //                //PktChatPartyWriteNotify.Packet(packet);
                    //    break;

                    //case 788:       // 0x315
                    //                //return new PacketChatItemLootNotify";
                    //    break;

                    //case 789:       // 0x316
                    //                //return new PacketSystemMessageShowNotify";
                    //    break;

                    //case 790:       // 0x317
                    //                //return new PacketChatAddInfoRead";
                    //    break;

                    //case 791:       // 0x318
                    //                //return new PacketChatAddInfoReadResult";
                    //    break;

                    //case 792:       // 0x319
                    //                //return new PacketChatPromoListRead";
                    //    break;

                    //case 793:       // 0x31A
                    //                //return new PacketChatPromoListReadResult";
                    //    break;

                    //case 794:       // 0x31B
                    //                //return new PacketChatPromoWrite";
                    //    break;

                    //case 795:       // 0x31C
                    //                //return new PacketChatPromoWriteResult";
                    //    break;

                    //case 796:       // 0x31D
                    //                //return new PacketChatBlockListRead";
                    //    break;

                    //case 797:       // 0x31E
                    //                //return new PacketChatBlockListReadResult";
                    //    break;

                    //case 798:       // 0x31F
                    //                //return new PacketChatBlockInsert";
                    //    break;

                    //case 799:       // 0x320
                    //                //return new PacketChatBlockInsertResult";
                    //    break;

                    //case 800:       // 0x321
                    //                //return new PacketChatBlockDelete";
                    //    break;

                    //case 801:       // 0x322
                    //                //return new PacketChatBlockDeleteResult";
                    //    break;

                    //case 850:       // 0x353
                    //                //return new PacketBagListRead";
                    //    break;

                    //case 851:       // 0x354
                    //                //return new PacketBagListReadResult";
                    //                //PktBagListReadresult.Packet(packet);
                    //    break;

                    //case 852:       // 0x355
                    //                //return new PacketEquipmentListRead";
                    //    break;

                    //case 853:       // 0x356
                    //                //return new PacketEquipmentListReadResult";
                    //    break;

                    //case 854:       // 0x357
                    //                //return new PacketItemUpdateNotify";
                    //    break;

                    //case 855:       // 0x358
                    //                //return new PacketItemEquip";
                    //    break;

                    //case 856:       // 0x359
                    //                //return new PacketItemEquipResult";
                    //    break;

                    //case 857:       // 0x35A
                    //                //return new PacketItemEquipNotify";
                    //    break;

                    //case 858:       // 0x35B
                    //                //return new PacketItemUnequip";
                    //    break;

                    //case 859:       // 0x35C
                    //                //return new PacketItemUnequipResult";
                    //    break;

                    //case 860:       // 0x35D
                    //                //return new PacketItemUnequipAll";
                    //    break;

                    //case 861:       // 0x35E
                    //                //return new PacketItemUnequipAllResult";
                    //    break;

                    //case 862:       // 0x35F
                    //                //return new PacketItemUnequipNotify";
                    //    break;

                    //case 863:       // 0x360
                    //                //return new PacketItemLike";
                    //    break;

                    //case 864:       // 0x361
                    //                //return new PacketItemLikeResult";
                    //    break;

                    //case 865:       // 0x362
                    //                //return new PacketItemSell";
                    //    break;

                    //case 866:       // 0x363
                    //                //return new PacketItemSellResult";
                    //    break;

                    //case 867:       // 0x364
                    //                //return new PacketItemDecompose";
                    //    break;

                    //case 868:       // 0x365
                    //                //return new PacketItemDecomposeResult";
                    //    break;

                    //case 869:       // 0x366
                    //                //return new PacketItemLevelUp";
                    //    break;

                    //case 870:       // 0x367
                    //                //return new PacketItemLevelUpResult";
                    //    break;

                    //case 871:       // 0x368
                    //                //return new PacketItemLevelUpInSocket";
                    //    break;

                    //case 872:       // 0x369
                    //                //return new PacketItemLevelUpInSocketResult";
                    //    break;

                    //case 873:       // 0x36A
                    //                //return new PacketItemLimitBreak";
                    //    break;

                    //case 874:       // 0x36B
                    //                //return new PacketItemLimitBreakResult";
                    //    break;

                    //case 875:       // 0x36C
                    //                //return new PacketItemEnchant";
                    //    break;

                    //case 876:       // 0x36D
                    //                //return new PacketItemEnchantResult";
                    //    break;

                    //case 877:       // 0x36E
                    //                //return new PacketEquipmentItemChangeNotify";
                    //    break;

                    //case 878:       // 0x36F
                    //                //return new PacketItemUpgrade";
                    //    break;

                    //case 879:       // 0x370
                    //                //return new PacketItemUpgradeResult";
                    //    break;

                    //case 880:       // 0x371
                    //                //return new PacketItemUpgradeInSocket";
                    //    break;

                    //case 881:       // 0x372
                    //                //return new PacketItemUpgradeInSocketResult";
                    //    break;

                    //case 882:       // 0x373
                    //                //return new PacketItemCompose";
                    //    break;

                    //case 883:       // 0x374
                    //                //return new PacketItemComposeResult";
                    //    break;

                    //case 884:       // 0x375
                    //                //return new PacketItemOptionChange";
                    //    break;

                    //case 885:       // 0x376
                    //                //return new PacketItemOptionChangeResult";
                    //    break;

                    //case 886:       // 0x377
                    //                //return new PacketItemAbilityUpgrade";
                    //    break;

                    //case 887:       // 0x378
                    //                //return new PacketItemAbilityUpgradeResult";
                    //    break;

                    //case 888:       // 0x379
                    //                //return new PacketItemUseNotify";
                    //    break;

                    //case 889:       // 0x37A
                    //                //return new PacketItemUse";
                    //    break;

                    //case 890:       // 0x37B
                    //                //return new PacketItemUseResult";
                    //    break;

                    //case 891:       // 0x37C
                    //                //return new PacketItemCoolTimeResetNotyfy";
                    //    break;

                    //case 892:       // 0x37D
                    //                //return new PacketSoulCrystalEquip";
                    //    break;

                    //case 893:       // 0x37E
                    //                //return new PacketSoulCrystalEquipResult";
                    //    break;

                    //case 894:       // 0x37F
                    //                //return new PacketSoulCrystalExtract";
                    //    break;

                    //case 895:       // 0x380
                    //                //return new PacketSoulCrystalExtractResult";
                    //    break;

                    //case 896:       // 0x381
                    //                //return new PacketEquipedSoulCrystalSell";
                    //    break;

                    //case 897:       // 0x382
                    //                //return new PacketEquipedSoulCrystalSellResult";
                    //    break;

                    //case 898:       // 0x383
                    //                //return new PacketSoulShotCraft";
                    //    break;

                    //case 899:       // 0x384
                    //                //return new PacketSoulShotCraftResult";
                    //    break;

                    //case 900:       // 0x385
                    //                //return new PacketItemCraft";
                    //    break;

                    //case 901:       // 0x386
                    //                //return new PacketItemCraftResult";
                    //    break;

                    //case 902:       // 0x387
                    //                //return new PacketItemLootNotify";
                    //                //PktItemLootNotify.Packet(packet);
                    //    break;

                    //case 903:       // 0x388
                    //                //return new PacketBagExpand";
                    //    break;

                    //case 904:       // 0x389
                    //                //return new PacketBagExpandResult";
                    //    break;

                    //case 905:       // 0x38A
                    //                //return new PacketBagExpandNotify";
                    //    break;

                    //case 906:       // 0x38B
                    //                //return new PacketWarehouseListRead";
                    //    break;

                    //case 907:       // 0x38C
                    //                //return new PacketWarehouseListReadResult";
                    //    break;

                    //case 908:       // 0x38D
                    //                //return new PacketItemMoveToWarehouse";
                    //    break;

                    //case 909:       // 0x38E
                    //                //return new PacketItemMoveToWarehouseResult";
                    //    break;

                    //case 910:       // 0x38F
                    //                //return new PacketItemMoveToBag";
                    //    break;

                    //case 911:       // 0x390
                    //                //return new PacketItemMoveToBagResult";
                    //    break;

                    //case 912:       // 0x391
                    //                //return new PacketWarehouseExpand";
                    //    break;

                    //case 913:       // 0x392
                    //                //return new PacketWarehouseExpandResult";
                    //    break;

                    //case 914:       // 0x393
                    //                //return new PacketEquipmentDeckChanageNotify";
                    //    break;

                    //case 915:       // 0x394
                    //                //return new PacketActiveEquipmentDeckRead";
                    //    break;

                    //case 916:       // 0x395
                    //                //return new PacketActiveEquipmentDeckReadResult";
                    //    break;

                    //case 917:       // 0x396
                    //                //return new PacketElixirInfoRead";
                    //    break;

                    //case 918:       // 0x397
                    //                //return new PacketElixirInfoReadResult";
                    //    break;

                    //case 919:       // 0x398
                    //                //return new PacketElixirChangeNotify";
                    //    break;

                    //case 920:       // 0x399
                    //                //return new PacketSoulCrystalAutoExtract";
                    //    break;

                    //case 921:       // 0x39A
                    //                //return new PacketSoulCrystalAutoExtractResult";
                    //    break;

                    //case 922:       // 0x39B
                    //                //return new PacketSummonGemUse";
                    //    break;

                    //case 923:       // 0x39C
                    //                //return new PacketSummonGemUseResult";
                    //    break;

                    //case 924:       // 0x39D
                    //                //return new PacketEquipmentCraft";
                    //    break;

                    //case 925:       // 0x39E
                    //                //return new PacketEquipmentCraftResult";
                    //    break;

                    //case 926:       // 0x39F
                    //                //return new PacketEquipmentCraftStepComplete";
                    //    break;

                    //case 927:       // 0x3A0
                    //                //return new PacketEquipmentCraftStepCompleteResult";
                    //    break;

                    //case 928:       // 0x3A1
                    //                //return new PacketItemBoxListRead";
                    //    break;

                    //case 929:       // 0x3A2
                    //                //return new PacketItemBoxListReadResult";
                    //    break;

                    //case 930:       // 0x3A3
                    //                //return new PacketItemCraftInfoRead";
                    //    break;

                    //case 931:       // 0x3A4
                    //                //return new PacketItemCraftInfoReadResult";
                    //    break;

                    //case 932:       // 0x3A5
                    //                //return new PacketSoulCrystalUpgrade";
                    //    break;

                    //case 933:       // 0x3A6
                    //                //return new PacketSoulCrystalUpgradeResult";
                    //    break;

                    //case 934:       // 0x3A7
                    //                //return new PacketSoulCrystalUpgradeInSocket";
                    //    break;

                    //case 935:       // 0x3A8
                    //                //return new PacketSoulCrystalUpgradeInSocketResult";
                    //    break;

                    //case 936:       // 0x3A9
                    //                //return new PacketItemDisassemble";
                    //    break;

                    //case 937:       // 0x3AA
                    //                //return new PacketItemDisassembleResult";
                    //    break;

                    //case 938:       // 0x3AB
                    //                //return new PacketItemUseNicknameChange";
                    //    break;

                    //case 939:       // 0x3AC
                    //                //return new PacketItemUseNicknameChangeResult";
                    //    break;

                    //case 940:       // 0x3AD
                    //                //return new PacketBattleDeckActivate";
                    //    break;

                    //case 941:       // 0x3AE
                    //                //return new PacketBattleDeckActivateResult";
                    //    break;

                    //case 942:       // 0x3AF
                    //                //return new PacketItemOptionChangeInSocket";
                    //    break;

                    //case 943:       // 0x3B0
                    //                //return new PacketItemOptionChangeInSocketResult";
                    //    break;

                    //case 944:       // 0x3B1
                    //                //return new PacketDeletePeriodItemNotify";
                    //    break;

                    //case 945:       // 0x3B2
                    //                //return new PacketBeautyChangeNotify";
                    //    break;

                    //case 946:       // 0x3B3
                    //                //return new PacketAppearanceNotify";
                    //    break;

                    //case 947:       // 0x3B4
                    //                //return new PacketItemDelete";
                    //    break;

                    //case 948:       // 0x3B5
                    //                //return new PacketItemDeleteResult";
                    //    break;

                    //case 1000:      // 0x3E9
                    //                //return new PacketMailListRead";
                    //    break;

                    //case 1001:      // 0x3EA
                    //                //return new PacketMailListReadResult";
                    //    break;

                    //case 1002:      // 0x3EB
                    //                //return new PacketMailDelete";
                    //    break;

                    //case 1003:      // 0x3EC
                    //                //return new PacketMailDeleteResult";
                    //    break;

                    //case 1004:      // 0x3ED
                    //                //return new PacketMailDeleteAll";
                    //    break;

                    //case 1005:      // 0x3EE
                    //                //return new PacketMailDeleteAllResult";
                    //    break;

                    //case 1006:      // 0x3EF
                    //                //return new PacketMailRewardGet";
                    //    break;

                    //case 1007:      // 0x3F0
                    //                //return new PacketMailRewardGetResult";
                    //    break;

                    //case 1008:      // 0x3F1
                    //                //return new PacketMailRewardAllGet";
                    //    break;

                    //case 1009:      // 0x3F2
                    //                //return new PacketMailRewardAllGetResult";
                    //    break;

                    //case 1010:      // 0x3F3
                    //                //return new PacketMailReceiveNotify";
                    //    break;

                    //case 1050:      // 0x41B
                    //                //return new PacketQuestStart";
                    //    break;

                    //case 1051:      // 0x41C
                    //                //return new PacketQuestStartResult";
                    //    break;

                    //case 1052:      // 0x41D
                    //                //return new PacketQuestCancel";
                    //    break;

                    //case 1053:      // 0x41E
                    //                //return new PacketQuestCancelResult";
                    //    break;

                    //case 1054:      // 0x41F
                    //                //return new PacketQuestRestart";
                    //    break;

                    //case 1055:      // 0x420
                    //                //return new PacketQuestRestartResult";
                    //    break;

                    //case 1056:      // 0x421
                    //                //return new PacketQuestUpdate";
                    //    break;

                    //case 1057:      // 0x422
                    //                //return new PacketQuestUpdateResult";
                    //    break;

                    //case 1058:      // 0x423
                    //                //return new PacketQuestUpdateNotify";
                    //    break;

                    //case 1059:      // 0x424
                    //                //return new PacketQuestGadgetControl";
                    //    break;

                    //case 1060:      // 0x425
                    //                //return new PacketQuestGadgetControlResult";
                    //    break;

                    //case 1061:      // 0x426
                    //                //return new PacketQuestGadgetControlNotify";
                    //    break;

                    //case 1062:      // 0x427
                    //                //return new PacketQuestFailNotify";
                    //    break;

                    //case 1063:      // 0x428
                    //                //return new PacketQuestComplete";
                    //    break;

                    //case 1064:      // 0x429
                    //                //return new PacketQuestCompleteResult";
                    //    break;

                    //case 1065:      // 0x42A
                    //                //return new PacketQuestRevive";
                    //    break;

                    //case 1066:      // 0x42B
                    //                //return new PacketQuestReviveResult";
                    //    break;

                    //case 1067:      // 0x42C
                    //                //return new PacketQuestNpcSearch";
                    //    break;

                    //case 1068:      // 0x42D
                    //                //return new PacketQuestNpcSearchResult";
                    //    break;

                    //case 1069:      // 0x42E
                    //                //return new PacketQuestWaveStartNotify";
                    //    break;

                    //case 1070:      // 0x42F
                    //                //return new PacketCastleAndFortressListRead";
                    //    break;

                    //case 1071:      // 0x430
                    //                //return new PacketCastleAndFortressListReadResult";
                    //    break;

                    //case 1072:      // 0x431
                    //                //return new PacketQuestShareRequestNotify";
                    //    break;

                    //case 1073:      // 0x432
                    //                //return new PacketQuestShareAcceptNotify";
                    //    break;

                    //case 1074:      // 0x433
                    //                //return new PacketQuestShare";
                    //    break;

                    //case 1075:      // 0x434
                    //                //return new PacketQuestShareResult";
                    //    break;

                    //case 1076:      // 0x435
                    //                //return new PacketSharedQuestAccept";
                    //    break;

                    //case 1077:      // 0x436
                    //                //return new PacketSharedQuestAcceptResult";
                    //    break;

                    //case 1078:      // 0x437
                    //                //return new PacketQuestActListRead";
                    //    break;

                    //case 1079:      // 0x438
                    //                //return new PacketQuestActListReadResult";
                    //    break;

                    //case 1080:      // 0x439
                    //                //return new PacketQuestActCompleteRewardGet";
                    //    break;

                    //case 1081:      // 0x43A
                    //                //return new PacketQuestActCompleteRewardGetResult";
                    //    break;

                    //case 1082:      // 0x43B
                    //                //return new PacketQuestActChapterCompleteNotify";
                    //    break;

                    //case 1083:      // 0x43C
                    //                //return new PacketQuestScrollCompleteCountReset";
                    //    break;

                    //case 1084:      // 0x43D
                    //                //return new PacketQuestScrollCompleteCountResetResult";
                    //    break;

                    //case 1085:      // 0x43E
                    //                //return new PacketQuestTeleport";
                    //    break;

                    //case 1086:      // 0x43F
                    //                //return new PacketQuestTeleportResult";
                    //    break;

                    //case 1087:      // 0x440
                    //                //return new PacketQuestSimpleUpdateNotify";
                    //    break;

                    //case 1150:      // 0x47F
                    //                //return new PacketPartyInfoRead";
                    //    break;

                    //case 1151:      // 0x480
                    //                //return new PacketPartyInfoReadResult";
                    //    break;

                    //case 1152:      // 0x481
                    //                //return new PacketPartySearchStart";
                    //    break;

                    //case 1153:      // 0x482
                    //                //return new PacketPartySearchStartResult";
                    //    break;

                    //case 1154:      // 0x483
                    //                //return new PacketPartySearchNotify";
                    //    break;

                    //case 1155:      // 0x484
                    //                //return new PacketPartySearchCancel";
                    //    break;

                    //case 1156:      // 0x485
                    //                //return new PacketPartySearchCancelResult";
                    //    break;

                    //case 1157:      // 0x486
                    //                //return new PacketPartyMemberSearchStart";
                    //    break;

                    //case 1158:      // 0x487
                    //                //return new PacketPartyMemberSearchStartResult";
                    //    break;

                    //case 1159:      // 0x488
                    //                //return new PacketPartyMemberSearchCancel";
                    //    break;

                    //case 1160:      // 0x489
                    //                //return new PacketPartyMemberSearchCancelResult";
                    //    break;

                    //case 1161:      // 0x48A
                    //                //return new PacketPartyInvite";
                    //    break;

                    //case 1162:      // 0x48B
                    //                //return new PacketPartyInviteResult";
                    //    break;

                    //case 1163:      // 0x48C
                    //                //return new PacketPartyInviteNotify";
                    //    break;

                    //case 1164:      // 0x48D
                    //                //return new PacketPartyInviteAccept";
                    //    break;

                    //case 1165:      // 0x48E
                    //                //return new PacketPartyInviteAcceptResult";
                    //    break;

                    //case 1166:      // 0x48F
                    //                //return new PacketPartyInviteRefuse";
                    //    break;

                    //case 1167:      // 0x490
                    //                //return new PacketPartyInviteRefuseResult";
                    //    break;

                    //case 1168:      // 0x491
                    //                //return new PacketPartyInviteRefuseNotify";
                    //    break;

                    //case 1169:      // 0x492
                    //                //return new PacketPartyJoinRequest";
                    //    break;

                    //case 1170:      // 0x493
                    //                //return new PacketPartyJoinRequestResult";
                    //    break;

                    //case 1171:      // 0x494
                    //                //return new PacketPartyJoinRequestNotify";
                    //    break;

                    //case 1172:      // 0x495
                    //                //return new PacketPartyJoinRequestCancel";
                    //    break;

                    //case 1173:      // 0x496
                    //                //return new PacketPartyJoinRequestCancelResult";
                    //    break;

                    //case 1174:      // 0x497
                    //                //return new PacketPartyJoinRequestCancelNotify";
                    //    break;

                    //case 1175:      // 0x498
                    //                //return new PacketPartyJoinAccept";
                    //    break;

                    //case 1176:      // 0x499
                    //                //return new PacketPartyJoinAcceptResult";
                    //    break;

                    //case 1177:      // 0x49A
                    //                //return new PacketPartyJoinAcceptNotify";
                    //    break;

                    //case 1178:      // 0x49B
                    //                //return new PacketPartyJoinRefuse";
                    //    break;

                    //case 1179:      // 0x49C
                    //                //return new PacketPartyJoinRefuseResult";
                    //    break;

                    //case 1180:      // 0x49D
                    //                //return new PacketPartyJoinRefuseNotify";
                    //    break;

                    //case 1181:      // 0x49E
                    //                //return new PacketPartyCreateNotify";
                    //    break;

                    //case 1182:      // 0x49F
                    //                //return new PacketPartyMemberJoinNotify";
                    //    break;

                    //case 1183:      // 0x4A0
                    //                //return new PacketPartyExpel";
                    //    break;

                    //case 1184:      // 0x4A1
                    //                //return new PacketPartyExpelResult";
                    //    break;

                    //case 1185:      // 0x4A2
                    //                //return new PacketPartyExpelNotify";
                    //    break;

                    //case 1186:      // 0x4A3
                    //                //return new PacketPartyWithdraw";
                    //    break;

                    //case 1187:      // 0x4A4
                    //                //return new PacketPartyWithdrawResult";
                    //    break;

                    //case 1188:      // 0x4A5
                    //                //return new PacketPartyWithdrawNotify";
                    //    break;

                    //case 1189:      // 0x4A6
                    //                //return new PacketPartyDisband";
                    //    break;

                    //case 1190:      // 0x4A7
                    //                //return new PacketPartyDisbandResult";
                    //    break;

                    //case 1191:      // 0x4A8
                    //                //return new PacketPartyDisbandNotify";
                    //    break;

                    //case 1192:      // 0x4A9
                    //                //return new PacketPartyMasterEntrust";
                    //    break;

                    //case 1193:      // 0x4AA
                    //                //return new PacketPartyMasterEntrustResult";
                    //    break;

                    //case 1194:      // 0x4AB
                    //                //return new PacketPartyMasterEntrustNotify";
                    //    break;

                    //case 1195:      // 0x4AC
                    //                //return new PacketPartyMuster";
                    //    break;

                    //case 1196:      // 0x4AD
                    //                //return new PacketPartyMusterResult";
                    //    break;

                    //case 1197:      // 0x4AE
                    //                //return new PacketPartyMusterNotify";
                    //    break;

                    //case 1198:      // 0x4AF
                    //                //return new PacketPartyMusterAccept";
                    //    break;

                    //case 1199:      // 0x4B0
                    //                //return new PacketPartyMusterAcceptResult";
                    //    break;

                    //case 1200:      // 0x4B1
                    //                //return new PacketPartyMusterRefuse";
                    //    break;

                    //case 1201:      // 0x4B2
                    //                //return new PacketPartyMusterRefuseResult";
                    //    break;

                    //case 1202:      // 0x4B3
                    //                //return new PacketPartyMusterRefuseNotify";
                    //    break;

                    //case 1203:      // 0x4B4
                    //                //return new PacketPartyMeet";
                    //    break;

                    //case 1204:      // 0x4B5
                    //                //return new PacketPartyMeetResult";
                    //    break;

                    //case 1205:      // 0x4B6
                    //                //return new PacketPartyCall";
                    //    break;

                    //case 1206:      // 0x4B7
                    //                //return new PacketPartyCallResult";
                    //    break;

                    //case 1207:      // 0x4B8
                    //                //return new PacketPartyCallNotify";
                    //    break;

                    //case 1208:      // 0x4B9
                    //                //return new PacketPartyMemberStatChangeNotify";
                    //    break;

                    //case 1209:      // 0x4BA
                    //                //return new PacketPartyMasterWorldMoveNotify";
                    //    break;

                    //case 1210:      // 0x4BB
                    //                //return new PacketPartyMemberDisconnectNotify";
                    //    break;

                    //case 1211:      // 0x4BC
                    //                //return new PacketPartyMemberReconnectNotify";
                    //    break;

                    //case 1212:      // 0x4BD
                    //                //return new PacketPartyNearPartyInfo";
                    //    break;

                    //case 1213:      // 0x4BE
                    //                //return new PacketPartyNearPartyInfoResult";
                    //    break;

                    //case 1214:      // 0x4BF
                    //                //return new PacketPartyNearPlayerInfo";
                    //    break;

                    //case 1215:      // 0x4C0
                    //                //return new PacketPartyNearPlayerInfoResult";
                    //    break;

                    //case 1216:      // 0x4C1
                    //                //return new PacketPartyTagSearch";
                    //    break;

                    //case 1217:      // 0x4C2
                    //                //return new PacketPartyTagSearchResult";
                    //    break;

                    //case 1218:      // 0x4C3
                    //                //return new PacketPartyTagChange";
                    //    break;

                    //case 1219:      // 0x4C4
                    //                //return new PacketPartyTagChangeResult";
                    //    break;

                    //case 1220:      // 0x4C5
                    //                //return new PacketPartyTempCreate";
                    //    break;

                    //case 1221:      // 0x4C6
                    //                //return new PacketPartyTempCreateResult";
                    //    break;

                    //case 1222:      // 0x4C7
                    //                //return new PacketPartyTempRegister";
                    //    break;

                    //case 1223:      // 0x4C8
                    //                //return new PacketPartyTempRegisterResult";
                    //    break;

                    //case 1224:      // 0x4C9
                    //                //return new PacketPartyCreate";
                    //    break;

                    //case 1225:      // 0x4CA
                    //                //return new PacketPartyCreateResult";
                    //    break;

                    //case 1226:      // 0x4CB
                    //                //return new PacketPartyMemberPosNotify";
                    //    break;

                    //case 1227:      // 0x4CC
                    //                //return new PacketPartyAutoEnterList";
                    //    break;

                    //case 1228:      // 0x4CD
                    //                //return new PacketPartyAutoEnterListResult";
                    //    break;

                    //case 1229:      // 0x4CE
                    //                //return new PacketPartyAutoEnter";
                    //    break;

                    //case 1230:      // 0x4CF
                    //                //return new PacketPartyAutoEnterResult";
                    //    break;

                    //case 1231:      // 0x4D0
                    //                //return new PacketPartyAutoEnterNotify";
                    //    break;

                    //case 1232:      // 0x4D1
                    //                //return new PacketPartyAutoEnterCancel";
                    //    break;

                    //case 1233:      // 0x4D2
                    //                //return new PacketPartyAutoEnterCancelResult";
                    //    break;

                    //case 1234:      // 0x4D3
                    //                //return new PacketPartyAutoEnterCancelNotify";
                    //    break;

                    //case 1235:      // 0x4D4
                    //                //return new PacketPartyAutoEnterStartNotify";
                    //    break;

                    //case 1236:      // 0x4D5
                    //                //return new PacketPartyAutoEnterAccept";
                    //    break;

                    //case 1237:      // 0x4D6
                    //                //return new PacketPartyAutoEnterAcceptResult";
                    //    break;

                    //case 1238:      // 0x4D7
                    //                //return new PacketPartyAutoEnterAcceptNotify";
                    //    break;

                    //case 1239:      // 0x4D8
                    //                //return new PacketPartyAutoEnterAcceptTimeOutNotify";
                    //    break;

                    //case 1240:      // 0x4D9
                    //                //return new PacketPartyAutoEnterAcceptImpossibleAreaNotify";
                    //    break;

                    //case 1241:      // 0x4DA
                    //                //return new PacketPartyDungeonEnter";
                    //    break;

                    //case 1242:      // 0x4DB
                    //                //return new PacketPartyDungeonEnterResult";
                    //    break;

                    //case 1243:      // 0x4DC
                    //                //return new PacketPartyDungeonEnterStartNotify";
                    //    break;

                    //case 1244:      // 0x4DD
                    //                //return new PacketPartyDungeonEnterCancelNotify";
                    //    break;

                    //case 1245:      // 0x4DE
                    //                //return new PacketPartyDungeonEnterAccept";
                    //    break;

                    //case 1246:      // 0x4DF
                    //                //return new PacketPartyDungeonEnterAcceptResult";
                    //    break;

                    //case 1247:      // 0x4E0
                    //                //return new PacketPartyDungeonEnterAcceptNotify";
                    //    break;

                    //case 1248:      // 0x4E1
                    //                //return new PacketPartyDungeonEnterNotify";
                    //    break;

                    //case 1249:      // 0x4E2
                    //                //return new PacketPartyInfoNotify";
                    //    break;

                    //case 1250:      // 0x4E3
                    //                //return new PacketPartyVoiceChatJoinNotify";
                    //    break;

                    //case 1251:      // 0x4E4
                    //                //return new PacketPartyVoiceChatJoin";
                    //    break;

                    //case 1252:      // 0x4E5
                    //                //return new PacketPartyVoiceChatJoinResult";
                    //    break;

                    //case 1253:      // 0x4E6
                    //                //return new PacketPartyVoiceChatExit";
                    //    break;

                    //case 1254:      // 0x4E7
                    //                //return new PacketPartyVoiceChatExitResult";
                    //    break;

                    //case 1255:      // 0x4E8
                    //                //return new PacketPartyMemberWorldMoveNotify";
                    //    break;

                    //case 1256:      // 0x4E9
                    //                //return new PacketPartyNameChange";
                    //    break;

                    //case 1257:      // 0x4EA
                    //                //return new PacketPartyNameChangeResult";
                    //    break;

                    //case 1258:      // 0x4EB
                    //                //return new PacketPartyNameChangeNotify";
                    //    break;

                    //case 1259:      // 0x4EC
                    //                //return new PacketPartyInviteIndicate";
                    //    break;

                    //case 1260:      // 0x4ED
                    //                //return new PacketPartyInviteIndicateResult";
                    //    break;

                    //case 1261:      // 0x4EE
                    //                //return new PacketPartyEmblemChangeNotify";
                    //    break;

                    //case 1262:      // 0x4EF
                    //                //return new PacketPartyDungeonSupportEnter";
                    //    break;

                    //case 1263:      // 0x4F0
                    //                //return new PacketPartyDungeonSupportEnterResult";
                    //    break;

                    //case 1264:      // 0x4F1
                    //                //return new PacketPartyDungeonHelpRequest";
                    //    break;

                    //case 1265:      // 0x4F2
                    //                //return new PacketPartyDungeonHelpRequestResult";
                    //    break;

                    //case 1266:      // 0x4F3
                    //                //return new PacketPartyDungeonHelpCancel";
                    //    break;

                    //case 1267:      // 0x4F4
                    //                //return new PacketPartyDungeonHelpCancelResult";
                    //    break;

                    //case 1268:      // 0x4F5
                    //                //return new PacketPartyDungeonHelpInfo";
                    //    break;

                    //case 1269:      // 0x4F6
                    //                //return new PacketPartyDungeonHelpInfoResult";
                    //    break;

                    //case 1270:      // 0x4F7
                    //                //return new PacketPartyDungeonHelpList";
                    //    break;

                    //case 1271:      // 0x4F8
                    //                //return new PacketPartyDungeonHelpListResult";
                    //    break;

                    //case 1272:      // 0x4F9
                    //                //return new PacketPartyDungeonHelpParticipate";
                    //    break;

                    //case 1273:      // 0x4FA
                    //                //return new PacketPartyDungeonHelpParticipateResult";
                    //    break;

                    //case 1274:      // 0x4FB
                    //                //return new PacketPartyDungeonResultNotify";
                    //    break;

                    //case 1300:      // 0x515
                    //                //return new PacketFriendListRead";
                    //    break;

                    //case 1301:      // 0x516
                    //                //return new PacketFriendListReadResult";
                    //    break;

                    //case 1302:      // 0x517
                    //                //return new PacketFriendInviteSendListRead";
                    //    break;

                    //case 1303:      // 0x518
                    //                //return new PacketFriendInviteSendListReadResult";
                    //    break;

                    //case 1304:      // 0x519
                    //                //return new PacketFriendInviterListRead";
                    //    break;

                    //case 1305:      // 0x51A
                    //                //return new PacketFriendInviterListReadResult";
                    //    break;

                    //case 1306:      // 0x51B
                    //                //return new PacketFriendInvite";
                    //    break;

                    //case 1307:      // 0x51C
                    //                //return new PacketFriendInviteResult";
                    //    break;

                    //case 1308:      // 0x51D
                    //                //return new PacketFriendInviteNotify";
                    //    break;

                    //case 1309:      // 0x51E
                    //                //return new PacketFriendInviteCancel";
                    //    break;

                    //case 1310:      // 0x51F
                    //                //return new PacketFriendInviteCancelResult";
                    //    break;

                    //case 1311:      // 0x520
                    //                //return new PacketFriendInviteCancelAll";
                    //    break;

                    //case 1312:      // 0x521
                    //                //return new PacketFriendInviteCancelAllResult";
                    //    break;

                    //case 1313:      // 0x522
                    //                //return new PacketFriendInviteCancelNotify";
                    //    break;

                    //case 1314:      // 0x523
                    //                //return new PacketFriendAccept";
                    //    break;

                    //case 1315:      // 0x524
                    //                //return new PacketFriendAcceptResult";
                    //    break;

                    //case 1316:      // 0x525
                    //                //return new PacketFriendAcceptNotify";
                    //    break;

                    //case 1317:      // 0x526
                    //                //return new PacketFriendRefuse";
                    //    break;

                    //case 1318:      // 0x527
                    //                //return new PacketFriendRefuseResult";
                    //    break;

                    //case 1319:      // 0x528
                    //                //return new PacketFriendAcceptAll";
                    //    break;

                    //case 1320:      // 0x529
                    //                //return new PacketFriendAcceptAllResult";
                    //    break;

                    //case 1321:      // 0x52A
                    //                //return new PacketFriendRefuseAll";
                    //    break;

                    //case 1322:      // 0x52B
                    //                //return new PacketFriendRefuseAllResult";
                    //    break;

                    //case 1323:      // 0x52C
                    //                //return new PacketFriendDelete";
                    //    break;

                    //case 1324:      // 0x52D
                    //                //return new PacketFriendDeleteResult";
                    //    break;

                    //case 1325:      // 0x52E
                    //                //return new PacketFriendSearch";
                    //    break;

                    //case 1326:      // 0x52F
                    //                //return new PacketFriendSearchResult";
                    //    break;

                    //case 1327:      // 0x530
                    //                //return new PacketFriendLike";
                    //    break;

                    //case 1328:      // 0x531
                    //                //return new PacketFriendLikeResult";
                    //    break;

                    //case 1329:      // 0x532
                    //                //return new PacketFriendRecommendationListRead";
                    //    break;

                    //case 1330:      // 0x533
                    //                //return new PacketFriendRecommendationListReadResult";
                    //    break;

                    //case 1331:      // 0x534
                    //                //return new PacketFriendRecommendationListRefresh";
                    //    break;

                    //case 1332:      // 0x535
                    //                //return new PacketFriendRecommendationListRefreshResult";
                    //    break;

                    //case 1333:      // 0x536
                    //                //return new PacketFriendRecommendationInviteAll";
                    //    break;

                    //case 1334:      // 0x537
                    //                //return new PacketFriendRecommendationInviteAllResult";
                    //    break;

                    //case 1335:      // 0x538
                    //                //return new PacketFriendListAutoManager";
                    //    break;

                    //case 1336:      // 0x539
                    //                //return new PacketFriendListAutoManagerResult";
                    //    break;

                    //case 1337:      // 0x53A
                    //                //return new PacketFriendGreet";
                    //    break;

                    //case 1338:      // 0x53B
                    //                //return new PacketFriendGreetResult";
                    //    break;

                    //case 1339:      // 0x53C
                    //                //return new PacketFriendGreetAll";
                    //    break;

                    //case 1340:      // 0x53D
                    //                //return new PacketFriendGreetAllResult";
                    //    break;

                    //case 1341:      // 0x53E
                    //                //return new PacketFriendGreetNotify";
                    //    break;

                    //case 1342:      // 0x53F
                    //                //return new PacketFriendGreetReceive";
                    //    break;

                    //case 1343:      // 0x540
                    //                //return new PacketFriendGreetReceiveResult";
                    //    break;

                    //case 1344:      // 0x541
                    //                //return new PacketFriendGreetReceiveAll";
                    //    break;

                    //case 1345:      // 0x542
                    //                //return new PacketFriendGreetReceiveAllResult";
                    //    break;

                    //case 1400:      // 0x579
                    //                //return new PacketGuildInfoRead";
                    //    break;

                    //case 1401:      // 0x57A
                    //                //return new PacketGuildInfoReadResult";
                    //                //PktGuildInfoReadresult.Packet(packet);
                    //    break;

                    //case 1402:      // 0x57B
                    //                //return new PacketGuildMemberListRead";
                    //    break;

                    //case 1403:      // 0x57C
                    //                //return new PacketGuildMemberListReadResult";
                    //                //PktGuildMemberListReadresult.Packet(packet);
                    //    break;

                    //case 1404:      // 0x57D
                    //                //return new PacketGuildCreate";
                    //    break;

                    //case 1405:      // 0x57E
                    //                //return new PacketGuildCreateResult";
                    //    break;

                    //case 1406:      // 0x57F
                    //                //return new PacketGuildCreateCheck";
                    //    break;

                    //case 1407:      // 0x580
                    //                //return new PacketGuildCreateCheckResult";
                    //    break;

                    //case 1408:      // 0x581
                    //                //return new PacketGuildInvite";
                    //    break;

                    //case 1409:      // 0x582
                    //                //return new PacketGuildInviteResult";
                    //    break;

                    //case 1410:      // 0x583
                    //                //return new PacketGuildInviteNotify";
                    //    break;

                    //case 1411:      // 0x584
                    //                //return new PacketGuildInviteAccept";
                    //    break;

                    //case 1412:      // 0x585
                    //                //return new PacketGuildInviteAcceptResult";
                    //    break;

                    //case 1413:      // 0x586
                    //                //return new PacketGuildInviteRefuse";
                    //    break;

                    //case 1414:      // 0x587
                    //                //return new PacketGuildInviteRefuseResult";
                    //    break;

                    //case 1415:      // 0x588
                    //                //return new PacketGuildInviteRefuseNotify";
                    //    break;

                    //case 1416:      // 0x589
                    //                //return new PacketGuildJoinRequest";
                    //    break;

                    //case 1417:      // 0x58A
                    //                //return new PacketGuildJoinRequestResult";
                    //    break;

                    //case 1418:      // 0x58B
                    //                //return new PacketGuildJoinRequestNotify";
                    //    break;

                    //case 1419:      // 0x58C
                    //                //return new PacketGuildJoinRequestListRead";
                    //    break;

                    //case 1420:      // 0x58D
                    //                //return new PacketGuildJoinRequestListReadResult";
                    //    break;

                    //case 1421:      // 0x58E
                    //                //return new PacketGuildReceivedJoinRequestListRead";
                    //    break;

                    //case 1422:      // 0x58F
                    //                //return new PacketGuildReceivedJoinRequestListReadResult";
                    //    break;

                    //case 1423:      // 0x590
                    //                //return new PacketGuildJoinRequestCancel";
                    //    break;

                    //case 1424:      // 0x591
                    //                //return new PacketGuildJoinRequestCancelResult";
                    //    break;

                    //case 1425:      // 0x592
                    //                //return new PacketGuildJoinAccept";
                    //    break;

                    //case 1426:      // 0x593
                    //                //return new PacketGuildJoinAcceptResult";
                    //    break;

                    //case 1427:      // 0x594
                    //                //return new PacketGuildJoinAcceptAll";
                    //    break;

                    //case 1428:      // 0x595
                    //                //return new PacketGuildJoinAcceptAllResult";
                    //    break;

                    //case 1429:      // 0x596
                    //                //return new PacketGuildJoinAcceptNotify";
                    //    break;

                    //case 1430:      // 0x597
                    //                //return new PacketGuildMemberJoinNotify";
                    //    break;

                    //case 1431:      // 0x598
                    //                //return new PacketGuildJoinRefuse";
                    //    break;

                    //case 1432:      // 0x599
                    //                //return new PacketGuildJoinRefuseResult";
                    //    break;

                    //case 1433:      // 0x59A
                    //                //return new PacketGuildJoinRefuseAll";
                    //    break;

                    //case 1434:      // 0x59B
                    //                //return new PacketGuildJoinRefuseAllResult";
                    //    break;

                    //case 1435:      // 0x59C
                    //                //return new PacketGuildJoinRefuseNotify";
                    //    break;

                    //case 1436:      // 0x59D
                    //                //return new PacketGuildExpel";
                    //    break;

                    //case 1437:      // 0x59E
                    //                //return new PacketGuildExpelResult";
                    //    break;

                    //case 1438:      // 0x59F
                    //                //return new PacketGuildExpelNotify";
                    //    break;

                    //case 1439:      // 0x5A0
                    //                //return new PacketGuildWithdraw";
                    //    break;

                    //case 1440:      // 0x5A1
                    //                //return new PacketGuildWithdrawResult";
                    //    break;

                    //case 1441:      // 0x5A2
                    //                //return new PacketGuildWithdrawNotify";
                    //    break;

                    //case 1442:      // 0x5A3
                    //                //return new PacketGuildDisband";
                    //    break;

                    //case 1443:      // 0x5A4
                    //                //return new PacketGuildDisbandResult";
                    //    break;

                    //case 1444:      // 0x5A5
                    //                //return new PacketGuildDisbandNotify";
                    //    break;

                    //case 1445:      // 0x5A6
                    //                //return new PacketGuildMasterEntrust";
                    //    break;

                    //case 1446:      // 0x5A7
                    //                //return new PacketGuildMasterEntrustResult";
                    //    break;

                    //case 1447:      // 0x5A8
                    //                //return new PacketGuildMasterEntrustNotify";
                    //    break;

                    //case 1448:      // 0x5A9
                    //                //return new PacketGuildMemberGradeChange";
                    //    break;

                    //case 1449:      // 0x5AA
                    //                //return new PacketGuildMemberGradeChangeResult";
                    //    break;

                    //case 1450:      // 0x5AB
                    //                //return new PacketGuildMemberGradeChangeNotify";
                    //    break;

                    //case 1451:      // 0x5AC
                    //                //return new PacketGuildIntroductionChange";
                    //    break;

                    //case 1452:      // 0x5AD
                    //                //return new PacketGuildIntroductionChangeResult";
                    //    break;

                    //case 1453:      // 0x5AE
                    //                //return new PacketGuildNoticeChange";
                    //    break;

                    //case 1454:      // 0x5AF
                    //                //return new PacketGuildNoticeChangeResult";
                    //    break;

                    //case 1455:      // 0x5B0
                    //                //return new PacketGuildNameChange";
                    //    break;

                    //case 1456:      // 0x5B1
                    //                //return new PacketGuildNameChangeResult";
                    //    break;

                    //case 1457:      // 0x5B2
                    //                //return new PacketGuildEmblemChange";
                    //    break;

                    //case 1458:      // 0x5B3
                    //                //return new PacketGuildEmblemChangeResult";
                    //    break;

                    //case 1459:      // 0x5B4
                    //                //return new PacketGuildRecommendationListRead";
                    //    break;

                    //case 1460:      // 0x5B5
                    //                //return new PacketGuildRecommendationListReadResult";
                    //                //PktGuildRecommendationListReadresult.Packet(packet);
                    //    break;

                    //case 1461:      // 0x5B6
                    //                //return new PacketGuildRankingListRead";
                    //    break;

                    //case 1462:      // 0x5B7
                    //                //return new PacketGuildRankingListReadResult";
                    //    break;

                    //case 1463:      // 0x5B8
                    //                //return new PacketGuildRecommendationListRefresh";
                    //    break;

                    //case 1464:      // 0x5B9
                    //                //return new PacketGuildRecommendationListRefreshResult";
                    //    break;

                    //case 1465:      // 0x5BA
                    //                //return new PacketGuildMemberRecommendationListRead";
                    //    break;

                    //case 1466:      // 0x5BB
                    //                //return new PacketGuildMemberRecommendationListReadResult";
                    //    break;

                    //case 1467:      // 0x5BC
                    //                //return new PacketGuildDonate";
                    //    break;

                    //case 1468:      // 0x5BD
                    //                //return new PacketGuildDonateResult";
                    //    break;

                    //case 1469:      // 0x5BE
                    //                //return new PacketGuildLevelUpNotify";
                    //    break;

                    //case 1470:      // 0x5BF
                    //                //return new PacketGuildImpeach";
                    //    break;

                    //case 1471:      // 0x5C0
                    //                //return new PacketGuildImpeachResult";
                    //    break;

                    //case 1472:      // 0x5C1
                    //                //return new PacketGuildImpeachNotify";
                    //    break;

                    //case 1473:      // 0x5C2
                    //                //return new PacketGuildAttend";
                    //    break;

                    //case 1474:      // 0x5C3
                    //                //return new PacketGuildAttendResult";
                    //    break;

                    //case 1475:      // 0x5C4
                    //                //return new PacketGuildAttendRewardGet";
                    //    break;

                    //case 1476:      // 0x5C5
                    //                //return new PacketGuildAttendRewardGetResult";
                    //    break;

                    //case 1477:      // 0x5C6
                    //                //return new PacketGuildGreet";
                    //    break;

                    //case 1478:      // 0x5C7
                    //                //return new PacketGuildGreetResult";
                    //    break;

                    //case 1479:      // 0x5C8
                    //                //return new PacketGuildGreetAll";
                    //    break;

                    //case 1480:      // 0x5C9
                    //                //return new PacketGuildGreetAllResult";
                    //    break;

                    //case 1481:      // 0x5CA
                    //                //return new PacketGuildGreetingReceivedNotify";
                    //    break;

                    //case 1482:      // 0x5CB
                    //                //return new PacketGuildGreetReceive";
                    //    break;

                    //case 1483:      // 0x5CC
                    //                //return new PacketGuildGreetReceiveResult";
                    //    break;

                    //case 1484:      // 0x5CD
                    //                //return new PacketGuildGreetReceiveAll";
                    //    break;

                    //case 1485:      // 0x5CE
                    //                //return new PacketGuildGreetReceiveAllResult";
                    //    break;

                    //case 1486:      // 0x5CF
                    //                //return new PacketGuildRecordListRead";
                    //    break;

                    //case 1487:      // 0x5D0
                    //                //return new PacketGuildRecordListReadResult";
                    //                //PktGuildRecordListReadresult.Packet(packet);
                    //    break;

                    //case 1488:      // 0x5D1
                    //                //return new PacketGuildWarehouseListRead";
                    //    break;

                    //case 1489:      // 0x5D2
                    //                //return new PacketGuildWarehouseListReadResult";
                    //    break;

                    //case 1490:      // 0x5D3
                    //                //return new PacketGuildWarehouseGrant";
                    //    break;

                    //case 1491:      // 0x5D4
                    //                //return new PacketGuildWarehouseGrantResult";
                    //    break;

                    //case 1492:      // 0x5D5
                    //                //return new PacketGuildWarehouseGrantAllMember";
                    //    break;

                    //case 1493:      // 0x5D6
                    //                //return new PacketGuildWarehouseGrantAllMemberResult";
                    //    break;

                    //case 1494:      // 0x5D7
                    //                //return new PacketGuildBuffUpgrade";
                    //    break;

                    //case 1495:      // 0x5D8
                    //                //return new PacketGuildBuffUpgradeResult";
                    //    break;

                    //case 1496:      // 0x5D9
                    //                //return new PacketGuildBuffListRead";
                    //    break;

                    //case 1497:      // 0x5DA
                    //                //return new PacketGuildBuffListReadResult";
                    //    break;

                    //case 1498:      // 0x5DB
                    //                //return new PacketGuildBuffBuy";
                    //    break;

                    //case 1499:      // 0x5DC
                    //                //return new PacketGuildBuffBuyResult";
                    //    break;

                    //case 1500:      // 0x5DD
                    //                //return new PacketGuildMarketListRead";
                    //    break;

                    //case 1501:      // 0x5DE
                    //                //return new PacketGuildMarketListReadResult";
                    //    break;

                    //case 1502:      // 0x5DF
                    //                //return new PacketGuildMarketBuy";
                    //    break;

                    //case 1503:      // 0x5E0
                    //                //return new PacketGuildMarketBuyResult";
                    //    break;

                    //case 1504:      // 0x5E1
                    //                //return new PacketGuildMarketGiftBuy";
                    //    break;

                    //case 1505:      // 0x5E2
                    //                //return new PacketGuildMarketGiftBuyResult";
                    //    break;

                    //case 1506:      // 0x5E3
                    //                //return new PacketGuildCastleUpgrade";
                    //    break;

                    //case 1507:      // 0x5E4
                    //                //return new PacketGuildCastleUpgradeResult";
                    //    break;

                    //case 1508:      // 0x5E5
                    //                //return new PacketGuildSearch";
                    //    break;

                    //case 1509:      // 0x5E6
                    //                //return new PacketGuildSearchResult";
                    //                //PktGuildSearchResult.Packet(packet);
                    //    break;

                    //case 1510:      // 0x5E7
                    //                //return new PacketGuildAllianceListRead";
                    //    break;

                    //case 1511:      // 0x5E8
                    //                //return new PacketGuildAllianceListReadResult";
                    //    break;

                    //case 1512:      // 0x5E9
                    //                //return new PacketGuildAllianceInviterListRead";
                    //    break;

                    //case 1513:      // 0x5EA
                    //                //return new PacketGuildAllianceInviterListReadResult";
                    //    break;

                    //case 1514:      // 0x5EB
                    //                //return new PacketGuildAllianceInvite";
                    //    break;

                    //case 1515:      // 0x5EC
                    //                //return new PacketGuildAllianceInviteResult";
                    //    break;

                    //case 1516:      // 0x5ED
                    //                //return new PacketGuildAllianceInvitationCancel";
                    //    break;

                    //case 1517:      // 0x5EE
                    //                //return new PacketGuildAllianceInvitationCancelResult";
                    //    break;

                    //case 1518:      // 0x5EF
                    //                //return new PacketGuildAllianceAccept";
                    //    break;

                    //case 1519:      // 0x5F0
                    //                //return new PacketGuildAllianceAcceptResult";
                    //    break;

                    //case 1520:      // 0x5F1
                    //                //return new PacketGuildAllianceChangeNotify";
                    //    break;

                    //case 1521:      // 0x5F2
                    //                //return new PacketGuildHostilityChangeNotify";
                    //    break;

                    //case 1522:      // 0x5F3
                    //                //return new PacketGuildAllianceRefuse";
                    //    break;

                    //case 1523:      // 0x5F4
                    //                //return new PacketGuildAllianceRefuseResult";
                    //    break;

                    //case 1524:      // 0x5F5
                    //                //return new PacketGuildAllianceRefuseAll";
                    //    break;

                    //case 1525:      // 0x5F6
                    //                //return new PacketGuildAllianceRefuseAllResult";
                    //    break;

                    //case 1526:      // 0x5F7
                    //                //return new PacketGuildAllianceDelete";
                    //    break;

                    //case 1527:      // 0x5F8
                    //                //return new PacketGuildAllianceDeleteResult";
                    //    break;

                    //case 1528:      // 0x5F9
                    //                //return new PacketGuildHostilityListRead";
                    //    break;

                    //case 1529:      // 0x5FA
                    //                //return new PacketGuildHostilityListReadResult";
                    //    break;

                    //case 1530:      // 0x5FB
                    //                //return new PacketGuildHostilityRegister";
                    //    break;

                    //case 1531:      // 0x5FC
                    //                //return new PacketGuildHostilityRegisterResult";
                    //    break;

                    //case 1532:      // 0x5FD
                    //                //return new PacketGuildHostilityWarDeclare";
                    //    break;

                    //case 1533:      // 0x5FE
                    //                //return new PacketGuildHostilityWarDeclareResult";
                    //    break;

                    //case 1534:      // 0x5FF
                    //                //return new PacketGuildHostilityUnregister";
                    //    break;

                    //case 1535:      // 0x600
                    //                //return new PacketGuildHostilityUnregisterResult";
                    //    break;

                    //case 1536:      // 0x601
                    //                //return new PacketGuildHostileWarSurrender";
                    //    break;

                    //case 1537:      // 0x602
                    //                //return new PacketGuildHostileWarSurrenderResult";
                    //    break;

                    //case 1538:      // 0x603
                    //                //return new PacketGuildHostileWarRecordListRead";
                    //    break;

                    //case 1539:      // 0x604
                    //                //return new PacketGuildHostileWarRecordListReadResult";
                    //    break;

                    //case 1540:      // 0x605
                    //                //return new PacketGuildAchievementListRead";
                    //    break;

                    //case 1541:      // 0x606
                    //                //return new PacketGuildAchievementListReadResult";
                    //    break;

                    //case 1542:      // 0x607
                    //                //return new PacketGuildAchievementRewardGet";
                    //    break;

                    //case 1543:      // 0x608
                    //                //return new PacketGuildAchievementRewardGetResult";
                    //    break;

                    //case 1544:      // 0x609
                    //                //return new PacketGuildJoinRequestOptionChange";
                    //    break;

                    //case 1545:      // 0x60A
                    //                //return new PacketGuildJoinRequestOptionChangeResult";
                    //    break;

                    //case 1546:      // 0x60B
                    //                //return new PacketGuildInfoReadChangeNotify";
                    //    break;

                    //case 1547:      // 0x60C
                    //                //return new PacketGuildBadgeNotify";
                    //    break;

                    //case 1548:      // 0x60D
                    //                //return new PacketGuildHostileWarBroadcastNotify";
                    //    break;

                    //case 1549:      // 0x60E
                    //                //return new PacketGuildNoticeRead";
                    //    break;

                    //case 1550:      // 0x60F
                    //                //return new PacketGuildNoticeReadResult";
                    //    break;

                    //case 1551:      // 0x610
                    //                //return new PacketGuildPromotionLimitTimeNotify";
                    //    break;

                    //case 1552:      // 0x611
                    //                //return new PacketGuildDungeonEnter";
                    //    break;

                    //case 1553:      // 0x612
                    //                //return new PacketGuildDungeonEnterResult";
                    //    break;

                    //case 1554:      // 0x613
                    //                //return new PacketGuildDungeonEnterNotify";
                    //    break;

                    //case 1555:      // 0x614
                    //                //return new PacketGuildDungeonList";
                    //    break;

                    //case 1556:      // 0x615
                    //                //return new PacketGuildDungeonListResult";
                    //    break;

                    //case 1557:      // 0x616
                    //                //return new PacketGuildDungeonReset";
                    //    break;

                    //case 1558:      // 0x617
                    //                //return new PacketGuildDungeonResetResult";
                    //    break;

                    //case 1559:      // 0x618
                    //                //return new PacketGuildDungeonInviteRequest";
                    //    break;

                    //case 1560:      // 0x619
                    //                //return new PacketGuildDungeonInviteRequestResult";
                    //    break;

                    //case 1561:      // 0x61A
                    //                //return new PacketGuildDungeonInviteRequestNotify";
                    //    break;

                    //case 1562:      // 0x61B
                    //                //return new PacketGuildDungeonInviteAccept";
                    //    break;

                    //case 1563:      // 0x61C
                    //                //return new PacketGuildDungeonInviteAcceptResult";
                    //    break;

                    //case 1564:      // 0x61D
                    //                //return new PacketGuildDungeonDamageNotify";
                    //    break;

                    //case 1565:      // 0x61E
                    //                //return new PacketGuildDungeonResultNotify";
                    //    break;

                    //case 1566:      // 0x61F
                    //                //return new PacketGuildDungeonKickoutNotify";
                    //    break;

                    //case 1567:      // 0x620
                    //                //return new PacketGuildMasterBuffNotify";
                    //    break;

                    //case 1568:      // 0x621
                    //                //return new PacketGuildNameChangeNotify";
                    //    break;

                    //case 1570:      // 0x623
                    //                //return new PacketGuildInfoNotify";
                    //    break;

                    //case 1571:      // 0x624
                    //                //return new PacketGuildAgitBuy";
                    //    break;

                    //case 1572:      // 0x625
                    //                //return new PacketGuildAgitBuyResult";
                    //    break;

                    //case 1573:      // 0x626
                    //                //return new PacketGuildAgitUpgrade";
                    //    break;

                    //case 1574:      // 0x627
                    //                //return new PacketGuildAgitUpgradeResult";
                    //    break;

                    //case 1575:      // 0x628
                    //                //return new PacketGuildAgitCrystalUpgrade";
                    //    break;

                    //case 1576:      // 0x629
                    //                //return new PacketGuildAgitCrystalUpgradeResult";
                    //    break;

                    //case 1577:      // 0x62A
                    //                //return new PacketGuildAgitInfo";
                    //    break;

                    //case 1578:      // 0x62B
                    //                //return new PacketGuildAgitInfoResult";
                    //    break;

                    //case 1579:      // 0x62C
                    //                //return new PacketGuildAgitOpen";
                    //    break;

                    //case 1580:      // 0x62D
                    //                //return new PacketGuildAgitOpenResult";
                    //    break;

                    //case 1581:      // 0x62E
                    //                //return new PacketGuildAgitExpel";
                    //    break;

                    //case 1582:      // 0x62F
                    //                //return new PacketGuildAgitExpelResult";
                    //    break;

                    //case 1583:      // 0x630
                    //                //return new PacketGuildAgitExpelNotify";
                    //    break;

                    //case 1584:      // 0x631
                    //                //return new PacketGuildAgitEnter";
                    //    break;

                    //case 1585:      // 0x632
                    //                //return new PacketGuildAgitEnterResult";
                    //    break;

                    //case 1586:      // 0x633
                    //                //return new PacketGuildAgitLeave";
                    //    break;

                    //case 1587:      // 0x634
                    //                //return new PacketGuildAgitLeaveResult";
                    //    break;

                    //case 1588:      // 0x635
                    //                //return new PacketGuildAgitQuestList";
                    //    break;

                    //case 1589:      // 0x636
                    //                //return new PacketGuildAgitQuestListResult";
                    //                //PktGuildAgitQuestListresult.Packet(packet);
                    //    break;

                    //case 1590:      // 0x637
                    //                //return new PacketGuildAgitQuestAccept";
                    //    break;

                    //case 1591:      // 0x638
                    //                //return new PacketGuildAgitQuestAcceptResult";
                    //    break;

                    //case 1592:      // 0x639
                    //                //return new PacketGuildAgitQuestComplete";
                    //    break;

                    //case 1593:      // 0x63A
                    //                //return new PacketGuildAgitQuestCompleteResult";
                    //    break;

                    //case 1594:      // 0x63B
                    //                //return new PacketGuildAgitQuestCompleteImmediately";
                    //    break;

                    //case 1595:      // 0x63C
                    //                //return new PacketGuildAgitQuestCompleteImmediatelyResult";
                    //    break;

                    //case 1596:      // 0x63D
                    //                //return new PacketGuildPromoListRead";
                    //    break;

                    //case 1597:      // 0x63E
                    //                //return new PacketGuildPromoListReadResult";
                    //    break;

                    //case 1598:      // 0x63F
                    //                //return new PacketGuildCommunityOpen";
                    //    break;

                    //case 1599:      // 0x640
                    //                //return new PacketGuildCommunityOpenResult";
                    //    break;

                    //case 1600:      // 0x641
                    //                //return new PacketCastleSiegeInfoRead";
                    //    break;

                    //case 1601:      // 0x642
                    //                //return new PacketCastleSiegeInfoReadResult";
                    //    break;

                    //case 1602:      // 0x643
                    //                //return new PacketCastleSiegeEnter";
                    //    break;

                    //case 1603:      // 0x644
                    //                //return new PacketCastleSiegeEnterResult";
                    //    break;

                    //case 1604:      // 0x645
                    //                //return new PacketCastleSiegeEnterNotify";
                    //    break;

                    //case 1605:      // 0x646
                    //                //return new PacketCastleSiegeInfoNotify";
                    //    break;

                    //case 1606:      // 0x647
                    //                //return new PacketCastleSiegeStateChangeNotify";
                    //    break;

                    //case 1607:      // 0x648
                    //                //return new PacketCastleSiegeGuildInfoRead";
                    //    break;

                    //case 1608:      // 0x649
                    //                //return new PacketCastleSiegeGuildInfoReadResult";
                    //    break;

                    //case 1609:      // 0x64A
                    //                //return new PacketCastleSiegeFinishNotify";
                    //    break;

                    //case 1610:      // 0x64B
                    //                //return new PacketCastleSiegeRetreatNotify";
                    //    break;

                    //case 1611:      // 0x64C
                    //                //return new PacketCastleSiegeHolyArtifactHpChangeNotify";
                    //    break;

                    //case 1612:      // 0x64D
                    //                //return new PacketCastleSiegeHolyArtifactImprintNotify";
                    //    break;

                    //case 1613:      // 0x64E
                    //                //return new PacketCastleSiegeEventNotify";
                    //    break;

                    //case 1614:      // 0x64F
                    //                //return new PacketCastleSiegeLeave";
                    //    break;

                    //case 1615:      // 0x650
                    //                //return new PacketCastleSiegeLeaveResult";
                    //    break;

                    //case 1616:      // 0x651
                    //                //return new PacketCastleSiegeEntryBid";
                    //    break;

                    //case 1617:      // 0x652
                    //                //return new PacketCastleSiegeEntryBidResult";
                    //    break;

                    //case 1618:      // 0x653
                    //                //return new PacketCastleSiegeEntryBidCancel";
                    //    break;

                    //case 1619:      // 0x654
                    //                //return new PacketCastleSiegeEntryBidCancelResult";
                    //    break;

                    //case 1620:      // 0x655
                    //                //return new PacketCastleSiegeEntryChangeNotify";
                    //    break;

                    //case 1621:      // 0x656
                    //                //return new PacketCastleSiegeFestivalInfoRead";
                    //    break;

                    //case 1622:      // 0x657
                    //                //return new PacketCastleSiegeFestivalInfoReadResult";
                    //    break;

                    //case 1623:      // 0x658
                    //                //return new PacketCastleSiegeFestivalLotteryBuy";
                    //    break;

                    //case 1624:      // 0x659
                    //                //return new PacketCastleSiegeFestivalLotteryBuyResult";
                    //    break;

                    //case 1625:      // 0x65A
                    //                //return new PacketCastleSiegeFestivalLotteryRewardGet";
                    //    break;

                    //case 1626:      // 0x65B
                    //                //return new PacketCastleSiegeFestivalLotteryRewardGetResult";
                    //    break;

                    //case 1627:      // 0x65C
                    //                //return new PacketCastleSiegeGuildAlarm";
                    //    break;

                    //case 1628:      // 0x65D
                    //                //return new PacketCastleSiegeGuildAlarmResult";
                    //    break;

                    //case 1629:      // 0x65E
                    //                //return new PacketCastleSiegeGuildAlarmNotify";
                    //    break;

                    //case 1630:      // 0x65F
                    //                //return new PacketCommonSiegeKillComboNotify";
                    //    break;

                    //case 1631:      // 0x660
                    //                //return new PacketCommonSiegeOccupyBuffNotify";
                    //    break;

                    //case 1632:      // 0x661
                    //                //return new PacketCommonSiegeDestroyedActorNotify";
                    //    break;

                    //case 1633:      // 0x662
                    //                //return new PacketCastleOccupyGuildInfo";
                    //    break;

                    //case 1634:      // 0x663
                    //                //return new PacketCastleOccupyGuildInfoResult";
                    //    break;

                    //case 1635:      // 0x664
                    //                //return new PacketCastleSiegePrevRecord";
                    //    break;

                    //case 1636:      // 0x665
                    //                //return new PacketCastleSiegePrevRecordResult";
                    //    break;

                    //case 1637:      // 0x666
                    //                //return new PacketCastleSiegeHistoryList";
                    //    break;

                    //case 1638:      // 0x667
                    //                //return new PacketCastleSiegeHistoryListResult";
                    //    break;

                    //case 1639:      // 0x668
                    //                //return new PacketCastleSiegePreseasonInfo";
                    //    break;

                    //case 1640:      // 0x669
                    //                //return new PacketCastleSiegePreseasonInfoResult";
                    //    break;

                    //case 1641:      // 0x66A
                    //                //return new PacketGuildAutoDisbandNotify";
                    //    break;

                    //case 1700:      // 0x6A5
                    //                //return new PacketFortressSiegeInfoRead";
                    //    break;

                    //case 1701:      // 0x6A6
                    //                //return new PacketFortressSiegeInfoReadResult";
                    //    break;

                    //case 1702:      // 0x6A7
                    //                //return new PacketFortressSiegeEntryBid";
                    //    break;

                    //case 1703:      // 0x6A8
                    //                //return new PacketFortressSiegeEntryBidResult";
                    //    break;

                    //case 1704:      // 0x6A9
                    //                //return new PacketFortressSiegeEntryBidCancel";
                    //    break;

                    //case 1705:      // 0x6AA
                    //                //return new PacketFortressSiegeEntryBidCancelResult";
                    //    break;

                    //case 1706:      // 0x6AB
                    //                //return new PacketFortressSiegeEntryChangeNotify";
                    //    break;

                    //case 1707:      // 0x6AC
                    //                //return new PacketFortressSiegeEnter";
                    //    break;

                    //case 1708:      // 0x6AD
                    //                //return new PacketFortressSiegeEnterResult";
                    //    break;

                    //case 1709:      // 0x6AE
                    //                //return new PacketFortressSiegeEnterNotify";
                    //    break;

                    //case 1710:      // 0x6AF
                    //                //return new PacketFortressSiegeInfoNotify";
                    //    break;

                    //case 1711:      // 0x6B0
                    //                //return new PacketFortressSiegeStateChangeNotify";
                    //    break;

                    //case 1712:      // 0x6B1
                    //                //return new PacketFortressSiegeGuildInfoRead";
                    //    break;

                    //case 1713:      // 0x6B2
                    //                //return new PacketFortressSiegeGuildInfoReadResult";
                    //    break;

                    //case 1714:      // 0x6B3
                    //                //return new PacketFortressSiegeFinishNotify";
                    //    break;

                    //case 1715:      // 0x6B4
                    //                //return new PacketFortressSiegeRetreatNotify";
                    //    break;

                    //case 1716:      // 0x6B5
                    //                //return new PacketFortressSiegeHolyArtifactHpChangeNotify";
                    //    break;

                    //case 1717:      // 0x6B6
                    //                //return new PacketFortressSiegeHolyArtifactImprintNotify";
                    //    break;

                    //case 1718:      // 0x6B7
                    //                //return new PacketFortressSiegeEventNotify";
                    //    break;

                    //case 1719:      // 0x6B8
                    //                //return new PacketFortressSiegeLeave";
                    //    break;

                    //case 1720:      // 0x6B9
                    //                //return new PacketFortressSiegeLeaveResult";
                    //    break;

                    //case 1721:      // 0x6BA
                    //                //return new PacketFortressOccupyGuildInfo";
                    //    break;

                    //case 1722:      // 0x6BB
                    //                //return new PacketFortressOccupyGuildInfoResult";
                    //    break;

                    //case 1723:      // 0x6BC
                    //                //return new PacketFortressSiegePrevRecord";
                    //    break;

                    //case 1724:      // 0x6BD
                    //                //return new PacketFortressSiegePrevRecordResult";
                    //    break;

                    //case 1725:      // 0x6BE
                    //                //return new PacketFortressSiegeHistoryList";
                    //    break;

                    //case 1726:      // 0x6BF
                    //                //return new PacketFortressSiegeHistoryListResult";
                    //    break;

                    //case 1800:      // 0x709
                    //                //return new PacketAuctionHouseSearchListRead";
                    //    break;

                    //case 1801:      // 0x70A
                    //                //return new PacketAuctionHouseSearchListReadResult";
                    //    break;

                    //case 1802:      // 0x70B
                    //                //return new PacketAuctionHouseItemDetailView";
                    //    break;

                    //case 1803:      // 0x70C
                    //                //return new PacketAuctionHouseItemDetailViewResult";
                    //    break;

                    //case 1804:      // 0x70D
                    //                //return new PacketAuctionHouseBuy";
                    //    break;

                    //case 1805:      // 0x70E
                    //                //return new PacketAuctionHouseBuyResult";
                    //    break;

                    //case 1806:      // 0x70F
                    //                //return new PacketAuctionHouseSellingListRead";
                    //    break;

                    //case 1807:      // 0x710
                    //                //return new PacketAuctionHouseSellingListReadResult";
                    //    break;

                    //case 1808:      // 0x711
                    //                //return new PacketAuctionHouseSellingRegister";
                    //    break;

                    //case 1809:      // 0x712
                    //                //return new PacketAuctionHouseSellingRegisterResult";
                    //    break;

                    //case 1810:      // 0x713
                    //                //return new PacketAuctionHouseSellingCancel";
                    //    break;

                    //case 1811:      // 0x714
                    //                //return new PacketAuctionHouseSellingCancelResult";
                    //    break;

                    //case 1812:      // 0x715
                    //                //return new PacketAuctionHouseSellingResultGet";
                    //    break;

                    //case 1813:      // 0x716
                    //                //return new PacketAuctionHouseSellingResultGetResult";
                    //    break;

                    //case 1814:      // 0x717
                    //                //return new PacketAuctionHouseSellingResultGetAll";
                    //    break;

                    //case 1815:      // 0x718
                    //                //return new PacketAuctionHouseSellingResultGetAllResult";
                    //    break;

                    //case 1816:      // 0x719
                    //                //return new PacketAuctionHouseRecordListRead";
                    //    break;

                    //case 1817:      // 0x71A
                    //                //return new PacketAuctionHouseRecordListReadResult";
                    //    break;

                    //case 1818:      // 0x71B
                    //                //return new PacketAuctionHouseAveragePriceGet";
                    //    break;

                    //case 1819:      // 0x71C
                    //                //return new PacketAuctionHouseAveragePriceGetResult";
                    //    break;

                    //case 1820:      // 0x71D
                    //                //return new PacketAuctionHouseFavoritesListRead";
                    //    break;

                    //case 1821:      // 0x71E
                    //                //return new PacketAuctionHouseFavoritesListReadResult";
                    //    break;

                    //case 1822:      // 0x71F
                    //                //return new PacketAuctionHouseFavoritesRegister";
                    //    break;

                    //case 1823:      // 0x720
                    //                //return new PacketAuctionHouseFavoritesRegisterResult";
                    //    break;

                    //case 1824:      // 0x721
                    //                //return new PacketAuctionHouseFavoritesOnSaleNotify";
                    //    break;

                    //case 1825:      // 0x722
                    //                //return new PacketAuctionHouseSellingRegisterAgain";
                    //    break;

                    //case 1826:      // 0x723
                    //                //return new PacketAuctionHouseSellingRegisterAgainResult";
                    //    break;

                    //case 1827:      // 0x724
                    //                //return new PacketAuctionHouseGetEnabled";
                    //    break;

                    //case 1828:      // 0x725
                    //                //return new PacketAuctionHouseGetEnabledResult";
                    //    break;

                    //case 1900:      // 0x76D
                    //                //return new PacketShopItemListRead";
                    //    break;

                    //case 1901:      // 0x76E
                    //                //return new PacketShopItemListReadResult";
                    //    break;

                    //case 1902:      // 0x76F
                    //                //return new PacketShopItemBuy";
                    //    break;

                    //case 1903:      // 0x770
                    //                //return new PacketShopItemBuyResult";
                    //    break;

                    //case 1904:      // 0x771
                    //                //return new PacketFixedChargeNotify";
                    //    break;

                    //case 1905:      // 0x772
                    //                //return new PacketFixedChargeInfoNotify";
                    //    break;

                    //case 1906:      // 0x773
                    //                //return new PacketFixedChargeDetail";
                    //    break;

                    //case 1907:      // 0x774
                    //                //return new PacketFixedChargeDetailResult";
                    //    break;

                    //case 1908:      // 0x775
                    //                //return new PacketFixedChargeBuy";
                    //    break;

                    //case 1909:      // 0x776
                    //                //return new PacketFixedChargeBuyResult";
                    //    break;

                    //case 1910:      // 0x777
                    //                //return new PacketFixedChargeTopazGet";
                    //    break;

                    //case 1911:      // 0x778
                    //                //return new PacketFixedChargeTopazGetResult";
                    //    break;

                    //case 1912:      // 0x779
                    //                //return new PacketFixedChargeDiamondGet";
                    //    break;

                    //case 1913:      // 0x77A
                    //                //return new PacketFixedChargeDiamondGetResult";
                    //    break;

                    //case 1914:      // 0x77B
                    //                //return new PacketFixedChargeYesterdayDiamondGet";
                    //    break;

                    //case 1915:      // 0x77C
                    //                //return new PacketFixedChargeYesterdayDiamondGetResult";
                    //    break;

                    //case 1916:      // 0x77D
                    //                //return new PacketPensionTypeNotify";
                    //    break;

                    //case 1917:      // 0x77E
                    //                //return new PacketPensionTypeAchievementCompleteNotify";
                    //    break;

                    //case 1918:      // 0x77F
                    //                //return new PacketPensionTypeDetail";
                    //    break;

                    //case 1919:      // 0x780
                    //                //return new PacketPensionTypeDetailResult";
                    //    break;

                    //case 1920:      // 0x781
                    //                //return new PacketPensionTypeBuy";
                    //    break;

                    //case 1921:      // 0x782
                    //                //return new PacketPensionTypeBuyResult";
                    //    break;

                    //case 1922:      // 0x783
                    //                //return new PacketPensionTypeRewardGet";
                    //    break;

                    //case 1923:      // 0x784
                    //                //return new PacketPensionTypeRewardGetResult";
                    //    break;

                    //case 1924:      // 0x785
                    //                //return new PacketSmartPopupNotify";
                    //    break;

                    //case 1925:      // 0x786
                    //                //return new PacketSmartPopupClose";
                    //    break;

                    //case 1926:      // 0x787
                    //                //return new PacketSmartPopupCloseResult";
                    //    break;

                    //case 1927:      // 0x788
                    //                //return new PacketDailyAdenaNotify";
                    //    break;

                    //case 1928:      // 0x789
                    //                //return new PacketDailyAdenaInfoNotify";
                    //    break;

                    //case 1929:      // 0x78A
                    //                //return new PacketDailyAdenaDetail";
                    //    break;

                    //case 1930:      // 0x78B
                    //                //return new PacketDailyAdenaDetailResult";
                    //    break;

                    //case 1931:      // 0x78C
                    //                //return new PacketDailyAdenaBuy";
                    //    break;

                    //case 1932:      // 0x78D
                    //                //return new PacketDailyAdenaBuyResult";
                    //    break;

                    //case 1933:      // 0x78E
                    //                //return new PacketDailyAdenaDiamondGet";
                    //    break;

                    //case 1934:      // 0x78F
                    //                //return new PacketDailyAdenaDiamondGetResult";
                    //    break;

                    //case 1935:      // 0x790
                    //                //return new PacketDailyAdenaRewardGet";
                    //    break;

                    //case 1936:      // 0x791
                    //                //return new PacketDailyAdenaRewardGetResult";
                    //    break;

                    //case 1937:      // 0x792
                    //                //return new PacketShopRewardListRead";
                    //    break;

                    //case 1938:      // 0x793
                    //                //return new PacketShopRewardListReadResult";
                    //    break;

                    //case 1939:      // 0x794
                    //                //return new PacketShopRewardGet";
                    //    break;

                    //case 1940:      // 0x795
                    //                //return new PacketShopRewardGetResult";
                    //    break;

                    //case 1941:      // 0x796
                    //                //return new PacketShopRewardNotify";
                    //    break;

                    //case 1942:      // 0x797
                    //                //return new PacketFixedChargeGoodsListRead";
                    //    break;

                    //case 1943:      // 0x798
                    //                //return new PacketFixedChargeGoodsListReadResult";
                    //    break;

                    //case 1944:      // 0x799
                    //                //return new PacketFixedChargeGoodsBuy";
                    //    break;

                    //case 1945:      // 0x79A
                    //                //return new PacketFixedChargeGoodsBuyResult";
                    //    break;

                    //case 1946:      // 0x79B
                    //                //return new PacketFixedChargeGoodsDailyReward";
                    //    break;

                    //case 1947:      // 0x79C
                    //                //return new PacketFixedChargeGoodsDailyRewardResult";
                    //    break;

                    //case 1948:      // 0x79D
                    //                //return new PacketFixedChargeGoodsExpireNotify";
                    //    break;

                    //case 1949:      // 0x79E
                    //                //return new PacketShopSuggestionRead";
                    //    break;

                    //case 1950:      // 0x79F
                    //                //return new PacketShopSuggestionReadResult";
                    //    break;

                    //case 1951:      // 0x7A0
                    //                //return new PacketTimeShopListRead";
                    //    break;

                    //case 1952:      // 0x7A1
                    //                //return new PacketTimeShopListReadResult";
                    //    break;

                    //case 1953:      // 0x7A2
                    //                //return new PacketTimeShopListNotify";
                    //    break;

                    //case 1954:      // 0x7A3
                    //                //return new PacketDiscountShopListRead";
                    //    break;

                    //case 1955:      // 0x7A4
                    //                //return new PacketDiscountShopListReadResult";
                    //    break;

                    //case 1956:      // 0x7A5
                    //                //return new PacketDailyBenefitsEventStartNotify";
                    //    break;

                    //case 1957:      // 0x7A6
                    //                //return new PacketDailyBenefitsEventExpireNotify";
                    //    break;

                    //case 1958:      // 0x7A7
                    //                //return new PacketDailyBenefitsEventRequest";
                    //    break;

                    //case 1959:      // 0x7A8
                    //                //return new PacketDailyBenefitsEventRequestResult";
                    //    break;

                    //case 1960:      // 0x7A9
                    //                //return new PacketBeautyShopListRead";
                    //    break;

                    //case 1961:      // 0x7AA
                    //                //return new PacketBeautyShopListReadResult";
                    //    break;

                    //case 1962:      // 0x7AB
                    //                //return new PacketBeautyShopItemBuy";
                    //    break;

                    //case 1963:      // 0x7AC
                    //                //return new PacketBeautyShopItemBuyResult";
                    //    break;

                    //case 1964:      // 0x7AD
                    //                //return new PacketShopCumulativePurchaseListRead";
                    //    break;

                    //case 1965:      // 0x7AE
                    //                //return new PacketShopCumulativePurchaseListReadResult";
                    //    break;

                    //case 2000:      // 0x7D1
                    //                //return new PacketDungeonListRead";
                    //    break;

                    //case 2001:      // 0x7D2
                    //                //return new PacketDungeonListReadResult";
                    //    break;

                    //case 2002:      // 0x7D3
                    //                //return new PacketDungeonEnter";
                    //    break;

                    //case 2003:      // 0x7D4
                    //                //return new PacketDungeonEnterResult";
                    //    break;

                    //case 2004:      // 0x7D5
                    //                //return new PacketDungeonExit";
                    //    break;

                    //case 2005:      // 0x7D6
                    //                //return new PacketDungeonExitResult";
                    //    break;

                    //case 2006:      // 0x7D7
                    //                //return new PacketDungeonGiveUp";
                    //    break;

                    //case 2007:      // 0x7D8
                    //                //return new PacketDungeonGiveUpResult";
                    //    break;

                    //case 2008:      // 0x7D9
                    //                //return new PacketDungeonSweep";
                    //    break;

                    //case 2009:      // 0x7DA
                    //                //return new PacketDungeonSweepResult";
                    //    break;

                    //case 2010:      // 0x7DB
                    //                //return new PacketDungeonResultNotify";
                    //    break;

                    //case 2011:      // 0x7DC
                    //                //return new PacketDungeonStateNotify";
                    //    break;

                    //case 2012:      // 0x7DD
                    //                //return new PacketDungeonEndTimeNotify";
                    //    break;

                    //case 2013:      // 0x7DE
                    //                //return new PacketDungeonStartTimeNotify";
                    //    break;

                    //case 2014:      // 0x7DF
                    //                //return new PacketDungeonScoreChangeNotify";
                    //    break;

                    //case 2015:      // 0x7E0
                    //                //return new PacketDungeonReviveInfoNotify";
                    //    break;

                    //case 2016:      // 0x7E1
                    //                //return new PacketGatheringNotify";
                    //    break;

                    //case 2017:      // 0x7E2
                    //                //return new PacketDungeonQuestSweep";
                    //    break;

                    //case 2018:      // 0x7E3
                    //                //return new PacketDungeonQuestSweepResult";
                    //    break;

                    //case 2019:      // 0x7E4
                    //                //return new PacketDungeonQuestRewardGet";
                    //    break;

                    //case 2020:      // 0x7E5
                    //                //return new PacketDungeonQuestRewardGetResult";
                    //    break;

                    //case 2021:      // 0x7E6
                    //                //return new PacketDungeonQuestPointRewardGet";
                    //    break;

                    //case 2022:      // 0x7E7
                    //                //return new PacketDungeonQuestPointRewardGetResult";
                    //    break;

                    //case 2023:      // 0x7E8
                    //                //return new PacketDungeonHotTimeCharge";
                    //    break;

                    //case 2024:      // 0x7E9
                    //                //return new PacketDungeonHotTimeChargeResult";
                    //    break;

                    //case 2025:      // 0x7EA
                    //                //return new PacketDungeonQuestNotify";
                    //    break;

                    //case 2026:      // 0x7EB
                    //                //return new PacketDungeonQuestCompleteNotify";
                    //    break;

                    //case 2027:      // 0x7EC
                    //                //return new PacketDungeonHotTimeNotify";
                    //    break;

                    //case 2028:      // 0x7ED
                    //                //return new PacketDungeonFreeCountBuy";
                    //    break;

                    //case 2029:      // 0x7EE
                    //                //return new PacketDungeonFreeCountBuyResult";
                    //    break;

                    //case 2030:      // 0x7EF
                    //                //return new PacketEnchantScrollDungeonStateNotify";
                    //    break;

                    //case 2031:      // 0x7F0
                    //                //return new PacketEnchantScrollDungeonInfoNotify";
                    //    break;

                    //case 2032:      // 0x7F1
                    //                //return new PacketDungeonReconnectNotify";
                    //    break;

                    //case 2033:      // 0x7F2
                    //                //return new PacketEnchantScrollDungeonReconnectMoreInfoNotify";
                    //    break;

                    //case 2034:      // 0x7F3
                    //                //return new PacketSummonStoneDungeonStateNotify";
                    //    break;

                    //case 2035:      // 0x7F4
                    //                //return new PacketSummonStoneDungeonInfoNotify";
                    //    break;

                    //case 2036:      // 0x7F5
                    //                //return new PacketSummonStoneDungeonReconnectMoreInfoNotify";
                    //    break;

                    //case 2037:      // 0x7F6
                    //                //return new PacketDungeonBonusRewardNotify";
                    //    break;

                    //case 2038:      // 0x7F7
                    //                //return new PacketPartyDungeonListRead";
                    //    break;

                    //case 2039:      // 0x7F8
                    //                //return new PacketPartyDungeonListReadResult";
                    //    break;

                    //case 2040:      // 0x7F9
                    //                //return new PacketPartyDungeonClearReset";
                    //    break;

                    //case 2041:      // 0x7FA
                    //                //return new PacketPartyDungeonClearResetResult";
                    //    break;

                    //case 2100:      // 0x835
                    //                //return new PacketPvpInfoRead";
                    //    break;

                    //case 2101:      // 0x836
                    //                //return new PacketPvpInfoReadResult";
                    //    break;

                    //case 2102:      // 0x837
                    //                //return new PacketPvpTargetListRefresh";
                    //    break;

                    //case 2103:      // 0x838
                    //                //return new PacketPvpTargetListRefreshResult";
                    //    break;

                    //case 2104:      // 0x839
                    //                //return new PacketPvpStartCheck";
                    //    break;

                    //case 2105:      // 0x83A
                    //                //return new PacketPvpStartCheckResult";
                    //    break;

                    //case 2106:      // 0x83B
                    //                //return new PacketPvpStart";
                    //    break;

                    //case 2107:      // 0x83C
                    //                //return new PacketPvpStartResult";
                    //    break;

                    //case 2108:      // 0x83D
                    //                //return new PacketPvpStartNotify";
                    //    break;

                    //case 2109:      // 0x83E
                    //                //return new PacketPvpRecordListRead";
                    //    break;

                    //case 2110:      // 0x83F
                    //                //return new PacketPvpRecordListReadResult";
                    //    break;

                    //case 2111:      // 0x840
                    //                //return new PacketPvpRankingListRead";
                    //    break;

                    //case 2112:      // 0x841
                    //                //return new PacketPvpRankingListReadResult";
                    //    break;

                    //case 2113:      // 0x842
                    //                //return new PacketPvpLeave";
                    //    break;

                    //case 2114:      // 0x843
                    //                //return new PacketPvpLeaveResult";
                    //    break;

                    //case 2115:      // 0x844
                    //                //return new PacketPvpRewardGet";
                    //    break;

                    //case 2116:      // 0x845
                    //                //return new PacketPvpRewardGetResult";
                    //    break;

                    //case 2117:      // 0x846
                    //                //return new PacketPvpCountDownStartNotify";
                    //    break;

                    //case 2118:      // 0x847
                    //                //return new PacketPvpTimeNotify";
                    //    break;

                    //case 2119:      // 0x848
                    //                //return new PacketPvpEndNotify";
                    //    break;

                    //case 2120:      // 0x849
                    //                //return new PacketPvpHonorRankUpNotify";
                    //    break;

                    //case 2121:      // 0x84A
                    //                //return new PacketPvpRankingChangeNotify";
                    //    break;

                    //case 2122:      // 0x84B
                    //                //return new PacketPkStatus";
                    //    break;

                    //case 2123:      // 0x84C
                    //                //return new PacketPkStatusResult";
                    //    break;

                    //case 2124:      // 0x84D
                    //                //return new PacketPkStatusNotify";
                    //    break;

                    //case 2125:      // 0x84E
                    //                //return new PacketPkAttackStateNotify";
                    //    break;

                    //case 2126:      // 0x84F
                    //                //return new PacketPkPointNotify";
                    //    break;

                    //case 2128:      // 0x851
                    //                //return new PacketPvpBattleStart";
                    //    break;

                    //case 2129:      // 0x852
                    //                //return new PacketPvpBattleStartResult";
                    //    break;

                    //case 2130:      // 0x853
                    //                //return new PacketPkPointMonsterKillCount";
                    //    break;

                    //case 2131:      // 0x854
                    //                //return new PacketPkPointMonsterKillCountResult";
                    //    break;

                    //case 2200:      // 0x899
                    //                //return new PacketClassTransferQuestStart";
                    //    break;

                    //case 2201:      // 0x89A
                    //                //return new PacketClassTransferQuestStartResult";
                    //    break;

                    //case 2202:      // 0x89B
                    //                //return new PacketClassTransferQuestListRead";
                    //    break;

                    //case 2203:      // 0x89C
                    //                //return new PacketClassTransferQuestListReadResult";
                    //    break;

                    //case 2204:      // 0x89D
                    //                //return new PacketClassTransferQuestRewardGet";
                    //    break;

                    //case 2205:      // 0x89E
                    //                //return new PacketClassTransferQuestRewardGetResult";
                    //    break;

                    //case 2206:      // 0x89F
                    //                //return new PacketClassTransfer";
                    //    break;

                    //case 2207:      // 0x8A0
                    //                //return new PacketClassTransferResult";
                    //    break;

                    //case 2208:      // 0x8A1
                    //                //return new PacketClassTransferableNotify";
                    //    break;

                    //case 2209:      // 0x8A2
                    //                //return new PacketClassTransferQuestUpdateNotify";
                    //    break;

                    //case 2210:      // 0x8A3
                    //                //return new PacketClassTransferQuestCompleteNotify";
                    //    break;

                    //case 2211:      // 0x8A4
                    //                //return new PacketClassTransferCheatNotify";
                    //    break;

                    //case 2300:      // 0x8FD
                    //                //return new PacketGuideQuestListRead";
                    //    break;

                    //case 2301:      // 0x8FE
                    //                //return new PacketGuideQuestListReadResult";
                    //    break;

                    //case 2302:      // 0x8FF
                    //                //return new PacketGuideQuestRewardGet";
                    //    break;

                    //case 2303:      // 0x900
                    //                //return new PacketGuideQuestRewardGetResult";
                    //    break;

                    //case 2304:      // 0x901
                    //                //return new PacketGuideQuestUpdateNotify";
                    //    break;

                    //case 2305:      // 0x902
                    //                //return new PacketGuideQuestCompleteNotify";
                    //    break;

                    //case 2306:      // 0x903
                    //                //return new PacketGuideQuestCheatNotify";
                    //    break;

                    //case 2307:      // 0x904
                    //                //return new PacketGuideQuestActivityTimeRenew";
                    //    break;

                    //case 2308:      // 0x905
                    //                //return new PacketGuideQuestActivityTimeRenewResult";
                    //    break;

                    //case 2350:      // 0x92F
                    //                //return new PacketPromoteStateListRead";
                    //    break;

                    //case 2351:      // 0x930
                    //                //return new PacketPromoteStateListReadResult";
                    //    break;

                    //case 2352:      // 0x931
                    //                //return new PacketPromoteStateLowListRead";
                    //    break;

                    //case 2353:      // 0x932
                    //                //return new PacketPromoteStateLowListReadResult";
                    //    break;

                    //case 2400:      // 0x961
                    //                //return new PacketTutorialNotify";
                    //    break;

                    //case 2401:      // 0x962
                    //                //return new PacketTutorialListRead";
                    //    break;

                    //case 2402:      // 0x963
                    //                //return new PacketTutorialListReadResult";
                    //    break;

                    //case 2403:      // 0x964
                    //                //return new PacketTutorialStart";
                    //    break;

                    //case 2404:      // 0x965
                    //                //return new PacketTutorialStartResult";
                    //    break;

                    //case 2405:      // 0x966
                    //                //return new PacketTutorialProgress";
                    //    break;

                    //case 2406:      // 0x967
                    //                //return new PacketTutorialProgressResult";
                    //    break;

                    //case 2407:      // 0x968
                    //                //return new PacketTutorialRewardGet";
                    //    break;

                    //case 2408:      // 0x969
                    //                //return new PacketTutorialRewardGetResult";
                    //    break;

                    //case 2409:      // 0x96A
                    //                //return new PacketTutorialMaterialReceiveNotify";
                    //    break;

                    //case 2410:      // 0x96B
                    //                //return new PacketTutorialSkip";
                    //    break;

                    //case 2411:      // 0x96C
                    //                //return new PacketTutorialSkipResult";
                    //    break;

                    //case 2500:      // 0x9C5
                    //                //return new PacketCutSceneNotify";
                    //    break;

                    //case 2501:      // 0x9C6
                    //                //return new PacketCutSceneStart";
                    //    break;

                    //case 2502:      // 0x9C7
                    //                //return new PacketCutSceneStartResult";
                    //    break;

                    //case 2503:      // 0x9C8
                    //                //return new PacketCutSceneEnd";
                    //    break;

                    //case 2504:      // 0x9C9
                    //                //return new PacketCutSceneEndResult";
                    //    break;

                    //case 2505:      // 0x9CA
                    //                //return new PacketCutSceneEndReserve";
                    //    break;

                    //case 2506:      // 0x9CB
                    //                //return new PacketCutSceneEndReserveResult";
                    //    break;

                    //case 2507:      // 0x9CC
                    //                //return new PacketWorldPause";
                    //    break;

                    //case 2508:      // 0x9CD
                    //                //return new PacketWorldPauseResult";
                    //    break;

                    //case 2509:      // 0x9CE
                    //                //return new PacketWorldResume";
                    //    break;

                    //case 2510:      // 0x9CF
                    //                //return new PacketWorldResumeResult";
                    //    break;

                    //case 2511:      // 0x9D0
                    //                //return new PacketQuestCutSceneEndSync";
                    //    break;

                    //case 2512:      // 0x9D1
                    //                //return new PacketQuestCutSceneEndSyncResult";
                    //    break;

                    //case 2513:      // 0x9D2
                    //                //return new PacketQuestCutSceneEndSyncNotify";
                    //    break;

                    //case 2600:      // 0xA29
                    //                //return new PacketSystemSettingsGet";
                    //    break;

                    //case 2601:      // 0xA2A
                    //                //return new PacketSystemSettingsGetResult";
                    //    break;

                    //case 2602:      // 0xA2B
                    //                //return new PacketSystemSettingsSet";
                    //    break;

                    //case 2603:      // 0xA2C
                    //                //return new PacketSystemSettingsSetResult";
                    //    break;

                    //case 2604:      // 0xA2D
                    //                //return new PacketSystemAlarmNotify";
                    //    break;

                    //case 2605:      // 0xA2E
                    //                //return new PacketPing";
                    //    break;

                    //case 2606:      // 0xA2F
                    //                //return new PacketPingResult";
                    //    break;

                    //case 2650:      // 0xA5B
                    //                //return new PacketInstantCompleteListRead";
                    //    break;

                    //case 2651:      // 0xA5C
                    //                //return new PacketInstantCompleteListReadResult";
                    //    break;

                    //case 2652:      // 0xA5D
                    //                //return new PacketInstantCompleteRewardGet";
                    //    break;

                    //case 2653:      // 0xA5E
                    //                //return new PacketInstantCompleteRewardGetResult";
                    //    break;

                    //case 2654:      // 0xA5F
                    //                //return new PacketInstantCompleteRewardAllGet";
                    //    break;

                    //case 2655:      // 0xA60
                    //                //return new PacketInstantCompleteRewardAllGetResult";
                    //    break;

                    //case 2700:      // 0xA8D
                    //                //return new PacketMissionRequestListRead";
                    //    break;

                    //case 2701:      // 0xA8E
                    //                //return new PacketMissionRequestListReadResult";
                    //    break;

                    //case 2702:      // 0xA8F
                    //                //return new PacketMissionRequestStart";
                    //    break;

                    //case 2703:      // 0xA90
                    //                //return new PacketMissionRequestStartResult";
                    //    break;

                    //case 2704:      // 0xA91
                    //                //return new PacketMissionDailyRefresh";
                    //    break;

                    //case 2705:      // 0xA92
                    //                //return new PacketMissionDailyRefreshResult";
                    //    break;

                    //case 2706:      // 0xA93
                    //                //return new PacketMissionDailyNowComplete";
                    //    break;

                    //case 2707:      // 0xA94
                    //                //return new PacketMissionDailyNowCompleteResult";
                    //    break;

                    //case 2708:      // 0xA95
                    //                //return new PacketMissionDailyMaxComboComplete";
                    //    break;

                    //case 2709:      // 0xA96
                    //                //return new PacketMissionDailyMaxComboCompleteResult";
                    //    break;

                    //case 2710:      // 0xA97
                    //                //return new PacketMissionWeeklyPass";
                    //    break;

                    //case 2711:      // 0xA98
                    //                //return new PacketMissionWeeklyPassResult";
                    //    break;

                    //case 2712:      // 0xA99
                    //                //return new PacketMissionDailyRewardGet";
                    //    break;

                    //case 2713:      // 0xA9A
                    //                //return new PacketMissionDailyRewardGetResult";
                    //    break;

                    //case 2714:      // 0xA9B
                    //                //return new PacketMissionWeeklyRewardGet";
                    //    break;

                    //case 2715:      // 0xA9C
                    //                //return new PacketMissionWeeklyRewardGetResult";
                    //    break;

                    //case 2716:      // 0xA9D
                    //                //return new PacketMissionRequestRewardGet";
                    //    break;

                    //case 2717:      // 0xA9E
                    //                //return new PacketMissionRequestRewardGetResult";
                    //    break;

                    //case 2718:      // 0xA9F
                    //                //return new PacketMissionRequestCompleteNotify";
                    //    break;

                    //case 2719:      // 0xAA0
                    //                //return new PacketMissionDailyUpdateNotify";
                    //    break;

                    //case 2720:      // 0xAA1
                    //                //return new PacketMissionWeeklyUpdateNotify";
                    //    break;

                    //case 2721:      // 0xAA2
                    //                //return new PacketMissionTeleport";
                    //    break;

                    //case 2722:      // 0xAA3
                    //                //return new PacketMissionTeleportResult";
                    //    break;

                    //case 2723:      // 0xAA4
                    //                //return new PacketMissionWeeklyRefresh";
                    //    break;

                    //case 2724:      // 0xAA5
                    //                //return new PacketMissionWeeklyRefreshResult";
                    //    break;

                    //case 2725:      // 0xAA6
                    //                //return new PacketEventDailyQuestListRead";
                    //    break;

                    //case 2726:      // 0xAA7
                    //                //return new PacketEventDailyQuestListReadResult";
                    //    break;

                    //case 2727:      // 0xAA8
                    //                //return new PacketEventDailyQuestRewardGet";
                    //    break;

                    //case 2728:      // 0xAA9
                    //                //return new PacketEventDailyQuestRewardGetResult";
                    //    break;

                    //case 2729:      // 0xAAA
                    //                //return new PacketEventDailyQuestProgressRewardGet";
                    //    break;

                    //case 2730:      // 0xAAB
                    //                //return new PacketEventDailyQuestProgressRewardGetResult";
                    //    break;

                    //case 2731:      // 0xAAC
                    //                //return new PacketEventDailyQuestStart";
                    //    break;

                    //case 2732:      // 0xAAD
                    //                //return new PacketEventDailyQuestStartResult";
                    //    break;

                    //case 2733:      // 0xAAE
                    //                //return new PacketEventDailyQuestResetCompletedCountNotify";
                    //    break;

                    //case 2750:      // 0xABF
                    //                //return new PacketEventListRead";
                    //    break;

                    //case 2751:      // 0xAC0
                    //                //return new PacketEventListReadResult";
                    //    break;

                    //case 2752:      // 0xAC1
                    //                //return new PacketEventRewardGet";
                    //    break;

                    //case 2753:      // 0xAC2
                    //                //return new PacketEventRewardGetResult";
                    //    break;

                    //case 2754:      // 0xAC3
                    //                //return new PacketEventStartNotify";
                    //    break;

                    //case 2755:      // 0xAC4
                    //                //return new PacketEventListNotify";
                    //    break;

                    //case 2756:      // 0xAC5
                    //                //return new PacketEventMessageNotify";
                    //    break;

                    //case 2757:      // 0xAC6
                    //                //return new PacketDropBoxEventNotify";
                    //    break;

                    //case 2758:      // 0xAC7
                    //                //return new PacketInitDropBoxNotify";
                    //    break;

                    //case 2759:      // 0xAC8
                    //                //return new PacketEventDiceExecute";
                    //    break;

                    //case 2760:      // 0xAC9
                    //                //return new PacketEventDiceExecuteResult";
                    //    break;

                    //case 2761:      // 0xACA
                    //                //return new PacketEventProgressNotify";
                    //    break;

                    //case 2762:      // 0xACB
                    //                //return new PacketEventPostListRead";
                    //    break;

                    //case 2763:      // 0xACC
                    //                //return new PacketEventPostListReadResult";
                    //    break;

                    //case 2764:      // 0xACD
                    //                //return new PacketEventNeroDiceExecute";
                    //    break;

                    //case 2765:      // 0xACE
                    //                //return new PacketEventNeroDiceExecuteResult";
                    //    break;

                    //case 2766:      // 0xACF
                    //                //return new PacketEventNeroDiceGetReward";
                    //    break;

                    //case 2767:      // 0xAD0
                    //                //return new PacketEventNeroDiceGetRewardResult";
                    //    break;

                    //case 2768:      // 0xAD1
                    //                //return new PacketEventPostConfirm";
                    //    break;

                    //case 2769:      // 0xAD2
                    //                //return new PacketEventPostConfirmResult";
                    //    break;

                    //case 2800:      // 0xAF1
                    //                //return new PacketNetmarbleSIAPInitialize";
                    //    break;

                    //case 2801:      // 0xAF2
                    //                //return new PacketNetmarbleSIAPInitializeResult";
                    //    break;

                    //case 2802:      // 0xAF3
                    //                //return new PacketNetmarbleSIAPVerify";
                    //    break;

                    //case 2803:      // 0xAF4
                    //                //return new PacketNetmarbleSIAPVerifyResult";
                    //    break;

                    //case 2804:      // 0xAF5
                    //                //return new PacketNetmarbleSIAPPurchaseCancel";
                    //    break;

                    //case 2805:      // 0xAF6
                    //                //return new PacketNetmarbleSIAPPurchaseCancelResult";
                    //    break;

                    //case 2806:      // 0xAF7
                    //                //return new PacketGoogleAnalyticsFirstDied";
                    //    break;

                    //case 2807:      // 0xAF8
                    //                //return new PacketGoogleAnalyticsFirstDiedResult";
                    //    break;

                    //case 2808:      // 0xAF9
                    //                //return new PacketNetmarbleSWebAchievementNotify";
                    //    break;

                    //case 2809:      // 0xAFA
                    //                //return new PacketNetmarbleSIAPGetNetmarbleItemId";
                    //    break;

                    //case 2810:      // 0xAFB
                    //                //return new PacketNetmarbleSIAPGetNetmarbleItemIdResult";
                    //    break;

                    //case 2900:      // 0xB55
                    //                //return new PacketRankingListRead";
                    //    break;

                    //case 2901:      // 0xB56
                    //                //return new PacketRankingListReadResult";
                    //                //PktRankingListRead.Packet(packet);
                    //    break;

                    //case 2902:      // 0xB57
                    //                //return new PacketBroadCastNotify";
                    //    break;

                    //case 2903:      // 0xB58
                    //                //return new PacketSocialNetworkShared";
                    //    break;

                    //case 2904:      // 0xB59
                    //                //return new PacketSocialNetworkSharedResult";
                    //    break;

                    //case 3000:      // 0xBB9
                    //                //return new PacketUpdate";
                    //    break;

                    //case 3001:      // 0xBBA
                    //                //return new PacketUpdateResult";
                    //    break;

                    //case 3002:      // 0xBBB
                    //                //return new PacketAdminToolRequest";
                    //    break;

                    //case 3003:      // 0xBBC
                    //                //return new PacketAdminToolRequestResult";
                    //    break;

                    //case 3004:      // 0xBBD
                    //                //return new PacketAdminToolNoticeInsert";
                    //    break;

                    //case 3005:      // 0xBBE
                    //                //return new PacketAdminToolNoticeInsertResult";
                    //    break;

                    //case 3006:      // 0xBBF
                    //                //return new PacketAdminToolNoticeDelete";
                    //    break;

                    //case 3007:      // 0xBC0
                    //                //return new PacketAdminToolNoticeDeleteResult";
                    //    break;

                    //case 3100:      // 0xC1D
                    //                //return new PacketCharacterTitleListRead";
                    //    break;

                    //case 3101:      // 0xC1E
                    //                //return new PacketCharacterTitleListReadResult";
                    //    break;

                    //case 3102:      // 0xC1F
                    //                //return new PacketCharacterTitleEquip";
                    //    break;

                    //case 3103:      // 0xC20
                    //                //return new PacketCharacterTitleEquipResult";
                    //    break;

                    //case 3104:      // 0xC21
                    //                //return new PacketCharacterTitleUpdateNotify";
                    //    break;

                    //case 3105:      // 0xC22
                    //                //return new PacketCharacterTitleEquipNotify";
                    //    break;

                    //case 3106:      // 0xC23
                    //                //return new PacketCharacterTitleAcquire";
                    //    break;

                    //case 3107:      // 0xC24
                    //                //return new PacketCharacterTitleAcquireResult";
                    //    break;

                    //case 3108:      // 0xC25
                    //                //return new PacketCharacterTitleDeleteNotify";
                    //    break;

                    //case 3200:      // 0xC81
                    //                //return new PacketCapeListRead";
                    //    break;

                    //case 3201:      // 0xC82
                    //                //return new PacketCapeListReadResult";
                    //    break;

                    //case 3202:      // 0xC83
                    //                //return new PacketCapeAcquire";
                    //    break;

                    //case 3203:      // 0xC84
                    //                //return new PacketCapeAcquireResult";
                    //    break;

                    //case 3204:      // 0xC85
                    //                //return new PacketCapeEquipChange";
                    //    break;

                    //case 3205:      // 0xC86
                    //                //return new PacketCapeEquipChangeResult";
                    //    break;

                    //case 3206:      // 0xC87
                    //                //return new PacketCapeUnequip";
                    //    break;

                    //case 3207:      // 0xC88
                    //                //return new PacketCapeUnequipResult";
                    //    break;

                    //case 3208:      // 0xC89
                    //                //return new PacketCapeLevelUp";
                    //    break;

                    //case 3209:      // 0xC8A
                    //                //return new PacketCapeLevelUpResult";
                    //    break;

                    //case 3210:      // 0xC8B
                    //                //return new PacketCapeOptionChange";
                    //    break;

                    //case 3211:      // 0xC8C
                    //                //return new PacketCapeOptionChangeResult";
                    //    break;

                    //case 3212:      // 0xC8D
                    //                //return new PacketGuildCapeLevelUp";
                    //    break;

                    //case 3213:      // 0xC8E
                    //                //return new PacketGuildCapeLevelUpResult";
                    //    break;

                    //case 3214:      // 0xC8F
                    //                //return new PacketGuildCapeColorChange";
                    //    break;

                    //case 3215:      // 0xC90
                    //                //return new PacketGuildCapeColorChangeResult";
                    //    break;

                    //case 3216:      // 0xC91
                    //                //return new PacketCapeChangePlayerNotify";
                    //    break;

                    //case 3217:      // 0xC92
                    //                //return new PacketCapeChangeNotify";
                    //    break;

                    //case 3500:      // 0xDAD
                    //                //return new PacketCacheObjectInvalidateNotify";
                    //    break;

                    //case 4000:      // 0xFA1
                    //                //return new PacketWebUserLogin";
                    //    break;

                    //case 4001:      // 0xFA2
                    //                //return new PacketWebUserLoginResult";
                    //    break;

                    //case 4002:      // 0xFA3
                    //                //return new PacketWebUserLogout";
                    //    break;

                    //case 4003:      // 0xFA4
                    //                //return new PacketWebUserLogoutResult";
                    //    break;

                    //case 4004:      // 0xFA5
                    //                //return new PacketActorLocationNotify";
                    //    break;

                    //case 4005:      // 0xFA6
                    //                //return new PacketMessageShowNotify";
                    //    break;

                    //case 4006:      // 0xFA7
                    //                //return new PacketMessageReply";
                    //    break;

                    //case 4007:      // 0xFA8
                    //                //return new PacketMessageReplyResult";
                    //    break;

                    //case 4008:      // 0xFA9
                    //                //return new PacketLogShowNotify";
                    //    break;

                    //case 4009:      // 0xFAA
                    //                //return new PacketStyleSheet";
                    //    break;

                    //case 4010:      // 0xFAB
                    //                //return new PacketStyleSheetResult";
                    //    break;

                    //case 4011:      // 0xFAC
                    //                //return new PacketStyleSheetResource";
                    //    break;

                    //case 4012:      // 0xFAD
                    //                //return new PacketStyleSheetResourceResult";
                    //    break;

                    //case 4013:      // 0xFAE
                    //                //return new PacketTestBotPlayerInfoRead";
                    //    break;

                    //case 4014:      // 0xFAF
                    //                //return new PacketTestBotPlayerInfoReadResult";
                    //    break;

                    //case 4015:      // 0xFB0
                    //                //return new PacketQuestEdit";
                    //    break;

                    //case 4016:      // 0xFB1
                    //                //return new PacketQuestEditResult";
                    //    break;

                    //case 4017:      // 0xFB2
                    //                //return new PacketDebugShapeShowNotify";
                    //    break;

                    //case 4018:      // 0xFB3
                    //                //return new PacketSecurityCodeManage";
                    //    break;

                    //case 4019:      // 0xFB4
                    //                //return new PacketSecurityCodeManageResult";
                    //    break;

                    //case 4020:      // 0xFB5
                    //                //return new PacketWorldBossNotify";
                    //    break;

                    //case 4021:      // 0xFB6
                    //                //return new PacketTestBotCommandNotify";
                    //    break;

                    //case 4022:      // 0xFB7
                    //                //return new PacketPerformanceTrace";
                    //    break;

                    //case 4023:      // 0xFB8
                    //                //return new PacketPerformanceTraceResult";
                    //    break;

                    //case 4024:      // 0xFB9
                    //                //return new PacketApolloVoiceGetAuthKey";
                    //    break;

                    //case 4025:      // 0xFBA
                    //                //return new PacketApolloVoiceGetAuthKeyResult";
                    //    break;

                    //case 4026:      // 0xFBB
                    //                //return new PacketEnvironmentManage";
                    //    break;

                    //case 4027:      // 0xFBC
                    //                //return new PacketEnvironmentManageResult";
                    //    break;

                    //case 4028:      // 0xFBD
                    //                //return new PacketFuncCall";
                    //    break;

                    //case 4029:      // 0xFBE
                    //                //return new PacketFuncCallResult";
                    //    break;

                    //case 4030:      // 0xFBF
                    //                //return new PacketObjectStatsTrace";
                    //    break;

                    //case 4031:      // 0xFC0
                    //                //return new PacketObjectStatsTraceResult";
                    //    break;

                    //case 5000:      // 0x1389
                    //                //return new PacketPlayerSocialActionListRead";
                    //    break;

                    //case 5001:      // 0x138A
                    //                //return new PacketPlayerSocialActionListReadResult";
                    //    break;

                    //case 5002:      // 0x138B
                    //                //return new PacketPlayerSocialActionMessageChange";
                    //    break;

                    //case 5003:      // 0x138C
                    //                //return new PacketPlayerSocialActionMessageChangeResult";
                    //    break;

                    //case 5004:      // 0x138D
                    //                //return new PacketEventGachaListRead";
                    //    break;

                    //case 5005:      // 0x138E
                    //                //return new PacketEventGachaListReadResult";
                    //    break;

                    //case 5006:      // 0x138F
                    //                //return new PacketEventGachaDetailRead";
                    //    break;

                    //case 5007:      // 0x1390
                    //                //return new PacketEventGachaDetailReadResult";
                    //    break;

                    //case 5008:      // 0x1391
                    //                //return new PacketEventGacha";
                    //    break;

                    //case 5009:      // 0x1392
                    //                //return new PacketEventGachaResult";
                    //    break;

                    //case 5010:      // 0x1393
                    //                //return new PacketEventGachaNotify";
                    //    break;

                    //case 5011:      // 0x1394
                    //                //return new PacketGuildDailyRewardRead";
                    //    break;

                    //case 5012:      // 0x1395
                    //                //return new PacketGuildDailyRewardReadResult";
                    //    break;

                    //case 5013:      // 0x1396
                    //                //return new PacketGuildFortressDailyRewardGet";
                    //    break;

                    //case 5014:      // 0x1397
                    //                //return new PacketGuildFortressDailyRewardGetResult";
                    //    break;

                    //case 6000:      // 0x1771
                    //                //return new PacketGuildAgitKeeperInfo";
                    //    break;

                    //case 6001:      // 0x1772
                    //                //return new PacketGuildAgitKeeperInfoResult";
                    //    break;

                    //case 6002:      // 0x1773
                    //                //return new PacketGuildAgitBanquetList";
                    //    break;

                    //case 6003:      // 0x1774
                    //                //return new PacketGuildAgitBanquetListResult";
                    //    break;

                    //case 6004:      // 0x1775
                    //                //return new PacketGuildAgitBanquetCreate";
                    //    break;

                    //case 6005:      // 0x1776
                    //                //return new PacketGuildAgitBanquetCreateResult";
                    //    break;

                    //case 6006:      // 0x1777
                    //                //return new PacketGuildAgitBanquetCreateNotify";
                    //    break;

                    //case 6007:      // 0x1778
                    //                //return new PacketGuildAgitRelicList";
                    //    break;

                    //case 6008:      // 0x1779
                    //                //return new PacketGuildAgitRelicListResult";
                    //    break;

                    //case 6009:      // 0x177A
                    //                //return new PacketGuildAgitRelicRegist";
                    //    break;

                    //case 6010:      // 0x177B
                    //                //return new PacketGuildAgitRelicRegistResult";
                    //    break;

                    //case 6011:      // 0x177C
                    //                //return new PacketGuildAgitRelicAppraise";
                    //    break;

                    //case 6012:      // 0x177D
                    //                //return new PacketGuildAgitRelicAppraiseResult";
                    //    break;

                    //case 6013:      // 0x177E
                    //                //return new PacketGuildAgitRelicPointUse";
                    //    break;

                    //case 6014:      // 0x177F
                    //                //return new PacketGuildAgitRelicPointUseResult";
                    //    break;

                    //case 6015:      // 0x1780
                    //                //return new PacketGuildAgitKeeperUpgrade";
                    //    break;

                    //case 6016:      // 0x1781
                    //                //return new PacketGuildAgitKeeperUpgradeResult";
                    //    break;

                    //case 6017:      // 0x1782
                    //                //return new PacketGuildAgitKeeperAutoExtends";
                    //    break;

                    //case 6018:      // 0x1783
                    //                //return new PacketGuildAgitKeeperAutoExtendsResult";
                    //    break;

                    //case 6019:      // 0x1784
                    //                //return new PacketGuildAgitQuestListNotify";
                    //    break;

                    //case 6020:      // 0x1785
                    //                //return new PacketGuildAgitQuestUpdateNotify";
                    //    break;

                    //case 6021:      // 0x1786
                    //                //return new PacketGuildFortressGiveUp";
                    //    break;

                    //case 6022:      // 0x1787
                    //                //return new PacketGuildFortressGiveUpResult";
                    //    break;

                    //case 6023:      // 0x1788
                    //                //return new PacketGuildCastleGiveUp";
                    //    break;

                    //case 6024:      // 0x1789
                    //                //return new PacketGuildCastleGiveUpResult";
                    //    break;

                    //case 6025:      // 0x178A
                    //                //return new PacketGuildStateChangeNotify";
                    //    break;

                    //case 6026:      // 0x178B
                    //                //return new PacketGuildDonateReset";
                    //    break;

                    //case 6027:      // 0x178C
                    //                //return new PacketGuildDonateResetResult";
                    //    break;

                    //case 6028:      // 0x178D
                    //                //return new PacketGuildAgitUpgradeNotify";
                    //    break;

                    //case 6029:      // 0x178E
                    //                //return new PacketGuildAgitFirePlaceEnable";
                    //    break;

                    //case 6030:      // 0x178F
                    //                //return new PacketGuildAgitFirePlaceEnableResult";
                    //    break;

                    //case 6031:      // 0x1790
                    //                //return new PacketGuildAgitFirePlaceEnableNotify";
                    //    break;

                    //case 6032:      // 0x1791
                    //                //return new PacketGuildAgitLiquidCreate";
                    //    break;

                    //case 6033:      // 0x1792
                    //                //return new PacketGuildAgitLiquidCreateResult";
                    //    break;

                    //case 6034:      // 0x1793
                    //                //return new PacketGuildAgitLiquidCreateNotify";
                    //    break;

                    //case 6035:      // 0x1794
                    //                //return new PacketOtherGuildAllianceChangeNotify";
                    //    break;

                    //case 6036:      // 0x1795
                    //                //return new PacketGuildCastleDailyRewardGet";
                    //    break;

                    //case 6037:      // 0x1796
                    //                //return new PacketGuildCastleDailyRewardGetResult";
                    //    break;

                    //case 6038:      // 0x1797
                    //                //return new PacketGuildOrderNotify";
                    //    break;

                    //case 6039:      // 0x1798
                    //                //return new PacketGuildWarehouseGrantByList";
                    //    break;

                    //case 6040:      // 0x1799
                    //                //return new PacketGuildWarehouseGrantByListResult";
                    //    break;

                    //case 6041:      // 0x179A
                    //                //return new PacketGuildCastleTypeSelect";
                    //    break;

                    //case 6042:      // 0x179B
                    //                //return new PacketGuildCastleTypeSelectResult";
                    //    break;

                    //case 6043:      // 0x179C
                    //                //return new PacketGuildCastleTypeSelectNotify";
                    //    break;

                    //case 6044:      // 0x179D
                    //                //return new PacketGuildHostileWarEndSuggest";
                    //    break;

                    //case 6045:      // 0x179E
                    //                //return new PacketGuildHostileWarEndSuggestResult";
                    //    break;

                    //case 6046:      // 0x179F
                    //                //return new PacketGuildHostileWarEndAnswer";
                    //    break;

                    //case 6047:      // 0x17A0
                    //                //return new PacketGuildHostileWarEndAnswerResult";
                    //    break;

                    //case 6048:      // 0x17A1
                    //                //return new PacketGuildAgitQuestCompleteNotify";
                    //    break;

                    //case 6049:      // 0x17A2
                    //                //return new PacketGuildAgitWishListRead";
                    //    break;

                    //case 6050:      // 0x17A3
                    //                //return new PacketGuildAgitWishListReadResult";
                    //    break;

                    //case 6051:      // 0x17A4
                    //                //return new PacketGuildCastleTypeSelectTimeNotify";
                    //    break;

                    //case 6052:      // 0x17A5
                    //                //return new PacketGuildAgitWishGet";
                    //    break;

                    //case 6053:      // 0x17A6
                    //                //return new PacketGuildAgitWishGetResult";
                    //    break;

                    //case 6054:      // 0x17A7
                    //                //return new PacketGuildReJoinPenaltyTimeRead";
                    //    break;

                    //case 6055:      // 0x17A8
                    //                //return new PacketGuildReJoinPenaltyTimeReadResult";
                    //    break;

                    //case 6056:      // 0x17A9
                    //                //return new PacketGuildWantJoin";
                    //    break;

                    //case 6057:      // 0x17AA
                    //                //return new PacketGuildWantJoinResult";
                    //    break;

                    //case 6058:      // 0x17AB
                    //                //return new PacketGuildInviteListRead";
                    //    break;

                    //case 6059:      // 0x17AC
                    //                //return new PacketGuildInviteListReadResult";
                    //    break;

                    //case 6060:      // 0x17AD
                    //                //return new PacketGuildWantJoinListRead";
                    //    break;

                    //case 6061:      // 0x17AE
                    //                //return new PacketGuildWantJoinListReadResult";
                    //    break;

                    //case 6062:      // 0x17AF
                    //                //return new PacketGuildInviteCancel";
                    //    break;

                    //case 6063:      // 0x17B0
                    //                //return new PacketGuildInviteCancelResult";
                    //    break;

                    //case 6064:      // 0x17B1
                    //                //return new PacketGuildInviteReject";
                    //    break;

                    //case 6065:      // 0x17B2
                    //                //return new PacketGuildInviteRejectResult";
                    //    break;

                    //case 6066:      // 0x17B3
                    //                //return new PacketGuildMemberSelfIntroChange";
                    //    break;

                    //case 6067:      // 0x17B4
                    //                //return new PacketGuildMemberSelfIntroChangeResult";
                    //    break;

                    //case 6068:      // 0x17B5
                    //                //return new PacketGuildHostileWarRecordDetailRead";
                    //    break;

                    //case 6069:      // 0x17B6
                    //                //return new PacketGuildHostileWarRecordDetailReadResult";
                    //    break;

                    //case 6070:      // 0x17B7
                    //                //return new PacketGuildHostileWarRecordRankRead";
                    //    break;

                    //case 6071:      // 0x17B8
                    //                //return new PacketGuildHostileWarRecordRankReadResult";
                    //    break;

                    //case 6072:      // 0x17B9
                    //                //return new PacketGuildVoiceChatJoinNotify";
                    //    break;

                    //case 6073:      // 0x17BA
                    //                //return new PacketGuildVoiceChatJoin";
                    //    break;

                    //case 6074:      // 0x17BB
                    //                //return new PacketGuildVoiceChatJoinResult";
                    //    break;

                    //case 6075:      // 0x17BC
                    //                //return new PacketGuildVoiceChatExit";
                    //    break;

                    //case 6076:      // 0x17BD
                    //                //return new PacketGuildVoiceChatExitResult";
                    //    break;

                    //case 6077:      // 0x17BE
                    //                //return new PacketGuildVoiceChatEmpowerment";
                    //    break;

                    //case 6078:      // 0x17BF
                    //                //return new PacketGuildVoiceChatEmpowermentResult";
                    //    break;

                    //case 6079:      // 0x17C0
                    //                //return new PacketGuildVoiceChatEmpowermentNotify";
                    //    break;

                    //case 7000:      // 0x1B59
                    //                //return new PacketPetListRead";
                    //    break;

                    //case 7001:      // 0x1B5A
                    //                //return new PacketPetListReadResult";
                    //    break;

                    //case 7002:      // 0x1B5B
                    //                //return new PacketPetUnlockNotify";
                    //    break;

                    //case 7003:      // 0x1B5C
                    //                //return new PacketPetItemUse";
                    //    break;

                    //case 7004:      // 0x1B5D
                    //                //return new PacketPetItemUseResult";
                    //    break;

                    //case 7005:      // 0x1B5E
                    //                //return new PacketPetEquip";
                    //    break;

                    //case 7006:      // 0x1B5F
                    //                //return new PacketPetEquipResult";
                    //    break;

                    //case 7007:      // 0x1B60
                    //                //return new PacketPetRiding";
                    //    break;

                    //case 7008:      // 0x1B61
                    //                //return new PacketPetRidingResult";
                    //    break;

                    //case 7009:      // 0x1B62
                    //                //return new PacketPetUpdateNotify";
                    //    break;

                    //case 7010:      // 0x1B63
                    //                //return new PacketPetRidingNotify";
                    //    break;

                    //case 7011:      // 0x1B64
                    //                //return new PacketPetActive";
                    //    break;

                    //case 7012:      // 0x1B65
                    //                //return new PacketPetActiveResult";
                    //    break;

                    //case 7013:      // 0x1B66
                    //                //return new PacketPetActivatableNotify";
                    //    break;

                    //case 7014:      // 0x1B67
                    //                //return new PacketPetItemEquip";
                    //    break;

                    //case 7015:      // 0x1B68
                    //                //return new PacketPetItemEquipResult";
                    //    break;

                    //case 7016:      // 0x1B69
                    //                //return new PacketPetItemLevelUp";
                    //    break;

                    //case 7017:      // 0x1B6A
                    //                //return new PacketPetItemLevelUpResult";
                    //    break;

                    //case 7018:      // 0x1B6B
                    //                //return new PacketPetItemUpgrade";
                    //    break;

                    //case 7019:      // 0x1B6C
                    //                //return new PacketPetItemUpgradeResult";
                    //    break;

                    //case 7020:      // 0x1B6D
                    //                //return new PacketPetUpgrade";
                    //    break;

                    //case 7021:      // 0x1B6E
                    //                //return new PacketPetUpgradeResult";
                    //    break;

                    //case 7022:      // 0x1B6F
                    //                //return new PacketForcePetRidingNotify";
                    //    break;

                    //case 7023:      // 0x1B70
                    //                //return new PacketPetItemEnchant";
                    //    break;

                    //case 7024:      // 0x1B71
                    //                //return new PacketPetItemEnchantResult";
                    //    break;

                    //case 7025:      // 0x1B72
                    //                //return new PacketPetEquipmentItemLike";
                    //    break;

                    //case 7026:      // 0x1B73
                    //                //return new PacketPetEquipmentItemLikeResult";
                    //    break;

                    //case 7027:      // 0x1B74
                    //                //return new PacketPetItemOptionChange";
                    //    break;

                    //case 7028:      // 0x1B75
                    //                //return new PacketPetItemOptionChangeResult";
                    //    break;

                    //case 7100:      // 0x1BBD
                    //                //return new PacketMeleeKillNotify";
                    //    break;

                    //case 7101:      // 0x1BBE
                    //                //return new PacketMeleeRankingChangeNotify";
                    //    break;

                    //case 7200:      // 0x1C21
                    //                //return new PacketOptionChange";
                    //    break;

                    //case 7201:      // 0x1C22
                    //                //return new PacketOptionChangeResult";
                    //    break;

                    //case 7202:      // 0x1C23
                    //                //return new PacketOptionDeckListRead";
                    //    break;

                    //case 7203:      // 0x1C24
                    //                //return new PacketOptionDeckListReadResult";
                    //    break;

                    //case 7204:      // 0x1C25
                    //                //return new PacketOptionDeckChange";
                    //    break;

                    //case 7205:      // 0x1C26
                    //                //return new PacketOptionDeckChangeResult";
                    //    break;

                    //case 7300:      // 0x1C85
                    //                //return new PacketBattlefieldInfo";
                    //    break;

                    //case 7301:      // 0x1C86
                    //                //return new PacketBattlefieldInfoResult";
                    //    break;

                    //case 7302:      // 0x1C87
                    //                //return new PacketBattlefieldOpenTimeListNotify";
                    //    break;

                    //case 7303:      // 0x1C88
                    //                //return new PacketBattlefieldHistoryInfo";
                    //    break;

                    //case 7304:      // 0x1C89
                    //                //return new PacketBattlefieldHistoryInfoResult";
                    //    break;

                    //case 7305:      // 0x1C8A
                    //                //return new PacketBattlefieldPopup";
                    //    break;

                    //case 7306:      // 0x1C8B
                    //                //return new PacketBattlefieldPopupResult";
                    //    break;

                    //case 7307:      // 0x1C8C
                    //                //return new PacketBattlefieldEnter";
                    //    break;

                    //case 7308:      // 0x1C8D
                    //                //return new PacketBattlefieldEnterResult";
                    //    break;

                    //case 7309:      // 0x1C8E
                    //                //return new PacketBattlefieldEnterNotify";
                    //    break;

                    //case 7310:      // 0x1C8F
                    //                //return new PacketBattlefieldEnterCancel";
                    //    break;

                    //case 7311:      // 0x1C90
                    //                //return new PacketBattlefieldEnterCancelResult";
                    //    break;

                    //case 7312:      // 0x1C91
                    //                //return new PacketBattlefieldEnterCancelNotify";
                    //    break;

                    //case 7313:      // 0x1C92
                    //                //return new PacketBattlefieldEnterCompletedNotify";
                    //    break;

                    //case 7314:      // 0x1C93
                    //                //return new PacketBattlefieldCountDownStartNotify";
                    //    break;

                    //case 7315:      // 0x1C94
                    //                //return new PacketBattlefieldWorldEnter";
                    //    break;

                    //case 7316:      // 0x1C95
                    //                //return new PacketBattlefieldWorldEnterResult";
                    //    break;

                    //case 7317:      // 0x1C96
                    //                //return new PacketBattlefieldTimeNotify";
                    //    break;

                    //case 7318:      // 0x1C97
                    //                //return new PacketBattlefieldEndNotify";
                    //    break;

                    //case 7319:      // 0x1C98
                    //                //return new PacketBattlefieldExit";
                    //    break;

                    //case 7320:      // 0x1C99
                    //                //return new PacketBattlefieldExitResult";
                    //    break;

                    //case 7321:      // 0x1C9A
                    //                //return new PacketBattlefieldScoreChangeNotify";
                    //    break;

                    //case 7322:      // 0x1C9B
                    //                //return new PacketBattlefieldOccupationProgressListNotify";
                    //    break;

                    //case 7323:      // 0x1C9C
                    //                //return new PacketBattlefieldFreyaCarveStartNotify";
                    //    break;

                    //case 7324:      // 0x1C9D
                    //                //return new PacketBattlefieldFreyaCarveSuccessNotify";
                    //    break;

                    //case 7325:      // 0x1C9E
                    //                //return new PacketBattlefieldFreyaCarveFailNotify";
                    //    break;

                    //case 7326:      // 0x1C9F
                    //                //return new PacketBattlefieldKillNotify";
                    //    break;

                    //case 7327:      // 0x1CA0
                    //                //return new PacketBattlefieldOfHonorReconnectDataNotify";
                    //    break;

                    //case 7328:      // 0x1CA1
                    //                //return new PacketBattlefieldDailyTimeEndNotify";
                    //    break;

                    //case 7329:      // 0x1CA2
                    //                //return new PacketBattlefieldHallOfFameInfo";
                    //    break;

                    //case 7330:      // 0x1CA3
                    //                //return new PacketBattlefieldHallOfFameInfoResult";
                    //    break;

                    //case 7331:      // 0x1CA4
                    //                //return new PacketBattlefieldSeasonRewardNotify";
                    //    break;

                    //case 7332:      // 0x1CA5
                    //                //return new PacketBattlefieldSeasonRewardRequest";
                    //    break;

                    //case 7333:      // 0x1CA6
                    //                //return new PacketBattlefieldSeasonRewardRequestResult";
                    //    break;

                    //case 7334:      // 0x1CA7
                    //                //return new PacketBattlefieldPartyMemberLeagueChangeNotify";
                    //    break;

                    //case 7335:      // 0x1CA8
                    //                //return new PacketBattlefieldNextBuffCreateTimeNotify";
                    //    break;

                    //case 7800:      // 0x1E79
                    //                //return new PacketCostumeSetHidden";
                    //    break;

                    //case 7801:      // 0x1E7A
                    //                //return new PacketCostumeSetHiddenResult";
                    //    break;

                    //case 7802:      // 0x1E7B
                    //                //return new PacketCostumeSetHiddenNotify";
                    //    break;

                    //case 7803:      // 0x1E7C
                    //                //return new PacketCostumeShopListRead";
                    //    break;

                    //case 7804:      // 0x1E7D
                    //                //return new PacketCostumeShopListReadResult";
                    //    break;

                    //case 7805:      // 0x1E7E
                    //                //return new PacketCostumeShopBuy";
                    //    break;

                    //case 7806:      // 0x1E7F
                    //                //return new PacketCostumeShopBuyResult";
                    //    break;

                    //case 9000:      // 0x2329
                    //                //return new PacketGuildDungeonSupportRequest";
                    //    break;

                    //case 9001:      // 0x232A
                    //                //return new PacketGuildDungeonSupportRequestResult";
                    //    break;

                    //case 9002:      // 0x232B
                    //                //return new PacketGuildDungeonSupportCancel";
                    //    break;

                    //case 9003:      // 0x232C
                    //                //return new PacketGuildDungeonSupportCancelResult";
                    //    break;

                    //case 9004:      // 0x232D
                    //                //return new PacketGuildDungeonParticipate";
                    //    break;

                    //case 9005:      // 0x232E
                    //                //return new PacketGuildDungeonParticipateResult";
                    //    break;

                    //case 9006:      // 0x232F
                    //                //return new PacketGuildDungeonHelpResultNotify";
                    //                //PktGuildDungeonParticipateresult.Packet(packet);
                    //    break;

                    //case 9007:      // 0x2330
                    //                //return new PacketGuildDungeonHelpInfo";
                    //    break;

                    //case 9008:      // 0x2331
                    //                //return new PacketGuildDungeonHelpInfoResult";
                    //    break;

                    //case 9009:      // 0x2332
                    //                //return new PacketGuildDungeonHelpList";
                    //    break;

                    //case 9010:      // 0x2333
                    //                //return new PacketGuildDungeonHelpListResult";
                    //    break;

                    //case 9500:      // 0x251D
                    //                //return new PacketESportsContentsLockListRead";
                    //    break;

                    //case 9501:      // 0x251E
                    //                //return new PacketESportsContentsLockListReadResult";
                    //    break;

                    //case 9502:      // 0x251F
                    //                //return new PacketESportsMatchInfoNotify";
                    //    break;

                    //case 9503:      // 0x2520
                    //                //return new PacketESportsMatchJoin";
                    //    break;

                    //case 9504:      // 0x2521
                    //                //return new PacketESportsMatchJoinResult";
                    //    break;

                    //case 9600:      // 0x2581
                    //                //return new PacketEventCheckBoardListRead";
                    //    break;

                    //case 9601:      // 0x2582
                    //                //return new PacketEventCheckBoardListReadResult";
                    //    break;

                    //case 9602:      // 0x2583
                    //                //return new PacketEventCheckBoardGet";
                    //    break;

                    //case 9603:      // 0x2584
                    //                //return new PacketEventCheckBoardGetResult";
                    //    break;

                    //case 9604:      // 0x2585
                    //                //return new PacketEventCheckBoardReset";
                    //    break;

                    //case 9605:      // 0x2586
                    //                //return new PacketEventCheckBoardResetResult";
                    //    break;

                    //case 9606:      // 0x2587
                    //                //return new PacketEventCheckBoardAccrueGet";
                    //    break;

                    //case 9607:      // 0x2588
                    //                //return new PacketEventCheckBoardAccrueGetResult";
                    //    break;

                    //case 9608:      // 0x2589
                    //                //return new PacketEventCheckBoardBadgeClear";
                    //    break;

                    //case 9609:      // 0x258A
                    //                //return new PacketEventCheckBoardBadgeClearResult";
                    //    break;

                    //case 9700:      // 0x25E5
                    //                //return new PacketFacebookInviteList";
                    //    break;

                    //case 9701:      // 0x25E6
                    //                //return new PacketFacebookInviteListResult";
                    //    break;

                    //case 9702:      // 0x25E7
                    //                //return new PacketFacebookInviteRequest";
                    //    break;

                    //case 9703:      // 0x25E8
                    //                //return new PacketFacebookInviteRequestResult";
                    //    break;

                    //case 9704:      // 0x25E9
                    //                //return new PacketFacebookFriendListInfoRequest";
                    //    break;

                    //case 9705:      // 0x25EA
                    //                //return new PacketFacebookFriendListInfoRequestResult";
                    //    break;

                    //case 9706:      // 0x25EB
                    //                //return new PacketFacebookRewardRequest";
                    //    break;

                    //case 9707:      // 0x25EC
                    //                //return new PacketFacebookRewardRequestResult";
                    //    break;

                    //case 9750:      // 0x2617
                    //                //return new PacketNewsletterListRead";
                    //    break;

                    //case 9751:      // 0x2618
                    //                //return new PacketNewsletterListReadResult";
                    //    break;

                    //case 9752:      // 0x2619
                    //                //return new PacketNewsletterDelete";
                    //    break;

                    //case 9753:      // 0x261A
                    //                //return new PacketNewsletterDeleteResult";
                    //    break;

                    //case 9754:      // 0x261B
                    //                //return new PacketNewsletterDeleteAll";
                    //    break;

                    //case 9755:      // 0x261C
                    //                //return new PacketNewsletterDeleteAllResult";
                    //    break;

                    //case 9756:      // 0x261D
                    //                //return new PacketNewsletterRewardGet";
                    //    break;

                    //case 9757:      // 0x261E
                    //                //return new PacketNewsletterRewardGetResult";
                    //    break;

                    //case 9758:      // 0x261F
                    //                //return new PacketNewsletterRewardAllGet";
                    //    break;

                    //case 9759:      // 0x2620
                    //                //return new PacketNewsletterRewardAllGetResult";
                    //    break;

                    //case 9760:      // 0x2621
                    //                //return new PacketNewsletterReceiveNotify";
                    //    break;

                    //case 9761:      // 0x2622
                    //                //return new PacketNewsletterOpen";
                    //    break;

                    //case 9762:      // 0x2623
                    //                //return new PacketNewsletterOpenResult";
                    //    break;

                    //case 10000:     // 0x2711
                    //                //return new PacketGuildEmblemChangeNotify";
                    //    break;

                    //case 10001:     // 0x2712
                    //                //return new PacketGuildNicknameChangeNotify";
                    //    break;

                    //case 10002:     // 0x2713
                    //                //return new PacketGuildMemberLoginNotify";
                    //    break;

                    //case 10003:     // 0x2714
                    //                //return new PacketGuildDonateNotify";
                    //    break;

                    //case 10004:     // 0x2715
                    //                //return new PacketGuildWarehouseGrantNotify";
                    //    break;

                    //case 10005:     // 0x2716
                    //                //return new PacketGuildWarehouseGrantAllNotify";
                    //    break;

                    //case 10006:     // 0x2717
                    //                //return new PacketGuildWarehouseGrantByListNotify";
                    //    break;

                    //case 10007:     // 0x2718
                    //                //return new PacketGuildMarketGiftBuyNotify";
                    //    break;

                    //case 10008:     // 0x2719
                    //                //return new PacketGuildRevenge";
                    //    break;

                    //case 10009:     // 0x271A
                    //                //return new PacketGuildRevengeResult";
                    //    break;

                    //case 10010:     // 0x271B
                    //                //return new PacketGuildRevengeNotify";
                    //    break;

                    //case 10011:     // 0x271C
                    //                //return new PacketGuildRevengeAnswer";
                    //    break;

                    //case 10012:     // 0x271D
                    //                //return new PacketGuildRevengeAnswerResult";
                    //    break;

                    //case 10013:     // 0x271E
                    //                //return new PacketGuildHostilityRegisterNotify";
                    //    break;

                    //case 10014:     // 0x271F
                    //                //return new PacketGuildHostileWarEndRefuseNotify";
                    //    break;

                    //case 10015:     // 0x2720
                    //                //return new PacketGuildHostileWarEndNotify";
                    //    break;

                    //case 10016:     // 0x2721
                    //                //return new PacketGuildHostileWarSurrenderNotify";
                    //    break;

                    //case 10017:     // 0x2722
                    //                //return new PacketGuildBuffUpgradeNotify";
                    //    break;

                    //case 10018:     // 0x2723
                    //                //return new PacketGuildMarketBuyNotify";
                    //    break;

                    //case 10019:     // 0x2724
                    //                //return new PacketGuildDungeonResetNotify";
                    //    break;

                    //case 10020:     // 0x2725
                    //                //return new PacketFortressSiegeEntryBidNotify";
                    //    break;

                    //case 10021:     // 0x2726
                    //                //return new PacketCastleSiegeEntryBidNotify";
                    //    break;

                    //case 10022:     // 0x2727
                    //                //return new PacketFortressSiegeEntryBidTimeNotify";
                    //    break;

                    //case 10023:     // 0x2728
                    //                //return new PacketCastleSiegeEntryBidTimeNotify";
                    //    break;

                    //case 10024:     // 0x2729
                    //                //return new PacketFortressSiegeJoinNotify";
                    //    break;

                    //case 10025:     // 0x272A
                    //                //return new PacketCastleSiegeJoinNotify";
                    //    break;

                    //case 10026:     // 0x272B
                    //                //return new PacketFortressSiegeStartNotify";
                    //    break;

                    //case 10027:     // 0x272C
                    //                //return new PacketCastleSiegeStartNotify";
                    //    break;

                    //case 10028:     // 0x272D
                    //                //return new PacketGuildFortressGiveUpNotify";
                    //    break;

                    //case 10029:     // 0x272E
                    //                //return new PacketGuildCastleTypeSelectGuildNotify";
                    //    break;

                    //case 10030:     // 0x272F
                    //                //return new PacketGuildAgitCrystalUpgradeNotify";
                    //    break;

                    //case 10031:     // 0x2730
                    //                //return new PacketGuildAgitRelicPointUseNotify";
                    //    break;

                    //case 10032:     // 0x2731
                    //                //return new PacketGuildAgitFirePlaceDisableNotify";
                    //    break;

                    //case 10100:     // 0x2775
                    //                //return new PacketServerTransferListRead";
                    //    break;

                    //case 10101:     // 0x2776
                    //                //return new PacketServerTransferListReadResult";
                    //    break;

                    //case 10102:     // 0x2777
                    //                //return new PacketServerTransferBuyCheck";
                    //    break;

                    //case 10103:     // 0x2778
                    //                //return new PacketServerTransferBuyCheckResult";
                    //    break;

                    //case 10104:     // 0x2779
                    //                //return new PacketServerTransferInfoRead";
                    //    break;

                    //case 10105:     // 0x277A
                    //                //return new PacketServerTransferInfoReadResult";
                    //    break;

                    //case 10106:     // 0x277B
                    //                //return new PacketServerTransferItemUse";
                    //    break;

                    //case 10107:     // 0x277C
                    //                //return new PacketServerTransferItemUseResult";
                    //    break;

                    //case 10108:     // 0x277D
                    //                //return new PacketServerTransferReady";
                    //    break;

                    //case 10109:     // 0x277E
                    //                //return new PacketServerTransferReadyResult";
                    //    break;

                    //case 10110:     // 0x277F
                    //                //return new PacketServerTransferStart";
                    //    break;

                    //case 10111:     // 0x2780
                    //                //return new PacketServerTransferStartResult";
                    //    break;

                    //case 10112:     // 0x2781
                    //                //return new PacketServerTransferEnd";
                    //    break;

                    //case 10113:     // 0x2782
                    //                //return new PacketServerTransferEndResult";
                    //    break;

                    //case 10114:     // 0x2783
                    //                //return new PacketPlayerStorageListRead";
                    //    break;

                    //case 10115:     // 0x2784
                    //                //return new PacketPlayerStorageListReadResult";
                    //    break;

                    //case 10116:     // 0x2785
                    //                //return new PacketPlayerStorageExpand";
                    //    break;

                    //case 10117:     // 0x2786
                    //                //return new PacketPlayerStorageExpandResult";
                    //    break;

                    //case 10118:     // 0x2787
                    //                //return new PacketItemMoveToPlayerStorage";
                    //    break;

                    //case 10119:     // 0x2788
                    //                //return new PacketItemMoveToPlayerStorageResult";
                    //    break;

                    //case 10120:     // 0x2789
                    //                //return new PacketPlayerStorageItemMoveToBag";
                    //    break;

                    //case 10121:     // 0x278A
                    //                //return new PacketPlayerStorageItemMoveToBagResult";
                    //    break;

                    //case 10122:     // 0x278B
                    //                //return new PacketItemSpecialNotify";
                    //    break;

                    //case 10123:     // 0x278C
                    //                //return new PacketItemCoolTimeListNotify";
                    //    break;

                    //case 10124:     // 0x278D
                    //                //return new PacketBossItemDropNotify";
                    //    break;

                    //case 10300:     // 0x283D
                    //                //return new PacketFreeSiegeRecruitCreate";
                    //    break;

                    //case 10301:     // 0x283E
                    //                //return new PacketFreeSiegeRecruitCreateResult";
                    //    break;

                    //case 10302:     // 0x283F
                    //                //return new PacketFreeSiegeRecruitCreateNotify";
                    //    break;

                    //case 10303:     // 0x2840
                    //                //return new PacketFreeSiegeRecruitDisband";
                    //    break;

                    //case 10304:     // 0x2841
                    //                //return new PacketFreeSiegeRecruitDisbandResult";
                    //    break;

                    //case 10305:     // 0x2842
                    //                //return new PacketFreeSiegeRecruitDisbandNotify";
                    //    break;

                    //case 10306:     // 0x2843
                    //                //return new PacketFreeSiegeRecruitExpel";
                    //    break;

                    //case 10307:     // 0x2844
                    //                //return new PacketFreeSiegeRecruitExpelResult";
                    //    break;

                    //case 10308:     // 0x2845
                    //                //return new PacketFreeSiegeRecruitExpelNotify";
                    //    break;

                    //case 10309:     // 0x2846
                    //                //return new PacketFreeSiegeRecruitWithdraw";
                    //    break;

                    //case 10310:     // 0x2847
                    //                //return new PacketFreeSiegeRecruitWithdrawResult";
                    //    break;

                    //case 10311:     // 0x2848
                    //                //return new PacketFreeSiegeRecruitWithdrawNotify";
                    //    break;

                    //case 10312:     // 0x2849
                    //                //return new PacketFreeSiegeRecruitChangeClass";
                    //    break;

                    //case 10313:     // 0x284A
                    //                //return new PacketFreeSiegeRecruitChangeClassResult";
                    //    break;

                    //case 10314:     // 0x284B
                    //                //return new PacketFreeSiegeRecruitChangeClassNotify";
                    //    break;

                    //case 10315:     // 0x284C
                    //                //return new PacketFreeSiegeRecruitInvite";
                    //    break;

                    //case 10316:     // 0x284D
                    //                //return new PacketFreeSiegeRecruitInviteResult";
                    //    break;

                    //case 10317:     // 0x284E
                    //                //return new PacketFreeSiegeRecruitInviteNotify";
                    //    break;

                    //case 10318:     // 0x284F
                    //                //return new PacketFreeSiegeRecruitInviteRefuse";
                    //    break;

                    //case 10319:     // 0x2850
                    //                //return new PacketFreeSiegeRecruitInviteRefuseResult";
                    //    break;

                    //case 10320:     // 0x2851
                    //                //return new PacketFreeSiegeRecruitInviteRefuseNotify";
                    //    break;

                    //case 10321:     // 0x2852
                    //                //return new PacketFreeSiegeRecruitJoin";
                    //    break;

                    //case 10322:     // 0x2853
                    //                //return new PacketFreeSiegeRecruitJoinResult";
                    //    break;

                    //case 10323:     // 0x2854
                    //                //return new PacketFreeSiegeRecruitJoinNotify";
                    //    break;

                    //case 10324:     // 0x2855
                    //                //return new PacketFreeSiegeRecruitReady";
                    //    break;

                    //case 10325:     // 0x2856
                    //                //return new PacketFreeSiegeRecruitReadyResult";
                    //    break;

                    //case 10326:     // 0x2857
                    //                //return new PacketFreeSiegeRecruitReadyNotify";
                    //    break;

                    //case 10327:     // 0x2858
                    //                //return new PacketFreeSiegeEnterRequest";
                    //    break;

                    //case 10328:     // 0x2859
                    //                //return new PacketFreeSiegeEnterRequestResult";
                    //    break;

                    //case 10329:     // 0x285A
                    //                //return new PacketFreeSiegeEnterRequestNotify";
                    //    break;

                    //case 10330:     // 0x285B
                    //                //return new PacketFreeSiegeRecruitDataNotify";
                    //    break;

                    //case 10331:     // 0x285C
                    //                //return new PacketFreeSiegeEnterCancel";
                    //    break;

                    //case 10332:     // 0x285D
                    //                //return new PacketFreeSiegeEnterCancelResult";
                    //    break;

                    //case 10333:     // 0x285E
                    //                //return new PacketFreeSiegeEnterCancelNotify";
                    //    break;

                    //case 10334:     // 0x285F
                    //                //return new PacketFreeSiegeStepNotify";
                    //    break;

                    //case 10335:     // 0x2860
                    //                //return new PacketFreeSiegeInfo";
                    //    break;

                    //case 10336:     // 0x2861
                    //                //return new PacketFreeSiegeInfoResult";
                    //    break;

                    //case 10337:     // 0x2862
                    //                //return new PacketFreeSiegeSubMissionUpdateNotify";
                    //    break;

                    //case 10338:     // 0x2863
                    //                //return new PacketFreeSiegeFinishNotify";
                    //    break;

                    //case 10339:     // 0x2864
                    //                //return new PacketFreeSiegeChangeClass";
                    //    break;

                    //case 10340:     // 0x2865
                    //                //return new PacketFreeSiegeChangeClassResult";
                    //    break;

                    //case 10341:     // 0x2866
                    //                //return new PacketFreeSiegeLeaderState";
                    //    break;

                    //case 10342:     // 0x2867
                    //                //return new PacketFreeSiegeLeaderStateResult";
                    //    break;

                    //case 10343:     // 0x2868
                    //                //return new PacketFreeSiegeChangeLeaderNotify";
                    //    break;

                    //case 10344:     // 0x2869
                    //                //return new PacketFreeSiegeEnterWaitNotify";
                    //    break;

                    //case 10345:     // 0x286A
                    //                //return new PacketFreeSiegeSkillListNotify";
                    //    break;

                    //case 10346:     // 0x286B
                    //                //return new PacketFreeSiegeTransferCoolTimeNotify";
                    //    break;

                    //case 10500:     // 0x2905
                    //                //return new PacketObserverSiegeEnter";
                    //    break;

                    //case 10501:     // 0x2906
                    //                //return new PacketObserverSiegeEnterResult";
                    //    break;

                    //case 10502:     // 0x2907
                    //                //return new PacketObserverSiegeEnterNotify";
                    //    break;

                    //case 10503:     // 0x2908
                    //                //return new PacketObserverParticipateInfo";
                    //    break;

                    //case 10504:     // 0x2909
                    //                //return new PacketObserverParticipateInfoResult";
                    //    break;

                    //case 10505:     // 0x290A
                    //                //return new PacketCommonSiegeGuildInfoRead";
                    //    break;

                    //case 10506:     // 0x290B
                    //                //return new PacketCommonSiegeGuildInfoReadResult";
                    //    break;

                    //case 10507:     // 0x290C
                    //                //return new PacketCommonSiegeFinishNotifyForObserver";
                    //    break;

                    //case 11000:     // 0x2AF9
                    //                //return new PacketSummonGemListRead";
                    //    break;

                    //case 11001:     // 0x2AFA
                    //                //return new PacketSummonGemListReadResult";
                    //    break;

                    //case 11002:     // 0x2AFB
                    //                //return new PacketSummonGemPartyMatch";
                    //    break;

                    //case 11003:     // 0x2AFC
                    //                //return new PacketSummonGemPartyMatchResult";
                    //    break;

                    //case 11004:     // 0x2AFD
                    //                //return new PacketSummonGemPartyMatchCancel";
                    //    break;

                    //case 11005:     // 0x2AFE
                    //                //return new PacketSummonGemPartyMatchCancelResult";
                    //    break;

                    //case 11006:     // 0x2AFF
                    //                //return new PacketSummonGemEnter";
                    //    break;

                    //case 11007:     // 0x2B00
                    //                //return new PacketSummonGemEnterResult";
                    //    break;

                    //case 11008:     // 0x2B01
                    //                //return new PacketSummonGemSingleMatch";
                    //    break;

                    //case 11009:     // 0x2B02
                    //                //return new PacketSummonGemSingleMatchResult";
                    //    break;

                    //case 11010:     // 0x2B03
                    //                //return new PacketSummonGemSingleMatchCancel";
                    //    break;

                    //case 11011:     // 0x2B04
                    //                //return new PacketSummonGemSingleMatchCancelResult";
                    //    break;

                    //case 11012:     // 0x2B05
                    //                //return new PacketSummonGemNextDungeonReadyNotice";
                    //    break;

                    //case 11013:     // 0x2B06
                    //                //return new PacketSummonGemDungeonFinishNotice";
                    //    break;

                    //case 11014:     // 0x2B07
                    //                //return new PacketSummonGemAutoMatch";
                    //    break;

                    //case 11015:     // 0x2B08
                    //                //return new PacketSummonGemAutoMatchResult";
                    //    break;

                    //case 11016:     // 0x2B09
                    //                //return new PacketSummonGemAutoMatchCancel";
                    //    break;

                    //case 11017:     // 0x2B0A
                    //                //return new PacketSummonGemAutoMatchCancelResult";
                    //    break;

                    //case 11018:     // 0x2B0B
                    //                //return new PacketSummonGemReservationExit";
                    //    break;

                    //case 11019:     // 0x2B0C
                    //                //return new PacketSummonGemReservationExitResult";
                    //    break;

                    //case 11020:     // 0x2B0D
                    //                //return new PacketSummonGemReservationExitCancel";
                    //    break;

                    //case 11021:     // 0x2B0E
                    //                //return new PacketSummonGemReservationExitCancelResult";
                    //    break;

                    //case 11022:     // 0x2B0F
                    //                //return new PacketSummonGemMemberChangeNotice";
                    //    break;

                    //case 11023:     // 0x2B10
                    //                //return new PacketSummonGemDungeonStartNotice";
                    //    break;

                    //case 11024:     // 0x2B11
                    //                //return new PacketSummonGemItemConsumeNotice";
                    //    break;

                    //case 11025:     // 0x2B12
                    //                //return new PacketSummonGemDungeonExitNotice";
                    //    break;

                    default:
                        break;
                        //throw new ApplicationException(string.Format("Packet '{0}' not recognized.", PacketID));
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLineAsync("Case Statement Error: \r\n" + ex.ToString());
                return null;
            }
        }
    }
}