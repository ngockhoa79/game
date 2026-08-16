using System;
using Ice.ProjectCos.UI.DataModel;

public class UIItemPopup : IceUIBase
{
	public UICmItemIcon Icon;

	public UIStarsRow Stars;

	public UILabel NameText;

	public UILabel DescText;

	public UILabel lbLevel;

	public UILabel lbMainPropertyValue;

	public UISprite spMainPropertyType;

	public UISprite spMainPropertyIcon;

	public UIEventListener bnCancel;

	public UIEventListener bnStrength;

	public UIEventListener bnJIngLian;

	public UIEventListener bnReplace;

	public UIEventListener bnClose;

	public Action<ItemHolding> OnChange;

	public Action<ItemHolding> OnStrength;

	public Action<ItemHolding> OnJIngLian;

	public Action<ItemHolding> OnCancel;

	private ItemHolding holding;

	private GearHolding gh;

	public ItemHolding Holding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(ItemHolding holding)
	{
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
}
