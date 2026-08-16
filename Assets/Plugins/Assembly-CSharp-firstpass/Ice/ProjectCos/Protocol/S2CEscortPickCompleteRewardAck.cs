using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CEscortPickCompleteRewardAck")]
	public class S2CEscortPickCompleteRewardAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1
		}

		private ResultCode _Code;

		private List<ItemChangeProto> _Changes;

		private EscortPlayerInfoProto _Info;

		private List<EscortWrestRecordProto> _Records;

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

		[ProtoMember(3, IsRequired = true, Name = "Info", DataFormat = DataFormat.Default)]
		public EscortPlayerInfoProto Info
		{
			get => _Info;
			set => _Info = value;
		}

		[ProtoMember(4, Name = "Records", DataFormat = DataFormat.Default)]
		public List<EscortWrestRecordProto> Records

		{

			get => _Records;

			set => _Records = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
