using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFriendEggsInfoNtf")]
	public class S2CFriendEggsInfoNtf : IExtensible
	{
		private FriendEggsProto _EggsInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "EggsInfo", DataFormat = DataFormat.Default)]
		public FriendEggsProto EggsInfo
		{
			get => _EggsInfo;
			set => _EggsInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
