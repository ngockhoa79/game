using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortSpeedupAck")]
	public class S2CEscortSpeedupAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoInTime", Value = 2)]
			NoInTime = 2,
			[ProtoEnum(Name = "NoInRunning", Value = 3)]
			NoInRunning = 3,
			[ProtoEnum(Name = "SpeedIsMax", Value = 4)]
			SpeedIsMax = 4,
			[ProtoEnum(Name = "MoneyLess", Value = 5)]
			MoneyLess = 5
		}

		private ResultCode _Code;

		private EscortCarInfoProto.SpeedCodeEnum _NewSpeed;

		private string _Speed;

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

		[ProtoMember(2, IsRequired = true, Name = "NewSpeed", DataFormat = DataFormat.TwosComplement)]
		public EscortCarInfoProto.SpeedCodeEnum NewSpeed
		{
			get
			{
				return default(EscortCarInfoProto.SpeedCodeEnum);
			}
			set
			{
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "Speed", DataFormat = DataFormat.Default)]
		public string Speed
		{
			get => _Speed;
			set => _Speed = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
