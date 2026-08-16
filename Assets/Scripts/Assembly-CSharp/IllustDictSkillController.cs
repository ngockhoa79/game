using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class IllustDictSkillController : IllustDictBaseController
{
	private List<Skill> AllSkillDataList;

	private List<Skill> FilteredSkillDataList;

	public int SkillComparer(Skill skillA, Skill skillB)
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
