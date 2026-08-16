using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICommonGearItem : IceUIBase
{
	public enum EState
	{
		Idle = 0,
		InSelection = 1,
		CannotSelect = 2,
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
		LevelMax = 2,
		Combinable = 3
	}

	[SerializeField]
	private UILabel GearLevel;

	[SerializeField]
	private UILabel GearMajorBufValue;

	[SerializeField]
	private UILabel GearPrice;

	[SerializeField]
	private UILabel RefineLevel;

	[SerializeField]
	private UILuggagePortrait GearPortrait;

	[SerializeField]
	private GameObject SelectGroup;

	[SerializeField]
	private GameObject CannotSelectGroup;

	[SerializeField]
	private GameObject SellGroup;

	[SerializeField]
	private GameObject UserRoot;

	[SerializeField]
	private GameObject Displayer;

	[SerializeField]
	private UILabel UserTxt;

	[SerializeField]
	private GameObject UnloadGroup;

	[SerializeField]
	private UIEventListener btnClick;

	[SerializeField]
	private UISprite spTag;

	public Action<ItemHolding> E_OnClick;

	private EState _state;

	private EMode _mode;

	private ItemHolding _data;

	public ItemHolding Data => null;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetData(ItemHolding gear, EState state = EState.Idle, EMode mode = EMode.NormalMode)
	{
	}

	public void SetState(EState state)
	{
	}

	public void SetMode(EMode mode)
	{
	}

	private void setData(GearHolding holding)
	{
	}

	private string RarityStringColor(ERarity rarity)
	{
		return null;
	}

	public void ShowTag(ETag tag)
	{
	}
}
