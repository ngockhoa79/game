using System;
using UnityEngine;

public class UIPVEChapterRoot : IceUIBase
{
	public int defaultChapterId;

	[HideInInspector]
	public int ProgressType;

	public UIPVEChapterContainer Container;

	public UIEventListener btnBack;

	public UIEventListener btnMainPage;

	public Action E_OnBack;

	public Action E_OnMainPage;

	public Action E_OnAddEnergy;

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnBackClicked(GameObject go)
	{
	}

	private void OnMainPageClicked(GameObject go)
	{
	}

	protected override void DoDispose()
	{
	}
}
