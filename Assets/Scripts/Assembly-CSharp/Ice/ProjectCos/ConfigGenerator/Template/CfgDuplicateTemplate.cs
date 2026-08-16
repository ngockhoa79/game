using System.Collections.Generic;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	public class CfgDuplicateTemplate : DuplicateTemplate
	{
		public int EnemyHeadId;

		public CfgProtoDuplication.DifficultyEnum ChapterDifficulty;

		public CfgProtoDuplication.StageTypeEnum StageType;

		public List<CfgProtoDuplication.DropItemContent> DropItemList;

		public LevelTextTemplate TextTemplate { get; private set; }

		public override void Init()
		{
		}

		public new static CfgDuplicateTemplate[] Load()
		{
			return null;
		}
	}
}
