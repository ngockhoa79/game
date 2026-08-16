using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SPVPBattleStartReq")]
	public class C2SPVPBattleStartReq : IExtensible
	{
		private ulong _TargetPlayerId;

		private int _TargetRankingValue;

		private IExtension extensionObject;

		[ProtoMember(2, IsRequired = true, Name = "TargetPlayerId", DataFormat = DataFormat.TwosComplement)]
		public ulong TargetPlayerId
		{
			get => _TargetPlayerId;
			set => _TargetPlayerId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "TargetRankingValue", DataFormat = DataFormat.TwosComplement)]
		public int TargetRankingValue
		{
			get => _TargetRankingValue;
			set => _TargetRankingValue = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
