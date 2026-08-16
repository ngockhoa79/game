using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SOpenGlobalChatNtf")]
	public class C2SOpenGlobalChatNtf : IExtensible
	{
		private bool _IsOpen;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsOpen", DataFormat = DataFormat.Default)]
		public bool IsOpen
		{
			get => _IsOpen;
			set => _IsOpen = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
