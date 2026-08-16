using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class FormationTemplateExt : FormationTemplate
	{
		public List<MonsterTemplateExt> Monsters { get; private set; }

		public double CombatValue { get; private set; }

		public new EnterBattleType[] EnterTypes => null;

		public override void Init()
		{
		}

		private void DelayInit()
		{
		}
	}
}
