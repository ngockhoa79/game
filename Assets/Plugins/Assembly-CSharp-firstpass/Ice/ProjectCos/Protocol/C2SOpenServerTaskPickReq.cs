using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SOpenServerTaskPickReq")]
	public class C2SOpenServerTaskPickReq : IExtensible
	{
		private int _TaskId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TaskId", DataFormat = DataFormat.TwosComplement)]
		public int TaskId
		{
			get => _TaskId;
			set => _TaskId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
