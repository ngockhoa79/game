using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "AgentAuthTokenAck")]
	public class AgentAuthTokenAck : IExtensible
	{
		private string _authTokenResult;

		private int _state;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "authTokenResult", DataFormat = DataFormat.Default)]
		public string AuthTokenResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "state", DataFormat = DataFormat.TwosComplement)]
		public int State
		{
			get
			{
				return 0;
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
