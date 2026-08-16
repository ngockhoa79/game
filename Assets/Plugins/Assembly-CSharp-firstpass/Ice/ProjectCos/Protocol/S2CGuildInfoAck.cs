using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildInfoAck")]
	public class S2CGuildInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 2)]
			NoGuild = 2
		}

		private ResultCode _Code;

		private GuildAllInfoProto _GuildInfo;

		private PlayerGuildInfoProto _InfoOfPlayer;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "GuildInfo", DataFormat = DataFormat.Default)]
		public GuildAllInfoProto GuildInfo
		{
			get => _GuildInfo;
			set => _GuildInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "InfoOfPlayer", DataFormat = DataFormat.Default)]
		public PlayerGuildInfoProto InfoOfPlayer
		{
			get => _InfoOfPlayer;
			set => _InfoOfPlayer = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
