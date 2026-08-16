using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CShopPveStartBattleAck")]
	public class S2CShopPveStartBattleAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "ShopIdError", Value = 2)]
			ShopIdError = 2,
			[ProtoEnum(Name = "NotAppearError", Value = 3)]
			NotAppearError = 3,
			[ProtoEnum(Name = "AlreadyIsOpenError", Value = 4)]
			AlreadyIsOpenError = 4
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

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

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
