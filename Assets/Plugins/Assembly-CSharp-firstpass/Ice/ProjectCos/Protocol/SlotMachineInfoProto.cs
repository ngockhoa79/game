using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "SlotMachineInfoProto")]
	public class SlotMachineInfoProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "ConfigProto")]
		public class ConfigProto : IExtensible
		{
			private long _StartTime;

			private long _EndTime;

			private string _RatioMin;

			private string _RatioMax;

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

			[ProtoMember(3, IsRequired = true, Name = "RatioMin", DataFormat = DataFormat.Default)]
			public string RatioMin
			{
				get => _RatioMin;
				set => _RatioMin = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "RatioMax", DataFormat = DataFormat.Default)]
			public string RatioMax
			{
				get => _RatioMax;
				set => _RatioMax = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "RecordProto")]
		public class RecordProto : IExtensible
		{
			private string _Name;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<int> _Slots;

		private int _Index;

		private ConfigProto _ConfigInfo;

		private List<RecordProto> _Records;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Slots", DataFormat = DataFormat.TwosComplement)]
		public List<int> Slots

		{

			get => _Slots;

			set => _Slots = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get => _Index;
			set => _Index = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ConfigInfo", DataFormat = DataFormat.Default)]
		public ConfigProto ConfigInfo
		{
			get => _ConfigInfo;
			set => _ConfigInfo = value;
		}

		[ProtoMember(5, Name = "Records", DataFormat = DataFormat.Default)]
		public List<RecordProto> Records

		{

			get => _Records;

			set => _Records = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
