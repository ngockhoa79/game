using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonPlayOffBetAck")]
	public class S2CCrossPersonPlayOffBetAck : IExtensible
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
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4,
			[ProtoEnum(Name = "IndexError", Value = 5)]
			IndexError = 5,
			[ProtoEnum(Name = "StatusNotMatch", Value = 6)]
			StatusNotMatch = 6,
			[ProtoEnum(Name = "IsAlreayBet", Value = 7)]
			IsAlreayBet = 7
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
