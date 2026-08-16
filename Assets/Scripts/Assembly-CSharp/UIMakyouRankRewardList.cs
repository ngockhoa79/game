using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIMakyouRankRewardList : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	[SerializeField]
	private UIMakyouRankRewardListAnimator mlist;

	[SerializeField]
	private IceUIBtnGroup tabs;

	private string CurrentTab;

	private int CurrentIndex;

	protected override void DoInit()
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	private void onchangeTab(int tab)
	{
	}

	private void __request_Level_info_()
	{
	}

	private void __request_info_()
	{
	}

	public CrossPersonRankBonusTemplate[] GetInfo(int type)
	{
		return null;
	}

	private void onClick(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}
}
