using System;
using ProtoBuf;

namespace Ice.ServerFramework.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LoginBySessionTokenReq")]
	public class LoginBySessionTokenReq : IExtensible
	{
		private string _SessionToken;
		private string _ClientVersion;
		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SessionToken", DataFormat = DataFormat.Default)]
		public string SessionToken
		{
			get => _SessionToken;
			set => _SessionToken = value;
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
