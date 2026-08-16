using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class FriendshipLevelTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class LevelBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int FriendshipTotal;

		[ProtoMember(3)]
		public LevelBonus[] LevelBonuss;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : FriendshipLevelTemplate, new()
		{
			return null;
		}

		public static FriendshipLevelTemplate[] Load()
		{
			return null;
		}
	}
}
