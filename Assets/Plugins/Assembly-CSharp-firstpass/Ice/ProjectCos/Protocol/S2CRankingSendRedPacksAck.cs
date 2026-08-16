using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRankingSendRedPacksAck")]
	public class S2CRankingSendRedPacksAck : IExtensible
	{
		[ProtoContract(Name = "CodeResult")]
		public enum CodeResult
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotSendEnable", Value = 2)]
			NotSendEnable = 2,
			[ProtoEnum(Name = "SendTimesLess", Value = 3)]
			SendTimesLess = 3,
			[ProtoEnum(Name = "AlreadySendError", Value = 4)]
			AlreadySendError = 4
		}

		private CodeResult _Code;

		private RankingRedPackProto _CurSendInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public CodeResult Code
		{
			get
			{
				return default(CodeResult);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "CurSendInfo", DataFormat = DataFormat.Default)]
		public RankingRedPackProto CurSendInfo
		{
			get => _CurSendInfo;
			set => _CurSendInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
