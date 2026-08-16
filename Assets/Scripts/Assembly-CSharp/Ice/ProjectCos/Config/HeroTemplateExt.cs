using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class HeroTemplateExt : HeroTemplate
	{
		public struct PropertyItem
		{
			public int BaseValue;

			public int AdditionValue;

			public int Multiplier;

			public int FinalValue;

			public PropertyItem(int _base, int _add, int _mul, int _final)
			{
				BaseValue = 0;
				AdditionValue = 0;
				Multiplier = 0;
				FinalValue = 0;
			}
		}

		private PropertyItemModel hp_;

		private PropertyItemModel attack_;

		private PropertyItemModel defense_;

		private PropertyItemModel spirit_;

		private PropertyItemModel speed_;

		private PropertyItemModel crit_;

		private PropertyItemModel antiCrit_;

		private PropertyItemModel miss_;

		private PropertyItemModel antiMiss_;

		private PropertyItemModel block_;

		private PropertyItemModel antiBlock_;

		private PropertyItemModel batter_;

		private PropertyItemModel antiBatter_;

		public CardTextTemplate TextTemplate { get; private set; }

		public ItemTemplateExt ChipTemplate { get; private set; }

		public PropertyItem HpProperty => default(PropertyItem);

		public PropertyItem AttackProperty => default(PropertyItem);

		public PropertyItem DefenseProperty => default(PropertyItem);

		public PropertyItem SpiritProperty => default(PropertyItem);

		public PropertyItem SpeedProperty => default(PropertyItem);

		public PropertyItem CritProperty => default(PropertyItem);

		public PropertyItem AntiCritProperty => default(PropertyItem);

		public PropertyItem MissProperty => default(PropertyItem);

		public PropertyItem AntiMissProperty => default(PropertyItem);

		public PropertyItem BlockProperty => default(PropertyItem);

		public PropertyItem AntiBlockProperty => default(PropertyItem);

		public PropertyItem BatterProperty => default(PropertyItem);

		public PropertyItem AntiBatterProperty => default(PropertyItem);

		public SkillTemplateExt SkillTmpl { get; private set; }

		public SkillTemplateExt[] FeatureTmpls { get; private set; }

		public double CombatValue { get; private set; }

		public new EHeroProfession Profession => default(EHeroProfession);

		public new ERarity Rarity => default(ERarity);

		public int BaseExpTotal => 0;

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}

		private void AddProperty(HeroPropertyType type, int value, int multiplier = 0)
		{
		}

		private void CalculationProperty()
		{
		}

		private void BuildCombatValue()
		{
		}
	}
}
