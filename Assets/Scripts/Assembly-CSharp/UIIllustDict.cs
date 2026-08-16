using System;
using UnityEngine;

public class UIIllustDict : IceUIBase
{
	public IllustDictCoserController DictCoserUI;

	public IllustDictGearController DictGearUI;

	public IllustDictSkillController DictSkillUI;

	public UILabel DictItemCountLabel;

	public UIEventListener ButtonHomePage;

	public UIEventListener ButtonReturn;

	public IceUIBtnGroup ButtonsTab;

	public Action OnReturn;

	public Action OnHomePage;

	private int currentTabID;

	private string currentTabName;

	public void SetData(int _enterTab)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void EnterScene()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	protected override void DoDispose()
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}
}
