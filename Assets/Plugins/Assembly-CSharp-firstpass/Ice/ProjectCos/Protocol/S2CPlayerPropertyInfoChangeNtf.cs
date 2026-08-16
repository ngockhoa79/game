using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CPlayerPropertyInfoChangeNtf")]
	public class S2CPlayerPropertyInfoChangeNtf : IExtensible
	{
		private PlayerPropertyInfoProto _Property;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Property", DataFormat = DataFormat.Default)]
		public PlayerPropertyInfoProto Property
		{
			get => _Property;
			set => _Property = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
