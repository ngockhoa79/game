using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "CrossGuildBattleOverPlayerRewardProto")]
	public class CrossGuildBattleOverPlayerRewardProto : IExtensible
	{
		private CrossGuildBattleOverBaseProto _GuildInfo;

		private CrossGuildBattleOverProto.RewardOfPlayerProto _RewardInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "GuildInfo", DataFormat = DataFormat.Default)]
		public CrossGuildBattleOverBaseProto GuildInfo
		{
			get => _GuildInfo;
			set => _GuildInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RewardInfo", DataFormat = DataFormat.Default)]
		public CrossGuildBattleOverProto.RewardOfPlayerProto RewardInfo
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
}
