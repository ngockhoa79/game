using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ActivityOpenBoxListProto")]
	public class ActivityOpenBoxListProto : IExtensible
	{
		private List<ThingProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<ThingProto> Items

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
