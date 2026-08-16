using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "OnlineRewardProto")]
	public class OnlineRewardProto : IExtensible
	{
		private int _Id;

		private long _ReceivedTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get => _Id;
			set => _Id = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "ReceivedTime", DataFormat = DataFormat.TwosComplement)]
		public long ReceivedTime
		{
			get => _ReceivedTime;
			set => _ReceivedTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
