using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.Config
{
	public sealed class GlobalTemplateManager : ConfigSingle<GlobalTemplateManager, GlobalConfigTemplateExt>
	{
		public static GlobalConfigTemplateExt Template { get; private set; }

		public int GetSkillCombatBaseValue(ERarity rarity)
		{
			return 0;
		}
	}
}
