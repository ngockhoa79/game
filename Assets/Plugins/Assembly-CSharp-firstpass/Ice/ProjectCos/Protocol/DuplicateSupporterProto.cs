using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateSupporterProto")]
	public class DuplicateSupporterProto : IExtensible
	{
		private PlayerSummaryInfoProto _SummaryInfo;

		private BattleFormationProto _Formation;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
		public BattleFormationProto Formation
		{
			get => _Formation;
			set => _Formation = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
