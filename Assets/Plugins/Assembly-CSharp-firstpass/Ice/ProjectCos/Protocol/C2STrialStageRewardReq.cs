using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2STrialStageRewardReq")]
	public class C2STrialStageRewardReq : IExtensible
	{
		private int _SuperStageId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "SuperStageId", DataFormat = DataFormat.TwosComplement)]
		public int SuperStageId
		{
			get => _SuperStageId;
			set => _SuperStageId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
