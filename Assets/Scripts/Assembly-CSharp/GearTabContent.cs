using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class GearTabContent : TabContent
{
	protected List<ItemHolding> mContentList;

	public bool AddArmed { get; set; }

	public int AddGearSlotInt { get; set; }

	public Luggage.GearFilter SortType { get; set; }

	public ERarity[] ForbbitnRarity { get; set; }

	public override void CreateContentList()
	{
	}
}
