using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiItemCell : IceUIBase
{
	[SerializeField]
	private UILabel canEauipLabel;

	[SerializeField]
	private UILabel addLabel1;

	[SerializeField]
	private UILabel addLabel2;

	[SerializeField]
	private UILabel addLabel3;

	[SerializeField]
	private UILabel numLabel;

	[SerializeField]
	private UISprite bg1;

	[SerializeField]
	private UISprite bg2;

	[SerializeField]
	private UISprite bg3;

	[SerializeField]
	private UISprite addFlag;

	[SerializeField]
	private UISprite iconMask;

	[SerializeField]
	private UITexture Image;

	[SerializeField]
	private UIEventListener addEvent;

	[SerializeField]
	private IceAnimatorTotalCommander equipAnimator;

	[SerializeField]
	private UISprite spMask;

	[HideInInspector]
	public Action EquipCallBack;

	public Hero hero;

	private int state;

	private int index;

	private bool isEquip;

	private bool canAdd;

	private CardBaQiItem data;

	private UniIcon icon;

	private AutoTipTriger mTriger;

	private bool isplaying;

	public bool IsEquip()
	{
		return false;
	}

	protected override void DoPrepare()
	{
	}

	public void StopAllAnimator()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	private void useItem(ItemHolding th)
	{
	}

	private void selectLowEquip()
	{
	}

	private void onClickCell(GameObject obj)
	{
	}

	private bool isEquipItem(int type, int id)
	{
		return false;
	}

	private void refrush()
	{
	}

	public void setData(int index, CardBaQiItem data)
	{
	}

	private void resetView()
	{
	}

	public void ChangeState(int state)
	{
	}

	private void beforeChangeState()
	{
	}

	public void AddIcon(ThingHolding h)
	{
	}

	public void BindAutoTipTriger(ThingHolding mThing)
	{
	}

	private void UnbindTipTriger()
	{
	}

	private void LoadIcon(ThingHolding h)
	{
	}
}
