using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public sealed class SkillTemplateManager : ConfigSingleExtend<SkillTemplateManager, SkillTemplateExt>
	{
		private Dictionary<int, SkillTemplateExt> _skillsDic;

		public SkillTemplateExt[] Items => null;

		public Dictionary<int, SkillTemplateExt> SkillsDic => null;

		private void InitNoConfigSkillDic()
		{
		}

		private void AddNoConfigSkillItem(int _id, string _prefab, SkillRangeType _rangeType)
		{
		}

		public SkillTemplateExt GetSkillInfo(int _skillId)
		{
			return null;
		}
	}
}
