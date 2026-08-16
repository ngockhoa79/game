using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "AgentAuthTokenReq")]
	public class AgentAuthTokenReq : IExtensible
	{
		private string _username;

		private string _password;

		private string _deviceid;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "username", DataFormat = DataFormat.Default)]
		public string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "password", DataFormat = DataFormat.Default)]
		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "deviceid", DataFormat = DataFormat.Default)]
		public string Deviceid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
