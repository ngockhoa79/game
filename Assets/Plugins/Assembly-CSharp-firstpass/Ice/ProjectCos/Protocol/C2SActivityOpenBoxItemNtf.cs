using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SActivityOpenBoxItemNtf")]
	public class C2SActivityOpenBoxItemNtf : IExtensible
	{
		private int _DuplicateId;

		private int _Postion;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Postion", DataFormat = DataFormat.TwosComplement)]
		public int Postion
		{
			get => _Postion;
			set => _Postion = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
