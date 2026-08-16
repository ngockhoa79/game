using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "GuildAllInfoProto")]
	public class GuildAllInfoProto : IExtensible
	{
		private GuildInfoProto _BaseInfo;

		private List<GuildMemberInfoProto> _Members;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseInfo", DataFormat = DataFormat.Default)]
		public GuildInfoProto BaseInfo
		{
			get => _BaseInfo;
			set => _BaseInfo = value;
		}

		[ProtoMember(2, Name = "Members", DataFormat = DataFormat.Default)]
		public List<GuildMemberInfoProto> Members

		{

			get => _Members;

			set => _Members = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
