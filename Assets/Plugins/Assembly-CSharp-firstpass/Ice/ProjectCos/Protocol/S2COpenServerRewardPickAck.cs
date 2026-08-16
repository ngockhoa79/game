using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2COpenServerRewardPickAck")]
	public class S2COpenServerRewardPickAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "AlreadyPick", Value = 2)]
			AlreadyPick = 2,
			[ProtoEnum(Name = "IndexOutOfRange", Value = 3)]
			IndexOutOfRange = 3,
			[ProtoEnum(Name = "ActivityClose", Value = 4)]
			ActivityClose = 4
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private int _RewardMark;

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

		[ProtoMember(2, Name = "Changes", DataFormat = DataFormat.Default)]
		public List<ItemChangeProto> Changes

		{

			get => _Changes;

			set => _Changes = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "RewardMark", DataFormat = DataFormat.TwosComplement)]
		public int RewardMark
		{
			get => _RewardMark;
			set => _RewardMark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
