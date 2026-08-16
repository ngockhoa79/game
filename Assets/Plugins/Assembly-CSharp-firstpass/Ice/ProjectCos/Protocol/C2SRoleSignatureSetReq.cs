using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SRoleSignatureSetReq")]
	public class C2SRoleSignatureSetReq : IExtensible
	{
		private string _Content;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get => _Content;
			set => _Content = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
