using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SUnEquipEquipmentReq")]
	public class C2SUnEquipEquipmentReq : IExtensible
	{
		private int _HeroIndex;

		private int _EquipmentIndex;

		private int _CrossType;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroIndex", DataFormat = DataFormat.TwosComplement)]
		public int HeroIndex
		{
			get => _HeroIndex;
			set => _HeroIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "EquipmentIndex", DataFormat = DataFormat.TwosComplement)]
		public int EquipmentIndex
		{
			get => _EquipmentIndex;
			set => _EquipmentIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CrossType", DataFormat = DataFormat.TwosComplement)]
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
