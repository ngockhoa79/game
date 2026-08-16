using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EquipmentContainerProto")]
	public class EquipmentContainerProto : IExtensible
	{
		private List<EquipmentItemProto> _Items;

		private int _MaxEquipCount;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<EquipmentItemProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		[ProtoMember(2, IsRequired = true, Name = "MaxEquipCount", DataFormat = DataFormat.TwosComplement)]
		public int MaxEquipCount
		{
			get => _MaxEquipCount;
			set => _MaxEquipCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
