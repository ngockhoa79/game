using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIStrengthenMatBtnCtrller : MonoBehaviour
{
	public GameObject Background;

	public UICmItemIcon ItemIcon;

	public GameObject ExpGroup;

	public ItemHolding holding;

	public UIEventListener.VoidDelegate onClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Prepare()
	{
	}

	public void SetOnclickEvent()
	{
	}

	public void SetData(Hero _holding)
	{
	}

	private int GetHeroEatExp(Hero _hero)
	{
		return 0;
	}
}
