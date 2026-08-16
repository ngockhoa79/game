using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class PlayerLevelTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class TrailGold_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int LevelExp;

		[ProtoMember(3)]
		public int StaminaMax;

		[ProtoMember(4)]
		public int EnergyMax;

		[ProtoMember(5)]
		public int EnergyBonus;

		[ProtoMember(6)]
		public int HeroMax;

		[ProtoMember(7)]
		public int FriendMax;

		[ProtoMember(8)]
		public int FriendGiftNumber;

		[ProtoMember(9)]
		public int NewFuction;

		[ProtoMember(10)]
		public TrailGold_ TrailGold;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : PlayerLevelTemplate, new()
		{
			return null;
		}

		public static PlayerLevelTemplate[] Load()
		{
			return null;
		}
	}
}
