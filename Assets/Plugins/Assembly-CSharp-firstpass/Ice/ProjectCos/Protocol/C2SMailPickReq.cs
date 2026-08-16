using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SMailPickReq")]
	public class C2SMailPickReq : IExtensible
	{
		private int _MailId;

		private bool _IsPickAll;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MailId", DataFormat = DataFormat.TwosComplement)]
		public int MailId
		{
			get => _MailId;
			set => _MailId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "IsPickAll", DataFormat = DataFormat.Default)]
		public bool IsPickAll
		{
			get => _IsPickAll;
			set => _IsPickAll = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
