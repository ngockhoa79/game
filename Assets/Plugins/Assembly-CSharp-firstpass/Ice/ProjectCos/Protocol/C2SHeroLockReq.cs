using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SHeroLockReq")]
	public class C2SHeroLockReq : IExtensible
	{
		private int _HeroIndex;

		private bool _IsLocked;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsLocked", DataFormat = DataFormat.Default)]
		public bool IsLocked
		{
			get => _IsLocked;
			set => _IsLocked = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
