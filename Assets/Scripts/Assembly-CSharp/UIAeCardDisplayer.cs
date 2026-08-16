using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeCardDisplayer : MonoBehaviour
{
	private Rect LayoutRect;

	private const string ResCategory = "icon_heroes";

	private const string TransparentBlank = "Texture/TransparentBlank";

	private const string PVEBossIcon = "FrameBoss";

	private const string PVERedRarity = "FrameRed";

	private const string FrameSpriteHead = "HeadFrame_0";

	private const string AssistantInactive = "SkillTypeSpecAssistantInactive";

	private const string AssistantActive = "SkillTypeSpecAssistant";

	private string[] CaptainActive;

	private string[] CaptainInactive;

	public Vector3 ResortToDeception;

	public UISprite Portrait;

	public UISprite Profession;

	public UISprite Frame;

	public IceAnimatorTotalCommander Up;

	public IceAnimatorTotalCommander Down;

	public IceAnimatorTotalCommander IconSupport;

	public IceAnimatorTotalCommander Leader;

	public GameObject RedDot;

	public GameObject UpgradeTip;

	protected UITexture ImageTexture;

	private Hero card;

	private HeroConfig config;

	public UIAeCardLevelIndicator LvIndicator;

	private static Texture EmptyHeroTexture;

	public VIPLabel VIPLabel;

	public Action OnTexDone;

	public Action OnTipCalculated;

	private bool _isHeadIcon;

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

	public HeroConfig Config
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Dispose()
	{
	}

	private void clear()
	{
	}

	private void initTexture()
	{
	}

	public void SetByHeroID(int id)
	{
	}

	public void set(Hero card)
	{
	}

	private void set(HeroConfig config)
	{
	}

	public void ShowProfession(bool isShow = true)
	{
	}

	private void setLvIndicator(Hero hero)
	{
	}

	public void SetPVERedRarity(bool isBoss = false)
	{
	}

	protected virtual void initIcon(Hero card)
	{
	}

	protected virtual void initIcon(HeroConfig config)
	{
	}

	private void handleRedDot(Hero h)
	{
	}

	private void handleUpgradeTip(Hero h)
	{
	}

	public void SetCaptainStatus(CaptainStatus status, int i)
	{
	}

	public void ShowRestrainShip(Restrainship relationship)
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
}
