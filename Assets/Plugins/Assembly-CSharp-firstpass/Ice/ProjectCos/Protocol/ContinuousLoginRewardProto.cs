using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ContinuousLoginRewardProto")]
	public class ContinuousLoginRewardProto : IExtensible
	{
		private int _Unit;

		private int _SignDay;

		private long _LastReceivedTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Unit", DataFormat = DataFormat.TwosComplement)]
		public int Unit
		{
			get => _Unit;
			set => _Unit = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "SignDay", DataFormat = DataFormat.TwosComplement)]
		public int SignDay
		{
			get => _SignDay;
			set => _SignDay = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "LastReceivedTime", DataFormat = DataFormat.TwosComplement)]
		public long LastReceivedTime
		{
			get => _LastReceivedTime;
			set => _LastReceivedTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
