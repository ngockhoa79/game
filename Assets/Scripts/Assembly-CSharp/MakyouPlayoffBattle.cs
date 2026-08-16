using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class MakyouPlayoffBattle : MonoBehaviour
{
	public enum EBattleStatus
	{
		Prepare = 0,
		Fighting = 1,
		Over = 2
	}

	public MakyouPlayoffPlayer PlayerA;

	public MakyouPlayoffPlayer PlayerB;

	public UIEventListener ButtonSupport;

	public UIEventListener ButtonViewBattle;

	public Action E_InfoChanged;

	private CrossPersonPlayOffInfoProto.BattleOnceProto BattleData;

	private int BattleIndex;

	private EBattleStatus BattleStatus;

	private MakyouData.PlayoffsFightType BattleType;

	public void Setup()
	{
	}

	public void SetData(CrossPersonPlayOffInfoProto.BattleOnceProto battleData, int battleIndex)
	{
	}

	public void ResetUI()
	{
	}

	public void ClearData()
	{
	}

	public void Clear()
	{
	}

	private void OnSupportClicked(GameObject btn)
	{
	}

	private void OnViewClicked(GameObject btn)
	{
	}
}
