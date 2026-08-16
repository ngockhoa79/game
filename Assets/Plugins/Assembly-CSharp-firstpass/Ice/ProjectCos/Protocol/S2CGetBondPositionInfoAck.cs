using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGetBondPositionInfoAck")]
	public class S2CGetBondPositionInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private BattleFormationProto _Formation;

		private BondPositionProto _BondPosition;

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

		[ProtoMember(2, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
		public BattleFormationProto Formation
		{
			get => _Formation;
			set => _Formation = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BondPosition", DataFormat = DataFormat.Default)]
		public BondPositionProto BondPosition
		{
			get => _BondPosition;
			set => _BondPosition = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
