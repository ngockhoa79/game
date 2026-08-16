using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortPromoteCarAck")]
	public class S2CEscortPromoteCarAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2,
			[ProtoEnum(Name = "NoRefreshCar", Value = 3)]
			NoRefreshCar = 3,
			[ProtoEnum(Name = "IsMaxCar", Value = 4)]
			IsMaxCar = 4
		}

		private ResultCode _Code;

		private int _newCarId;

		private int _PromoteProbability;

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

		[ProtoMember(2, IsRequired = true, Name = "newCarId", DataFormat = DataFormat.TwosComplement)]
		public int NewCarId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "PromoteProbability", DataFormat = DataFormat.TwosComplement)]
		public int PromoteProbability
		{
			get => _PromoteProbability;
			set => _PromoteProbability = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
