using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonTargetAck")]
	public class S2CCrossPersonTargetAck : IExtensible
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
			[ProtoEnum(Name = "InCd", Value = 4)]
			InCd = 4,
			[ProtoEnum(Name = "ForceChangeButNoTarget", Value = 5)]
			ForceChangeButNoTarget = 5
		}

		private ResultCode _Code;

		private List<CrossPersonTargetInfoProto> _Targets;

		private long _ChangeTargetFreeOverTime;

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

		[ProtoMember(2, Name = "Targets", DataFormat = DataFormat.Default)]
		public List<CrossPersonTargetInfoProto> Targets

		{

			get => _Targets;

			set => _Targets = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "ChangeTargetFreeOverTime", DataFormat = DataFormat.TwosComplement)]
		public long ChangeTargetFreeOverTime
		{
			get => _ChangeTargetFreeOverTime;
			set => _ChangeTargetFreeOverTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
