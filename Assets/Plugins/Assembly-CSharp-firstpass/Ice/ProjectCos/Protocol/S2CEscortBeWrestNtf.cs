using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortBeWrestNtf")]
	public class S2CEscortBeWrestNtf : IExtensible
	{
		private int _CarId;

		private PlayerSummaryInfoProto _Robber;

		private int _AlreayGetReward;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
		public int CarId
		{
			get => _CarId;
			set => _CarId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Robber", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto Robber
		{
			get => _Robber;
			set => _Robber = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "AlreayGetReward", DataFormat = DataFormat.TwosComplement)]
		public int AlreayGetReward
		{
			get => _AlreayGetReward;
			set => _AlreayGetReward = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
