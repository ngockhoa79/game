using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CLotteryRecordAck")]
	public class S2CLotteryRecordAck : IExtensible
	{
		private readonly List<LotteryRecordProto> _records;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "records", DataFormat = DataFormat.Default)]
		public List<LotteryRecordProto> Records => null;

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
