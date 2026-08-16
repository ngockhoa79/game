using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SGuildActiveBuffReq")]
	public class C2SGuildActiveBuffReq : IExtensible
	{
		private int _BuffId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BuffId", DataFormat = DataFormat.TwosComplement)]
		public int BuffId
		{
			get => _BuffId;
			set => _BuffId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
