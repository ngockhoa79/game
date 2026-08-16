using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Ice.ProjectCos.Protocol
{
	[Serializable]
	[ProtoContract(Name = "QuestProto")]
	public class QuestProto : IExtensible
	{
		private List<DuplicateProto> _Duplicates;

		private List<ChapterRewardProto> _ChapterRewards;

		private List<DuplicateDailyTimesProto> _DailyTimes;

		private int _FreeSweepUsedCount;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "Duplicates", DataFormat = DataFormat.Default)]
		public List<DuplicateProto> Duplicates

		{

			get => _Duplicates;

			set => _Duplicates = value;

		}

		[ProtoMember(2, Name = "ChapterRewards", DataFormat = DataFormat.Default)]
		public List<ChapterRewardProto> ChapterRewards

		{

			get => _ChapterRewards;

			set => _ChapterRewards = value;

		}

		[ProtoMember(3, Name = "DailyTimes", DataFormat = DataFormat.Default)]
		public List<DuplicateDailyTimesProto> DailyTimes

		{

			get => _DailyTimes;

			set => _DailyTimes = value;

		}

		[ProtoMember(4, IsRequired = true, Name = "FreeSweepUsedCount", DataFormat = DataFormat.TwosComplement)]
		public int FreeSweepUsedCount
		{
			get => _FreeSweepUsedCount;
			set => _FreeSweepUsedCount = value;
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}
}
