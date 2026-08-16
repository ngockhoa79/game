using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "FriendEggsProto")]
	public class FriendEggsProto : IExtensible
	{
		private int _Count;

		private long _EggPickCdOverTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get => _Count;
			set => _Count = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "EggPickCdOverTime", DataFormat = DataFormat.TwosComplement)]
		public long EggPickCdOverTime
		{
			get => _EggPickCdOverTime;
			set => _EggPickCdOverTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
