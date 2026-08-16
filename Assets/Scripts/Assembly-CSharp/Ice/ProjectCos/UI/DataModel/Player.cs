using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Player : DataModelBase
	{
		public class GuildEssentialInfo
		{
			public enum GuildPost
			{
				None = 0,
				Member = 1,
				ViceLeader = 2,
				Leader = 3,
				NeedToAskServer = 99
			}

			public int ID;

			public string Name;

			public int Icon;

			public int Level;

			public GuildPost Post;

			public void Clear()
			{
			}

			public bool IsIntact()
			{
				return false;
			}

			public void CreateFromProto(PlayerSummaryInfoProto.GuildInfoProto proto)
			{
			}

			public void UpdateFromNtf(S2CPlayerGuildSummaryInfoNtf proto)
			{
			}

			public void RequestGuildPost(int playerID)
			{
			}
		}

		public int ID;

		public string Name;

		public string Signature;

		public int Level;

		public int Ranking;

		public int Power;

		public int Reputation;

		protected readonly List<BattleArray> arrays = new List<BattleArray>();

		protected readonly List<BattleArray> PurpleCardArrays = new List<BattleArray>();

		private HeroList mHeroList;

		public Action E_OnNameChanged;

		public int Portrait;

		public List<BattleArray> m_dcArrayList;

		public GuildEssentialInfo GuildInfo;

		public int HeadIconID { get; set; }

		public virtual int VIPLevel { get; set; }

		// [STRUCTURAL-RECONSTRUCTION]
		// Native getter exists at RVA 0x876770.
		// AssetRipper produced `public HeroList HeroList => null;`.
		public HeroList HeroList => mHeroList ?? (mHeroList = new HeroList());

		// [STRUCTURAL-RECONSTRUCTION]
		// Native getter exists at RVA 0x8764E0.
		// AssetRipper produced `public BattleArray ActiveArray => null;`.
		public BattleArray ActiveArray => (arrays != null && arrays.Count > 0) ? arrays[0] : null;

		public BattleArray PurchAcrdActiveArray => (PurpleCardArrays != null && PurpleCardArrays.Count > 0) ? PurpleCardArrays[0] : null;

		public BattleArray DcActiveArray => (m_dcArrayList != null && m_dcArrayList.Count > 0) ? m_dcArrayList[0] : null;

		// [STRUCTURAL-RECONSTRUCTION]
		// Original native getter exists at RVA 0x876780.
		// AssetRipper produced `public List<Hero> MainSceneDemonstrateHeroes => null;`.
		// Reconstruction derives heroes from ActiveArray when ActiveArray is initialized.
		// If ActiveArray is null or uninitialized, returns an empty list.
		// No arbitrary fallback hero selection (e.g. HeroList.Take(3)) is introduced.
		public List<Hero> MainSceneDemonstrateHeroes
		{
			get
			{
				bool activeValid = ActiveArray != null;
				bool cardsValid = activeValid && ActiveArray.MyCards != null;
				int cardsCount = cardsValid ? System.Linq.Enumerable.Count(ActiveArray.MyCards) : -1;
				UnityEngine.Debug.Log($"[PLAYER-DIAG] MainSceneDemonstrateHeroes getter accessed: arrays.Count={(arrays != null ? arrays.Count : 0)}, ActiveArray!=null={activeValid}, MyCards.Count={cardsCount}");
				if (ActiveArray != null && ActiveArray.MyCards != null)
				{
					List<Hero> list = new List<Hero>();
					foreach (Hero hero in ActiveArray.MyCards)
					{
						if (hero != null)
						{
							list.Add(hero);
						}
					}
					return list;
				}
				return new List<Hero>();
			}
		}

		public virtual bool IsInGuild()
		{
			return false;
		}

		public void SetName(string name)
		{
		}

		public void AddArray(BattleArray a)
		{
			if (a != null && !arrays.Contains(a))
			{
				arrays.Add(a);
				UnityEngine.Debug.Log($"[PLAYER-DIAG] AddArray executed: arrays.Count={arrays.Count}, ActiveArray.MyCards.Count={(a.MyCards != null ? System.Linq.Enumerable.Count(a.MyCards) : 0)}");
			}
		}

		public void PurchCardAddArray(BattleArray a)
		{
		}

		public void ClearArray()
		{
		}

		public void ClearPurpleCardArray()
		{
		}

		public bool HeroInBattleArray(int _localId)
		{
			return false;
		}

		public void FromProto(RankingItemProto proto)
		{
		}

		public static Player CreateFromProto(RankingItemProto proto)
		{
			return null;
		}

		public static Player CreateWithIdentifier(int id = int.MinValue)
		{
			return null;
		}
	}
}
