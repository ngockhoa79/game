using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildListInfoReq")]
	public class C2SGuildListInfoReq : IExtensible
	{
		private int _PageIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PageIndex", DataFormat = DataFormat.TwosComplement)]
		public int PageIndex
		{
			get => _PageIndex;
			set => _PageIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
