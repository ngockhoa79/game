using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGasAddMaterialReq")]
	public class C2SGasAddMaterialReq : IExtensible
	{
		private int _HeroIndex;

		private int _Position;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get => _Position;
			set => _Position = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
