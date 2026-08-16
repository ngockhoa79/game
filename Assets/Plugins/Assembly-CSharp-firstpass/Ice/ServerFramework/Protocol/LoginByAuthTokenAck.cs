using System;
using System.ComponentModel;
using ProtoBuf;

namespace Ice.ServerFramework.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LoginByAuthTokenAck")]
	public class LoginByAuthTokenAck : IExtensible
	{
		private int _Result;
		private bool _NeedRedirect;
		private string _SessionToken;
		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get => _Result;
			set => _Result = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "NeedRedirect", DataFormat = DataFormat.Default)]
		public bool NeedRedirect
		{
			get => _NeedRedirect;
			set => _NeedRedirect = value;
		}

		[ProtoMember(3, IsRequired = false, Name = "SessionToken", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public string SessionToken
		{
			get => _SessionToken;
			set => _SessionToken = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
