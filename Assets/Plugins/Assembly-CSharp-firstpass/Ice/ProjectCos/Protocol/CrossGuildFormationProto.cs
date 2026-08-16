using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildFormationProto")]
	public class CrossGuildFormationProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "GuildInfoProto")]
		public class GuildInfoProto : IExtensible
		{
			private string _Name;

			private int _ReamNum;

			private int _WinCount;

			private int _Icon;

			private int _ScoreOfRound1;

			private int _ScoreOfRound2;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "ReamNum", DataFormat = DataFormat.TwosComplement)]
			public int ReamNum
			{
				get => _ReamNum;
				set => _ReamNum = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "WinCount", DataFormat = DataFormat.TwosComplement)]
			public int WinCount
			{
				get => _WinCount;
				set => _WinCount = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
			public int Icon
			{
				get => _Icon;
				set => _Icon = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "ScoreOfRound1", DataFormat = DataFormat.TwosComplement)]
			public int ScoreOfRound1
			{
				get => _ScoreOfRound1;
				set => _ScoreOfRound1 = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "ScoreOfRound2", DataFormat = DataFormat.TwosComplement)]
			public int ScoreOfRound2
			{
				get => _ScoreOfRound2;
				set => _ScoreOfRound2 = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[ProtoContract(Name = "LineResultEnum")]
		public enum LineResultEnum
		{
			[ProtoEnum(Name = "Lose", Value = 0)]
			Lose = 0,
			[ProtoEnum(Name = "WinAndPiece", Value = 1)]
			WinAndPiece = 1,
			[ProtoEnum(Name = "WinNoPiece", Value = 2)]
			WinNoPiece = 2
		}

		private CrossGuildFormationBinaryDataProto _ForamtionData;

		private int _RowIndexOfSelf;

		private int _ColunmIndexOfSelf;

		private bool _IsDeadAlready;

		private CrossGuildInfoProto.StatusEnum _Status;

		private long _OverTime;

		private GuildInfoProto _SelfGuildInfo;

		private GuildInfoProto _TargetGuildInfo;

		private long _LastBattleTime;

		private List<LineResultEnum> _LastLineReslutInfos;

		private int _ReliveCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ForamtionData", DataFormat = DataFormat.Default)]
		public CrossGuildFormationBinaryDataProto ForamtionData
		{
			get => _ForamtionData;
			set => _ForamtionData = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RowIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
		public int RowIndexOfSelf
		{
			get => _RowIndexOfSelf;
			set => _RowIndexOfSelf = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ColunmIndexOfSelf", DataFormat = DataFormat.TwosComplement)]
		public int ColunmIndexOfSelf
		{
			get => _ColunmIndexOfSelf;
			set => _ColunmIndexOfSelf = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsDeadAlready", DataFormat = DataFormat.Default)]
		public bool IsDeadAlready
		{
			get => _IsDeadAlready;
			set => _IsDeadAlready = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public CrossGuildInfoProto.StatusEnum Status
		{
			get
			{
				return default(CrossGuildInfoProto.StatusEnum);
			}
			set
			{
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
		public long OverTime
		{
			get => _OverTime;
			set => _OverTime = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "SelfGuildInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto SelfGuildInfo
		{
			get => _SelfGuildInfo;
			set => _SelfGuildInfo = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "TargetGuildInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto TargetGuildInfo
		{
			get => _TargetGuildInfo;
			set => _TargetGuildInfo = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "LastBattleTime", DataFormat = DataFormat.TwosComplement)]
		public long LastBattleTime
		{
			get => _LastBattleTime;
			set => _LastBattleTime = value;
		}

		[ProtoMember(10, Name = "LastLineReslutInfos", DataFormat = DataFormat.TwosComplement)]
		public List<LineResultEnum> LastLineReslutInfos

		{

			get => _LastLineReslutInfos;

			set => _LastLineReslutInfos = value;

		}

		[ProtoMember(11, IsRequired = true, Name = "ReliveCount", DataFormat = DataFormat.TwosComplement)]
		public int ReliveCount
		{
			get => _ReliveCount;
			set => _ReliveCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
