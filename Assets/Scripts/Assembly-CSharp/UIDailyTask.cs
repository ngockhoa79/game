using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIDailyTask : IceUIBase, IceUIReusableList<DailyTask>.IVisualizer
{
	public UIDailyTaskListAnimator List;

	private int enterLevel;

	public UITexture txDailyTaskComplete;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOnscreen()
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

	public void SetData(GameObject widget, DailyTask data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void SetList(bool animate = true)
	{
	}

	private void showCompleteTexture()
	{
	}

	public void OnGetReward(ItemDailyTask item, DailyTask dt)
	{
	}

	public void OnGotoBattle(ItemDailyTask item, DailyTask dt)
	{
	}

	public void RequestDailyTaskList()
	{
	}

	private void CheckLevelUp()
	{
	}
}
