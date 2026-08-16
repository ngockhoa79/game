using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "ActivityQuestProto")]
	public class ActivityQuestProto : IExtensible
	{
		private List<ActivityChapterProto> _Chapters;

		private List<ActivityChapterDailyProto> _DailyInfo;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Chapters", DataFormat = DataFormat.Default)]
		public List<ActivityChapterProto> Chapters

		{

			get => _Chapters;

			set => _Chapters = value;

		}

		[ProtoMember(2, Name = "DailyInfo", DataFormat = DataFormat.Default)]
		public List<ActivityChapterDailyProto> DailyInfo

		{

			get => _DailyInfo;

			set => _DailyInfo = value;

		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
