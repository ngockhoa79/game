using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class IllustDictCoserController : IllustDictBaseController
{
	private List<HeroConfig> AllCoserDataList;

	private List<HeroConfig> FilteredCoserDataList;

	private List<int> IgnoreList;

	public static int CoserComparer(HeroConfig CoserA, HeroConfig CoserB)
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
