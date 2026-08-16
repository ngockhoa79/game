using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CPVPBattleStartAck")]
	public class S2CPVPBattleStartAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "MultiChallangeConflict", Value = 2)]
			MultiChallangeConflict = 2,
			[ProtoEnum(Name = "TargetRankValueIsSmall", Value = 3)]
			TargetRankValueIsSmall = 3
		}

		private ResultCode _Code;

		private BattleReportProto _BattleReport;

		private int _ChallengeUsedCount;

		private long _ChallengeCoolDownOverTime;

		private int _Crystal;

		private int _Reputation;

		private int _PrveRanking;

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

		[ProtoMember(2, IsRequired = true, Name = "BattleReport", DataFormat = DataFormat.Default)]
		public BattleReportProto BattleReport
		{
			get => _BattleReport;
			set => _BattleReport = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "ChallengeUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int ChallengeUsedCount
		{
			get => _ChallengeUsedCount;
			set => _ChallengeUsedCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ChallengeCoolDownOverTime", DataFormat = DataFormat.TwosComplement)]
		public long ChallengeCoolDownOverTime
		{
			get => _ChallengeCoolDownOverTime;
			set => _ChallengeCoolDownOverTime = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get => _Crystal;
			set => _Crystal = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Reputation", DataFormat = DataFormat.TwosComplement)]
		public int Reputation
		{
			get => _Reputation;
			set => _Reputation = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "PrveRanking", DataFormat = DataFormat.TwosComplement)]
		public int PrveRanking
		{
			get => _PrveRanking;
			set => _PrveRanking = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "CurRanking", DataFormat = DataFormat.TwosComplement)]
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
