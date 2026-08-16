using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeSupporterItem : IceUIBase
{
	public Action<Player> OnChosen;

	public UISprite Profession;

	public UISprite Frame;

	public UISprite TypeFriendSprite;

	public UISprite TypeStrangerSprite;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel LeaderSkillDesc;

	public UILabel Points;

	public UILabel BattleText;

	public UIEventListener ChooseBtn;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public GameObject[] TalentTypes;

	private Player player;

	public UIEventListener TipClicker;

	public UIAeCardLevelIndicator LI;

	public ArraySupporters.EntrancePoint entrance;

	private bool isServing;

	public Player Player
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsServing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(Player player)
	{
	}

	private TipData createTipData(string sentence, Transform parent)
	{
		return null;
	}

	private string makeUpLeaderSkill(Hero leader, out string desc)
	{
		desc = null;
		return null;
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
