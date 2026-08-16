using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialWinningStageProto")]
	public class TrialWinningStageProto : IExtensible
	{
		private PlayerSummaryInfoProto _SummaryInfo;

		private int _TotalChallengeaCount;

		private int _WinCount;

		private bool _IsMirror;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SummaryInfo", DataFormat = DataFormat.Default)]
		public PlayerSummaryInfoProto SummaryInfo
		{
			get => _SummaryInfo;
			set => _SummaryInfo = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "TotalChallengeaCount", DataFormat = DataFormat.TwosComplement)]
		public int TotalChallengeaCount
		{
			get => _TotalChallengeaCount;
			set => _TotalChallengeaCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "WinCount", DataFormat = DataFormat.TwosComplement)]
		public int WinCount
		{
			get => _WinCount;
			set => _WinCount = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "IsMirror", DataFormat = DataFormat.Default)]
		public bool IsMirror
		{
			get => _IsMirror;
			set => _IsMirror = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
