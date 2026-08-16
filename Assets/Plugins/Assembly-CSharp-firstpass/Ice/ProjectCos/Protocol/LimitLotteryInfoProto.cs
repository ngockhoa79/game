using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LimitLotteryInfoProto")]
	public class LimitLotteryInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			[Serializable]
			[ProtoContract(Name = "RankingReward")]
			public class RankingReward : IExtensible
			{
				private int _Min;

				private int _Max;

				private List<ThingProto> _Rewards;

				private IExtension extensionObject;

				[ProtoMember(1, IsRequired = true, Name = "Min", DataFormat = DataFormat.TwosComplement)]
				public int Min
				{
					get => _Min;
					set => _Min = value;
				}

				[ProtoMember(2, IsRequired = true, Name = "Max", DataFormat = DataFormat.TwosComplement)]
				public int Max
				{
					get => _Max;
					set => _Max = value;
				}

				[ProtoMember(3, Name = "Rewards", DataFormat = DataFormat.Default)]
				public List<ThingProto> Rewards

				{

					get => _Rewards;

					set => _Rewards = value;

				}

				IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
			}

			private long _StartTime;

			private long _EndTime;

			private List<RankingReward> _RankingRewards;

			private List<int> _Heros;

			private int _FreePerScore;

			private int _Cost;

			private int _CostAdvance;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "StartTime", DataFormat = DataFormat.TwosComplement)]
			public long StartTime
			{
				get => _StartTime;
				set => _StartTime = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "EndTime", DataFormat = DataFormat.TwosComplement)]
			public long EndTime
			{
				get => _EndTime;
				set => _EndTime = value;
			}

			[ProtoMember(3, Name = "RankingRewards", DataFormat = DataFormat.Default)]
			public List<RankingReward> RankingRewards

			{

				get => _RankingRewards;

				set => _RankingRewards = value;

			}

			[ProtoMember(4, Name = "Heros", DataFormat = DataFormat.TwosComplement)]
			public List<int> Heros

			{

				get => _Heros;

				set => _Heros = value;

			}

			[ProtoMember(5, IsRequired = true, Name = "FreePerScore", DataFormat = DataFormat.TwosComplement)]
			public int FreePerScore
			{
				get => _FreePerScore;
				set => _FreePerScore = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "Cost", DataFormat = DataFormat.TwosComplement)]
			public int Cost
			{
				get => _Cost;
				set => _Cost = value;
			}

			[ProtoMember(7, IsRequired = true, Name = "CostAdvance", DataFormat = DataFormat.TwosComplement)]
			public int CostAdvance
			{
				get => _CostAdvance;
				set => _CostAdvance = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		[Serializable]
		[ProtoContract(Name = "RankingInfoProto")]
		public class RankingInfoProto : IExtensible
		{
			private string _Name;

			private int _Score;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
			public int Score
			{
				get => _Score;
				set => _Score = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		private int _Score;

		private int _ScoreFreeEnableCount;

		private long _NextFreeTime;

		private int _RaningValue;

		private List<RankingInfoProto> _Rankings;

		private int _TryMustGetPurpleCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get => _Score;
			set => _Score = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ScoreFreeEnableCount", DataFormat = DataFormat.TwosComplement)]
		public int ScoreFreeEnableCount
		{
			get => _ScoreFreeEnableCount;
			set => _ScoreFreeEnableCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "NextFreeTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeTime
		{
			get => _NextFreeTime;
			set => _NextFreeTime = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "RaningValue", DataFormat = DataFormat.TwosComplement)]
		public int RaningValue
		{
			get => _RaningValue;
			set => _RaningValue = value;
		}

		[ProtoMember(5, Name = "Rankings", DataFormat = DataFormat.Default)]
		public List<RankingInfoProto> Rankings

		{

			get => _Rankings;

			set => _Rankings = value;

		}

		[ProtoMember(6, IsRequired = true, Name = "TryMustGetPurpleCount", DataFormat = DataFormat.TwosComplement)]
		public int TryMustGetPurpleCount
		{
			get => _TryMustGetPurpleCount;
			set => _TryMustGetPurpleCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
