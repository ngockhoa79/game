using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "BigWheelInfoProto")]
	public class BigWheelInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			[Serializable]
			[ProtoContract(Name = "ScoreItemProto")]
			public class ScoreItemProto : IExtensible
			{
				private ThingProto _Item;

				private int _Score;

				private IExtension extensionObject;

				[ProtoMember(1, IsRequired = true, Name = "Item", DataFormat = DataFormat.Default)]
				public ThingProto Item
				{
					get => _Item;
					set => _Item = value;
				}

				[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
				public int Score
				{
					get => _Score;
					set => _Score = value;
				}

				IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
			}

			private long _StartTime;

			private long _EndTime;

			private List<ThingProto> _Rewards;

			private int _Score;

			private List<ScoreItemProto> _ScoreItems;

			private int _PayTenCost;

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

			[ProtoMember(3, Name = "Rewards", DataFormat = DataFormat.Default)]
			public List<ThingProto> Rewards

			{

				get => _Rewards;

				set => _Rewards = value;

			}

			[ProtoMember(4, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
			public int Score
			{
				get => _Score;
				set => _Score = value;
			}

			[ProtoMember(5, Name = "ScoreItems", DataFormat = DataFormat.Default)]
			public List<ScoreItemProto> ScoreItems

			{

				get => _ScoreItems;

				set => _ScoreItems = value;

			}

			[ProtoMember(6, IsRequired = true, Name = "PayTenCost", DataFormat = DataFormat.TwosComplement)]
			public int PayTenCost
			{
				get => _PayTenCost;
				set => _PayTenCost = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		[Serializable]
		[ProtoContract(Name = "RecordProto")]
		public class RecordProto : IExtensible
		{
			private string _Name;

			private ThingProto _Reward;

			private bool _IsBigReward;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Reward", DataFormat = DataFormat.Default)]
			public ThingProto Reward
			{
				get => _Reward;
				set => _Reward = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "IsBigReward", DataFormat = DataFormat.Default)]
			public bool IsBigReward
			{
				get => _IsBigReward;
				set => _IsBigReward = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		private ConfigProto _ConfigInfo;

		private long _NextFreeTime;

		private int _GrandTotal;

		private List<RecordProto> _Records;

		private int _NextPayCost;

		private int _Score;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public ConfigProto ConfigInfo
		{
			get => _ConfigInfo;
			set => _ConfigInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "NextFreeTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeTime
		{
			get => _NextFreeTime;
			set => _NextFreeTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "GrandTotal", DataFormat = DataFormat.TwosComplement)]
		public int GrandTotal
		{
			get => _GrandTotal;
			set => _GrandTotal = value;
		}

		[ProtoMember(4, Name = "Records", DataFormat = DataFormat.Default)]
		public List<RecordProto> Records

		{

			get => _Records;

			set => _Records = value;

		}

		[ProtoMember(5, IsRequired = true, Name = "NextPayCost", DataFormat = DataFormat.TwosComplement)]
		public int NextPayCost
		{
			get => _NextPayCost;
			set => _NextPayCost = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
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
}
