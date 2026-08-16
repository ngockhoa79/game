using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "RedPackCoolDownTimeProto")]
	public class RedPackCoolDownTimeProto : IExtensible
	{
		private int _RedPackId;

		private long _OverTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "RedPackId", DataFormat = DataFormat.TwosComplement)]
		public int RedPackId
		{
			get => _RedPackId;
			set => _RedPackId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "OverTime", DataFormat = DataFormat.TwosComplement)]
		public long OverTime
		{
			get => _OverTime;
			set => _OverTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
