using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GasTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class GasLevelBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_1_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_1_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_2_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_2_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_3_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_3_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_4_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_4_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_5_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_5_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material_6_ : IGeneratorObject
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

		[ProtoContract]
		public class MaterialBonus_6_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int HeroGroupId;

		[ProtoMember(2)]
		public int GasLevel;

		[ProtoMember(3)]
		public GasLevelBonus[] GasLevelBonuss;

		[ProtoMember(4)]
		public Material_1_ Material_1;

		[ProtoMember(5)]
		public MaterialBonus_1_ MaterialBonus_1;

		[ProtoMember(6)]
		public Material_2_ Material_2;

		[ProtoMember(7)]
		public MaterialBonus_2_ MaterialBonus_2;

		[ProtoMember(8)]
		public Material_3_ Material_3;

		[ProtoMember(9)]
		public MaterialBonus_3_ MaterialBonus_3;

		[ProtoMember(10)]
		public Material_4_ Material_4;

		[ProtoMember(11)]
		public MaterialBonus_4_ MaterialBonus_4;

		[ProtoMember(12)]
		public Material_5_ Material_5;

		[ProtoMember(13)]
		public MaterialBonus_5_ MaterialBonus_5;

		[ProtoMember(14)]
		public Material_6_ Material_6;

		[ProtoMember(15)]
		public MaterialBonus_6_ MaterialBonus_6;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GasTemplate, new()
		{
			return null;
		}

		public static GasTemplate[] Load()
		{
			return null;
		}
	}
}
