using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonSeasonInfoProto")]
	public class CrossPersonSeasonInfoProto : IExtensible
	{
		private int _Score;

		private int _Ranking;

		private int _Wins;

		private int _ContinuouWinCount;

		private int _AttackWinCount;

		private int _DefenseWinCount;

		private int _AttackFailCount;

		private int _DefenseFailCount;

		private int _MaxContinuouWinCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get => _Score;
			set => _Score = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
		public int Ranking
		{
			get => _Ranking;
			set => _Ranking = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Wins", DataFormat = DataFormat.TwosComplement)]
		public int Wins
		{
			get => _Wins;
			set => _Wins = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "ContinuouWinCount", DataFormat = DataFormat.TwosComplement)]
		public int ContinuouWinCount
		{
			get => _ContinuouWinCount;
			set => _ContinuouWinCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "AttackWinCount", DataFormat = DataFormat.TwosComplement)]
		public int AttackWinCount
		{
			get => _AttackWinCount;
			set => _AttackWinCount = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "DefenseWinCount", DataFormat = DataFormat.TwosComplement)]
		public int DefenseWinCount
		{
			get => _DefenseWinCount;
			set => _DefenseWinCount = value;
		}

		[ProtoMember(7, IsRequired = true, Name = "AttackFailCount", DataFormat = DataFormat.TwosComplement)]
		public int AttackFailCount
		{
			get => _AttackFailCount;
			set => _AttackFailCount = value;
		}

		[ProtoMember(8, IsRequired = true, Name = "DefenseFailCount", DataFormat = DataFormat.TwosComplement)]
		public int DefenseFailCount
		{
			get => _DefenseFailCount;
			set => _DefenseFailCount = value;
		}

		[ProtoMember(9, IsRequired = true, Name = "MaxContinuouWinCount", DataFormat = DataFormat.TwosComplement)]
		public int MaxContinuouWinCount
		{
			get => _MaxContinuouWinCount;
			set => _MaxContinuouWinCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
