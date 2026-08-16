using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortRefreshCarAck")]
	public class S2CEscortRefreshCarAck : IExtensible
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
			[ProtoEnum(Name = "NoEnoushTimes", Value = 3)]
			NoEnoushTimes = 3,
			[ProtoEnum(Name = "IsRunning", Value = 4)]
			IsRunning = 4,
			[ProtoEnum(Name = "NoPickCompleteReward", Value = 5)]
			NoPickCompleteReward = 5
		}

		private ResultCode _Code;

		private int _RefreshCarId;

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

		[ProtoMember(2, IsRequired = true, Name = "RefreshCarId", DataFormat = DataFormat.TwosComplement)]
		public int RefreshCarId
		{
			get => _RefreshCarId;
			set => _RefreshCarId = value;
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
