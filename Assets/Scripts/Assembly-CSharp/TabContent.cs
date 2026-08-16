using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public abstract class TabContent
{
	protected List<ItemHolding> mList;

	public TabContent()
	{
	}

	public abstract void CreateContentList();

	public List<ItemHolding> GetList()
	{
		return null;
	}
}
