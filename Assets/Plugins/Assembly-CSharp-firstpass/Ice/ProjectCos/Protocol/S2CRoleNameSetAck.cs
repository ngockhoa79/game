using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRoleNameSetAck")]
	public class S2CRoleNameSetAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "AlreadyUsed", Value = 2)]
			AlreadyUsed = 2,
			[ProtoEnum(Name = "HasSensitiveWord", Value = 3)]
			HasSensitiveWord = 3,
			[ProtoEnum(Name = "IsTooLong", Value = 4)]
			IsTooLong = 4,
			[ProtoEnum(Name = "IsSame", Value = 5)]
			IsSame = 5,
			[ProtoEnum(Name = "MoneyLess", Value = 6)]
			MoneyLess = 6,
			[ProtoEnum(Name = "LevelLess", Value = 7)]
			LevelLess = 7
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
