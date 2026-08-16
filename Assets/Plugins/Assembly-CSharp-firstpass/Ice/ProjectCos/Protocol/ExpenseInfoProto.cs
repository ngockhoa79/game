using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ExpenseInfoProto")]
	public class ExpenseInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			[Serializable]
			[ProtoContract(Name = "Slot")]
			public class Slot : IExtensible
			{
				private int _Count;

				private List<ThingProto> _Rewards;

				private IExtension extensionObject;

				[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
				public int Count
				{
					get => _Count;
					set => _Count = value;
				}

				[ProtoMember(2, Name = "Rewards", DataFormat = DataFormat.Default)]
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

			[ProtoMember(3, Name = "Slots", DataFormat = DataFormat.Default)]
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

		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2,
			[ProtoEnum(Name = "OutOfPickRange", Value = 3)]
			OutOfPickRange = 3,
			[ProtoEnum(Name = "CostNotEnough", Value = 4)]
			CostNotEnough = 4,
			[ProtoEnum(Name = "AlreadyPick", Value = 5)]
			AlreadyPick = 5
		}

		private ConfigProto _ConfigInfo;

		private int _IndexMark;

		private int _TotalCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public ConfigProto ConfigInfo
		{
			get => _ConfigInfo;
			set => _ConfigInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IndexMark", DataFormat = DataFormat.TwosComplement)]
		public int IndexMark
		{
			get => _IndexMark;
			set => _IndexMark = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "TotalCount", DataFormat = DataFormat.TwosComplement)]
		public int TotalCount
		{
			get => _TotalCount;
			set => _TotalCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
