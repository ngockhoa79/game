using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class IllustDictGearController : IllustDictBaseController
{
	private List<Gear> AllGearDataList;

	private List<Gear> FilteredGearDataList;

	public int GearComparer(Gear gearA, Gear gearB)
	{
		return 0;
	}

	protected override void DoPrepare()
	{
	}

	protected override void FilterReset()
	{
	}

	protected override void PrepareFilterUI(UIIllustDictFilterPanel filterUI)
	{
	}

	protected override bool IsFilterValid(Filter filter)
	{
		return false;
	}

	protected override void ApplyFilter(Filter filter)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override int LoadPageDataBody(int logicalPageNum, int physicalPageNum)
	{
		return 0;
	}

	protected override int GetTotalPageNumber()
	{
		return 0;
	}

	public override int GetItemTotalCount()
	{
		return 0;
	}

	protected override void RememberPageIndex(int page_index)
	{
	}

	protected override int GetRememberedPageIndex()
	{
		return 0;
	}
}
