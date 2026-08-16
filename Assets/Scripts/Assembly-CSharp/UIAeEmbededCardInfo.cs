using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeEmbededCardInfo : IceUIBase
{
	private static int SrcCardLocalID;

	private static int[] SkillHoldings;

	private static int[] GearHoldings;

	private bool heirloom;

	[SerializeField]
	private UICmSkillIcon[] Skills;

	[SerializeField]
	private UICmGearIcon[] Gears;

	[SerializeField]
	private UICardFullBodyPortraitForArrayEditor portrait;

	private GameObject funnyRenderer;

	[SerializeField]
	private UILabel CardName;

	[SerializeField]
	private CardEditorAttributeLVTxtAlignment LVAlignment;

	[SerializeField]
	private UILabel CurLevel;

	[SerializeField]
	private UILabel MaxLevel;

	[SerializeField]
	private UILabel PowerText;

	[SerializeField]
	private UILabel HealthText;

	[SerializeField]
	private UILabel DefenceText;

	[SerializeField]
	private UILabel AttackText;

	[SerializeField]
	private UILabel SpiritText;

	[SerializeField]
	private UILabel EmptyCouplingTip;

	[SerializeField]
	private GameObject cardFeaturesRoot;

	[SerializeField]
	private GameObject cardInfoRoot;

	[SerializeField]
	private UIEventListener cardFeaturesTrigger;

	[SerializeField]
	private UIEventListener cardFullBodyClicker;

	private bool isCardFeaturesOn;

	[SerializeField]
	private UICeCouplingDisplayer[] couplingDisps;

	[SerializeField]
	private UILabel[] couplingTxts;

	[SerializeField]
	private IceAnimatorTotalCommander[] couplingTxtAnims;

	[SerializeField]
	private UITable couplingUITable;

	public Action<Hero> OnTalentClicked;

	public Action<Hero, int> OnSkillClicked;

	public Action<Hero, EGearSlot> OnGearClicked;

	private Action onTipCalculated;

	public UIEventListener NoCouplingListener;

	private Hero card;

	private BattleArray exhibitArray;

	private void clearCard()
	{
	}

	public void SetDetails(BattleArray ary, Hero card, bool readOnly, bool heirloom, Action tipCal = null)
	{
	}

	private void handleHeroChanged()
	{
	}

	private void attachEvents()
	{
	}

	public void ClearFullBodyOnClickEvent()
	{
	}

	private bool isMeIns()
	{
		return false;
	}

	private void loadSkillInfo(Hero card)
	{
	}

	private void skillStorage(int index, SkillHolding holding)
	{
	}

	private void loadGearInfo(Hero card)
	{
	}

	private bool isMine(Hero c)
	{
		return false;
	}

	private void gearStorage(int index, GearHolding holding)
	{
	}

	private void syncPulseHeirloom(Hero card)
	{
	}

	private void skillGroupFilter(Skill t)
	{
	}

	private void unloadSkill(int heroID, int skillID, SkillHolding sh)
	{
	}

	private void handleSyncPulseHeirloomResult(Hero card, object response)
	{
	}

	private void loadProperties(Hero card)
	{
	}

	private void loadCouplingInfo(Hero card)
	{
	}

	private void loadCouplingTxtInfo(Hero card, int availables)
	{
	}

	private void playCouplingTxtAnimation(int i)
	{
	}

	public void ActivateFunnyRenderer(bool activated)
	{
	}

	private void popUpTipWithHandlingOfLayers(string tip)
	{
	}

	protected override void DoInit()
	{
	}

	private void handleTabSwitched(GameObject btn)
	{
	}

	public void UpDateCouplingInfo()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void handleCardFullBodyClicked(GameObject btn)
	{
	}

	protected override void DoDispose()
	{
	}

	private Hero findNewestHero(Hero card)
	{
		return null;
	}

	private SkillHolding getSkillByLocalID(int local)
	{
		return null;
	}

	private GearHolding getGearlByLocalID(int local)
	{
		return null;
	}

	private void OnEnable()
	{
	}
}
