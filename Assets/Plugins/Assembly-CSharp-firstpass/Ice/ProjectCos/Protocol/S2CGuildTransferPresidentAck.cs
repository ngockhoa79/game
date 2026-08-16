using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildTransferPresidentAck")]
	public class S2CGuildTransferPresidentAck : IExtensible
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
			[ProtoEnum(Name = "TargetIsNotVicePresident", Value = 3)]
			TargetIsNotVicePresident = 3,
			[ProtoEnum(Name = "NoGuild", Value = 4)]
			NoGuild = 4,
			[ProtoEnum(Name = "InCd", Value = 5)]
			InCd = 5,
			[ProtoEnum(Name = "TargetInCd", Value = 6)]
			TargetInCd = 6
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
