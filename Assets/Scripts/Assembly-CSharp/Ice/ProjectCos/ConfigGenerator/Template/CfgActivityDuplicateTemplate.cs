using System;
using System.Collections.Generic;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	public class CfgActivityDuplicateTemplate : ActivityDuplicateTemplate
	{
		public string StageName;

		public DateTime ChapterStartTime;

		public DateTime ChapterEndTime;

		public TimeSpan ChapterOpenWindowTime;

		public TimeSpan ChapterCloseWindowTime;

		public List<CfgProtoDuplication.DropItemContent> DropItemList;

		public override void Init()
		{
		}

		public new static CfgActivityDuplicateTemplate[] Load()
		{
			return null;
		}
	}
}
