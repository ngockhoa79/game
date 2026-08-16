using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CTimeSynchronizationAck")]
	public class S2CTimeSynchronizationAck : IExtensible
	{
		private int _TimeZoneRawOffset;

		private long _UnixTimestamp;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "TimeZoneRawOffset", DataFormat = DataFormat.TwosComplement)]
		public int TimeZoneRawOffset
		{
			get => _TimeZoneRawOffset;
			set => _TimeZoneRawOffset = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "UnixTimestamp", DataFormat = DataFormat.TwosComplement)]
		public long UnixTimestamp
		{
			get => _UnixTimestamp;
			set => _UnixTimestamp = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
