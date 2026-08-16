using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRegisterDeviceTokenReq")]
	public class C2SRegisterDeviceTokenReq : IExtensible
	{
		private string _DeviceToken;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DeviceToken", DataFormat = DataFormat.Default)]
		public string DeviceToken
		{
			get => _DeviceToken;
			set => _DeviceToken = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
