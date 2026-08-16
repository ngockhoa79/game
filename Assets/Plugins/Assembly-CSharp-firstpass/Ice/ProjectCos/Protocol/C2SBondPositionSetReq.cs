using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SBondPositionSetReq")]
	public class C2SBondPositionSetReq : IExtensible
	{
		private List<int> _HeroIndex;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "HeroIndex", DataFormat = DataFormat.Default)]
		public List<int> HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
		public int CrossType
		{
			get => _CrossType;
			set => _CrossType = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
