using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CDuplicateBuyLimitTimesAck")]
	public class S2CDuplicateBuyLimitTimesAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "DuplicateUsedIsNotMax", Value = 3)]
			DuplicateUsedIsNotMax = 3,
			[ProtoEnum(Name = "BuyTimesIsMax", Value = 4)]
			BuyTimesIsMax = 4,
			[ProtoEnum(Name = "MoneyLess", Value = 5)]
			MoneyLess = 5
		}

		private ResultCode _Code;

		private int _AlreadyBuyTimes;

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

		[ProtoMember(2, IsRequired = true, Name = "AlreadyBuyTimes", DataFormat = DataFormat.TwosComplement)]
		public int AlreadyBuyTimes
		{
			get => _AlreadyBuyTimes;
			set => _AlreadyBuyTimes = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
