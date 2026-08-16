using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class HeroEffectTemplateManager : ConfigSingleExtend<HeroEffectTemplateManager, HeroEffectTemplate>
	{
		public HashSet<string> BundleSet;

		public Dictionary<string, object> EffectDic => null;
	}
}
