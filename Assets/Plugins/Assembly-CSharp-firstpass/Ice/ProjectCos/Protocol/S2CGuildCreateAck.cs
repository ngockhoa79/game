using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildCreateAck")]
	public class S2CGuildCreateAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NameUsed", Value = 2)]
			NameUsed = 2,
			[ProtoEnum(Name = "NameTooLong", Value = 3)]
			NameTooLong = 3,
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4,
			[ProtoEnum(Name = "HasGuild", Value = 5)]
			HasGuild = 5,
			[ProtoEnum(Name = "HasSensitiveWord", Value = 6)]
			HasSensitiveWord = 6,
			[ProtoEnum(Name = "InCd", Value = 7)]
			InCd = 7,
			[ProtoEnum(Name = "LevelLess", Value = 8)]
			LevelLess = 8
		}

		private ResultCode _Code;

		private GuildAllInfoProto _Info;

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

		[ProtoMember(2, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public GuildAllInfoProto Info
		{
			get => _Info;
			set => _Info = value;
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
