using System.Collections.Generic;
using UnityEngine;

public class UIBtTopBar : MonoBehaviour
{
	public GameObject heroRoot;

	public UIBtTopHeroCtrller[] heros;

	private Dictionary<int, UIBtTopHeroCtrller> heroDic;

	private int currentIndex;

	private const int HeadGap = 102;

	public IceAnimatorTotalCommander lightChangeAnim;

	public IceAnimatorTotalCommander lightDieAnim;

	public UILabel lightCounter;

	private int activeTeamNum;

	public int TotalTeamNum
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void AddFighter(UIBtFighterInfo _info)
	{
	}

	public void FighterDie(int _fighterId)
	{
	}

	public void ClearFighters()
	{
	}

	public void CheckTopHeads()
	{
	}

	public void PlayHeadInAnim(int _fighterId, float _delay)
	{
	}

	public void ResetHeadInAnim()
	{
	}

	public void PlayLeaderIconAnim(int _fighterId)
	{
	}

	public void PlaySupportIconAnim(int _fighterId)
	{
	}

	public void AddBuff(int _fighterId, int _buffId)
	{
	}

	public void RemoveBuff(int _fighterId, int _buffId)
	{
	}

	public bool InavtiveCurrentTeam()
	{
		return false;
	}
}
