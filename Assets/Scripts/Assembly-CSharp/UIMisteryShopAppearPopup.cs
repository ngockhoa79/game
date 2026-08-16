using System;
using UnityEngine;

public class UIMisteryShopAppearPopup : MonoBehaviour
{
	public UIEventListener eventGotoMistery;

	public UIEventListener eventClose;

	public IceAnimatorTotalCommander TurnOutAnimtaion;

	public Action<bool> OnChoose;

	private void Start()
	{
	}

	private void DoDestroy()
	{
	}
}
