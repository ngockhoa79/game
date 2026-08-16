using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ActivityChapterTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string EventType;

		[ProtoMember(3)]
		public string ChapterName;

		[ProtoMember(4)]
		public int DropType;

		[ProtoMember(5)]
		public int ChapterPosition;

		[ProtoMember(6)]
		public string ChapterBg;

		[ProtoMember(7)]
		public string EnemyHead;

		[ProtoMember(8)]
		public int EnergyCost;

		[ProtoMember(9)]
		public int LimitTimes;

		[ProtoMember(10)]
		public int BuyTimes;

		[ProtoMember(11)]
		public int Exp;

		[ProtoMember(12)]
		public string StartTime;

		private string enttime;

		[ProtoMember(13)]
		public string EndTime;

		[ProtoMember(14)]
		public string OpenWindow;

		[ProtoMember(15)]
		public int[] CirclePoints;

		[ProtoMember(16)]
		public int Hint;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ActivityChapterTemplate, new()
		{
			return null;
		}

		public static ActivityChapterTemplate[] Load()
		{
			return null;
		}
	}
}
