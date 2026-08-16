using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossPersonPlayOffBetRankingProto")]
	public class CrossPersonPlayOffBetRankingProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "RankingItemProto")]
		public class RankingItemProto : IExtensible
		{
			private int _Ranking;

			private CrossPlayerSummaryInfoProto _SummaryInfo;

			private int _Count;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Ranking", DataFormat = DataFormat.TwosComplement)]
			public int Ranking
			{
				get => _Ranking;
				set => _Ranking = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
			public CrossPlayerSummaryInfoProto SummaryInfo
			{
				get => _SummaryInfo;
				set => _SummaryInfo = value;
			}

			[ProtoMember(3, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
			public int Count
			{
				get => _Count;
				set => _Count = value;
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
