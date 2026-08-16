using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.GameOperations;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Me : Player
	{
		public enum CardFilter
		{
			Default = 0,
			Quality = 1,
			Star = 2,
			Level = 3,
			Prof = 4,
			_NUM = 5
		}

		public enum JobFilter
		{
			All = 0,
			HeavySwordsman = 1,
			LightSwordsman = 2,
			Mage = 3,
			Fighter = 4,
			_NUM = 5
		}

		public enum SortFilter
		{
			QuailtyDown = 0,
			QuailtyUp = 1,
			StarDown = 2,
			StarUp = 3,
			RankDown = 4,
			RankUp = 5,
			_NUM = 6
		}

		public enum ConvoyFriendSelectStatus
		{
			StartCar = 0,
			WrestOthers = 1,
			_NUM = 2
		}

		public class SmeltJourneyMapLocation
		{
			public float xPos;

			public float yPos;

			public bool useThis;
		}

		public int SlotIndex;

		public Hero FetterId;

		public Hero[] FerrerArrayHeroInfo;

		public Hero[] PruchCardFerrerArrayHeroInfo;

		public Action FetterOnBack;

		public Action FetterReturn;

		public string TargetVersion;

		public string Url;

		public Luggage Luggage;

		public FriendThings FriendThings;

		public FriendThings SupporterThings;

		public PVEProgress PveProgress;

		public PlayerInfo PlayerInfo;

		public RobberyInfo RobberyInfo;

		public PVEProgress PveActivity;

		public Notifications Notifications;

		public OnlineReward OnlineReward;

		public string Token;

		private Activity mActivity;

		private bool redpackNormalStatus;

		private bool redpackGuildStatus;

		public bool BindingOK;

		public bool SetDataOk;

		public int LogIntype;

		public int CrossType;

		public bool isFirstIn;

		public string CheckLogToken;

		private GameShop mGameShop;

		public bool CloseGuidance;

		private OpActivity mOpActivity;

		public bool b_ClickShowEnemyArrayInfo;

		private ChargeList mChargeList;

		private Mail mMail;

		private DailyTaskThing mDailyTask;

		private Achivement mAchive;

		public int HoldingsMultiSelectNumber;

		public int HoldingsMultiSelectMax;

		public string SecretCode;

		public static int CardMaxNumber;

		public static int TestSkillMaxNumber;

		public static int TestEquicMaxNumber;

		public Dictionary<int, int> shipLayerCache;

		private PVPEstimate pVpEstimate;

		public bool IsOnHotFix;

		public bool GotVersion;

		public bool isShowCG;

		public bool isPhoneBind;

		public bool isPhoneLogin;

		public string Email;

		private static Me instance;

		public CardFilter cardFilter;

		public JobFilter jobFilter;

		public SortFilter sortFilter;

		public bool ReusableListDraggable;

		public bool isNeedPVEChapterGuidePopup;

		public bool LogInFromAccount;

		public int LastPVEDuplicationId;

		public bool isCardLevelupFromMainHeroSelected;

		public List<Hero> CardLevelupSelection;

		public List<ItemHolding> SkillUpgraderMat;

		public EscortPlayerInfo EscortPlayerInfo;

		public ConvoyInfoOp convoyInfoOp;

		public List<Friend> ConvoyFriendList;

		public List<ColumnInfo> ConvoyFriendsFormations;

		public Friend ConvoyFriend;

		public Friend ConvoyWrestFriend;

		public ShipLayerManager ConvoyShipLayerManager;

		public ConvoyFriendSelectStatus ConvoyPlayerSelectStatus;

		public int ConvoyFriendIndex;

		public WrestBattleInfo.EWrestStatus WrestResultPopup;

		public int PuishGoldOfWrestFail;

		public int WrestTargetShip;

		public EscortPlayerInfo completeInfoCache;

		public EscortPlayerInfoProto.EscortRecord EscortScoreBoardCache;

		public IllustDictRecords dictRecords;

		public IllustDictRecords PurpleCardDictRecords;

		public int PortraHeroID;

		public SettingProto currentSettings;

		public BulletinMessagePool bulletinMsgPool;

		public Action E_guildInfoUpdated;

		public AccSignData accSignData;

		public Action E_accSignUpdateMainScene;

		public Action E_accSignUpdateSignUI;

		public Action E_OpActivePrizeGoldUI;

		public SmeltJourneyMapLocation SJ_MapLoc;

		public VIP VIP { get; private set; }

		public override int VIPLevel => 0;

		public Activity ActivityThings => null;

		public GameShop GameShop => null;

		public OpActivity OpActivity => null;

		public ChargeList ChargeList => null;

		public Mail MailBox => null;

		public DailyTaskThing DailyTaskThing => null;

		public Achivement Achivement => null;

		public PackageItemShop PackageShop { get; private set; }

		public PackageItemShop ItemShop { get; private set; }

		public bool SampleRedpackStatus => false;

		public bool isMultiSelectMax => false;

		public static int GearMaxNumber => 0;

		public static int SkillMaxNumber => 0;

		public static Me Ins => instance ?? (instance = new Me());

		public int MaxRanking { get; set; }

		public PVPEstimate RanksBeforePVPEntrance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object ActivityNotice { get; internal set; }

		public void NotifyRedpackStatus(S2CRedPackStatusNtf ntf)
		{
		}

		public bool isBossLevel(int duplucationID)
		{
			return false;
		}

		public bool isPastLevel(int duplucationID)
		{
			return false;
		}

		public void ApplyChange(List<ItemChangeProto> changeList, bool bShowBoard = true, Action onClose = null)
		{
		}

		private void Clear()
		{
		}

		// [STRUCTURAL-RECONSTRUCTION]
		// Native hydration from S2CEnterGameAllInfoNtf (MsgId 1175) -> PlayerAllInfoProto -> FormationInfo.
		public void FromProto(PlayerAllInfoProto proto)
		{
			SetDataOk = true;
			if (PlayerInfo == null)
			{
				PlayerInfo = new PlayerInfo();
			}

			if (proto != null)
			{
				if (proto.HerosBagInfo != null && proto.HerosBagInfo.HerosInfo != null)
				{
					HeroList.ClearHeroList();
					foreach (var heroProto in proto.HerosBagInfo.HerosInfo)
					{
						Hero hero = Hero.CreateFromProto(heroProto, this);
						if (hero != null)
						{
							HeroList.AddHero(hero, true);
						}
					}
					UnityEngine.Debug.Log($"[ME-DIAG] HerosBagInfo hydrated: HeroList.Count={HeroList.Count}");
				}

				bool formValid = proto.FormationInfo != null;
				UnityEngine.Debug.Log($"[ME-DIAG] FromProto 1175 received: FormationInfo!=null={formValid}");
				if (proto.FormationInfo != null)
				{
					BattleArray activeArray = BattleArray.CreateFromProto(proto.FormationInfo);
					UnityEngine.Debug.Log($"[ME-DIAG] BattleArray.CreateFromProto returned: {(activeArray != null ? "valid (MyCards=" + (activeArray.MyCards != null ? System.Linq.Enumerable.Count(activeArray.MyCards).ToString() : "null") + ")" : "null")}");
					if (activeArray != null)
					{
						AddArray(activeArray);
					}
				}
				if (proto.PropertyBaseInfo != null)
				{
					PlayerInfo.Crystal = proto.PropertyBaseInfo.Crystal;
					PlayerInfo.Gold = proto.PropertyBaseInfo.Gold;
					PlayerInfo.Energy = proto.PropertyBaseInfo.Energy;
					PlayerInfo.Level = proto.PropertyBaseInfo.Level;
				}
			}

			int arraysCount = arrays != null ? arrays.Count : 0;
			int demoCount = MainSceneDemonstrateHeroes != null ? MainSceneDemonstrateHeroes.Count : 0;
			UnityEngine.Debug.Log($"[ME-DIAG] FromProto executed! SetDataOk=true, PlayerInfo.Crystal={(PlayerInfo != null ? PlayerInfo.Crystal : 0)}, arrays.Count={arraysCount}, ActiveArray={(ActiveArray != null ? "valid" : "null")}, MainSceneDemonstrateHeroes.Count={demoCount}");
		}

		public void UpdatePropertyFromNtf(PlayerPropertyInfoProto proto)
		{
		}

		public List<Hero> FilterCardList(bool isMatUp = false)
		{
			return null;
		}

		public List<Hero> FilteredHeroList2(bool isMatUp = false)
		{
			return null;
		}

		public void UserLogin()
		{
		}

		public void SetConvoySupporter(int index)
		{
		}

		public void UpdateGuildInfoFromNtf(S2CPlayerGuildSummaryInfoNtf proto)
		{
		}

		public override bool IsInGuild()
		{
			return false;
		}

		public void UpdateOpActive0Time()
		{
		}

		public void UpdateAccSign()
		{
		}

		public void RefreshRedPackShit()
		{
		}

		public int GetMyCurrencyValue(CurrencyType cType)
		{
			return 0;
		}

		public bool IsMyCurrencyEnough(CurrencyType cType, int cost)
		{
			return false;
		}
	}
}
