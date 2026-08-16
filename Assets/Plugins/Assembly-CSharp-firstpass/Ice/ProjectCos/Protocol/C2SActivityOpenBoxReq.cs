using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SActivityOpenBoxReq")]
	public class C2SActivityOpenBoxReq : IExtensible
	{
		private int _DuplicateId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
