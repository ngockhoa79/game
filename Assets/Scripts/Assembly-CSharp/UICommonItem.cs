using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public abstract class UICommonItem : IceUIBase
{
	public enum EState
	{
		Idle = 0,
		InSelection = 1,
		CannotSelection = 2,
		UnloadMode = 3,
		Hide = 4
	}

	public enum EMode
	{
		NormalMode = 0,
		SellMode = 1
	}

	public enum ETag
	{
		None = 0,
		RefineMax = 1,
		LevelInsufficient = 2,
		LevelMax = 3,
		Combinable = 4,
		MaterialInsufficient = 5,
		Wakeupable = 6,
		WakeupMax = 7,
		Upline = 8,
		CardDuplicate = 9,
		SkillDuplicate = 10,
		CardGasLevel = 11
	}

	[SerializeField]
	protected GameObject SelectGroup;

	[SerializeField]
	protected GameObject CannotSelectGroup;

	[SerializeField]
	protected GameObject SellGroup;

	[SerializeField]
	protected GameObject UserRoot;

	[SerializeField]
	protected GameObject Displayer;

	[SerializeField]
	protected UILabel UserTxt;

	[SerializeField]
	protected GameObject UnloadGroup;

	[SerializeField]
	protected UIEventListener btnClick;

	[SerializeField]
	private UISprite spTag;

	public Action<ItemHolding> E_OnClick;

	public EState EItemState { get; private set; }

	public abstract void SetData(ItemHolding item, EState state = EState.Idle, EMode mode = EMode.NormalMode);

	public void SetState(EState state)
	{
	}

	public void SetMode(EMode mode)
	{
	}

	protected string RarityStringColor(ERarity rarity)
	{
		return null;
	}

	public void ShowTag(ETag tag)
	{
	}
}
