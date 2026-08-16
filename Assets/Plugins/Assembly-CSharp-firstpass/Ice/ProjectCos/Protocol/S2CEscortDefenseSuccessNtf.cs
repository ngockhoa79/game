using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortDefenseSuccessNtf")]
	public class S2CEscortDefenseSuccessNtf : IExtensible
	{
		private PlayerSummaryInfoProto _Robber;

		private int _AddGold;

		private int _AddGoldToCar;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Robber", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto Robber
		{
			get => _Robber;
			set => _Robber = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "AddGold", DataFormat = DataFormat.TwosComplement)]
		public int AddGold
		{
			get => _AddGold;
			set => _AddGold = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "AddGoldToCar", DataFormat = DataFormat.TwosComplement)]
		public int AddGoldToCar
		{
			get => _AddGoldToCar;
			set => _AddGoldToCar = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
