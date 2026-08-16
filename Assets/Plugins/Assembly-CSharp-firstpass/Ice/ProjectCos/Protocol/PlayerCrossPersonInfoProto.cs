using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerCrossPersonInfoProto")]
	public class PlayerCrossPersonInfoProto : IExtensible
	{
		private int _RemainBattleCount;

		private int _BuyBattleCount;

		private int _BuyClearChangeTargetCount;

		private long _ChangeTargetFreeOverTime;

		private CrossPersonSeasonInfoProto _SeasonInfo;

		private int _RewardGroupId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RemainBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int RemainBattleCount
		{
			get => _RemainBattleCount;
			set => _RemainBattleCount = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "BuyBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int BuyBattleCount
		{
			get => _BuyBattleCount;
			set => _BuyBattleCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuyClearChangeTargetCount", DataFormat = DataFormat.TwosComplement)]
		public int BuyClearChangeTargetCount
		{
			get => _BuyClearChangeTargetCount;
			set => _BuyClearChangeTargetCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ChangeTargetFreeOverTime", DataFormat = DataFormat.TwosComplement)]
		public long ChangeTargetFreeOverTime
		{
			get => _ChangeTargetFreeOverTime;
			set => _ChangeTargetFreeOverTime = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "SeasonInfo", DataFormat = DataFormat.Default)]
		public CrossPersonSeasonInfoProto SeasonInfo
		{
			get => _SeasonInfo;
			set => _SeasonInfo = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "RewardGroupId", DataFormat = DataFormat.TwosComplement)]
		public int RewardGroupId
		{
			get => _RewardGroupId;
			set => _RewardGroupId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
