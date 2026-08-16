using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public sealed class EffectBundleTemplateManager : ConfigSingleExtendString<EffectBundleTemplateManager, EffectBundleTemplate>
	{
		public Dictionary<string, string> EffectBundleDic;

		public HashSet<string> BundleSet;

		private void AddEffectToDic(string _key, string _value)
		{
		}
	}
}
