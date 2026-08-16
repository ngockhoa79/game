using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GoddessGrailInfoProto")]
	public class GoddessGrailInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			[Serializable]
			[ProtoContract(Name = "CountReward")]
			public class CountReward : IExtensible
			{
				private List<ThingProto> _Rewards;

				private IExtension extensionObject;

				[ProtoMember(1, Name = "Rewards", DataFormat = DataFormat.Default)]
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

			private List<CountReward> _TotalGrailReward;

			private int _ClickCount;

			private int _Interval;

			private int _DayCount;

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

			[ProtoMember(3, Name = "TotalGrailReward", DataFormat = DataFormat.Default)]
			public List<CountReward> TotalGrailReward

			{

				get => _TotalGrailReward;

				set => _TotalGrailReward = value;

			}

			[ProtoMember(4, IsRequired = true, Name = "ClickCount", DataFormat = DataFormat.TwosComplement)]
			public int ClickCount
			{
				get => _ClickCount;
				set => _ClickCount = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Interval", DataFormat = DataFormat.TwosComplement)]
			public int Interval
			{
				get => _Interval;
				set => _Interval = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "DayCount", DataFormat = DataFormat.TwosComplement)]
			public int DayCount
			{
				get => _DayCount;
				set => _DayCount = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		private int _Count;

		private long _NextReceivedTime;

		private int _TotalRewardState;

		private int _DayCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "NextReceivedTime", DataFormat = DataFormat.TwosComplement)]
		public long NextReceivedTime
		{
			get => _NextReceivedTime;
			set => _NextReceivedTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "TotalRewardState", DataFormat = DataFormat.TwosComplement)]
		public int TotalRewardState
		{
			get => _TotalRewardState;
			set => _TotalRewardState = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "DayCount", DataFormat = DataFormat.TwosComplement)]
		public int DayCount
		{
			get => _DayCount;
			set => _DayCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
