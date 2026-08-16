using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SEquipmentLevelupReq")]
	public class C2SEquipmentLevelupReq : IExtensible
	{
		private int _EquipmentIndex;

		private bool _IsAutoLevelup;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "EquipmentIndex", DataFormat = DataFormat.TwosComplement)]
		public int EquipmentIndex
		{
			get => _EquipmentIndex;
			set => _EquipmentIndex = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsAutoLevelup", DataFormat = DataFormat.Default)]
		public bool IsAutoLevelup
		{
			get => _IsAutoLevelup;
			set => _IsAutoLevelup = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
