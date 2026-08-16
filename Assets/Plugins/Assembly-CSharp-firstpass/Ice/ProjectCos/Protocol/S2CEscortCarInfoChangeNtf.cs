using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortCarInfoChangeNtf")]
	public class S2CEscortCarInfoChangeNtf : IExtensible
	{
		[ProtoContract(Name = "StatusCode")]
		public enum StatusCode
		{
			[ProtoEnum(Name = "SpeedUp", Value = 0)]
			SpeedUp = 0,
			[ProtoEnum(Name = "BeWrest", Value = 1)]
			BeWrest = 1,
			[ProtoEnum(Name = "Inspire", Value = 2)]
			Inspire = 2,
			[ProtoEnum(Name = "New", Value = 3)]
			New = 3,
			[ProtoEnum(Name = "Complete", Value = 4)]
			Complete = 4
		}

		private StatusCode _Status;

		private EscortTargetProto _TargetCarInfo;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public StatusCode Status
		{
			get
			{
				return default(StatusCode);
			}
			set
			{
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "TargetCarInfo", DataFormat = DataFormat.Default)]
		public EscortTargetProto TargetCarInfo
		{
			get => _TargetCarInfo;
			set => _TargetCarInfo = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
