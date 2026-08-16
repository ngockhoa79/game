using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class HeroTabContent : TabContent
{
	protected List<Hero> mContentList;

	public List<Hero> List => null;

	public bool IsAddMaterilCard { get; set; }

	public bool IsAddHeroCard { get; set; }

	public bool IsAddHeroCardNotInFormation { get; set; }

	public ERarity[] ForbbitnRarity { get; set; }

	public Me.CardFilter SortType { get; set; }

	public override void CreateContentList()
	{
	}
}
