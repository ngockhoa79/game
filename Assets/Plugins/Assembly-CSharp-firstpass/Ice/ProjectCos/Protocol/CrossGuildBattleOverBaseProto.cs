using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildBattleOverBaseProto")]
	public class CrossGuildBattleOverBaseProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "GuildInfoProto")]
		public class GuildInfoProto : IExtensible
		{
			private string _Name;

			private int _ReamNum;

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

			[ProtoMember(3, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
			public int Icon
			{
				get => _Icon;
				set => _Icon = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "ScoreOfRound1", DataFormat = DataFormat.TwosComplement)]
			public int ScoreOfRound1
			{
				get => _ScoreOfRound1;
				set => _ScoreOfRound1 = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "ScoreOfRound2", DataFormat = DataFormat.TwosComplement)]
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

		private bool _IsWin;

		private int _CurBattleCount;

		private GuildInfoProto _SelfGuildInfo;

		private GuildInfoProto _TargetGuildInfo;

		private int _CurTotalScore;

		private int _Ranking;

		private int _WinCount;

		private int _ContinuouWinCount;

		private int _RewardGuildExp;

		private int _GuildId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsWin", DataFormat = DataFormat.Default)]
		public bool IsWin
		{
			get => _IsWin;
			set => _IsWin = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CurBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int CurBattleCount
		{
			get => _CurBattleCount;
			set => _CurBattleCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "SelfGuildInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto SelfGuildInfo
		{
			get => _SelfGuildInfo;
			set => _SelfGuildInfo = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "TargetGuildInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto TargetGuildInfo
		{
			get => _TargetGuildInfo;
			set => _TargetGuildInfo = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "CurTotalScore", DataFormat = DataFormat.TwosComplement)]
		public int CurTotalScore
		{
			get => _CurTotalScore;
			set => _CurTotalScore = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "WinCount", DataFormat = DataFormat.TwosComplement)]
		public int WinCount
		{
			get => _WinCount;
			set => _WinCount = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "ContinuouWinCount", DataFormat = DataFormat.TwosComplement)]
		public int ContinuouWinCount
		{
			get => _ContinuouWinCount;
			set => _ContinuouWinCount = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "RewardGuildExp", DataFormat = DataFormat.TwosComplement)]
		public int RewardGuildExp
		{
			get => _RewardGuildExp;
			set => _RewardGuildExp = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.TwosComplement)]
		public int GuildId
		{
			get => _GuildId;
			set => _GuildId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
