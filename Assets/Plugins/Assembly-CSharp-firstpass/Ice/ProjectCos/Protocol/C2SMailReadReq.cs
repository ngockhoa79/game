using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SMailReadReq")]
	public class C2SMailReadReq : IExtensible
	{
		private int _MailId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MailId", DataFormat = DataFormat.TwosComplement)]
		public int MailId
		{
			get => _MailId;
			set => _MailId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
