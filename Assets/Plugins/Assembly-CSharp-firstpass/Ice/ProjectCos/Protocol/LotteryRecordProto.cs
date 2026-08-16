using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "LotteryRecordProto")]
	public class LotteryRecordProto : IExtensible
	{
		private int _HeroId;

		private int _Rarity;

		private long _Time;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get => _HeroId;
			set => _HeroId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Rarity", DataFormat = DataFormat.TwosComplement)]
		public int Rarity
		{
			get => _Rarity;
			set => _Rarity = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public long Time
		{
			get => _Time;
			set => _Time = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
