using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonRankingItemProto")]
	public class CrossPersonRankingItemProto : IExtensible
	{
		private int _Ranking;

		private CrossPlayerSummaryInfoProto _Summary;

		private int _Score;

		private int _Wins;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Summary", DataFormat = DataFormat.Default)]
		public CrossPlayerSummaryInfoProto Summary
		{
			get => _Summary;
			set => _Summary = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get => _Score;
			set => _Score = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Wins", DataFormat = DataFormat.TwosComplement)]
		public int Wins
		{
			get => _Wins;
			set => _Wins = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
