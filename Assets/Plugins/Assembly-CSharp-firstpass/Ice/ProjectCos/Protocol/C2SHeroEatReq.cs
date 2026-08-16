using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroEatReq")]
	public class C2SHeroEatReq : IExtensible
	{
		private int _HeroIndex;

		private List<int> _BeingEatenIndexs;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, Name = "BeingEatenIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeingEatenIndexs

		{

			get => _BeingEatenIndexs;

			set => _BeingEatenIndexs = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
