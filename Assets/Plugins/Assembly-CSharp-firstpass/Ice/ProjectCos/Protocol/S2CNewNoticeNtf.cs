using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CNewNoticeNtf")]
	public class S2CNewNoticeNtf : IExtensible
	{
		private NewNoticeProto _Notice;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Notice", DataFormat = DataFormat.Default)]
		public NewNoticeProto Notice
		{
			get => _Notice;
			set => _Notice = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
