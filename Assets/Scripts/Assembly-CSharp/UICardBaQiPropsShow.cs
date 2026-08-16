using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiPropsShow : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	[SerializeField]
	private GearProperty[] listPros;

	public Action E_OnClose;

	private Hero hero;

	public void SetData(Hero hero)
	{
	}

	protected override void DoInit()
	{
	}

	private void onCloseClick(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
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
}
