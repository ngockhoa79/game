using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialForamtionProto")]
	public class TrialForamtionProto : IExtensible
	{
		private bool _IsMirror;

		private BattleFormationProto _Formation;

		private PlayerSummaryInfoProto _SummaryInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsMirror", DataFormat = DataFormat.Default)]
		public bool IsMirror
		{
			get => _IsMirror;
			set => _IsMirror = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Formation", DataFormat = DataFormat.Default)]
		public BattleFormationProto Formation
		{
			get => _Formation;
			set => _Formation = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
