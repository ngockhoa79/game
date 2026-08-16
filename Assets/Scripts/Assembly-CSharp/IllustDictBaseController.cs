using UnityEngine;

public abstract class IllustDictBaseController : IceUIBase
{
	public enum Filter
	{
		Filter_Uninitialized = 0,
		Coser_All = 1,
		Coser_HeavySwordsman = 2,
		Coser_LightSwordsman = 3,
		Coser_Fighter = 4,
		Coser_Mage = 5,
		Coser_End = 6,
		Gear_All = 7,
		Gear_Head = 8,
		Gear_Weapon = 9,
		Gear_Upper = 10,
		Gear_Jewelry = 11,
		Gear_End = 12,
		Skill_All = 13,
		Skill_Leader = 14,
		Skill_Support = 15,
		Skill_Passive = 16,
		Skill_Battle = 17,
		Skill_End = 18
	}

	public UIEventListener ArrowButtonLeft;

	public UIEventListener ArrowButtonRight;

	public UIEventListener FilterSelectButton;

	public UILabel FilterSelectButtonText;

	public UIScrollBar BottomScrollBar;

	public UILabel LabelPageNumber;

	public GameObject PageAnchorPoint;

	public UIScrollView InvisibleScrollView;

	public UISprite InvisibleScrollContent;

	public UIProgressBar HorizontalScrollBar;

	protected UIDictPage[] DictPages;

	private int LogicalPageCount;

	private IllustDictPageCombination CurrentPageComb;

	private bool Initialized;

	protected Filter CurrentFilter;

	public abstract int GetItemTotalCount();

	protected abstract int GetTotalPageNumber();

	protected abstract int LoadPageDataBody(int logicalPageNum, int physicalPageNum);

	protected abstract void PrepareFilterUI(UIIllustDictFilterPanel filterUI);

	protected abstract bool IsFilterValid(Filter filter);

	protected abstract void ApplyFilter(Filter filter);

	protected abstract void FilterReset();

	protected abstract void RememberPageIndex(int page_index);

	protected abstract int GetRememberedPageIndex();

	protected override void DoPrepare()
	{
	}

	public void SetData()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected void Reset()
	{
	}

	protected int LoadPageData(int logicalPageNum, int physicalPageNum)
	{
		return 0;
	}

	protected void ChangePageTo(int logical_page_num, bool remember_page_index = false, bool bCleanMemory = true)
	{
	}

	protected void PreviousPage()
	{
	}

	protected void NextPage()
	{
	}

	protected void AutoSetArrowsVisibility()
	{
	}

	protected void DisableArrowButtons(int physical_page)
	{
	}

	protected void EnableArrowButtons()
	{
	}

	protected string GetPageNumberText(int current_page, int total_page)
	{
		return null;
	}

	public void OnFilterSelectButtonClicked(GameObject btn)
	{
	}

	public void OnFilterSelected(Filter new_filter)
	{
	}

	public void OnScrollBar()
	{
	}

	public void OnScrollBarDragFinished()
	{
	}
}
