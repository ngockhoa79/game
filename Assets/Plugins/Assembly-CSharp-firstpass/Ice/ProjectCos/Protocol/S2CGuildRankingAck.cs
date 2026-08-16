using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildRankingAck")]
	public class S2CGuildRankingAck : IExtensible
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

		private List<GuildSummaryInfoProto> _Guilds;

		private int _CurRanking;

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

		[ProtoMember(3, IsRequired = true, Name = "CurRanking", DataFormat = DataFormat.TwosComplement)]
		public int CurRanking
		{
			get => _CurRanking;
			set => _CurRanking = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
