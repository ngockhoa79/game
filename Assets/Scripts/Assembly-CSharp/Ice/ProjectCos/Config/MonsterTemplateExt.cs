using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class MonsterTemplateExt : MonsterTemplate
	{
		private const int kIsSkillEnableValue = 1;

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

		public EHeroProfession Profession => default(EHeroProfession);

		public HeroTemplateExt HeroTemplate { get; private set; }

		private bool IsTalentSkillEnable => false;

		public int Hp => 0;

		public int Attack => 0;

		public int Defense => 0;

		public int Spirit => 0;

		public int Speed => 0;

		public int Crit => 0;

		public int AntiCrit => 0;

		public int Miss => 0;

		public int AntiMiss => 0;

		public int Block => 0;

		public int AntiBlock => 0;

		public int Batter => 0;

		public int AntiBatter => 0;

		public SkillTemplateExt[] Skills { get; private set; }

		public SkillTemplateExt[] Features { get; private set; }

		public double CombatValue { get; private set; }

		private void AddProperty(HeroPropertyType type, int value, int multiplier = 0)
		{
		}

		private void CalculationProperty()
		{
		}

		private void BuildCombatValue()
		{
		}

		public override void Init()
		{
		}

		public void DelayInit()
		{
		}
	}
}
