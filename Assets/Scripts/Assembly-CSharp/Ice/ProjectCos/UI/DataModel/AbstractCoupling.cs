using System.Collections.Generic;
using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class AbstractCoupling
	{
		private static Dictionary<int, AbstractCoupling> couplings;

		public int ID { get; private set; }

		public int TargetHeroGroupID { get; private set; }

		public AbstractBuff Buff { get; private set; }

		public static IEnumerable<AbstractCoupling> Couplings => null;

		public abstract bool IsTriggered(Hero hero);

		public static AbstractCoupling Get(int configID)
		{
			return null;
		}

		public static void LoadFromTemplates()
		{
		}

		protected abstract bool FromTemplate(BondTemplateExt template);

		protected bool ParseConfig(BondTemplateExt template)
		{
			return false;
		}

		protected static AbstractBuff ParseBuff(BondTemplateExt template, string buffName)
		{
			return null;
		}

		public string FormatToPercentage(float v)
		{
			return null;
		}
	}
}
