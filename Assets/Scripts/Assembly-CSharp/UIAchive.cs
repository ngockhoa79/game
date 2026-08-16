using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAchive : IceUIBase, IceUIReusableList<AchiveGroup>.IVisualizer
{
	public UIAchiveGroupListAnimator List;

	public GameObject txAchieveComplete;

	protected override void DoInit()
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

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, AchiveGroup data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void SetList()
	{
	}

	private void checkReddot()
	{
	}

	public void RequestAchiveList()
	{
	}

	public void OnGetReward(ItemAchive item, AchiveGroup ag)
	{
	}

	public void OnGotoBattle(ItemAchive item, AchiveGroup ag)
	{
	}
}
