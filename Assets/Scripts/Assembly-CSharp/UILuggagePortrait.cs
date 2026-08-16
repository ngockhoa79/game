using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILuggagePortrait : IceUIBase
{
	[SerializeField]
	private UISprite Frame;

	[SerializeField]
	private UISprite MaskIcon;

	[SerializeField]
	private UISprite TypeSpec;

	[SerializeField]
	private UISprite CaseImg;

	[SerializeField]
	private UISprite NameBaseImg;

	[SerializeField]
	private UISprite Line;

	[SerializeField]
	private UISprite PartTypeSpec;

	[SerializeField]
	private UITexture ItemTexture;

	[SerializeField]
	private UILabel TargetName;

	[SerializeField]
	private UICmStarDisplayer imgStars;

	protected AbstractItem TargetItem;

	protected ItemHolding TargetHolding;

	private static Texture EmptySlotImage;

	private const string SkillTypeSpec = "SkillTypeSpec";

	private const string GearTypeIcon = "GearTypeIcon";

	private const string PartTypeSpecIcon = "GearTypeIcon";

	private string defaultFrameName;

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

	public event Action<UILuggagePortrait> OnClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void SetToEmptyImage()
	{
	}

	protected virtual void Clear()
	{
	}

	protected virtual void Set(AbstractItem item)
	{
	}

	private void AsyncLoadIcon(UITexture texture, AbstractItem TargetItem)
	{
	}

	protected virtual void Set(ItemHolding holding)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoClearData()
	{
	}

	private string caseName(ERarity rarity)
	{
		return null;
	}

	private string rarityNameBody(ERarity rarity)
	{
		return null;
	}

	private string rarityNameColor(ERarity rarity)
	{
		return null;
	}
}
