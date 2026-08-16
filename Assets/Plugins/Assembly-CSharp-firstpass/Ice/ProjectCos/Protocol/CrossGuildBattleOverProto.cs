using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildBattleOverProto")]
	public class CrossGuildBattleOverProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "RewardOfPlayerProto")]
		public class RewardOfPlayerProto : IExtensible
		{
			private ulong _PlayerId;

			private int _Score;

			private int _CourageProof;

			private int _ReliveCount;

			private int _GuildContribution;

			private int _KillHeroCount;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong PlayerId
			{
				get => _PlayerId;
				set => _PlayerId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
			public int Score
			{
				get => _Score;
				set => _Score = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "CourageProof", DataFormat = DataFormat.TwosComplement)]
			public int CourageProof
			{
				get => _CourageProof;
				set => _CourageProof = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "ReliveCount", DataFormat = DataFormat.TwosComplement)]
			public int ReliveCount
			{
				get => _ReliveCount;
				set => _ReliveCount = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "GuildContribution", DataFormat = DataFormat.TwosComplement)]
			public int GuildContribution
			{
				get => _GuildContribution;
				set => _GuildContribution = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "KillHeroCount", DataFormat = DataFormat.TwosComplement)]
			public int KillHeroCount
			{
				get => _KillHeroCount;
				set => _KillHeroCount = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private CrossGuildBattleOverBaseProto _BaseInfo;

		private List<RewardOfPlayerProto> _RewardsOfPlayer;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseInfo", DataFormat = DataFormat.Default)]
		public CrossGuildBattleOverBaseProto BaseInfo
		{
			get => _BaseInfo;
			set => _BaseInfo = value;
		}

		[ProtoMember(2, Name = "RewardsOfPlayer", DataFormat = DataFormat.Default)]
		public List<RewardOfPlayerProto> RewardsOfPlayer

		{

			get => _RewardsOfPlayer;

			set => _RewardsOfPlayer = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
