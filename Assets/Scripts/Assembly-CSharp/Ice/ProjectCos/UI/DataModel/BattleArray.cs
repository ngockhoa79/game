using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class BattleArray
	{
		[CompilerGenerated]
		private sealed class _003Cget_MyCards_003Ed__49 : IEnumerable<Hero>, IEnumerable, IEnumerator<Hero>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Hero _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BattleArray _003C_003E4__this;

			private int _003Cr_003E5__2;

			private int _003Cc_003E5__3;

			Hero IEnumerator<Hero>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_MyCards_003Ed__49(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Hero> IEnumerable<Hero>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_OthersCards_003Ed__51 : IEnumerable<Hero>, IEnumerable, IEnumerator<Hero>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Hero _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BattleArray _003C_003E4__this;

			private int _003Cr_003E5__2;

			private int _003Cc_003E5__3;

			Hero IEnumerator<Hero>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_OthersCards_003Ed__51(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Hero> IEnumerable<Hero>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_SupportCards_003Ed__53 : IEnumerable<Hero>, IEnumerable, IEnumerator<Hero>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Hero _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BattleArray _003C_003E4__this;

			private int _003Cr_003E5__2;

			private int _003Cc_003E5__3;

			Hero IEnumerator<Hero>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_SupportCards_003Ed__53(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Hero> IEnumerable<Hero>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Captains_003Ed__94 : IEnumerable<CaptainMisc>, IEnumerable, IEnumerator<CaptainMisc>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private CaptainMisc _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public BattleArray _003C_003E4__this;

			private int _003Cc_003E5__2;

			private int _003Cr_003E5__3;

			CaptainMisc IEnumerator<CaptainMisc>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Captains_003Ed__94(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<CaptainMisc> IEnumerable<CaptainMisc>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public const int EMPTY = -2;

		public const int Source_Index_Mine = 0;

		public const int Source_Index_Supporter = 3;

		public List<Hero[]> array;

		private List<int> captainIndexs;

		private int tempLeaderId;

		private Hero puppetHolder;

		private bool isGettingOffOtherCards;

		private bool isPuppetHoming;

		public List<CaptainMisc> PVEPuppetLeaders;

		public Player Owner { get; private set; }

		public List<int> CaptainIndexs => captainIndexs;

		public int RowCount => 3;

		public int ColumnCount => (array != null) ? array.Count : 0;

		public double AmendedPower { get; set; }

		public Hero get_Item(int row, int column)
		{
			if (array != null && column >= 0 && column < array.Count)
			{
				Hero[] colArr = array[column];
				if (colArr != null && row >= 0 && row < colArr.Length)
				{
					return colArr[row];
				}
			}
			return null;
		}

		public void set_Item(int row, int column, Hero value)
		{
			setColumnCount(column + 1);
			if (array != null && column >= 0 && column < array.Count)
			{
				Hero[] colArr = array[column];
				if (colArr != null && row >= 0 && row < colArr.Length)
				{
					colArr[row] = value;
				}
			}
		}

		public int CardCount => System.Linq.Enumerable.Count(MyCards);

		public int MyCardCount => System.Linq.Enumerable.Count(MyCards);

		public int OthersCardCount => 0;

		public IEnumerable<Hero> MyCards
		{
			get
			{
				if (array != null)
				{
					for (int c = 0; c < array.Count; c++)
					{
						Hero[] colArr = array[c];
						if (colArr != null)
						{
							for (int r = 0; r < colArr.Length; r++)
							{
								Hero h = colArr[r];
								if (h != null && (h.Owner == null || h.Owner == Owner || Owner == null))
								{
									yield return h;
								}
							}
						}
					}
				}
			}
		}

		public IEnumerable<Hero> OthersCards
		{
			[IteratorStateMachine(typeof(_003Cget_OthersCards_003Ed__51))]
			get
			{
				return null;
			}
		}

		public IEnumerable<Hero> SupportCards
		{
			[IteratorStateMachine(typeof(_003Cget_SupportCards_003Ed__53))]
			get
			{
				return null;
			}
		}

		public bool RedDot => false;

		public int OpenedSlotsCount => 0;

		public int Power => 0;

		public Hero Captain => null;

		public IEnumerable<CaptainMisc> Captains
		{
			[IteratorStateMachine(typeof(_003Cget_Captains_003Ed__94))]
			get
			{
				return null;
			}
		}

		public int CaptainsCount => 0;

		public int ActiveCaptainsCount => 0;

		public event Action<BattleArray, int, int, Hero> OnArrayChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<BattleArray, CaptainMisc, CaptainMisc> OnLeaderChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public BattleArray(Player owner)
		{
			Owner = owner;
			array = new List<Hero[]>();
			captainIndexs = new List<int>();
			setColumnCount(3);
		}

		public void RemoveColumnAt(int index)
		{
		}

		public bool IsColumnEmpty(int index)
		{
			return false;
		}

		public void AddColumn(int newColumnCount, CaptainIndexsType t, BattleArray ary, int local = -2, BattleFormationProto proto = null)
		{
		}

		private void setColumnCount(int newColumnCount)
		{
			if (array == null)
			{
				array = new List<Hero[]>();
			}
			while (array.Count < newColumnCount)
			{
				array.Add(new Hero[3]);
			}
		}

		public bool FindHero(Hero hero, out int row, out int column)
		{
			row = default(int);
			column = default(int);
			return false;
		}

		private bool findHero(int local, out int row, out int column)
		{
			row = default(int);
			column = default(int);
			return false;
		}

		public bool FindHeroByLocalID(Hero hero, out int row, out int column)
		{
			row = default(int);
			column = default(int);
			return false;
		}

		public bool Contains(Hero hero)
		{
			return false;
		}

		public void GetOffOthersCards()
		{
		}

		public void GetOffSupportersCards()
		{
		}

		public BattleArray GetOff(Hero hero)
		{
			return null;
		}

		private bool hasRedDot(Hero h)
		{
			return false;
		}

		public bool IsThirdColumnAvailable(out int level)
		{
			level = default(int);
			return false;
		}

		public static BattleArray CopyBattleArray(BattleArray from)
		{
			return null;
		}

		public static BattleArrayMisc CreateMachineArray(int formationID, int columns, string displayName)
		{
			return null;
		}

		public void Swap(int arow, int acol, int brow, int bcol)
		{
		}

		public Hero SwapOutPuppet(int row, int col, Hero puppet)
		{
			return null;
		}

		public void PuppetHoming()
		{
		}

		private bool checkCaptainMark(Hero hero)
		{
			return false;
		}

		private Hero resetCaptain()
		{
			return null;
		}

		public void MakeHeroesLevelZero()
		{
		}

		public void S2C(int serverSideIndex, out int row, out int column)
		{
			row = default(int);
			column = default(int);
		}

		public int C2S(int row, int column)
		{
			return 0;
		}

		// [STRUCTURAL-RECONSTRUCTION]
		// Native method exists in dump.cs TypeDefIndex 7692.
		// AssetRipper produced `return null;`.
		public static BattleArray CreateFromProto(PlayerFormationItemInfoProto proto)
		{
			if (proto == null) return null;
			BattleArray battleArray = new BattleArray(null);
			battleArray.fromProto(proto);
			return battleArray;
		}

		private void fromProto(PlayerFormationItemInfoProto proto)
		{
			if (proto == null) return;

			setColumnCount(3);

			if (proto.HerosIndexList != null)
			{
				for (int col = 0; col < 3; col++)
				{
					for (int row = 0; row < 3; row++)
					{
						int index = row + col * 3;
						if (index < proto.HerosIndexList.Count)
						{
							int localId = proto.HerosIndexList[index];
							if (localId > 0)
							{
								Hero hero = null;
								if (Me.Ins != null && Me.Ins.HeroList != null)
								{
									hero = Me.Ins.HeroList.FindByLocalID(localId);
								}
								if (hero == null)
								{
									HeroConfig config = HeroConfig.Get(localId);
									if (config != null)
									{
										hero = new Hero(config, Owner ?? Me.Ins, localId);
										if (Me.Ins != null && Me.Ins.HeroList != null)
										{
											Me.Ins.HeroList.AddHero(hero, true);
										}
									}
								}
								if (hero != null)
								{
									set_Item(row, col, hero);
								}
							}
						}
					}
				}
			}

			if (proto.LeaderHeroIndexs != null)
			{
				List<int> leaders = eliminate(proto.LeaderHeroIndexs);
				resolveLeaders(leaders);
			}
		}

		private void resolveLeaders(List<int> leaders)
		{
		}

		private List<int> eliminate(List<int> leaders)
		{
			return null;
		}

		private List<int> makeup(List<int> leaders)
		{
			return null;
		}

		public PlayerFormationItemInfoProto ToProto()
		{
			return null;
		}

		public List<Hero> ProtoToHeroes(BattleFormationProto proto)
		{
			return null;
		}

		private List<int> congregateCaptainIndexs(BattleFormationProto proto)
		{
			return null;
		}

		public static BattleArray CreateFromProto(BattleFormationProto proto, bool duplicateMe = false)
		{
			return null;
		}

		public BattleArray AddOrReplace(Hero former, int src, Hero latter)
		{
			return null;
		}

		public bool IsSimilarTo(BattleArray other)
		{
			return false;
		}

		public void Promote(Hero hero)
		{
		}

		private void demote(Hero hero)
		{
		}

		private CaptainStatus resolveRole(Hero hero)
		{
			return default(CaptainStatus);
		}

		public Hero ActiveCaptain(int column)
		{
			return null;
		}

		public Hero Supporter(int column)
		{
			return null;
		}

		public bool IsCaptain(Hero hero)
		{
			return false;
		}

		public bool IsActiveCaptain(Hero hero)
		{
			return false;
		}

		private bool isNeedResetWhenGetOff(Hero hero)
		{
			return false;
		}

		public bool IsSupporterUpSideDown(int columnIndex)
		{
			return false;
		}

		private void shiftCaptainIndexs(int former, int latter)
		{
		}

		public bool HasFront(int r, int c)
		{
			return false;
		}
	}
}
