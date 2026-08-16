using System;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "QuestDuplicateProto")]
	public class QuestDuplicateProto : IExtensible
	{
		private QuestProto _Normal;

		private ActivityQuestProto _Activity;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Normal", DataFormat = DataFormat.Default)]
		public QuestProto Normal
		{
			get => _Normal;
			set => _Normal = value;
		}

		[ProtoMember(2, IsRequired = true, Name = "Activity", DataFormat = DataFormat.Default)]
		public ActivityQuestProto Activity
		{
			get => _Activity;
			set => _Activity = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
