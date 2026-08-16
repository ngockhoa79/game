using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRegNewUserAck")]
	public class S2CRegNewUserAck : IExtensible
	{
		[ProtoContract(Name = "ResultTypeCode")]
		public enum ResultTypeCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NameAlreadyUsed", Value = 2)]
			NameAlreadyUsed = 2,
			[ProtoEnum(Name = "HasSensitiveWord", Value = 3)]
			HasSensitiveWord = 3,
			[ProtoEnum(Name = "NameIsTooLong", Value = 4)]
			NameIsTooLong = 4
		}

		private ResultTypeCode _Result;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public ResultTypeCode Result
		{
			get
			{
				return default(ResultTypeCode);
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
