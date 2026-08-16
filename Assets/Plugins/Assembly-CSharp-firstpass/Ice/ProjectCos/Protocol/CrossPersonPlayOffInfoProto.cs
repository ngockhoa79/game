using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonPlayOffInfoProto")]
	public class CrossPersonPlayOffInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "FighterProto")]
		public class FighterProto : IExtensible
		{
			private CrossPlayerSummaryInfoProto _Summary;

			private BattleFormationProto _Formation;

			private int _WinCount;

			private int _BeBetCount;

			private string _Id;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
			public CrossPlayerSummaryInfoProto Summary
			{
				get => _Summary;
				set => _Summary = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
			public BattleFormationProto Formation
			{
				get => _Formation;
				set => _Formation = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "WinCount", DataFormat = DataFormat.TwosComplement)]
			public int WinCount
			{
				get => _WinCount;
				set => _WinCount = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "BeBetCount", DataFormat = DataFormat.TwosComplement)]
			public int BeBetCount
			{
				get => _BeBetCount;
				set => _BeBetCount = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Id", DataFormat = DataFormat.Default)]
			public string Id
			{
				get => _Id;
				set => _Id = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "BattleOnceProto")]
		public class BattleOnceProto : IExtensible
		{
			private FighterProto _Left;

			private FighterProto _Right;

			private BattleStatusEnum _Status;

			private bool _IsLeftWin;

			private BetStatusEnum _IsBet;

			private List<bool> _Results;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Left", DataFormat = DataFormat.Default)]
			public FighterProto Left
			{
				get => _Left;
				set => _Left = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Right", DataFormat = DataFormat.Default)]
			public FighterProto Right
			{
				get => _Right;
				set => _Right = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
			public BattleStatusEnum Status
			{
				get
				{
					return default(BattleStatusEnum);
				}
				set
				{
				}
			}

			[ProtoMember(4, IsRequired = true, Name = "IsLeftWin", DataFormat = DataFormat.Default)]
			public bool IsLeftWin
			{
				get => _IsLeftWin;
				set => _IsLeftWin = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "IsBet", DataFormat = DataFormat.TwosComplement)]
			public BetStatusEnum IsBet
			{
				get
				{
					return default(BetStatusEnum);
				}
				set
				{
				}
			}

			[ProtoMember(6, Name = "Results", DataFormat = DataFormat.Default)]
			public List<bool> Results

			{

				get => _Results;

				set => _Results = value;

			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "BattleStatusEnum")]
		public enum BattleStatusEnum
		{
			[ProtoEnum(Name = "Pre", Value = 0)]
			Pre = 0,
			[ProtoEnum(Name = "Fighting", Value = 1)]
			Fighting = 1,
			[ProtoEnum(Name = "Over", Value = 2)]
			Over = 2
		}

		[ProtoContract(Name = "BetStatusEnum")]
		public enum BetStatusEnum
		{
			[ProtoEnum(Name = "None", Value = 0)]
			None = 0,
			[ProtoEnum(Name = "Left", Value = 1)]
			Left = 1,
			[ProtoEnum(Name = "Right", Value = 2)]
			Right = 2
		}

		private List<BattleOnceProto> _Battles;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Battles", DataFormat = DataFormat.Default)]
		public List<BattleOnceProto> Battles

		{

			get => _Battles;

			set => _Battles = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
