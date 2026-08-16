using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2STrialRecordInfoReq")]
	public class C2STrialRecordInfoReq : IExtensible
	{
		private IExtension extensionObject;

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
