using System;
using UnityEngine;

public class UIDialogShopGotoBattle : MonoBehaviour
{
	public Action E_OnGotoBattle;

	public Action E_OnClose;

	public UIEventListener eventGo;

	public UIEventListener eventClose;

	public GameObject[] Headers;

	public UILabel lbEasyBattleValue;

	public UILabel lbNormalBattleValue;

	public UILabel lbHardBattleValue;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Set(int index)
	{
	}

	private void Update()
	{
	}
}
