using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class HeroTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Hp_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Attack_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Defense_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Spirit_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Speed_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Critical_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class AntiCritical_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Batter_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class AntiBatter_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Miss_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class AntiMiss_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Block_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class AntiBlock_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Base;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DropLevel : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int HeroId;

		[ProtoMember(2)]
		public int IllustDict;

		[ProtoMember(3)]
		public int Group;

		[ProtoMember(4)]
		public string Prefab;

		[ProtoMember(5)]
		public string SpineName;

		[ProtoMember(6)]
		public int Gender;

		[ProtoMember(7)]
		public int VoiceId;

		[ProtoMember(8)]
		public int Profession;

		[ProtoMember(9)]
		public int CardType;

		[ProtoMember(10)]
		public string Image;

		[ProtoMember(11)]
		public string HeadSmall;

		[ProtoMember(12)]
		public int Chip;

		[ProtoMember(13)]
		public int ChipNum;

		[ProtoMember(14)]
		public int ExpType;

		[ProtoMember(15)]
		public int Rarity;

		[ProtoMember(16)]
		public int Break;

		[ProtoMember(17)]
		public int IsMaxBreak;

		[ProtoMember(18)]
		public int Star;

		[ProtoMember(19)]
		public int BaseLevel;

		[ProtoMember(20)]
		public int MaxLevel;

		[ProtoMember(21)]
		public int SkillId;

		[ProtoMember(22)]
		public int[] Features;

		[ProtoMember(23)]
		public int PotentialGrowth;

		[ProtoMember(24)]
		public int ConvertToExpBase;

		[ProtoMember(25)]
		public int SoldPrice;

		[ProtoMember(26)]
		public Hp_ Hp;

		[ProtoMember(27)]
		public Attack_ Attack;

		[ProtoMember(28)]
		public Defense_ Defense;

		[ProtoMember(29)]
		public Spirit_ Spirit;

		[ProtoMember(30)]
		public Speed_ Speed;

		[ProtoMember(31)]
		public Critical_ Critical;

		[ProtoMember(32)]
		public AntiCritical_ AntiCritical;

		[ProtoMember(33)]
		public Batter_ Batter;

		[ProtoMember(34)]
		public AntiBatter_ AntiBatter;

		[ProtoMember(35)]
		public Miss_ Miss;

		[ProtoMember(36)]
		public AntiMiss_ AntiMiss;

		[ProtoMember(37)]
		public Block_ Block;

		[ProtoMember(38)]
		public AntiBlock_ AntiBlock;

		[ProtoMember(39)]
		public DropLevel[] DropLevels;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : HeroTemplate, new()
		{
			return null;
		}

		public static HeroTemplate[] Load()
		{
			return null;
		}
	}
}
