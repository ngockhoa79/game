using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CSlotMachineRecordNtf")]
	public class S2CSlotMachineRecordNtf : IExtensible
	{
		private SlotMachineInfoProto.RecordProto _RecordInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RecordInfo", DataFormat = DataFormat.Default)]
		public SlotMachineInfoProto.RecordProto RecordInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
