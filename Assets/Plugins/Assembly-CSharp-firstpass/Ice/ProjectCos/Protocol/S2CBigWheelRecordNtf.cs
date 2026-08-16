using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CBigWheelRecordNtf")]
	public class S2CBigWheelRecordNtf : IExtensible
	{
		private BigWheelInfoProto.RecordProto _RecordInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RecordInfo", DataFormat = DataFormat.Default)]
		public BigWheelInfoProto.RecordProto RecordInfo
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
