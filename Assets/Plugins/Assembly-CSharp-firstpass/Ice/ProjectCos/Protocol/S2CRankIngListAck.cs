using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CRankIngListAck")]
	public class S2CRankIngListAck : IExtensible
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

		private List<RankingerInfoProto> _Tops;

		private List<RankingerInfoProto> _Revenges;

		private List<RankingerInfoProto> _Challenges;

		private int _Ranking;

		private int _Reputation;

		private int _ChallengeUsedCount;

		private long _ChallengeCoolDownOverTime;

		private int _BuyChallengeTimes;

		private int _MaxRanking;

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

		[ProtoMember(2, Name = "Tops", DataFormat = DataFormat.Default)]
		public List<RankingerInfoProto> Tops

		{

			get => _Tops;

			set => _Tops = value;

		}

		[ProtoMember(3, Name = "Revenges", DataFormat = DataFormat.Default)]
		public List<RankingerInfoProto> Revenges

		{

			get => _Revenges;

			set => _Revenges = value;

		}

		[ProtoMember(4, Name = "Challenges", DataFormat = DataFormat.Default)]
		public List<RankingerInfoProto> Challenges

		{

			get => _Challenges;

			set => _Challenges = value;

		}

		[ProtoMember(5, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "Reputation", DataFormat = DataFormat.TwosComplement)]
		public int Reputation
		{
			get => _Reputation;
			set => _Reputation = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "ChallengeUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int ChallengeUsedCount
		{
			get => _ChallengeUsedCount;
			set => _ChallengeUsedCount = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "ChallengeCoolDownOverTime", DataFormat = DataFormat.TwosComplement)]
		public long ChallengeCoolDownOverTime
		{
			get => _ChallengeCoolDownOverTime;
			set => _ChallengeCoolDownOverTime = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "BuyChallengeTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyChallengeTimes
		{
			get => _BuyChallengeTimes;
			set => _BuyChallengeTimes = value;
		}

		[ProtoMember(10, IsRequired = true, Name = "MaxRanking", DataFormat = DataFormat.TwosComplement)]
		public int MaxRanking
		{
			get => _MaxRanking;
			set => _MaxRanking = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
