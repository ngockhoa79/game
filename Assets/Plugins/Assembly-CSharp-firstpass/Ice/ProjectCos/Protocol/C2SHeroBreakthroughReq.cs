using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroBreakthroughReq")]
	public class C2SHeroBreakthroughReq : IExtensible
	{
		private int _HeroIndex;

		private List<int> _SacrificeIndexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, Name = "SacrificeIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> SacrificeIndexs

		{

			get => _SacrificeIndexs;

			set => _SacrificeIndexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
