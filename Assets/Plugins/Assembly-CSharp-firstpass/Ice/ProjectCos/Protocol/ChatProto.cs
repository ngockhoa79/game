using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ChatProto")]
	public class ChatProto : IExtensible
	{
		private int _WorldChatEnableTimes;

		private long _LastRefreshTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "WorldChatEnableTimes", DataFormat = DataFormat.TwosComplement)]
		public int WorldChatEnableTimes
		{
			get => _WorldChatEnableTimes;
			set => _WorldChatEnableTimes = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "LastRefreshTime", DataFormat = DataFormat.TwosComplement)]
		public long LastRefreshTime
		{
			get => _LastRefreshTime;
			set => _LastRefreshTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
