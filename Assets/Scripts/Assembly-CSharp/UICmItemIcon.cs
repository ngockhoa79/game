using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICmItemIcon : IceUIBase
{
	private static Texture EmptySlotImage;

	private const string FrameSpritePrefix = "Frame";

	private const string FrameSpriteHead = "HeadFrame_0";

	private const string TypeSpecSpritePrefix = "SkillTypeSpec";

	private const float ItemRatio = 0.9f;

	private const float HeroRatio = 0.94f;

	private int FrameWidth;

	private int FrameHeight;

	private bool _isHeadIcon;

	public UISprite Frame;

	public UISprite ItemIcon;

	public UISprite MaskIcon;

	public UISprite TypeSpec;

	public UISprite Profession;

	public Action<UICmItemIcon> OnClicked;

	public UITexture ItemTexture;

	public Texture DefaultTexture;

	public int itemDepth;

	public UILabel ItemNumber;

	protected AbstractItem TargetItem;

	protected ItemHolding TargetHolding;

	private float mTxRatio;

	public bool IsHeadIcon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual AbstractItem Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ItemHolding Holding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected virtual void Clear()
	{
	}

	private void SetToEmptyImage()
	{
	}

	protected virtual void Set(AbstractItem item)
	{
	}

	private void AsyncLoadIcon(UITexture texture, AbstractItem TargetItem)
	{
	}

	public void LoadTexture(string resType, string bundlename)
	{
	}

	protected virtual void Set(ItemHolding holding)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}
}
