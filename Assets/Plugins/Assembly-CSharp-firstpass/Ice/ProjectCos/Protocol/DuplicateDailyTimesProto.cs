using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "DuplicateDailyTimesProto")]
	public class DuplicateDailyTimesProto : IExtensible
	{
		private int _DuplicateId;

		private int _Times;

		private int _BuyLimitTimes;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "DuplicateId", DataFormat = DataFormat.TwosComplement)]
		public int DuplicateId
		{
			get => _DuplicateId;
			set => _DuplicateId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Times", DataFormat = DataFormat.TwosComplement)]
		public int Times
		{
			get => _Times;
			set => _Times = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuyLimitTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyLimitTimes
		{
			get => _BuyLimitTimes;
			set => _BuyLimitTimes = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
