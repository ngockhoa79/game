using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RankingerInfoProto")]
	public class RankingerInfoProto : IExtensible
	{
		private int _Rank;

		private PlayerSummaryInfoProto _PlayerInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
		{
			get => _Rank;
			set => _Rank = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "PlayerInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto PlayerInfo
		{
			get => _PlayerInfo;
			set => _PlayerInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
