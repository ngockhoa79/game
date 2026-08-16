using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "OperateProto")]
	public class OperateProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "OpenInfoProto")]
		public class OpenInfoProto : IExtensible
		{
			private int _Type;

			private long _OverTime;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
			public int Type
			{
				get => _Type;
				set => _Type = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
			public long OverTime
			{
				get => _OverTime;
				set => _OverTime = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		[Serializable]
		[ProtoContract(Name = "OpenServerActivityProto")]
		public class OpenServerActivityProto : IExtensible
		{
			private long _OpenTime;

			private int _RewardMark;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "OpenTime", DataFormat = DataFormat.TwosComplement)]
			public long OpenTime
			{
				get => _OpenTime;
				set => _OpenTime = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "RewardMark", DataFormat = DataFormat.TwosComplement)]
			public int RewardMark
			{
				get => _RewardMark;
				set => _RewardMark = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _GrowingIndexMark;

		private List<OpenInfoProto> _OpenInfos;

		private OpenServerActivityProto _OpenServerActivityInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GrowingIndexMark", DataFormat = DataFormat.TwosComplement)]
		public int GrowingIndexMark
		{
			get => _GrowingIndexMark;
			set => _GrowingIndexMark = value;
		}

		[ProtoMember(2, Name = "OpenInfos", DataFormat = DataFormat.Default)]
		public List<OpenInfoProto> OpenInfos

		{

			get => _OpenInfos;

			set => _OpenInfos = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "OpenServerActivityInfo", DataFormat = DataFormat.Default)]
		public OpenServerActivityProto OpenServerActivityInfo
		{
			get => _OpenServerActivityInfo;
			set => _OpenServerActivityInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
