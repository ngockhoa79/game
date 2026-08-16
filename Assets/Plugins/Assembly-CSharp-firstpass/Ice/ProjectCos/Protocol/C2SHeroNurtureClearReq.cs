using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroNurtureClearReq")]
	public class C2SHeroNurtureClearReq : IExtensible
	{
		private int _HeroIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
