using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardEditor : IceUIBase
{
	public static int srcCardLocalID;

	public static SkillHolding[] SkillHoldings;

	public static GearHolding[] GearHoldings;

	public const string IconNamePrefix = "UICEIcon";

	public const string WordNamePrefix = "UICETxt";

	public const string CardUnderProtection = "UICETxtLock";

	public const string CardUnderNoProtection = "UICETxtCancel";

	public const string TalentNamePatten = "[{0}]";

	[SerializeField]
	private GameObject[] TabContents;

	[SerializeField]
	private IceUIBtnGroup Tabs;

	[SerializeField]
	private UICmSkillIcon Talent;

	[SerializeField]
	private UILabel TalentName;

	[SerializeField]
	private UILabel TalentDesc;

	private UIHeroLoader uiHeroLoader;

	public Transform FunnyRendererPlaceHolder;

	private GameObject funnyRenderer;

	[SerializeField]
	private CardEditorAttributeLVTxtAlignment LVAlignment;

	[SerializeField]
	private UILabel Name;

	[SerializeField]
	private UILabel CurLv;

	[SerializeField]
	private UILabel LvMax;

	[SerializeField]
	private UILabel CardDesc;

	[SerializeField]
	private UILabel HealthText;

	[SerializeField]
	private UILabel DefenceText;

	[SerializeField]
	private UILabel AttackText;

	[SerializeField]
	private UILabel SpiritText;

	[SerializeField]
	private UILabel PowerText;

	[SerializeField]
	private UILabel SpeedText;

	[SerializeField]
	private UILabel CriticalText;

	[SerializeField]
	private UILabel AntiCriticalText;

	[SerializeField]
	private UILabel ComboText;

	[SerializeField]
	private UILabel AntiComboText;

	[SerializeField]
	private UILabel MissText;

	[SerializeField]
	private UILabel AntiMissText;

	[SerializeField]
	private UILabel BlockText;

	[SerializeField]
	private UILabel AntiBlockText;

	[SerializeField]
	private UICeCouplingDisplayer[] couplingDisps;

	[SerializeField]
	private UITable couplingUITable;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UIEventListener SourceBtn;

	[SerializeField]
	private UIEventListener StrengthenBtn;

	[SerializeField]
	private UIEventListener ProtectBtn;

	[SerializeField]
	private GameObject StrengthenButtonEnable;

	[SerializeField]
	private GameObject StrengthenButtonDisable;

	[SerializeField]
	private GameObject ProtectButtonEnable;

	[SerializeField]
	private GameObject ProtectButtonDisable;

	[SerializeField]
	private UISprite ProtectIcon;

	[SerializeField]
	private UICardFullBodyPortraitForArrayEditor portrait;

	[SerializeField]
	private UISprite protectText;

	[SerializeField]
	private UICeReincarnationDisplayer Reincarnation;

	[SerializeField]
	private UIEventListener leftArrow;

	[SerializeField]
	private UIEventListener rightArrow;

	[SerializeField]
	private UIEventListener rightDragListener;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private UIEventListener helpBtn;

	[SerializeField]
	private UILabel EmptyCouplingTip;

	public GameObject LockMask;

	private Hero card;

	private int rollIndex;

	private List<Hero> rollCards;

	private static UICardEditor self;

	private BattleArray exhibitArray;

	[SerializeField]
	private BaQiIcon baqiIcon;

	public static UICardEditor CardEditor => null;

	public UIHeroLoader HeroLoader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<Hero> OnTalentClicked
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

	public event Action<Hero> OnDigSource
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

	public event Action<Hero> OnStrengthened
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

	public event Action<Hero> OnProtected
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

	public event Action OnReturn
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

	public event Action OnHomePage
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

	private void clearCard()
	{
	}

	public void Set(Hero card, bool r, BattleArray ary)
	{
	}

	private void rolling(bool isLeft)
	{
	}

	private void work(int ri)
	{
	}

	private void arrowDisp(int ri)
	{
	}

	private void activateArrows(bool left, bool right)
	{
	}

	private List<Hero> battleCardsFilter(List<Hero> rolling)
	{
		return null;
	}

	private int indexOf(List<Hero> r, Hero c)
	{
		return 0;
	}

	private void set(Hero card)
	{
	}

	private void activeTab2(bool active)
	{
	}

	private void handleTabsSwitched(int f, int t)
	{
	}

	private void loadTalent(Hero card)
	{
	}

	private string CreateBlank(int nameLen, int descLen)
	{
		return null;
	}

	private void cardNullFilter()
	{
	}

	private void loadCouplingInfo(Hero card)
	{
	}

	private void loadReincarnationInfo(Hero card)
	{
	}

	private void clearUIHeroLoader()
	{
	}

	private void loadUIHero(int configID)
	{
	}

	private void loadProperties(Hero c)
	{
	}

	public void ActivateFunnyRenderer(bool activated)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void handleHelpClicked(GameObject btn)
	{
	}

	protected override void DoDispose()
	{
	}

	private void popUpTipWithHandlingOfLayers(string tip)
	{
	}

	public void HandleProtectIconChanged(bool underProtect)
	{
	}

	private string nakedValueFormula(int sum, int b)
	{
		return null;
	}

	private string sign(int d)
	{
		return null;
	}

	public void ShowButtons(bool bShow)
	{
	}

	public void ShowLockMask(bool bShow)
	{
	}
}
