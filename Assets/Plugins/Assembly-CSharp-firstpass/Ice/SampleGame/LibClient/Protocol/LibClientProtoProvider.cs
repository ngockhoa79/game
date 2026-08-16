using System;
using System.Collections.Generic;
using Ice.LibClient.Protocol;

namespace Ice.SampleGame.LibClient.Protocol
{
	public class LibClientProtoProvider : IProtoProvider
	{
		public const int MsgId_CCMSGConnectionReady = 90001;

		public const int MsgId_CCMSGConnectionBreak = 90002;

		public const int MsgId_CCMSGConnectionFailure = 90003;

		public const int MsgId_CCMSGConnectionSendFailure = 90004;

		public const int MsgId_CCMSGConnectionRecvFailure = 90005;

		public const int MsgId_LoginBySessionTokenAck = 1;

		public const int MsgId_LoginByAuthTokenAck = 2;

		public const int MsgId_LoginByAuthTokenReq = 3;

		public const int MsgId_LoginBySessionTokenReq = 4;

		public const int MsgId_S2CGameStateMatchErrorNtf = 1009;

		public const int MsgId_C2SFormationSetReq = 1115;

		public const int MsgId_S2CFormationSetAck = 1116;

		public const int MsgId_C2SGetFormationInfoReq = 1118;

		public const int MsgId_S2CGetFormationInfoAck = 1119;

		public const int MsgId_C2SRegNewUserReq = 1120;

		public const int MsgId_S2CRegNewUserAck = 1121;

		public const int MsgId_S2CRegNewUserNtf = 1122;

		public const int MsgId_C2SSellReq = 1124;

		public const int MsgId_S2CSellAck = 1126;

		public const int MsgId_C2SHeroEatReq = 1127;

		public const int MsgId_S2CHeroEatAck = 1128;

		public const int MsgId_C2SHeroBreakthroughReq = 1131;

		public const int MsgId_S2CHeroBreakthroughAck = 1132;

		public const int MsgId_C2SSkillStarLevelupReq = 1137;

		public const int MsgId_C2SHeroCombineReq = 1139;

		public const int MsgId_S2CSkillStarLevelupAck = 1142;

		public const int MsgId_S2CSkillCombineAck = 1143;

		public const int MsgId_C2SSkillCombineReq = 1144;

		public const int MsgId_C2SEquipmentCombineReq = 1145;

		public const int MsgId_S2CEquipmentCombineAck = 1146;

		public const int MsgId_S2CHeroCombineAck = 1147;

		public const int MsgId_C2SConsumeItemUseReq = 1148;

		public const int MsgId_S2CConsumeItemUseAck = 1149;

		public const int MsgId_C2SSkillEquipReq = 1153;

		public const int MsgId_S2CSkillEquipAck = 1154;

		public const int MsgId_C2STimeSynchronizationReq = 1157;

		public const int MsgId_S2CTimeSynchronizationAck = 1158;

		public const int MsgId_S2CEnterGameAllInfoNtf = 1175;

		public const int MsgId_C2SFriendBattleReq = 1183;

		public const int MsgId_S2CFriendBattleAck = 1184;

		public const int MsgId_S2CFriendsInfoAck = 1185;

		public const int MsgId_C2SFriendsInfoReq = 1187;

		public const int MsgId_C2SPresentationFriendReq = 1188;

		public const int MsgId_S2CPresentationFriendAck = 1189;

		public const int MsgId_C2SSkillUnEquipReq = 1191;

		public const int MsgId_C2SEquipEquipmentReq = 1192;

		public const int MsgId_S2CEquipEquipmentAck = 1193;

		public const int MsgId_C2SUnEquipEquipmentReq = 1194;

		public const int MsgId_C2SFriendEggsPickReq = 1201;

		public const int MsgId_S2CFriendEggsInfoNtf = 1202;

		public const int MsgId_S2CFriendEggsPickAck = 1203;

		public const int MsgId_C2SDuplicateBattleReq = 1205;

		public const int MsgId_S2CHeroInfoChangeNtf = 1208;

		public const int MsgId_S2CPlayerPropertyInfoChangeNtf = 1209;

		public const int MsgId_C2SEquipmentLevelupReq = 1213;

		public const int MsgId_S2CEquipmentLevelupAck = 1214;

		public const int MsgId_S2CItemsChangeNtf = 1215;

		public const int MsgId_C2SChapterRewardReq = 1216;

		public const int MsgId_S2CChapterRewardAck = 1217;

		public const int MsgId_S2CDuplicateBattleAck = 1218;

		public const int MsgId_C2SQueryPlayerSummaryInfoReq = 1237;

		public const int MsgId_S2CQueryPlayerSummaryInfoAck = 1238;

		public const int MsgId_C2SFriendShipLevelAwardReq = 1242;

		public const int MsgId_S2CFriendShipLevelAwardAck = 1243;

		public const int MsgId_C2SDuplicateReportReq = 1244;

		public const int MsgId_S2CDuplicateReportAck = 1245;

		public const int MsgId_C2SHeroLotteryReq = 1246;

		public const int MsgId_S2CHeroLotteryAck = 1247;

		public const int MsgId_C2SRankIngListReq = 1248;

		public const int MsgId_S2CRankIngListAck = 1249;

		public const int MsgId_C2SDuplicateSupporterReq = 1250;

		public const int MsgId_S2CDuplicateSupporterAck = 1251;

		public const int MsgId_C2SShopListReq = 1252;

		public const int MsgId_S2CShopListAck = 1253;

		public const int MsgId_C2SShopBuyReq = 1254;

		public const int MsgId_S2CShopBuyAck = 1255;

		public const int MsgId_C2SRobberyOpponentsReq = 1258;

		public const int MsgId_S2CRobberyOpponentsAck = 1259;

		public const int MsgId_C2SRobberyRobReq = 1260;

		public const int MsgId_S2CRobberyRobAck = 1261;

		public const int MsgId_C2SPVPBattleStartReq = 1262;

		public const int MsgId_C2SRankingPickRedPackReq = 1263;

		public const int MsgId_C2SRankingSendRedPacksReq = 1264;

		public const int MsgId_S2CPVPBattleStartAck = 1265;

		public const int MsgId_S2CRankingPickRedPackAck = 1266;

		public const int MsgId_S2CRankingSendRedPacksAck = 1267;

		public const int MsgId_C2SShopPveStartBattleReq = 1269;

		public const int MsgId_S2CShopPveStartBattleAck = 1270;

		public const int MsgId_C2SRankIngBattleReportReq = 1274;

		public const int MsgId_S2CRankIngBattleReportAck = 1275;

		public const int MsgId_C2SDailyTaskListReq = 1285;

		public const int MsgId_S2CDailyTaskListAck = 1286;

		public const int MsgId_C2SDailyTaskPickReq = 1287;

		public const int MsgId_S2CDailyTaskPickAck = 1288;

		public const int MsgId_C2SAchievementListReq = 1289;

		public const int MsgId_S2CAchievementListAck = 1290;

		public const int MsgId_C2SHeroNurtureReq = 1292;

		public const int MsgId_S2CHeroNurtureAck = 1293;

		public const int MsgId_C2SHeroNurtureCommitReq = 1297;

		public const int MsgId_S2CHeroNurtureCommitAck = 1298;

		public const int MsgId_C2SFriendPromoteListReq = 1299;

		public const int MsgId_S2CFriendPromoteListAck = 1300;

		public const int MsgId_C2SFriendAddReq = 1301;

		public const int MsgId_S2CFriendAddReqAck = 1302;

		public const int MsgId_C2SFrinedReplyAddReq = 1303;

		public const int MsgId_S2CFrinedReplyAddAck = 1304;

		public const int MsgId_C2SFrinedRemoveReq = 1306;

		public const int MsgId_S2CFrinedRemoveAck = 1307;

		public const int MsgId_C2SMailListReq = 1308;

		public const int MsgId_S2CMailListAck = 1309;

		public const int MsgId_C2SAchievementPickReq = 1311;

		public const int MsgId_S2CAchievementPickAck = 1312;

		public const int MsgId_C2SMailPickReq = 1315;

		public const int MsgId_C2SMailReadReq = 1316;

		public const int MsgId_S2CMailPickAck = 1317;

		public const int MsgId_S2CMailReadAck = 1318;

		public const int MsgId_S2CNewNoticeNtf = 1319;

		public const int MsgId_C2SEquipmentRefineReq = 1324;

		public const int MsgId_S2CEquipmentRefineAck = 1325;

		public const int MsgId_C2SEquipmentRefineClearReq = 1326;

		public const int MsgId_C2SEquipmentRefineReturnReq = 1327;

		public const int MsgId_S2CEquipmentRefineClearAck = 1328;

		public const int MsgId_S2CEquipmentRefineReturnAck = 1329;

		public const int MsgId_C2SItemTransformReq = 1330;

		public const int MsgId_S2CItemTransformAck = 1331;

		public const int MsgId_C2STrialStartBattleReq = 1336;

		public const int MsgId_S2CTrialStartBattleAck = 1338;

		public const int MsgId_C2STrialInfoReq = 1340;

		public const int MsgId_S2CTrialInfoAck = 1344;

		public const int MsgId_C2SChatReq = 1346;

		public const int MsgId_S2CChatAck = 1347;

		public const int MsgId_S2CChatNtf = 1348;

		public const int MsgId_C2SContinuousLoginRewardReq = 1350;

		public const int MsgId_C2SOnlineRewardReq = 1351;

		public const int MsgId_S2CContinuousLoginRewardAck = 1353;

		public const int MsgId_S2COnlineRewardAck = 1354;

		public const int MsgId_C2SAccumulationSignReq = 1355;

		public const int MsgId_S2CAccumulationSignAck = 1356;

		public const int MsgId_C2SRobberyRevengeReq = 1359;

		public const int MsgId_S2CRobberyRevengeAck = 1362;

		public const int MsgId_C2SRobberyBattleReportReq = 1363;

		public const int MsgId_S2CRobberyBattleReportAck = 1364;

		public const int MsgId_C2SDuplicateTaskRewardPickReq = 1365;

		public const int MsgId_S2CDuplicateTaskRewardPickAck = 1366;

		public const int MsgId_C2SRobberyHelpFriendReq = 1367;

		public const int MsgId_C2SRobberyHelpRequestReq = 1368;

		public const int MsgId_S2CRobberyHelpFriendAck = 1369;

		public const int MsgId_S2CRobberyHelpRequestAck = 1370;

		public const int MsgId_C2SRegisterDeviceTokenReq = 1371;

		public const int MsgId_S2CRegisterDeviceTokenAck = 1372;

		public const int MsgId_C2SRequirePVPRankReq = 1373;

		public const int MsgId_S2CRequirePVPRankAck = 1374;

		public const int MsgId_C2SEscortInfoReq = 1375;

		public const int MsgId_S2CEscortInfoAck = 1376;

		public const int MsgId_C2SItemTransformPreviewReq = 1377;

		public const int MsgId_S2CItemTransformPreviewAck = 1378;

		public const int MsgId_C2SEscortCarStartReq = 1381;

		public const int MsgId_S2CEscortCarStartAck = 1382;

		public const int MsgId_C2SEscortRefreshCarReq = 1385;

		public const int MsgId_S2CEscortRefreshCarAck = 1386;

		public const int MsgId_C2STrialBattleReportAck = 1390;

		public const int MsgId_C2STrialBattleReportReq = 1391;

		public const int MsgId_C2STrialChallengeWinningReq = 1392;

		public const int MsgId_S2CTrialChallengeWinningAck = 1393;

		public const int MsgId_C2SActivityOpenBoxReq = 1394;

		public const int MsgId_S2CActivityOpenBoxAck = 1395;

		public const int MsgId_C2SActivityOpenBoxItemNtf = 1396;

		public const int MsgId_C2STrialStageRewardReq = 1397;

		public const int MsgId_S2CTrialStageRewardAck = 1398;

		public const int MsgId_AgentAuthTokenAck = 1399;

		public const int MsgId_AgentAuthTokenReq = 1400;

		public const int MsgId_C2STrialReportDetailReq = 1401;

		public const int MsgId_S2CTrialReportDetailAck = 1402;

		public const int MsgId_C2SEscortWrestReq = 1403;

		public const int MsgId_S2CEscortWrestAck = 1404;

		public const int MsgId_S2CKickNtf = 1405;

		public const int MsgId_C2SBuyFunctionReq = 1406;

		public const int MsgId_S2CBuyFunctionAck = 1407;

		public const int MsgId_C2STrialRefreshStrangerReq = 1408;

		public const int MsgId_S2CTrialRefreshStrangerAck = 1409;

		public const int MsgId_C2SEscortPromoteCarReq = 1414;

		public const int MsgId_S2CEscortPromoteCarAck = 1415;

		public const int MsgId_C2SEscortSpeedupReq = 1416;

		public const int MsgId_S2CEscortSpeedupAck = 1417;

		public const int MsgId_C2SEscortPickCompleteRewardReq = 1420;

		public const int MsgId_S2CEscortPickCompleteRewardAck = 1421;

		public const int MsgId_C2SEscortWrestBattleReportReq = 1426;

		public const int MsgId_C2SEscortWrestReportDetailReq = 1427;

		public const int MsgId_S2CEscortWrestBattleReportAck = 1428;

		public const int MsgId_S2CEscortWrestReportDetailAck = 1429;

		public const int MsgId_C2SEscortInspireReq = 1431;

		public const int MsgId_C2SNewStagesStepReq = 1432;

		public const int MsgId_S2CNewStagesStepAck = 1433;

		public const int MsgId_S2CEscortInspireAck = 1434;

		public const int MsgId_C2SFriendLeaveMessageReq = 1436;

		public const int MsgId_S2CFriendLeaveMessageAck = 1437;

		public const int MsgId_C2SRandomNameReq = 1440;

		public const int MsgId_S2CRandomNameAck = 1441;

		public const int MsgId_C2SNewStagesSaveDataReq = 1443;

		public const int MsgId_S2CNewStagesSaveDataAck = 1444;

		public const int MsgId_C2SShopRefreshReq = 1445;

		public const int MsgId_S2CShopRefreshAck = 1446;

		public const int MsgId_C2SApplyCouponReq = 1447;

		public const int MsgId_S2CApplyCouponAck = 1448;

		public const int MsgId_S2CAnnouncementNtf = 1449;

		public const int MsgId_C2SDuplicateBuyLimitTimesReq = 1450;

		public const int MsgId_S2CDuplicateBuyLimitTimesAck = 1451;

		public const int MsgId_C2SHeroBatchEquipReq = 1457;

		public const int MsgId_S2CHeroBatchEquipAck = 1458;

		public const int MsgId_C2SHeroLockReq = 1459;

		public const int MsgId_S2CHeroLockAck = 1460;

		public const int MsgId_C2SFriendNoticesReq = 1467;

		public const int MsgId_S2CFriendNoticesAck = 1468;

		public const int MsgId_S2CFriendshipValueNtf = 1469;

		public const int MsgId_S2CSkillUnEquipAck = 1470;

		public const int MsgId_S2CUnEquipEquipmentAck = 1471;

		public const int MsgId_C2SChatListReq = 1473;

		public const int MsgId_S2CChatListAck = 1474;

		public const int MsgId_C2SChatListExitNtf = 1475;

		public const int MsgId_S2CEscortDefenseSuccessNtf = 1476;

		public const int MsgId_C2SCheckConnectedReq = 1477;

		public const int MsgId_S2CCheckConnectedAck = 1478;

		public const int MsgId_S2CChargeSuccessNtf = 1479;

		public const int MsgId_C2SChargeInfoReq = 1480;

		public const int MsgId_S2CChargeInfoAck = 1481;

		public const int MsgId_C2SDiamondShopBuyReq = 1482;

		public const int MsgId_S2CDiamondShopBuyAck = 1483;

		public const int MsgId_C2SDiamondShopInfoReq = 1484;

		public const int MsgId_S2CDiamondShopInfoAck = 1485;

		public const int MsgId_C2SRedPackListReq = 1488;

		public const int MsgId_S2CRedPackListAck = 1489;

		public const int MsgId_C2SConsumeItemUseBatchReq = 1494;

		public const int MsgId_S2CConsumeItemUseBatchAck = 1495;

		public const int MsgId_S2CRedPackStatusNtf = 1496;

		public const int MsgId_C2SEscortFriendReq = 1497;

		public const int MsgId_S2CEscortFriendAck = 1498;

		public const int MsgId_C2SEscortExitNtf = 1499;

		public const int MsgId_S2CEscortCarInfoChangeNtf = 1500;

		public const int MsgId_C2SValuePairSetReq = 1502;

		public const int MsgId_S2CValuePairSetAck = 1503;

		public const int MsgId_C2SRobberyReportInfoReq = 1506;

		public const int MsgId_S2CRobberyReportInfoAck = 1507;

		public const int MsgId_C2SRobberyNoticeInfoReq = 1508;

		public const int MsgId_S2CRobberyNoticeInfoAck = 1509;

		public const int MsgId_C2SEscortBeWrestClearReq = 1510;

		public const int MsgId_S2CEscortBeWrestClearAck = 1511;

		public const int MsgId_S2CEscortBeWrestNtf = 1512;

		public const int MsgId_S2CEscortNormalCompleteNtf = 1513;

		public const int MsgId_C2SRankIngBattleReportDetailReq = 1514;

		public const int MsgId_S2CRankIngBattleReportDetailAck = 1515;

		public const int MsgId_C2SFriendBattleReportReq = 1516;

		public const int MsgId_S2CFriendBattleReportAck = 1517;

		public const int MsgId_C2SFriendBattleReportDetailReq = 1518;

		public const int MsgId_S2CFriendBattleReportDetailAck = 1519;

		public const int MsgId_C2SGrowingOpenReq = 1521;

		public const int MsgId_C2SGrowingPickReq = 1522;

		public const int MsgId_S2CGrowingPickAck = 1523;

		public const int MsgId_C2SHeadIconSetReq = 1525;

		public const int MsgId_S2CGrowingOpenAck = 1526;

		public const int MsgId_C2SRechargeRewardInfoReq = 1527;

		public const int MsgId_S2CRechargeRewardInfoAck = 1528;

		public const int MsgId_C2SGrandTotalInfoReq = 1529;

		public const int MsgId_S2CGrandTotalInfoAck = 1530;

		public const int MsgId_C2SRechargeRewardPickReq = 1531;

		public const int MsgId_S2CRechargeRewardPickAck = 1532;

		public const int MsgId_C2SGrandTotalPickReq = 1533;

		public const int MsgId_S2CGrandTotalPickAck = 1534;

		public const int MsgId_S2CSlotMachinePickAck = 1536;

		public const int MsgId_C2SSlotMachineInfoReq = 1538;

		public const int MsgId_S2CSlotMachineInfoAck = 1539;

		public const int MsgId_C2SCornucopiaInfoReq = 1540;

		public const int MsgId_S2CCornucopiaInfoAck = 1541;

		public const int MsgId_C2SCornucopiaOpenReq = 1543;

		public const int MsgId_S2CCornucopiaOpenAck = 1544;

		public const int MsgId_C2SSlotMachinePickReq = 1545;

		public const int MsgId_C2SCornucopiaPickReq = 1546;

		public const int MsgId_S2CCornucopiaPickAck = 1547;

		public const int MsgId_C2SBigWheelInfoReq = 1548;

		public const int MsgId_S2CBigWheelInfoAck = 1549;

		public const int MsgId_C2SBigWheelPickReq = 1550;

		public const int MsgId_S2CBigWheelPickAck = 1551;

		public const int MsgId_C2SLimitLotteryPickReq = 1552;

		public const int MsgId_S2CLimitLotteryPickAck = 1553;

		public const int MsgId_C2SLimitLotteryInfoReq = 1554;

		public const int MsgId_S2CLimitLotteryInfoAck = 1555;

		public const int MsgId_S2CHeadIconSetAck = 1556;

		public const int MsgId_C2SBigWheelCloseNtf = 1557;

		public const int MsgId_S2CBigWheelRecordNtf = 1559;

		public const int MsgId_S2CSlotMachineRecordNtf = 1560;

		public const int MsgId_C2SSlotMachineCloseNtf = 1561;

		public const int MsgId_C2SEscortRecordClearReq = 1563;

		public const int MsgId_S2CEscortRecordClearAck = 1564;

		public const int MsgId_C2STrialRecordClearReq = 1567;

		public const int MsgId_S2CTrialRecordClearAck = 1568;

		public const int MsgId_C2STrialRecordInfoReq = 1569;

		public const int MsgId_S2CTrialRecordInfoAck = 1570;

		public const int MsgId_S2COperateOpenNtf = 1571;

		public const int MsgId_C2SSettingMarkReq = 1576;

		public const int MsgId_S2CSettingMarkAck = 1577;

		public const int MsgId_C2SBigWheelShopBuyReq = 1580;

		public const int MsgId_S2CBigWheelShopBuyAck = 1581;

		public const int MsgId_C2SOpenServerRewardPickReq = 1582;

		public const int MsgId_S2COpenServerRewardPickAck = 1583;

		public const int MsgId_C2SOpenServerShopBuyReq = 1586;

		public const int MsgId_S2COpenServerShopBuyAck = 1587;

		public const int MsgId_C2SOpenServerTaskPickReq = 1590;

		public const int MsgId_S2COpenServerTaskPickAck = 1591;

		public const int MsgId_C2SOpenServerInfoReq = 1592;

		public const int MsgId_S2COpenServerInfoAck = 1593;

		public const int MsgId_C2SRobberyClearNewNoticeReq = 1594;

		public const int MsgId_S2CRobberyClearNewNoticeAck = 1595;

		public const int MsgId_C2SGuildCreateReq = 1596;

		public const int MsgId_S2CGuildCreateAck = 1597;

		public const int MsgId_C2SGuildListInfoReq = 1598;

		public const int MsgId_S2CGuildListInfoAck = 1599;

		public const int MsgId_C2SGuildInfoReq = 1600;

		public const int MsgId_S2CGuildInfoAck = 1601;

		public const int MsgId_C2SGuildTransferPresidentReq = 1604;

		public const int MsgId_S2CGuildTransferPresidentAck = 1605;

		public const int MsgId_C2SGuildPromoteReq = 1606;

		public const int MsgId_S2CGuildPromoteAck = 1607;

		public const int MsgId_C2SGuildJoinReq = 1608;

		public const int MsgId_S2CGuildJoinAck = 1609;

		public const int MsgId_C2SGuildAgreeAddReq = 1613;

		public const int MsgId_S2CGuildAgreeAddAck = 1614;

		public const int MsgId_C2SGuildQuitReq = 1615;

		public const int MsgId_S2CGuildQuitAck = 1616;

		public const int MsgId_C2SGuidlInfoChangeReq = 1617;

		public const int MsgId_S2CGuidlInfoChangeAck = 1618;

		public const int MsgId_C2SGuildDonateReq = 1619;

		public const int MsgId_S2CGuildDonateAck = 1620;

		public const int MsgId_C2SGuildPartyStartReq = 1621;

		public const int MsgId_S2CGuildPartyStartAck = 1622;

		public const int MsgId_C2SGuildPartyInfoReq = 1623;

		public const int MsgId_S2CGuildPartyInfoAck = 1624;

		public const int MsgId_S2CGuildPartyPickAck = 1625;

		public const int MsgId_S2CGuildPartyPickReq = 1626;

		public const int MsgId_C2SGuildTaskInfoReq = 1627;

		public const int MsgId_S2CGuildTaskInfoAck = 1628;

		public const int MsgId_C2SGuildTaskPickReq = 1629;

		public const int MsgId_S2CGuildTaskPickAck = 1630;

		public const int MsgId_C2SGuildRankingReq = 1631;

		public const int MsgId_S2CGuildRankingAck = 1632;

		public const int MsgId_C2SGuildJoinListReq = 1633;

		public const int MsgId_S2CGuildJoinListAck = 1634;

		public const int MsgId_C2SGuildDynamicInfoReq = 1635;

		public const int MsgId_S2CGuildDynamicInfoAck = 1636;

		public const int MsgId_C2SGuildDonateInfoReq = 1637;

		public const int MsgId_S2CGuildDonateInfoAck = 1638;

		public const int MsgId_C2SGuildJoinCancelReq = 1639;

		public const int MsgId_S2CGuildJoinCancelAck = 1640;

		public const int MsgId_C2SGuildSearchForReq = 1641;

		public const int MsgId_S2CGuildSearchForAck = 1642;

		public const int MsgId_C2SRoleNameSetReq = 1643;

		public const int MsgId_C2SRoleSignatureSetReq = 1644;

		public const int MsgId_S2CRoleNameSetAck = 1645;

		public const int MsgId_S2CRoleSignatureSetAck = 1646;

		public const int MsgId_C2SGuildActiveBuffReq = 1647;

		public const int MsgId_S2CGuildActiveBuffAck = 1648;

		public const int MsgId_C2SOpenGlobalChatNtf = 1649;

		public const int MsgId_S2CPlayerGuildSummaryInfoNtf = 1652;

		public const int MsgId_C2SCrossPersonTargetReq = 1654;

		public const int MsgId_S2CCrossPersonTargetAck = 1656;

		public const int MsgId_C2SCrossPersonBattleReq = 1657;

		public const int MsgId_S2CCrossPersonBattleAck = 1658;

		public const int MsgId_C2SGasAddMaterialReq = 1659;

		public const int MsgId_C2SGasLevelupReq = 1660;

		public const int MsgId_S2CGasAddMaterialAck = 1661;

		public const int MsgId_S2CGasLevelupAck = 1662;

		public const int MsgId_C2SCrossPersonInfoReq = 1663;

		public const int MsgId_S2CCrossPersonInfoAck = 1664;

		public const int MsgId_C2SCrossPersonClearChangeCdReq = 1665;

		public const int MsgId_S2CCrossPersonClearChangeCdAck = 1666;

		public const int MsgId_C2SCrossPersonBattleReportReq = 1667;

		public const int MsgId_S2CCrossPersonBattleReportAck = 1668;

		public const int MsgId_C2SCrossPersonBuyBattleCountReq = 1669;

		public const int MsgId_S2CCrossPersonBuyBattleCountAck = 1670;

		public const int MsgId_C2SCrossPersonBattleReportDetailReq = 1671;

		public const int MsgId_S2CCrossPersonBattleReportDetailAck = 1672;

		public const int MsgId_C2SCrossPersonPickBattleRewardReq = 1673;

		public const int MsgId_S2CrossPersonPickBattleRewardAck = 1674;

		public const int MsgId_C2SCrossPersonRankingListReq = 1675;

		public const int MsgId_S2CCrossPersonRankingListAck = 1676;

		public const int MsgId_C2SCrossPersonPickScoreRankingReq = 1677;

		public const int MsgId_S2CCrossPersonPickScoreRankingAck = 1678;

		public const int MsgId_C2SCrossPersonPlayOffInfoReq = 1679;

		public const int MsgId_S2CCrossPersonPlayOffInfoAck = 1680;

		public const int MsgId_C2SCrossPersonPlayOffBattleReportReq = 1681;

		public const int MsgId_S2CCrossPersonPlayOffBattleReportAck = 1682;

		public const int MsgId_C2SCrossPersonPlayOffBetReq = 1683;

		public const int MsgId_S2CCrossPersonPlayOffBetAck = 1684;

		public const int MsgId_C2SCrossPersonPlayOffBetRankingReq = 1685;

		public const int MsgId_S2CCrossPersonPlayOffBetRankingAck = 1686;

		public const int MsgId_C2SCrossGuildInfoReq = 1688;

		public const int MsgId_C2SCrossGuildJoinReq = 1689;

		public const int MsgId_S2CCrossGuildInfoAck = 1690;

		public const int MsgId_S2CCrossGuildJoinAck = 1691;

		public const int MsgId_C2SCrossGuildForamtionInfoReq = 1692;

		public const int MsgId_S2CCrossGuildForamtionInfoAck = 1693;

		public const int MsgId_C2SCrossGuildFormationExitNtf = 1694;

		public const int MsgId_S2CCrossGuildFoamtionChangeNtf = 1695;

		public const int MsgId_C2SCrossGuildLineInfoReq = 1698;

		public const int MsgId_S2CCrossGuildLineInfoAck = 1699;

		public const int MsgId_C2SCrossGuildFoamtionSetReq = 1702;

		public const int MsgId_S2CCrossGuildFoamtionSetAck = 1703;

		public const int MsgId_C2SHeroNurtureClearReq = 1705;

		public const int MsgId_S2CHeroNurtureClearAck = 1706;

		public const int MsgId_C2SCrossGuildReportSummaryInfoReq = 1707;

		public const int MsgId_S2CCrossGuildReportSummaryInfoAck = 1708;

		public const int MsgId_C2SGoddessGrailInfoReq = 1710;

		public const int MsgId_C2SGoddessGrailPickReq = 1711;

		public const int MsgId_S2CGoddessGrailInfoAck = 1712;

		public const int MsgId_S2CGoddessGrailPickAck = 1713;

		public const int MsgId_C2SGoddessGrailPickPrizeReq = 1714;

		public const int MsgId_S2CGoddessGrailPickPrizeAck = 1715;

		public const int MsgId_C2SCrossGuidPickBattleOverRewardReq = 1716;

		public const int MsgId_S2CCrossGuidPickBattleOverRewardAck = 1717;

		public const int MsgId_S2CCrossGuildBattleOverNtf = 1718;

		public const int MsgId_C2SCrossGuildScoreRankingReq = 1721;

		public const int MsgId_S2CCrossGuildScoreRankingAck = 1722;

		public const int MsgId_C2SCrossGuildBattleResultReq = 1723;

		public const int MsgId_S2CCrossGuildBattleResultAck = 1724;

		public const int MsgId_C2SCrossGuildPlayerRankingReq = 1725;

		public const int MsgId_S2CCrossGuildPlayerRankingAck = 1726;

		public const int MsgId_C2SCrossGuildReliveReq = 1727;

		public const int MsgId_S2CCrossGuildReliveAck = 1728;

		public const int MsgId_C2SCrossGuildBattleReportDetailReq = 1731;

		public const int MsgId_S2CrossGuildBattleReportDetailAck = 1732;

		public const int MsgId_C2SCrossGuildReplayReq = 1733;

		public const int MsgId_S2CCrossGuildReplayAck = 1734;

		public const int MsgId_C2SCrossPersonPlayOffGetFormationAck = 1741;

		public const int MsgId_C2SCrossPersonPlayOffGetFormationReq = 1742;

		public const int MsgId_C2SSkillCombineBatchReq = 1745;

		public const int MsgId_S2CSkillCombineBatchAck = 1746;

		public const int MsgId_C2SRobberyProtectReq = 1747;

		public const int MsgId_S2CRobberyProtectAck = 1748;

		public const int MsgId_C2SWeekVipGiftPickReq = 1757;

		public const int MsgId_S2CWeekVipGiftPickAck = 1758;

		public const int MsgId_C2SWeekVipGiftInfoReq = 1759;

		public const int MsgId_S2CWeekVipGiftInfoAck = 1760;

		public const int MsgId_C2SDayRechargeRewardInfoReq = 1761;

		public const int MsgId_C2SDayRechargeRewardInfoAck = 1762;

		public const int MsgId_C2SDayRechargeRewardPickReq = 1763;

		public const int MsgId_C2SDayRechargeRewardPickACK = 1764;

		public const int MsgId_C2SWeekRechargeRewardReq = 1765;

		public const int MsgId_C2SWeekRechargeRewardAck = 1766;

		public const int MsgId_C2SWeekRechargeRewardPickReq = 1767;

		public const int MsgId_C2SWeekRechargeRewardPickACK = 1768;

		public const int MsgId_C2SContinueChargeInfoReq = 1751;

		public const int MsgId_C2SContinueChargePickReq = 1752;

		public const int MsgId_S2ContinueChargeInfoAck = 1753;

		public const int MsgId_S2ContinueChargePickAck = 1754;

		public const int MsgId_C2SContinueChargeBuyReq = 1775;

		public const int MsgId_S2ContinueChargeBuyAck = 1776;

		public const int MsgId_C2SContinueChargePickTotalReq = 1777;

		public const int MsgId_S2ContinueChargePickTotalAck = 1778;

		public const int MsgId_C2STrialOneKeyStartBattleReq = 1333;

		public const int MsgId_C2STrialOneKeyStartBattleAck = 1335;

		public const int MsgId_C2SGetBondPositionInfoReq = 1773;

		public const int MsgId_S2CGetBondPositionInfoAck = 1774;

		public const int MsgId_C2SBondPositionOpenReq = 1769;

		public const int MsgId_S2CBondPositionOpenAck = 1770;

		public const int MsgId_C2SBondPositionSetReq = 1771;

		public const int MsgId_S2CBondPositionSetAck = 1772;

		public const int MsgId_C2SGetLotteryRecordReq = 1788;

		public const int MsgId_S2CLotteryRecordAck = 1789;

		private Dictionary<int, Type> _idDic;

		private Dictionary<Type, int> _typeDic;

		public Dictionary<int, Type> IDTypeMap => null;

		public Dictionary<Type, int> TypeIDMap => null;

		public Type GetTypeById(int vId)
		{
			return null;
		}

		public int GetIdByType(Type vType)
		{
			return 0;
		}
	}
}
