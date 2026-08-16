using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SEquipmentCombineReq")]
	public class C2SEquipmentCombineReq : IExtensible
	{
		private int _EquipmentId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "EquipmentId", DataFormat = DataFormat.TwosComplement)]
		public int EquipmentId
		{
			get => _EquipmentId;
			set => _EquipmentId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
