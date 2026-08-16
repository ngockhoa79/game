using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "PlayerLotteryInfoProto")]
	public class PlayerLotteryInfoProto : IExtensible
	{
		private bool _IsDiamondFirstAlready;

		private long _NextFreeFriendTryTime;

		private long _NextFreeDiamondTryTime;

		private int _TryDiamondMustGetPurpleCount;

		private bool _IsDiamondTenFirstAlready;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "IsDiamondFirstAlready", DataFormat = DataFormat.Default)]
		public bool IsDiamondFirstAlready
		{
			get => _IsDiamondFirstAlready;
			set => _IsDiamondFirstAlready = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "NextFreeFriendTryTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeFriendTryTime
		{
			get => _NextFreeFriendTryTime;
			set => _NextFreeFriendTryTime = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "NextFreeDiamondTryTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeDiamondTryTime
		{
			get => _NextFreeDiamondTryTime;
			set => _NextFreeDiamondTryTime = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "TryDiamondMustGetPurpleCount", DataFormat = DataFormat.TwosComplement)]
		public int TryDiamondMustGetPurpleCount
		{
			get => _TryDiamondMustGetPurpleCount;
			set => _TryDiamondMustGetPurpleCount = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "IsDiamondTenFirstAlready", DataFormat = DataFormat.Default)]
		public bool IsDiamondTenFirstAlready
		{
			get => _IsDiamondTenFirstAlready;
			set => _IsDiamondTenFirstAlready = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
