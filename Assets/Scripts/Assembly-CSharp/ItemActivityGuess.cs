using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemActivityGuess : MonoBehaviour
{
	public UIEventListener eventClick;

	public UniIcon Icon;

	public GameObject SideA;

	public GameObject SideB;

	public IceAnimatorTotalCommander TurnOverItemAnim;

	public IceAnimatorTotalCommander TurnOverBattleAnim;

	public Action<int> E_OnClick;

	private int mIndex;

	private ThingHolding mData;

	private bool mSideA;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetIndex(int index)
	{
	}

	public void Clear()
	{
	}

	public void SetIcon(ThingHolding th)
	{
	}

	public void ShowSideAnother()
	{
	}

	public void ShowSide(bool isSideAShow)
	{
	}

	private void showSide()
	{
	}

	public bool IsSideA()
	{
		return false;
	}

	public void PlayTurnOverAnimation(bool isBattle, Action onComplete)
	{
	}
}
