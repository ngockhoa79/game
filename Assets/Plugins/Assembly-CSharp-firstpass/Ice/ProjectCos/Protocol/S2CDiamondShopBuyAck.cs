using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CDiamondShopBuyAck")]
	public class S2CDiamondShopBuyAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "IdError", Value = 2)]
			IdError = 2,
			[ProtoEnum(Name = "CountError", Value = 3)]
			CountError = 3,
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4,
			[ProtoEnum(Name = "TimesLess", Value = 5)]
			TimesLess = 5,
			[ProtoEnum(Name = "VipLess", Value = 6)]
			VipLess = 6
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
