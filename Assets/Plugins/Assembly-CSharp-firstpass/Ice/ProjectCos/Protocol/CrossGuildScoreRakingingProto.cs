using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildScoreRakingingProto")]
	public class CrossGuildScoreRakingingProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "RankingItemProto")]
		public class RankingItemProto : IExtensible
		{
			private int _Score;

			private int _Ranking;

			private string _Name;

			private int _ReamNum;

			private int _Icon;

			private int _Level;

			private int _WinCount;

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

			[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(4, IsRequired = true, Name = "ReamNum", DataFormat = DataFormat.TwosComplement)]
			public int ReamNum
			{
				get => _ReamNum;
				set => _ReamNum = value;
			}

			[ProtoMember(5, IsRequired = true, Name = "Icon", DataFormat = DataFormat.TwosComplement)]
			public int Icon
			{
				get => _Icon;
				set => _Icon = value;
			}

			[ProtoMember(6, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
			public int Level
			{
				get => _Level;
				set => _Level = value;
			}

			[ProtoMember(7, IsRequired = true, Name = "WinCount", DataFormat = DataFormat.TwosComplement)]
			public int WinCount
			{
				get => _WinCount;
				set => _WinCount = value;
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private int _Score;

		private int _Ranking;

		private List<RankingItemProto> _Rankings;

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

		[ProtoMember(3, Name = "Rankings", DataFormat = DataFormat.Default)]
		public List<RankingItemProto> Rankings

		{

			get => _Rankings;

			set => _Rankings = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return null;
		}
	}
}
