using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ContinueChargeInfoProto")]
	public class ContinueChargeInfoProto : IExtensible
	{
		private ConfigProto _ConfigInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ConfigProto", DataFormat = DataFormat.TwosComplement)]
		public ConfigProto ConfigInfo
		{
			get => _ConfigInfo;
			set => _ConfigInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
