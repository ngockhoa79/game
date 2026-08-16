using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RankingRedPackProto")]
	public class RankingRedPackProto : IExtensible
	{
		private PlayerSummaryInfoProto _PlayerInfo;

		private int _RedPackId;

		private int _CurCount;

		private int _MaxCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "PlayerInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto PlayerInfo
		{
			get => _PlayerInfo;
			set => _PlayerInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RedPackId", DataFormat = DataFormat.TwosComplement)]
		public int RedPackId
		{
			get => _RedPackId;
			set => _RedPackId = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "CurCount", DataFormat = DataFormat.TwosComplement)]
		public int CurCount
		{
			get => _CurCount;
			set => _CurCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "MaxCount", DataFormat = DataFormat.TwosComplement)]
		public int MaxCount
		{
			get => _MaxCount;
			set => _MaxCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
