using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuildCrossPkCtrller : MonoBehaviour
{
	public UIGuildCrossPkTopInfoCtrller[] topGuilds;

	public UIEventListener helpBtn;

	public GameObject enterGroup;

	public UIEventListener enterBattleBtn;

	public UILabel enterCenterText;

	public UILabel enterRightText;

	public GameObject signUpGroup;

	public UIEventListener signUpBtn;

	public UILabel signPrice;

	public UILabel signCenterText;

	public UILabel signRightText;

	private CrossGuildInfoProto.StatusEnum status;

	private DateTime nextPoint;

	private bool timerStart;

	public void Set()
	{
	}

	private void Update()
	{
	}

	private void req()
	{
	}

	private void tip(string t)
	{
	}

	private void SetUI(S2CCrossGuildInfoAck _ack)
	{
	}

	private void OnSignUpClicked(GameObject _obj)
	{
	}

	private void OnEnterBattleClicked(GameObject _obj)
	{
	}

	private void OnHelpClicked(GameObject _obj)
	{
	}
}
