using System;
using ProtoBuf;

namespace Ice.ServerFramework.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LoginBySessionTokenAck")]
	public class LoginBySessionTokenAck : IExtensible
	{
		private int _Result;
		private string _SessionToken;
		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get => _Result;
			set => _Result = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SessionToken", DataFormat = DataFormat.Default)]
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
