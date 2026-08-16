using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SNewStagesSaveDataReq")]
	public class C2SNewStagesSaveDataReq : IExtensible
	{
		private int _Data;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Data", DataFormat = DataFormat.TwosComplement)]
		public int Data
		{
			get => _Data;
			set => _Data = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
