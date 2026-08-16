using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildAgreeAddAck")]
	public class S2CGuildAgreeAddAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoPlayer", Value = 2)]
			NoPlayer = 2,
			[ProtoEnum(Name = "HasGuildAlready", Value = 3)]
			HasGuildAlready = 3,
			[ProtoEnum(Name = "NoPower", Value = 4)]
			NoPower = 4,
			[ProtoEnum(Name = "NoGuild", Value = 5)]
			NoGuild = 5,
			[ProtoEnum(Name = "Full", Value = 6)]
			Full = 6
		}

		private ResultCode _Code;

		private GuildMemberInfoProto _MemberInfo;

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

		[ProtoMember(2, IsRequired = true, Name = "MemberInfo", DataFormat = DataFormat.Default)]
		public GuildMemberInfoProto MemberInfo
		{
			get => _MemberInfo;
			set => _MemberInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
