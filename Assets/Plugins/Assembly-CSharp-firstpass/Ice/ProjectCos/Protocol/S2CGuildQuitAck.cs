using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildQuitAck")]
	public class S2CGuildQuitAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 2)]
			NoGuild = 2,
			[ProtoEnum(Name = "IsPresident", Value = 3)]
			IsPresident = 3,
			[ProtoEnum(Name = "GuildHasNoPlayer", Value = 4)]
			GuildHasNoPlayer = 4,
			[ProtoEnum(Name = "NoPower", Value = 5)]
			NoPower = 5,
			[ProtoEnum(Name = "InCd", Value = 6)]
			InCd = 6
		}

		private ResultCode _Code;

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

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
