using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CSlotMachinePickAck")]
	public class S2CSlotMachinePickAck : IExtensible
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
			[ProtoEnum(Name = "OutOfPickRange", Value = 3)]
			OutOfPickRange = 3,
			[ProtoEnum(Name = "MoneyLess", Value = 4)]
			MoneyLess = 4
		}

		private ResultCode _Code;

		private int _Cost;

		private int _Obtain;

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

		[ProtoMember(2, IsRequired = true, Name = "Cost", DataFormat = DataFormat.TwosComplement)]
		public int Cost
		{
			get => _Cost;
			set => _Cost = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "Obtain", DataFormat = DataFormat.TwosComplement)]
		public int Obtain
		{
			get => _Obtain;
			set => _Obtain = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
