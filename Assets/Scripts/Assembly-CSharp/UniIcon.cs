using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UniIcon : MonoBehaviour
{
	public const int FrameBorderWidth = 5;

	private const string FrameSpriteHead = "HeadFrame_0";

	private bool _isHeadIcon;

	public UISprite spFrame;

	public UISprite spBg;

	public UISprite spMaskOption;

	public UISprite spSkillTypeOption;

	public UISprite spJobOption;

	public UITexture txThingOption;

	public UILabel lbNum;

	public string NumBmFontName;

	public const string DefaultBmFontName = "bmfont_normal_num";

	private bool mbReCreateNumLable;

	public Texture txDefaultOption;

	public int BaseWidgetDepth;

	public int MaxWidth;

	public int MaxHeight;

	public UILabel lbGearLevelOption;

	private const string SKILL_NAME_SPITE_PRIFIX = "SkillTypeSpec";

	private const float ItemRatio = 0.9f;

	private const float HeroRatio = 0.94f;

	public UIEventListener eventIcon;

	public Action<ThingHolding, UniIcon> E_OnItemClick;

	private ThingHolding mThingHolding;

	private Thing mThing;

	private TipTriger mTriger;

	private EItemType mType;

	private float mTxRatio;

	private bool bindTips;

	private static Texture EmptySlotImage;

	private GameObject _star_root;

	private List<UISprite> _star_list;

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

	public Thing Thing
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ThingHolding ThingHolding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static UniIcon Add(Transform pos)
	{
		return null;
	}

	public static UniIcon Add(Transform pos, ThingHolding holding)
	{
		return null;
	}

	public static UniIcon Add(Transform pos, Thing thing)
	{
		return null;
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void EnableTouchEvent(bool isEnable = true)
	{
	}

	public void BindAutoTipTriger()
	{
	}

	public void UnbindTipTriger()
	{
	}

	public void Clear()
	{
	}

	public void SetCustomIcon(string resType, string resName, ERarity frameRairty, int Num = 1)
	{
	}

	public void Set(ThingHolding thingHolding)
	{
	}

	public void SetByConfig(Thing thing)
	{
	}

	private void showAll()
	{
	}

	private void setFrame()
	{
	}

	public void ShowNum(bool isShow = true)
	{
	}

	private void ShowResourceNumAuto()
	{
	}

	private void createNumLable()
	{
	}

	public float GetSizeScale()
	{
		return 0f;
	}

	public void SetToEmptyImage()
	{
	}

	private void asyncLoadIcon()
	{
	}

	private void createItemTextureIfNo()
	{
	}

	private void showProfession()
	{
	}

	private void showSkillTypeSpec()
	{
	}

	private void createSkillSpite()
	{
	}

	public void ShowSkillTypeSpec(bool isShow)
	{
	}

	private void showMask()
	{
	}

	public void ReorderDepth()
	{
	}

	public void ShowHeroStars(bool bShow)
	{
	}

	private void cleanSars()
	{
	}

	private void createStars(int count)
	{
	}

	public void ShowGearLevel()
	{
	}

	private void createGearLevelLable()
	{
	}

	public void ShowSkillStar(bool show)
	{
	}
}
