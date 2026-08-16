using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CPlayerGuildSummaryInfoNtf")]
	public class S2CPlayerGuildSummaryInfoNtf : IExtensible
	{
		private PlayerSummaryInfoProto.GuildInfoProto _GuildInfo;

		private GuildMemberInfoProto.TypeEnum _Postion;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GuildInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto.GuildInfoProto GuildInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Postion", DataFormat = DataFormat.TwosComplement)]
		public GuildMemberInfoProto.TypeEnum Postion
		{
			get
			{
				return default(GuildMemberInfoProto.TypeEnum);
			}
			set
			{
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
