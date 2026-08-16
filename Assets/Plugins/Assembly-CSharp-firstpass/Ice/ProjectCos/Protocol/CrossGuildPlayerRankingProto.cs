using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildPlayerRankingProto")]
	public class CrossGuildPlayerRankingProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "RankingItemProto")]
		public class RankingItemProto : IExtensible
		{
			private ulong _PlayerId;

			private int _Ranking;

			private string _Name;

			private int _KillHeroCount;

			private int _Score;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "PlayerId", DataFormat = DataFormat.TwosComplement)]
			public ulong PlayerId
			{
				get => _PlayerId;
				set => _PlayerId = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
			public int Ranking
			{
				get => _Ranking;
				set => _Ranking = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "KillHeroCount", DataFormat = DataFormat.TwosComplement)]
			public int KillHeroCount
			{
				get => _KillHeroCount;
				set => _KillHeroCount = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
			public int Score
			{
				get => _Score;
				set => _Score = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private List<RankingItemProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Items", DataFormat = DataFormat.Default)]
		public List<RankingItemProto> Items

		{

			get => _Items;

			set => _Items = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
