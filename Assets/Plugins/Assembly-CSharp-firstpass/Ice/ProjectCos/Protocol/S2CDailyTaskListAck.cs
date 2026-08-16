using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "S2CDailyTaskListAck")]
	public class S2CDailyTaskListAck : IExtensible
	{
		private List<TaskItemProto> _Tasks;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Tasks", DataFormat = DataFormat.Default)]
		public List<TaskItemProto> Tasks

		{

			get => _Tasks;

			set => _Tasks = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
