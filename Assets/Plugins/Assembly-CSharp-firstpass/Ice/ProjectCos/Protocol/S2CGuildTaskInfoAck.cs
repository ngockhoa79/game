using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CGuildTaskInfoAck")]
	public class S2CGuildTaskInfoAck : IExtensible
	{
		[ProtoContract(Name = "ResultCode")]
		public enum ResultCode
		{
			[ProtoEnum(Name = "Error", Value = 0)]
			Error = 0,
			[ProtoEnum(Name = "Success", Value = 1)]
			Success = 1,
			[ProtoEnum(Name = "NoGuild", Value = 4)]
			NoGuild = 4
		}

		private ResultCode _Code;

		private List<TaskItemProto> _TaskInfo;

		private int _ActivityValue;

		private int _Mark;

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

		[ProtoMember(2, Name = "TaskInfo", DataFormat = DataFormat.Default)]
		public List<TaskItemProto> TaskInfo

		{

			get => _TaskInfo;

			set => _TaskInfo = value;

		}

		[ProtoMember(3, IsRequired = true, Name = "ActivityValue", DataFormat = DataFormat.TwosComplement)]
		public int ActivityValue
		{
			get => _ActivityValue;
			set => _ActivityValue = value;
		}

		[ProtoMember(4, IsRequired = true, Name = "Mark", DataFormat = DataFormat.TwosComplement)]
		public int Mark
		{
			get => _Mark;
			set => _Mark = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
