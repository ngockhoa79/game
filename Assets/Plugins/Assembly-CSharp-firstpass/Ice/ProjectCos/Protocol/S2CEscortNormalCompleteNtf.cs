using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortNormalCompleteNtf")]
	public class S2CEscortNormalCompleteNtf : IExtensible
	{
		private int _CarId;

		private int _RemainGold;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "CarId", DataFormat = DataFormat.TwosComplement)]
		public int CarId
		{
			get => _CarId;
			set => _CarId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RemainGold", DataFormat = DataFormat.TwosComplement)]
		public int RemainGold
		{
			get => _RemainGold;
			set => _RemainGold = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
