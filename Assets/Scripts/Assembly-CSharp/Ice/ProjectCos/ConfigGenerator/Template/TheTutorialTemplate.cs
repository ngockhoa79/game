using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TheTutorialTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Stage;

		[ProtoMember(2)]
		public string StateID;

		[ProtoMember(3)]
		public int[] RectCenterPoints;

		[ProtoMember(4)]
		public int[] RectWidthHeights;

		[ProtoMember(5)]
		public int NPCRequired;

		[ProtoMember(6)]
		public string NPCId;

		[ProtoMember(7)]
		public int NPCEM;

		[ProtoMember(8)]
		public int NPCFlip;

		[ProtoMember(9)]
		public int[] NPCPositions;

		[ProtoMember(10)]
		public int FingerRequired;

		[ProtoMember(11)]
		public int FingerDirection;

		[ProtoMember(12)]
		public int FingerAnimatedType;

		[ProtoMember(13)]
		public int FingerDeferFrames;

		[ProtoMember(14)]
		public int[] FingerPositions;

		[ProtoMember(15)]
		public int DialogRequired;

		[ProtoMember(16)]
		public int Arrow;

		[ProtoMember(17)]
		public int PowerPoint;

		[ProtoMember(18)]
		public string DialogSentence;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TheTutorialTemplate, new()
		{
			return null;
		}

		public static TheTutorialTemplate[] Load()
		{
			return null;
		}
	}
}
