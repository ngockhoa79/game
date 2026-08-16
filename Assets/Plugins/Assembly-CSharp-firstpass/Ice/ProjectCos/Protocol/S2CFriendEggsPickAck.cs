using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CFriendEggsPickAck")]
	public class S2CFriendEggsPickAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Success", Value = 0)]
			Success = 0,
			[ProtoEnum(Name = "Error", Value = 1)]
			Error = 1,
			[ProtoEnum(Name = "IsNotFull", Value = 2)]
			IsNotFull = 2,
			[ProtoEnum(Name = "IsInCd", Value = 3)]
			IsInCd = 3
		}

		private ResultCode _Code;

		private int _EggCount;

		private long _EggPickCdOverTime;

		private List<ItemChangeProto> _Changes;

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

		[ProtoMember(2, IsRequired = true, Name = "EggCount", DataFormat = DataFormat.TwosComplement)]
		public int EggCount
		{
			get => _EggCount;
			set => _EggCount = value;
		}

		[ProtoMember(3, IsRequired = true, Name = "EggPickCdOverTime", DataFormat = DataFormat.TwosComplement)]
		public long EggPickCdOverTime
		{
			get => _EggPickCdOverTime;
			set => _EggPickCdOverTime = value;
		}

		[ProtoMember(4, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
