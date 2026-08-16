using System;
using UnityEngine;

public class UIMakyouRegularWin : IceUIBase
{
	public UISprite MakyouGroupIcon;

	public UIEventListener ButtonConfirm;

	public UILabel ComboWin;

	public UILabel TimesLeft;

	public UILabel ScoreChange;

	public UILabel MakyouExpBarText;

	public UISlider MakyouExpBar;

	public IceAnimatorTotalCommander AnimIn;

	public IceAnimatorTotalCommander AnimBadge;

	public void Start()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
		if (ButtonConfirm != null)
		{
			ButtonConfirm.onClick = OnConfirmClick;
		}
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetData()
	{
		gameObject.SetActive(true);
	}

	private void OnConfirmClick(GameObject btn)
	{
		if (GlobalManager.Instance.SceneManager != null)
		{
			GlobalManager.Instance.SceneManager.EnterMainStage(false);
		}
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		if (onEnterScreen != null) onEnterScreen();
	}

	private void OnClose(GameObject btn)
	{
		OnConfirmClick(btn);
	}
}
