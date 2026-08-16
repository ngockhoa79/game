using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CCornucopiaOpenAck")]
	public class S2CCornucopiaOpenAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NotOpen", Value = 2)]
			NotOpen = 2,
			[ProtoEnum(Name = "OutOfRange", Value = 3)]
			OutOfRange = 3,
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4,
			[ProtoEnum(Name = "AlreadyOpen", Value = 5)]
			AlreadyOpen = 5,
			[ProtoEnum(Name = "NotOpenSlot", Value = 6)]
			NotOpenSlot = 6
		}

		private ResultCode _Code;

		private int _SlotIndex;

		private long _OpenSlotTime;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public ResultCode Code
		{
			get
			{
				return default(ResultCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "SlotIndex", DataFormat = DataFormat.TwosComplement)]
		public int SlotIndex
		{
			get => _SlotIndex;
			set => _SlotIndex = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "OpenSlotTime", DataFormat = DataFormat.TwosComplement)]
		public long OpenSlotTime
		{
			get => _OpenSlotTime;
			set => _OpenSlotTime = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
