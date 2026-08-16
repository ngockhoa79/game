using System;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class UICardStrengthen : IceUIBase
{
	[SerializeField]
	public UICardLevelup levelupUI;

	[SerializeField]
	public UICardWakeup wakeupUI;

	[SerializeField]
	public UICardNurture nutrureUI;

	[SerializeField]
	public UICardBaQi baQiUI;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	public IceUIBtnGroup strengthenTab;

	private Hero card;

	private int enterTab;

	private string CurrentTab;

	public void SetData(Hero card, CardStrengthenIntent.ETab enterTab)
	{
	}

	public void SetTab(int _tab)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	public void RefrushTab(CardStrengthenIntent.ETab _tab)
	{
	}

	private void ActiveTabUI(CardStrengthenIntent.ETab _tab)
	{
	}
}
