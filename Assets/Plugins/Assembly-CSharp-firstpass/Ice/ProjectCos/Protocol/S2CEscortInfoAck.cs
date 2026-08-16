using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortInfoAck")]
	public class S2CEscortInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2
		}

		private ResultCode _Code;

		private EscortPlayerInfoProto _Info;

		private List<EscortTargetProto> _TargetItems;

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

		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public EscortPlayerInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		[ProtoMember(3, Name = "TargetItems", DataFormat = DataFormat.Default)]
		public List<EscortTargetProto> TargetItems

		{

			get => _TargetItems;

			set => _TargetItems = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
