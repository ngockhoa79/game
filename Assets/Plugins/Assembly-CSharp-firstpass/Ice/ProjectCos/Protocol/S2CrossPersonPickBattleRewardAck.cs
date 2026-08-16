using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CrossPersonPickBattleRewardAck")]
	public class S2CrossPersonPickBattleRewardAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2,
			[ProtoEnum(Name = "LevelLess", Value = 3)]
			LevelLess = 3,
			[ProtoEnum(Name = "PickNotEnbable", Value = 4)]
			PickNotEnbable = 4
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private ThingProto _ShowItem1;

		private ThingProto _ShowItem2;

		private ThingProto _ShowItem3;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "ShowItem1", DataFormat = DataFormat.Default)]
		public ThingProto ShowItem1
		{
			get => _ShowItem1;
			set => _ShowItem1 = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ShowItem2", DataFormat = DataFormat.Default)]
		public ThingProto ShowItem2
		{
			get => _ShowItem2;
			set => _ShowItem2 = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "ShowItem3", DataFormat = DataFormat.Default)]
		public ThingProto ShowItem3
		{
			get => _ShowItem3;
			set => _ShowItem3 = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
