using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMakyouOpponent : IceUIBase
{
	public UITexture PlayerImage;

	public UILabel PlayerName;

	public UISprite RankIcon;

	public UILabel FightPower;

	public UILabel WinRate;

	public UILabel Desc;

	public UIEventListener ButtonZoom;

	public UIEventListener ButtonCard;

	public Action E_NoChallengeCount;

	private CrossPersonTargetInfoProto OpponentData;

	public void SetData(CrossPersonTargetInfoProto opponentData)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void OnButtonZoomClick(GameObject btn)
	{
	}

	public void OnButtonCardClick(GameObject btn)
	{
	}

	public void LoadTexture()
	{
	}

	public void ClearTexture()
	{
	}

	public void ClearData()
	{
	}

	private Friend CreateOpponent()
	{
		return null;
	}
}
