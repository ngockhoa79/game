using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ActivityChapterDailyProto")]
	public class ActivityChapterDailyProto : IExtensible
	{
		private int _ChapterId;

		private int _Times;

		private int _BuyTimes;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get => _ChapterId;
			set => _ChapterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Times", DataFormat = DataFormat.TwosComplement)]
		public int Times
		{
			get => _Times;
			set => _Times = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "BuyTimes", DataFormat = DataFormat.TwosComplement)]
		public int BuyTimes
		{
			get => _BuyTimes;
			set => _BuyTimes = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
