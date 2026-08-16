using Ice.ProjectCos.Protocol;
using UnityEngine;

public class MakyouPlayoffPlayer : MonoBehaviour
{
	public UILabel PlayerName;

	public UILabel PlayerServer;

	public UILabel WinCount;

	public GameObject WinCountGroup;

	public UISprite IconWin;

	public UISprite IconSupported;

	public UIEventListener ButtonView;

	public IceAnimatorTotalCommander WinCountUpdateAni;

	public IceAnimatorTotalCommander WinAni;

	public IceAnimatorTotalCommander LoseAni;

	protected int BattleIndex;

	protected CrossPersonPlayOffInfoProto.FighterProto PlayerInfoCache;

	public void Setup()
	{
	}

	public void SetData(CrossPersonPlayOffInfoProto.FighterProto playerInfo, int winCount, bool winner, bool supported, int battle_index)
	{
	}

	public void ClearData()
	{
	}

	public void Clear()
	{
	}

	public void OnButtonViewClick(GameObject obj)
	{
	}

	public void ResetAllAni()
	{
	}

	public void PlayWinCountUpdateAni()
	{
	}

	public void PlayWinAni()
	{
	}

	public void PlayWinAniFinalFrame()
	{
	}

	public void PlayLoseAni()
	{
	}

	public void PlayLoseAniFinalFrame()
	{
	}
}
