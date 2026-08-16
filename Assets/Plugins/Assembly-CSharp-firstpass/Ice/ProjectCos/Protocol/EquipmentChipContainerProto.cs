using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "EquipmentChipContainerProto")]
	public class EquipmentChipContainerProto : IExtensible
	{
		private List<ItemInfoProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ItemInfoProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
