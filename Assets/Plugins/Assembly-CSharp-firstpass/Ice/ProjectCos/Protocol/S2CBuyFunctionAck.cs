using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CBuyFunctionAck")]
	public class S2CBuyFunctionAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "MoneyLess", Value = 2)]
			MoneyLess = 2,
			[ProtoEnum(Name = "TimesMax", Value = 3)]
			TimesMax = 3,
			[ProtoEnum(Name = "IsNotExhaustion", Value = 4)]
			IsNotExhaustion = 4,
			[ProtoEnum(Name = "NoGuild", Value = 5)]
			NoGuild = 5
		}

		private ResultCode _Code;

		private int _NewValue;

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

		[ProtoMember(2, IsRequired = true, Name = "NewValue", DataFormat = DataFormat.TwosComplement)]
		public int NewValue
		{
			get => _NewValue;
			set => _NewValue = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
