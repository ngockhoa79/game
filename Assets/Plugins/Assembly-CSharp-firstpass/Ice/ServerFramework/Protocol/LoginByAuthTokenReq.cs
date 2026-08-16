using System;
using ProtoBuf;

namespace Ice.ServerFramework.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LoginByAuthTokenReq")]
	public class LoginByAuthTokenReq : IExtensible
	{
		private string _AuthToken;
		private string _ClientVersion;
		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "AuthToken", DataFormat = DataFormat.Default)]
		public string AuthToken
		{
			get => _AuthToken;
			set => _AuthToken = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ClientVersion", DataFormat = DataFormat.Default)]
		public string ClientVersion
		{
			get => _ClientVersion;
			set => _ClientVersion = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
