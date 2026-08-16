using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class SkillTabContent : TabContent
{
	protected List<SkillHolding> mContentList;

	public bool AddArmed { get; set; }

	public Luggage.SkillFilter SortType { get; set; }

	public ERarity[] ForbbitnRarity { get; set; }

	public override void CreateContentList()
	{
	}
}
