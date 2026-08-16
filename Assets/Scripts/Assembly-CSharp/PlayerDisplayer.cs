using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class PlayerDisplayer : IceUIBase
{
	private const string ResCategory = "uiarena";

	private const string UIPvPRank = "UIPvPRank";

	private const string UIPvPRank10 = "UIPvPRank10";

	private const string UIPvPRankMediocre = "UIPvPRankMediocre";

	private const string UIPvPBadge = "UIPvPBadge";

	private const string UIVIP = "VIP";

	private int RankSpriteDepth;

	private int TopTen;

	private int TopThree;

	public Action<Vector2> E_OnDrag;

	public Action<bool> E_OnPress;

	public Action<Player> OnClick;

	public UILabel NameText;

	public UILabel LevelText;

	public UILabel PowerText;

	public UILabel ReputationText;

	public UILabel GuildName;

	public Transform FunnyRendererPlaceHolder;

	public UISprite Frame;

	public UIEventListener InfoClicker;

	public UIEventListener PortraitClicker;

	private PVPPlayer player;

	private List<Timer> cdTimers;

	private bool isSelfCD;

	[SerializeField]
	private UISprite badge;

	[SerializeField]
	private UISprite VIPSprite;

	[SerializeField]
	private Transform rankCentralAxis;

	[SerializeField]
	private IceAnimatorTotalCommander[] rankEffectAnimators;

	private List<UISprite> rankSprites;

	public virtual PVPPlayer Player
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void DoPrepare()
	{
	}

	private void bindDelegates()
	{
	}

	private void clear()
	{
	}

	protected void setRankSprite(int rank)
	{
	}

	private void set(PVPPlayer player)
	{
	}

	private string rankID(int rank)
	{
		return null;
	}

	private void activeWithDeferredHitPlay(IceAnimatorTotalCommander cmd)
	{
	}

	private void simplifyRankSymbols(int rank)
	{
	}

	private string rankToSpriteName(int rank)
	{
		return null;
	}

	private UISprite createOneSprite(int rank, Transform parent, char name, int depth)
	{
		return null;
	}

	private void repositionAndScale()
	{
	}

	private float wholeWidth()
	{
		return 0f;
	}

	public void SetSideInfo(Transform slot)
	{
	}

	public void ActivateFunnyRenderer(bool activated)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void PopupTip(string desc)
	{
	}
}
