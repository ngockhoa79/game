using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildPromoteAck")]
	public class S2CGuildPromoteAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IsNotLeader", Value = 2)]
			IsNotLeader = 2,
			[ProtoEnum(Name = "VicePresidentFull", Value = 3)]
			VicePresidentFull = 3,
			[ProtoEnum(Name = "PostionAlready", Value = 4)]
			PostionAlready = 4,
			[ProtoEnum(Name = "TargetIdWrong", Value = 5)]
			TargetIdWrong = 5,
			[ProtoEnum(Name = "NoGuild", Value = 6)]
			NoGuild = 6,
			[ProtoEnum(Name = "ContributiontLess", Value = 7)]
			ContributiontLess = 7,
			[ProtoEnum(Name = "InCd", Value = 8)]
			InCd = 8
		}

		private ResultCode _Code;

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
