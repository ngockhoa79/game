using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeSlot : IceUIBase
{
	public GameObject Obj;

	public UIAeCardDragger Dragger;

	public UISprite CheerMark;

	public GameObject Vacancy;

	private bool isCheer;

	private bool hasVacancy;

	public UIAePotentialTradeSelector TradeSelector;

	[HideInInspector]
	public bool PVERedRarity;

	[HideInInspector]
	public bool IsPVEBoss;

	public GameObject FerrerLv;

	public int SlotLv;

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoxCollider SlotCollider => null;

	public bool IsCheer
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasVacancy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void DisableSlotCollider()
	{
	}

	public void SwapDragger(UIAeSlot another)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void ShowRestrainShip(Restrainship restrainship)
	{
	}

	public void ClearRestrainShip()
	{
	}

	public void ShowIconSupportSkill(bool gray)
	{
	}

	public void ClearIconSupportSkill()
	{
	}

	public void Isferrer()
	{
	}

	protected override void DoDispose()
	{
	}
}
