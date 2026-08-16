using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GlobalConfigTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class FriendAssistCD_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Normal;

			[ProtoMember(2)]
			public int Cooperation;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class StrangePvePromotInfo_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Count;

			[ProtoMember(2)]
			public int LevelRange;

			[ProtoMember(3)]
			public int Time;

			[ProtoMember(4)]
			public int MinNumber;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class FriendPromotInfo_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Count;

			[ProtoMember(2)]
			public int LevelRange;

			[ProtoMember(3)]
			public int Time;

			[ProtoMember(4)]
			public int MinNumber;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class RedPackReturnRate_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class FragmentRobRateRange_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Low;

			[ProtoMember(2)]
			public int High;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class FragmentRobProtect_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Price;

			[ProtoMember(2)]
			public int Time;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class TrialBonusRowNumber_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Count;

			[ProtoMember(2)]
			public int MinNumber;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class TrialAssistRowRangeWeight : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			[ProtoMember(3)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class EscortAccelerateFunction : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Times;

			[ProtoMember(2)]
			public int Number;

			[ProtoMember(3)]
			public double Rate;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class EscortBuyBuff : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Times;

			[ProtoMember(2)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class EscortBuffNumber : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Rate;

			[ProtoMember(2)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class BattleFriendship_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Win;

			[ProtoMember(2)]
			public int Lose;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CardLevelupGrade : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Id;

			[ProtoMember(2)]
			public int Weight;

			[ProtoMember(3)]
			public double Multiple;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class GuideGiftHero_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Diamond;

			[ProtoMember(2)]
			public int Friend;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class GuideFriendModeLevel_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Level1;

			[ProtoMember(2)]
			public int Level2;

			[ProtoMember(3)]
			public double PlayerRate;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class FirstChargeReward : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class HeroSpeakTimeRange_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class PVELoseDeclineEnergy_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Normal;

			[ProtoMember(2)]
			public int Hero;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DevelopVIPLevel_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int VIPLevel;

			[ProtoMember(2)]
			public int Price;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DevelopLevelBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Level;

			[ProtoMember(2)]
			public int Bonus;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class GuildPositonContributeAddRate_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public double Position1;

			[ProtoMember(2)]
			public double Position2;

			[ProtoMember(3)]
			public double Position3;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class BuyGoldCritWeight : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Rate;

			[ProtoMember(2)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossGuildSignUpDate : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Date;

			[ProtoMember(2)]
			public int Hour;

			[ProtoMember(3)]
			public int Minute;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossGuildGetGuildExp_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Win;

			[ProtoMember(2)]
			public int Lose;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossGuildBaseBraveCoin_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Win;

			[ProtoMember(2)]
			public int Lose;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossGuildBaseContributeCoin_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Win;

			[ProtoMember(2)]
			public int Lose;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossGuildMatchComboWeight : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Diff;

			[ProtoMember(2)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class ContinuousChat_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Time;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int BattleBoutCountLimit;

		[ProtoMember(2)]
		public double AutoRecover;

		[ProtoMember(3)]
		public double[] HeroEatCosts;

		[ProtoMember(4)]
		public int BonusTimes;

		[ProtoMember(5)]
		public double WhiteWeaponIndexA;

		[ProtoMember(6)]
		public double WhiteClothIndexA;

		[ProtoMember(7)]
		public double WhiteJewelryIndexA;

		[ProtoMember(8)]
		public double WhiteHeadIndexA;

		[ProtoMember(9)]
		public double GreenWeaponIndexA;

		[ProtoMember(10)]
		public double GreenClothIndexA;

		[ProtoMember(11)]
		public double GreenJewelryIndexA;

		[ProtoMember(12)]
		public double GreenHeadIndexA;

		[ProtoMember(13)]
		public double BlueWeaponIndexA;

		[ProtoMember(14)]
		public double BlueClothIndexA;

		[ProtoMember(15)]
		public double BlueJewelryIndexA;

		[ProtoMember(16)]
		public double BlueHeadIndexA;

		[ProtoMember(17)]
		public double PurpleWeaponIndexA;

		[ProtoMember(18)]
		public double PurpleClothIndexA;

		[ProtoMember(19)]
		public double PurpleJewelryIndexA;

		[ProtoMember(20)]
		public double PurpleHeadIndexA;

		[ProtoMember(21)]
		public double OrangeWeaponIndexA;

		[ProtoMember(22)]
		public double OrangeClothIndexA;

		[ProtoMember(23)]
		public double OrangeJewelryIndexA;

		[ProtoMember(24)]
		public double OrangeHeadIndexA;

		[ProtoMember(25)]
		public double RedWeaponIndexA;

		[ProtoMember(26)]
		public double RedClothIndexA;

		[ProtoMember(27)]
		public double RedJewelryIndexA;

		[ProtoMember(28)]
		public double RedHeadIndexA;

		[ProtoMember(29)]
		public double EquipmentCostIndexB;

		[ProtoMember(30)]
		public double EquipmentCostIndexC;

		[ProtoMember(31)]
		public int EnergyRecoverTime;

		[ProtoMember(32)]
		public int SkillStarLevelCount_2;

		[ProtoMember(33)]
		public int SkillStarLevelCount_3;

		[ProtoMember(34)]
		public int SkillStarLevelCount_4;

		[ProtoMember(35)]
		public int SkillStarLevelCount_5;

		[ProtoMember(36)]
		public int SkillStarLevelGoldCost_2;

		[ProtoMember(37)]
		public int SkillStarLevelGoldCost_3;

		[ProtoMember(38)]
		public int SkillStarLevelGoldCost_4;

		[ProtoMember(39)]
		public int SkillStarLevelGoldCost_5;

		[ProtoMember(40)]
		public int SweepPrice;

		[ProtoMember(41)]
		public int UseableChallengeTimes;

		[ProtoMember(42)]
		public int ChallengeGoldBonus;

		[ProtoMember(43)]
		public double ChallengeRankIndexA;

		[ProtoMember(44)]
		public double ChallengeRankIndexB;

		[ProtoMember(45)]
		public double ChallengeRankIndexC;

		[ProtoMember(46)]
		public double ChallengeRankIndexD;

		[ProtoMember(47)]
		public int ChallengablePlayerNumber;

		[ProtoMember(48)]
		public int ChallengableExtraNumber;

		[ProtoMember(49)]
		public int ChallengableTotalEnemy;

		[ProtoMember(50)]
		public int ChallengableCDTime;

		[ProtoMember(51)]
		public int ChallengableClearCDCost;

		[ProtoMember(52)]
		public int[] ChallengeReputationRefreshs;

		[ProtoMember(53)]
		public int BuyChallengeTimes;

		[ProtoMember(54)]
		public int FriendAssistNumber;

		[ProtoMember(55)]
		public int StrangerAssistNumber;

		[ProtoMember(56)]
		public int StrangerLackNumber;

		[ProtoMember(57)]
		public int FriendFp;

		[ProtoMember(58)]
		public int StrangeFp;

		[ProtoMember(59)]
		public FriendAssistCD_ FriendAssistCD;

		[ProtoMember(60)]
		public int CooperationFriendLevel;

		[ProtoMember(61)]
		public int FriendshipDailyLimitation;

		[ProtoMember(62)]
		public StrangePvePromotInfo_ StrangePvePromotInfo;

		[ProtoMember(63)]
		public FriendPromotInfo_ FriendPromotInfo;

		[ProtoMember(64)]
		public int FriendPackPrice;

		[ProtoMember(65)]
		public int DiamondPacPrice;

		[ProtoMember(66)]
		public int Packs10Price;

		[ProtoMember(67)]
		public int FriendPackCD;

		[ProtoMember(68)]
		public int DiamondPackCD;

		[ProtoMember(69)]
		public int PVEShopLastTime;

		[ProtoMember(70)]
		public int BlueEquipmentRefine;

		[ProtoMember(71)]
		public int PurpleEquipmentRefine;

		[ProtoMember(72)]
		public int RedEquipmentRefine;

		[ProtoMember(73)]
		public int OrangeEquipmentRefine;

		[ProtoMember(74)]
		public int SweepEnableStarCount;

		[ProtoMember(75)]
		public int RedPackCD;

		[ProtoMember(76)]
		public RedPackReturnRate_ RedPackReturnRate;

		[ProtoMember(77)]
		public int EmailLimited;

		[ProtoMember(78)]
		public int BaseBagSpace;

		[ProtoMember(79)]
		public int BagSpaceLimit;

		[ProtoMember(80)]
		public int BagExtentPrice;

		[ProtoMember(81)]
		public int SkillBagLimit;

		[ProtoMember(82)]
		public int EquipBagLimit;

		[ProtoMember(83)]
		public int OncextentNumber;

		[ProtoMember(84)]
		public int FragmentRobCost;

		[ProtoMember(85)]
		public FragmentRobRateRange_ FragmentRobRateRange;

		[ProtoMember(86)]
		public int FragmentRobLastPieceRate;

		[ProtoMember(87)]
		public FragmentRobProtect_ FragmentRobProtect;

		[ProtoMember(88)]
		public int OncePurchaseFragmentRob;

		[ProtoMember(89)]
		public int EggCDTime;

		[ProtoMember(90)]
		public int BirdCDMaxCount;

		[ProtoMember(91)]
		public int FeedBirdMaxTimes;

		[ProtoMember(92)]
		public int FriendEggBonus;

		[ProtoMember(93)]
		public int FeedBirdFriendRange;

		[ProtoMember(94)]
		public int EquipmentLevelRate;

		[ProtoMember(95)]
		public int RandomDialyTaskNumber;

		[ProtoMember(96)]
		public int NurtureMedicineConsume;

		[ProtoMember(97)]
		public int NurtureCrystalCost;

		[ProtoMember(98)]
		public int NurtureReturnPrice;

		[ProtoMember(99)]
		public string FirstPickEnergyTime;

		[ProtoMember(100)]
		public string SecondPickEnergyTime;

		[ProtoMember(101)]
		public int[] FormationOpenLists;

		[ProtoMember(102)]
		public int PositionNumberRate;

		[ProtoMember(103)]
		public int RobberyRecoverTime;

		[ProtoMember(104)]
		public int RobberyInitCount;

		[ProtoMember(105)]
		public int[] RobberRewardGolds;

		[ProtoMember(106)]
		public int[] RobberLoseRewardGolds;

		[ProtoMember(107)]
		public int[] RobberSkillRarityRates;

		[ProtoMember(108)]
		public int[] RobberSkillRarityRateRoberts;

		[ProtoMember(109)]
		public int RobberLimitTimes;

		[ProtoMember(110)]
		public int RobberyAvengeBonus;

		[ProtoMember(111)]
		public double CardEeatBonus;

		[ProtoMember(112)]
		public double CardExpExchangeRate;

		[ProtoMember(113)]
		public int RefineLockCost;

		[ProtoMember(114)]
		public int RefineDeclinePrice;

		[ProtoMember(115)]
		public double RefineDeclineReturnStoneRate;

		[ProtoMember(116)]
		public int RefineCleanUpPrice;

		[ProtoMember(117)]
		public double TransformGoldRate;

		[ProtoMember(118)]
		public double TransformExpRate;

		[ProtoMember(119)]
		public int[] CardTransformGolds;

		[ProtoMember(120)]
		public int[] EquipmentTransformGolds;

		[ProtoMember(121)]
		public int[] SkillTransformGolds;

		[ProtoMember(122)]
		public int[] CardTransformSouls;

		[ProtoMember(123)]
		public int[] EquipmentTransformSouls;

		[ProtoMember(124)]
		public int[] SkillTransformSouls;

		[ProtoMember(125)]
		public int[] CardTransformNurtures;

		[ProtoMember(126)]
		public int[] EquipmentTransformRefineStones;

		[ProtoMember(127)]
		public int[] CardTransformChips;

		[ProtoMember(128)]
		public int RedPacketsDailyPurchase;

		[ProtoMember(129)]
		public int GuildRedPacketsDailyPurchase;

		[ProtoMember(130)]
		public int GuildDonateMemberNumber;

		[ProtoMember(131)]
		public int TrialPlayerRange;

		[ProtoMember(132)]
		public int TrialRangePlayesMinNumber;

		[ProtoMember(133)]
		public int TrialRangeDifferentRate;

		[ProtoMember(134)]
		public int TrialStartRange;

		[ProtoMember(135)]
		public int TrialbossRange;

		[ProtoMember(136)]
		public int TrialPlayerMinBattleRow;

		[ProtoMember(137)]
		public int TrialPlayerMaxBattleRow;

		[ProtoMember(138)]
		public int TrialAssistDefaultRow;

		[ProtoMember(139)]
		public int TrialAssistDefaultFriendRow;

		[ProtoMember(140)]
		public int TrialAssistFriendRange;

		[ProtoMember(141)]
		public TrialBonusRowNumber_ TrialBonusRowNumber;

		[ProtoMember(142)]
		public TrialAssistRowRangeWeight[] TrialAssistRowRangeWeights;

		[ProtoMember(143)]
		public int TrialRowRangeDifferentRate;

		[ProtoMember(144)]
		public string TrialRefreshTime;

		[ProtoMember(145)]
		public string EscortOpenTime;

		[ProtoMember(146)]
		public string EscortProductPlusTime;

		[ProtoMember(147)]
		public int EscortDistance;

		[ProtoMember(148)]
		public double EscortProductPlusRate;

		[ProtoMember(149)]
		public int EscortVehicleTimes;

		[ProtoMember(150)]
		public int EscortRobTimes;

		[ProtoMember(151)]
		public int EscortGetBonusDistance;

		[ProtoMember(152)]
		public double EscortBonusRate;

		[ProtoMember(153)]
		public double EscortDefenseBonusRate;

		[ProtoMember(154)]
		public int EscortCompleteTime;

		[ProtoMember(155)]
		public EscortAccelerateFunction[] EscortAccelerateFunctions;

		[ProtoMember(156)]
		public EscortBuyBuff[] EscortBuyBuffs;

		[ProtoMember(157)]
		public EscortBuffNumber[] EscortBuffNumbers;

		[ProtoMember(158)]
		public int EscortFriendFriendship;

		[ProtoMember(159)]
		public BattleFriendship_ BattleFriendship;

		[ProtoMember(160)]
		public int EscortVehicleMaxNumber;

		[ProtoMember(161)]
		public int EscortReflashTime;

		[ProtoMember(162)]
		public int EscortPlayerVehicleExp;

		[ProtoMember(163)]
		public int EscortEndPointExp;

		[ProtoMember(164)]
		public int EscortPlayerRobExp;

		[ProtoMember(165)]
		public int EscortRobReturnDistance;

		[ProtoMember(166)]
		public int ChatFreeTimes;

		[ProtoMember(167)]
		public int ChatPurchasePrice;

		[ProtoMember(168)]
		public int ChatSendMessageFrequency;

		[ProtoMember(169)]
		public int ChatWordsLimitation;

		[ProtoMember(170)]
		public int ChatSaveNumber;

		[ProtoMember(171)]
		public int BuyEnergyNumber;

		[ProtoMember(172)]
		public int ThreeStarsCondition;

		[ProtoMember(173)]
		public int TwoStarsCondition;

		[ProtoMember(174)]
		public int FriendNoticeNumber;

		[ProtoMember(175)]
		public CardLevelupGrade[] CardLevelupGrades;

		[ProtoMember(176)]
		public GuideGiftHero_ GuideGiftHero;

		[ProtoMember(177)]
		public GuideFriendModeLevel_ GuideFriendModeLevel;

		[ProtoMember(178)]
		public int PveShopOpen;

		[ProtoMember(179)]
		public int NewPlayerDiamondPackTimes;

		[ProtoMember(180)]
		public int PlayerDiamondPackTimes;

		[ProtoMember(181)]
		public int MonthCardReward;

		[ProtoMember(182)]
		public FirstChargeReward[] FirstChargeRewards;

		[ProtoMember(183)]
		public string[] FirstChargeRewardTexts;

		[ProtoMember(184)]
		public int TwiceSpeedOpenLevel;

		[ProtoMember(185)]
		public int HeroSpeakRate;

		[ProtoMember(186)]
		public HeroSpeakTimeRange_ HeroSpeakTimeRange;

		[ProtoMember(187)]
		public int FriendChatWordsLimitation;

		[ProtoMember(188)]
		public int NameLimit;

		[ProtoMember(189)]
		public int PveShopCombat1;

		[ProtoMember(190)]
		public int PveShopCombat2;

		[ProtoMember(191)]
		public int PveShopCombat3;

		[ProtoMember(192)]
		public string TipItemTitleColour;

		[ProtoMember(193)]
		public string TipCardTitleColour;

		[ProtoMember(194)]
		public string TipEquipTitleColour;

		[ProtoMember(195)]
		public string TipSkillTitleColour;

		[ProtoMember(196)]
		public string TipCardType;

		[ProtoMember(197)]
		public string TipCardProfession;

		[ProtoMember(198)]
		public string TipEquipType;

		[ProtoMember(199)]
		public string TipSkillType;

		[ProtoMember(200)]
		public string TipEquipProperty;

		[ProtoMember(201)]
		public string TipContentColour;

		[ProtoMember(202)]
		public string TipResoureceTitleColour;

		[ProtoMember(203)]
		public PVELoseDeclineEnergy_ PVELoseDeclineEnergy;

		[ProtoMember(204)]
		public DevelopVIPLevel_ DevelopVIPLevel;

		[ProtoMember(205)]
		public DevelopLevelBonus[] DevelopLevelBonuss;

		[ProtoMember(206)]
		public double SoldReturnGoldRate;

		[ProtoMember(207)]
		public int[] GachaTipss;

		[ProtoMember(208)]
		public string Redpacket_Refresh_Time;

		[ProtoMember(209)]
		public string Redpacket_Guild_Refresh_Time;

		[ProtoMember(210)]
		public int PveChooseFriend1;

		[ProtoMember(211)]
		public int PveChooseFriend2;

		[ProtoMember(212)]
		public int ContinuousUseKey;

		[ProtoMember(213)]
		public int Barragespace;

		[ProtoMember(214)]
		public int ChatLevelLimitation;

		[ProtoMember(215)]
		public int CreatGuildCost;

		[ProtoMember(216)]
		public int GuildApplyListNumber;

		[ProtoMember(217)]
		public int GuildChangeName;

		[ProtoMember(218)]
		public int GuildChangeIcon;

		[ProtoMember(219)]
		public int GuildAppointmentCD;

		[ProtoMember(220)]
		public int GuildRankListCount;

		[ProtoMember(221)]
		public int SignatureLimitCount;

		[ProtoMember(222)]
		public int NameChangeCost;

		[ProtoMember(223)]
		public int NameChangeLevel;

		[ProtoMember(224)]
		public int GuildBoradcastCost;

		[ProtoMember(225)]
		public int GuildTrends;

		[ProtoMember(226)]
		public GuildPositonContributeAddRate_ GuildPositonContributeAddRate;

		[ProtoMember(227)]
		public int GuildAppointmentContributeAmount;

		[ProtoMember(228)]
		public int GuildAnnouncementCount;

		[ProtoMember(229)]
		public int GuildNameMaxCount;

		[ProtoMember(230)]
		public double HeroTransferReturnNurturePillRate;

		[ProtoMember(231)]
		public BuyGoldCritWeight[] BuyGoldCritWeights;

		[ProtoMember(232)]
		public int CrossPersonDailyFightCount;

		[ProtoMember(233)]
		public string CrossPersonNormalGameTime;

		[ProtoMember(234)]
		public int CrossPersonChangeEnemyCD;

		[ProtoMember(235)]
		public int CrossPersonPushComboCount;

		[ProtoMember(236)]
		public int CrossPersonPushMinRange;

		[ProtoMember(237)]
		public int CrossPersonPlayerOnlineTime;

		[ProtoMember(238)]
		public int CrossPersonRankRange;

		[ProtoMember(239)]
		public int CrossPersonOnceBuyCount;

		[ProtoMember(240)]
		public int CrossPersonDailyHitCount;

		[ProtoMember(241)]
		public string CrossPersonPlayOffStartTime;

		[ProtoMember(242)]
		public int CrossPersonPlayOffWaitTime;

		[ProtoMember(243)]
		public int CrossPersonPlayOffBetCost;

		[ProtoMember(244)]
		public int[] CrossPersonPlayOffBetBonuss;

		[ProtoMember(245)]
		public int[] CrossPersonPlayOffUpdateRules;

		[ProtoMember(246)]
		public string CrossPersonPlayOffStartPoint;

		[ProtoMember(247)]
		public int CrossGuildSeasonBattleCount;

		[ProtoMember(248)]
		public CrossGuildSignUpDate[] CrossGuildSignUpDates;

		[ProtoMember(249)]
		public int CrossGuildSecondRoundWaitTime;

		[ProtoMember(250)]
		public int CrossGuildWaitBattleTime;

		[ProtoMember(251)]
		public int CrossGuildWaitMatchTime;

		[ProtoMember(252)]
		public int CrossGuildOpenTime;

		[ProtoMember(253)]
		public CrossGuildGetGuildExp_ CrossGuildGetGuildExp;

		[ProtoMember(254)]
		public CrossGuildBaseBraveCoin_ CrossGuildBaseBraveCoin;

		[ProtoMember(255)]
		public CrossGuildBaseContributeCoin_ CrossGuildBaseContributeCoin;

		[ProtoMember(256)]
		public double CrossGuildContributeCoinRate;

		[ProtoMember(257)]
		public double CrossGuildPointToBraveCoinRate;

		[ProtoMember(258)]
		public int CrossGuildPointCalculatMode;

		[ProtoMember(259)]
		public int CrossGuildLevel;

		[ProtoMember(260)]
		public int CrossGuildJoinCost;

		[ProtoMember(261)]
		public int CrossGuildOrdinaryPoint;

		[ProtoMember(262)]
		public int CrossGuildFlagPoint;

		[ProtoMember(263)]
		public CrossGuildMatchComboWeight[] CrossGuildMatchComboWeights;

		[ProtoMember(264)]
		public int CrossGuildFlagCount;

		[ProtoMember(265)]
		public int CrossGuildLastMatchJoinTime;

		[ProtoMember(266)]
		public ContinuousChat_ ContinuousChat;

		[ProtoMember(267)]
		public int[] ForbiddenChatTimes;

		[ProtoMember(268)]
		public int IgnoreForbidden;

		[ProtoMember(269)]
		public int GasLevelRate;

		[ProtoMember(270)]
		public string CrossPersonStartTime;

		[ProtoMember(271)]
		public string CrossGuildStartTime;

		[ProtoMember(272)]
		public int[] CheckHeroBags;

		[ProtoMember(273)]
		public int[] CheckSkillBags;

		[ProtoMember(274)]
		public int[] CheckEquipBags;

		[ProtoMember(275)]
		public int[] NoCheckBags;

		public virtual void Init()
		{
		}

		public static T Load<T>() where T : GlobalConfigTemplate, new()
		{
			return null;
		}

		public static GlobalConfigTemplate Load()
		{
			return null;
		}
	}
}
