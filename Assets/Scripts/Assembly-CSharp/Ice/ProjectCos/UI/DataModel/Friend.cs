using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Friend : Player
	{
		public enum FriendInviteType
		{
			CanInvite = 0,
			AlreadySent = 1
		}

		protected int _index;

		private int _leaderHeroId;

		private DateTime _lastLogoutTime;

		private int _leaderCombatValue;

		private FriendInviteType _inviteType;

		private int _giftLevel;

		private int _giftExpMax;

		private int _giftExp;

		public bool IsTodayAlreadyPresent { get; set; }

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LeaderHeroId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public DateTime LastLogoutTime
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public int LeaderCombatValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsGiftRewardEnable { get; set; }

		public FriendInviteType InviteType
		{
			get
			{
				return default(FriendInviteType);
			}
			set
			{
			}
		}

		public int GiftLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GiftExpTotal { get; private set; }

		public int GiftExpMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GiftExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void CaculateExp(int totalExp)
		{
		}

		public float GetGiftProgress()
		{
			return 0f;
		}

		public bool IsGiftLevelMax()
		{
			return false;
		}

		public bool CanSendGift()
		{
			return false;
		}

		public void CreateFromProto(PlayerFriendInfoProto fInfo)
		{
		}

		public static Friend CreateFromMe()
		{
			return null;
		}

		public void CreateFromSummaryProto(PlayerSummaryInfoProto f)
		{
		}

		public void CreateFromPlayer(Player f)
		{
		}
	}
}
