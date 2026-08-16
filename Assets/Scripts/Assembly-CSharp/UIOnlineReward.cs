using System;
using UnityEngine;

public class UIOnlineReward : IceUIBase
{
	public GameObject goEnable;

	public GameObject goDisable;

	public UIEventListener btnOnClick;

	public UILabel lbText;

	public BoxCollider collider;

	private int _lastTime;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void Update()
	{
	}

	private void CheckVisible()
	{
	}

	public void Refresh()
	{
	}

	private void SetWidgetState()
	{
	}

	private void OnClicked(GameObject go)
	{
	}

	private string ToFormatTime(int second)
	{
		return null;
	}
}
