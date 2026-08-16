using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CornucopiaInfoProto")]
	public class CornucopiaInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			[Serializable]
			[ProtoContract(Name = "DayReward")]
			public class DayReward : IExtensible
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

			[Serializable]
			[ProtoContract(Name = "Slot")]
			public class Slot : IExtensible
			{
				private int _Cost;

				private List<DayReward> _Days;

				private List<ThingProto> _AdditionFullRewards;

				private List<ThingProto> _AdditionJoinRewards;

				private IExtension extensionObject;

				[ProtoMember(1, IsRequired = true, Name = "Cost", DataFormat = DataFormat.TwosComplement)]
				public int Cost
				{
					get => _Cost;
					set => _Cost = value;
				}

				[ProtoMember(2, Name = "Days", DataFormat = DataFormat.Default)]
				public List<DayReward> Days

				{

					get => _Days;

					set => _Days = value;

				}

				[ProtoMember(3, Name = "AdditionFullRewards", DataFormat = DataFormat.Default)]
				public List<ThingProto> AdditionFullRewards

				{

					get => _AdditionFullRewards;

					set => _AdditionFullRewards = value;

				}

				[ProtoMember(4, Name = "AdditionJoinRewards", DataFormat = DataFormat.Default)]
				public List<ThingProto> AdditionJoinRewards

				{

					get => _AdditionJoinRewards;

					set => _AdditionJoinRewards = value;

				}

				IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
			}

			private long _StartTime;

			private long _EndTime;

			private long _EnabelOpenEndTime;

			private List<Slot> _Slots;

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

			[ProtoMember(3, IsRequired = true, Name = "EnabelOpenEndTime", DataFormat = DataFormat.TwosComplement)]
			public long EnabelOpenEndTime
			{
				get => _EnabelOpenEndTime;
				set => _EnabelOpenEndTime = value;
			}

			[ProtoMember(4, Name = "Slots", DataFormat = DataFormat.Default)]
			public List<Slot> Slots

			{

				get => _Slots;

				set => _Slots = value;

			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
			{
				return null;
			}
		}

		private ConfigProto _ConfigInfo;

		private int _SlotIndex;

		private long _OpenSlotTime;

		private int _Mark;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public ConfigProto ConfigInfo
		{
			get => _ConfigInfo;
			set => _ConfigInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SlotIndex", DataFormat = DataFormat.TwosComplement)]
		public int SlotIndex
		{
			get => _SlotIndex;
			set => _SlotIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "OpenSlotTime", DataFormat = DataFormat.TwosComplement)]
		public long OpenSlotTime
		{
			get => _OpenSlotTime;
			set => _OpenSlotTime = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Mark", DataFormat = DataFormat.TwosComplement)]
		public int Mark
		{
			get => _Mark;
			set => _Mark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
