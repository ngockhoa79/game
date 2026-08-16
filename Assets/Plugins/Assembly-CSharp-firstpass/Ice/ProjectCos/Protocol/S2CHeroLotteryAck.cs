using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CHeroLotteryAck")]
	public class S2CHeroLotteryAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "HeroSlotSpaceNotEnough", Value = 2)]
			HeroSlotSpaceNotEnough = 2
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Heros;

		private long _NextFreeTime;

		private int _FriendshipValue;

		private int _TryDiamondMustGetPurpleCount;

		private bool _IsDiamondFirstAlready;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get => _Code;
			set => _Code = value;
		}

		[ProtoMember(2, Name = "Heros", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Heros

		{

			get => _Heros;

			set => _Heros = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "NextFreeTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFreeTime
		{
			get => _NextFreeTime;
			set => _NextFreeTime = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "FriendshipValue", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipValue
		{
			get => _FriendshipValue;
			set => _FriendshipValue = value;
		}

		[ProtoMember(5, IsRequired = true, Name = "TryDiamondMustGetPurpleCount", DataFormat = DataFormat.TwosComplement)]
		public int TryDiamondMustGetPurpleCount
		{
			get => _TryDiamondMustGetPurpleCount;
			set => _TryDiamondMustGetPurpleCount = value;
		}

		[ProtoMember(6, IsRequired = true, Name = "IsDiamondFirstAlready", DataFormat = DataFormat.Default)]
		public bool IsDiamondFirstAlready
		{
			get => _IsDiamondFirstAlready;
			set => _IsDiamondFirstAlready = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
