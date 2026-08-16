using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class FriendThings : DataModelList<Friend>
	{
		private FriendInfoProto mRawData;

		private List<Friend> mPromteFriends;

		private HashSet<int> mCachedInvitedFriendID;

		private List<Friend> mEggAddFriends;

		private FriendEggsProto mEggInfo;

		private DateTime mEggCDEndTime;

		public Action<int> OnFrienShipChange;

		private int mFriendShip;

		private List<FriendNotification> mFriendNotify;

		public FriendInfoProto RawFriendInfoData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Friend> PromoteFriendList => null;

		public List<Friend> AddEggFriends => null;

		public List<FriendBattleReportProto.ReportItemProto> BattleList { get; set; }

		public int InvitedCount => 0;

		public int TodayQieCuoCount { get; set; }

		public int ToadyMaxQieCuo => 0;

		public int TodayRestQieCuoCount => 0;

		public int MaxEgg => 0;

		public int MaxFriendGiftLevelDiff => 0;

		public FriendEggsProto EggInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FriendShipTotal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CountPresentFriendToday { get; set; }

		public int MaxPresentOneDay => 0;

		public int RestPresentFriendToday => 0;

		public List<FriendNotification> FriendNotityList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FriendCount => 0;

		public int FriendMax => 0;

		public bool IsInvited(int ID)
		{
			return false;
		}

		public void AddInvited(int ID)
		{
		}

		public void ClearInvited()
		{
		}

		public bool IsEnoughFriendShip(int cost)
		{
			return false;
		}

		public void QieCuoCountAdd()
		{
		}

		public bool IsMyEggFull()
		{
			return false;
		}

		public bool IsMyEggCDEnd()
		{
			return false;
		}

		public void SetFriendList(List<Friend> friendList)
		{
		}

		public List<Friend> GetList()
		{
			return null;
		}

		public bool RemoveFriend(int _firendId)
		{
			return false;
		}

		public bool AddNewFriend(Friend f)
		{
			return false;
		}

		public bool IsFriendMax()
		{
			return false;
		}

		public void SortByBattleValue()
		{
		}

		public static void SortByBattleValue(List<Friend> list)
		{
		}

		public bool IsMyFriend(int id)
		{
			return false;
		}

		public Friend GetFriendByID(int id)
		{
			return null;
		}

		public void CreateFriendListFromProto(List<PlayerFriendInfoProto> listFriendProto)
		{
		}

		public void CreateNotifyListFromProto(List<FriendNoticeProto> listNotifyProto)
		{
		}

		public void CreatePromoteFriendListFromProto(List<PlayerSummaryInfoProto> lstF)
		{
		}

		private List<Friend> createFriendListFromSummary(List<PlayerSummaryInfoProto> lstF)
		{
			return null;
		}

		public List<Friend> createFriendListFromInfo(List<PlayerFriendInfoProto> listFriendProto)
		{
			return null;
		}

		public List<Friend> createFriendListFromEggRecord(List<FriendInfoProto.EggAddRecordProto> listEggdProto)
		{
			return null;
		}

		public void RequestAddFriend(int player_id, Action onSuccess = null)
		{
		}

		public void RequestDeleteFriend(int player_id, Action onSuccess = null)
		{
		}
	}
}
