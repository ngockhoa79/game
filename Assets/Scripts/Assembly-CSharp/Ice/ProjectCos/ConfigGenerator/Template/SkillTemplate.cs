using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class SkillTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class TriggerType : IGeneratorObject
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

		[ProtoContract]
		public class TargetFilter : IGeneratorObject
		{
			[ProtoMember(1)]
			public int FilterType;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Statement : IGeneratorObject
		{
			[ProtoMember(1)]
			public int StatementType;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Action : IGeneratorObject
		{
			[ProtoMember(1)]
			public int ActionType;

			[ProtoMember(2)]
			public int IParam1;

			[ProtoMember(3)]
			public int IParam2;

			[ProtoMember(4)]
			public int IParam3;

			[ProtoMember(5)]
			public int IParam4;

			[ProtoMember(6)]
			public int IParam5;

			[ProtoMember(7)]
			public int IParam6;

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
		public int SkillId;

		[ProtoMember(2)]
		public int SkillGroup;

		[ProtoMember(3)]
		public int AntiSkillGroup;

		[ProtoMember(4)]
		public string SkillName;

		[ProtoMember(5)]
		public string SkillDescription;

		[ProtoMember(6)]
		public string Prefab;

		[ProtoMember(7)]
		public int HitTimes;

		[ProtoMember(8)]
		public int[] HeavyHits;

		[ProtoMember(9)]
		public int ShootSpeed;

		[ProtoMember(10)]
		public string SkillIcon;

		[ProtoMember(11)]
		public int SkillRarity;

		[ProtoMember(12)]
		public TriggerType[] TriggerTypes;

		[ProtoMember(13)]
		public int SkillStar;

		[ProtoMember(14)]
		public int SkillType;

		[ProtoMember(15)]
		public int ProfessionRestric;

		[ProtoMember(16)]
		public int CriticalRate;

		[ProtoMember(17)]
		public int AddattackRate;

		[ProtoMember(18)]
		public int AntimissRate;

		[ProtoMember(19)]
		public int AntiblockRate;

		[ProtoMember(20)]
		public int SoldPrice;

		[ProtoMember(21)]
		public int TargetRangeType;

		[ProtoMember(22)]
		public int TargetFilterBool;

		[ProtoMember(23)]
		public TargetFilter[] TargetFilters;

		[ProtoMember(24)]
		public Statement[] Statements;

		[ProtoMember(25)]
		public Action[] Actions;

		[ProtoMember(26)]
		public int[] Combines;

		[ProtoMember(27)]
		public DropLevel[] DropLevels;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : SkillTemplate, new()
		{
			return null;
		}

		public static SkillTemplate[] Load()
		{
			return null;
		}
	}
}
