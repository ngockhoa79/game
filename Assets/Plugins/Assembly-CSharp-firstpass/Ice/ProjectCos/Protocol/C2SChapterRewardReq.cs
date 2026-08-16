using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "C2SChapterRewardReq")]
	public class C2SChapterRewardReq : IExtensible
	{
		private int _ChapterId;

		private int _RewardId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get => _ChapterId;
			set => _ChapterId = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "RewardId", DataFormat = DataFormat.TwosComplement)]
		public int RewardId
		{
			get => _RewardId;
			set => _RewardId = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
