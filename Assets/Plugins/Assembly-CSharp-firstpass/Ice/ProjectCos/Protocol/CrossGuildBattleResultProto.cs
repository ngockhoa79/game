using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildBattleResultProto")]
	public class CrossGuildBattleResultProto : IExtensible
	{
		[Serializable]
		[ProtoContract(Name = "RakingItemProto")]
		public class RakingItemProto : IExtensible
		{
			private string _Name;

			private CrossGuildBattleOverProto.RewardOfPlayerProto _ResultInfo;

			private IExtension extensionObject;

			[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			[ProtoMember(2, IsRequired = true, Name = "ResultInfo", DataFormat = DataFormat.Default)]
			public CrossGuildBattleOverProto.RewardOfPlayerProto ResultInfo
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
		}

		private string _GuildName;

		private int _ReamNum;

		private int _GuildIcon;

		private int _CurBattleCount;

		private int _RankingOfMy;

		private List<RakingItemProto> _Items;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GuildName", DataFormat = DataFormat.Default)]
		public string GuildName
		{
			get => _GuildName;
			set => _GuildName = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ReamNum", DataFormat = DataFormat.TwosComplement)]
		public int ReamNum
		{
			get => _ReamNum;
			set => _ReamNum = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "GuildIcon", DataFormat = DataFormat.TwosComplement)]
		public int GuildIcon
		{
			get => _GuildIcon;
			set => _GuildIcon = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "CurBattleCount", DataFormat = DataFormat.TwosComplement)]
		public int CurBattleCount
		{
			get => _CurBattleCount;
			set => _CurBattleCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "RankingOfMy", DataFormat = DataFormat.TwosComplement)]
		public int RankingOfMy
		{
			get => _RankingOfMy;
			set => _RankingOfMy = value;
		}

		[ProtoMember(6, Name = "Items", DataFormat = DataFormat.Default)]
		public List<RakingItemProto> Items

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
