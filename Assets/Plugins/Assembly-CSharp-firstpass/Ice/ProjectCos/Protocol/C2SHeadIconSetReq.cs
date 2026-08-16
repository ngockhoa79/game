using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeadIconSetReq")]
	public class C2SHeadIconSetReq : IExtensible
	{
		private int _HeroId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get => _HeroId;
			set => _HeroId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
