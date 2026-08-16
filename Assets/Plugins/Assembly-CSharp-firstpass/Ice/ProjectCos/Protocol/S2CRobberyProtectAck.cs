using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRobberyProtectAck")]
	public class S2CRobberyProtectAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "AlreadyProtect", Value = 2)]
			AlreadyProtect = 2,
			[ProtoEnum(Name = "MoneLess", Value = 3)]
			MoneLess = 3,
			[ProtoEnum(Name = "CoutMax", Value = 4)]
			CoutMax = 4,
			[ProtoEnum(Name = "IdError", Value = 5)]
			IdError = 5
		}

		private ResultCode _Code;

		private long _OverTime;

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
}
