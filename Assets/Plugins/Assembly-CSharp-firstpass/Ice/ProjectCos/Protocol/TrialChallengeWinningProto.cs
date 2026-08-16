using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "TrialChallengeWinningProto")]
	public class TrialChallengeWinningProto : IExtensible
	{
		private List<TrialWinningStageProto> _StageWinnings;

		private List<TrialWinningStageProto> _SuperStageWinnings;

		private IExtension extensionObject;

		[ProtoMember(2, Name = "StageWinnings", DataFormat = DataFormat.Default)]
		public List<TrialWinningStageProto> StageWinnings

		{

			get => _StageWinnings;

			set => _StageWinnings = value;

		}

		[ProtoMember(3, Name = "SuperStageWinnings", DataFormat = DataFormat.Default)]
		public List<TrialWinningStageProto> SuperStageWinnings

		{

			get => _SuperStageWinnings;

			set => _SuperStageWinnings = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
