using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class SkillTemplateExt : SkillTemplate
	{
		public const int kAddBuffAction = 2;

		public const int kPercentageChange = 2;

		public const int kPropertyBuffActionType = 1;

		public SkillTextTemplate TextTemplate { get; private set; }

		public double CombatValue { get; private set; }

		public ERarity Rarity => default(ERarity);

		public new ESkillType SkillType => default(ESkillType);

		public SkillType SkillTypeForBattle
		{
			get
			{
				return default(SkillType);
			}
			set
			{
			}
		}

		public SkillRangeType RangeType
		{
			get
			{
				return default(SkillRangeType);
			}
			set
			{
			}
		}

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}

		public void ForeachPropertyAction(Action<HeroPropertyType, int, int> action)
		{
		}

		public static bool IsPassivityBuffAction(BuffTemplate.Action action)
		{
			return false;
		}
	}
}
