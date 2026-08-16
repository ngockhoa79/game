using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildListInfoAck")]
	public class S2CGuildListInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "HasGuild", Value = 2)]
			HasGuild = 2
		}

		private ResultCode _Code;

		private List<GuildSummaryInfoProto> _Guilds;

		private int _TotalCount;

		private int _JsonCount;

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

		[ProtoMember(2, Name = "Guilds", DataFormat = DataFormat.Default)]
		public List<GuildSummaryInfoProto> Guilds

		{

			get => _Guilds;

			set => _Guilds = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "TotalCount", DataFormat = DataFormat.TwosComplement)]
		public int TotalCount
		{
			get => _TotalCount;
			set => _TotalCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "JsonCount", DataFormat = DataFormat.TwosComplement)]
		public int JsonCount
		{
			get => _JsonCount;
			set => _JsonCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
