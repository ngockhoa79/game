using System;
using System.Runtime.CompilerServices;

namespace Ice.ProjectCos.UI.DataModel
{
	public class GearHolding : EquipableItemHolding
	{
		public class RefineInfo
		{
			public int MajorAdditionalValue;

			public bool MinorBufLock1;

			public bool MinorBufLock2;

			public EAttrType MinorBuf1;

			public EAttrType MinorBuf2;

			public int MinorBuf1Value;

			public int MinorBuf2Value;
		}

		private int level;

		private int refineLevel;

		public int MajorBufValue;

		public int MajorAdditionalValue;

		public EAttrType MinorBuf1;

		public EAttrType MinorBuf2;

		public int MinorBuf1Value;

		public int MinorBuf2Value;

		public RefineInfo PrevRefineInfo;

		public bool IsRefineReturnable;

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxLevel => 0;

		public int RefineLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxRefineLevel => 0;

		public int MajorValue => 0;

		public Gear Gear => null;

		public int LevelupCostGold { get; set; }

		public override int SellingPrice => 0;

		public event Action<GearHolding, int, int> OnLevelChanged
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

		public GearHolding(Gear gear, int localID, int count = 1)
			: base(null, 0, 0)
		{
		}

		public override void AddToMe()
		{
		}
	}
}
