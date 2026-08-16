using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SNewStagesStepReq")]
	public class C2SNewStagesStepReq : IExtensible
	{
		private int _StepId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "StepId", DataFormat = DataFormat.TwosComplement)]
		public int StepId
		{
			get => _StepId;
			set => _StepId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
