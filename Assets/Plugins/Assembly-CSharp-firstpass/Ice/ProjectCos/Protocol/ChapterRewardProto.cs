using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ChapterRewardProto")]
	public class ChapterRewardProto : IExtensible
	{
		[ProtoContract(Name = "FlagEnum")]
		public enum FlagEnum
		{
			[ProtoEnum(Name = "Star_1", Value = 1)]
			Star1 = 1,
			[ProtoEnum(Name = "Star_2", Value = 2)]
			Star2 = 2,
			[ProtoEnum(Name = "Star_3", Value = 4)]
			Star3 = 4
		}

		private int _ChapterId;

		private int _Flag;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get => _ChapterId;
			set => _ChapterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Flag", DataFormat = DataFormat.TwosComplement)]
		public int Flag
		{
			get => _Flag;
			set => _Flag = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
