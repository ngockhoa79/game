using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SCrossGuildLineInfoReq")]
	public class C2SCrossGuildLineInfoReq : IExtensible
	{
		private int _LineIndex;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "LineIndex", DataFormat = DataFormat.TwosComplement)]
		public int LineIndex
		{
			get => _LineIndex;
			set => _LineIndex = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
