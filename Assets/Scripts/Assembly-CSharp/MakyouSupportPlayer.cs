using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class MakyouSupportPlayer : MonoBehaviour
{
	public enum SupportState
	{
		None = 0,
		Supported = 1,
		SupportedOpponent = 2
	}

	public enum PlayerPosition
	{
		Left = 0,
		Right = 1
	}

	public UIAeCardDisplayer PlayerIcon;

	public UILabel PlayerName;

	public UILabel PlayerLevel;

	public UILabel FightPower;

	public UILabel SupporterCount;

	public UILabel SupportPriceActive;

	public UILabel SupportPriceInactive;

	public UIEventListener ButtonView;

	public UIEventListener ButtonSupport;

	public GameObject ButtonSupportDisable;

	public GameObject SpriteSupported;

	public Action<PlayerPosition> E_Support;

	protected CrossPersonPlayOffInfoProto.FighterProto PlayerInfoCache;

	protected SupportState PlayerSupportState;

	protected PlayerPosition PlayerSide;

	protected int BattleIndex;

	public void Setup()
	{
	}

	public void SetData(CrossPersonPlayOffInfoProto.FighterProto playerInfo, SupportState supportState, PlayerPosition side, int battleIndex)
	{
	}

	public void ClearData()
	{
	}

	public void Clear()
	{
	}

	private void OnViewClicked(GameObject btn)
	{
	}

	private void OnSupportClicked(GameObject btn)
	{
	}
}
