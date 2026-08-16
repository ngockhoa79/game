using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CQueryPlayerSummaryInfoAck")]
	public class S2CQueryPlayerSummaryInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private PlayerSummaryInfoProto _SummaryInfo;

		private GuildMemberInfoProto.TypeEnum _GuildPostion;

		private int _PveRanking;

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

		[ProtoMember(2, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "GuildPostion", DataFormat = DataFormat.TwosComplement)]
		public GuildMemberInfoProto.TypeEnum GuildPostion
		{
			get
			{
				return default(GuildMemberInfoProto.TypeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "PveRanking", DataFormat = DataFormat.TwosComplement)]
		public int PveRanking
		{
			get => _PveRanking;
			set => _PveRanking = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
