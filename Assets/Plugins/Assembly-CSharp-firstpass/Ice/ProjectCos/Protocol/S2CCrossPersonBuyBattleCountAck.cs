using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCrossPersonBuyBattleCountAck")]
	public class S2CCrossPersonBuyBattleCountAck : IExtensible
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
			[ProtoEnum(Name = "HasRemainBattleCount", Value = 4)]
			HasRemainBattleCount = 4,
			[ProtoEnum(Name = "BuyMaxCount", Value = 5)]
			BuyMaxCount = 5,
			[ProtoEnum(Name = "MoneyLess", Value = 6)]
			MoneyLess = 6
		}

		private ResultCode _Code;

		private int _RemainBattleCount;

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

		[ProtoMember(2, IsRequired = true, Name = "RemainBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int RemainBattleCount
		{
			get => _RemainBattleCount;
			set => _RemainBattleCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
