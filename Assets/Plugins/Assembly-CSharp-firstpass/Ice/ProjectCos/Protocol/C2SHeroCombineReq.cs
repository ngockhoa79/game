using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroCombineReq")]
	public class C2SHeroCombineReq : IExtensible
	{
		private int _HeroId;

		private int _ChipIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get => _HeroId;
			set => _HeroId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ChipIndex", DataFormat = DataFormat.TwosComplement)]
		public int ChipIndex
		{
			get => _ChipIndex;
			set => _ChipIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
