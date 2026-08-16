using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;

public class CardEditorIntent : IceUIIntent
{
	private const string IntentKey = "CardEditor";

	private const string CardSrcPrefab = "CardEditorSrc";

	private const string ResCategory = "uicardeditor";

	private bool rolling;

	private bool showButtons;

	private bool showLockMask;

	private BattleArray exhibitArray;

	public Hero Card { get; private set; }

	public CardEditorIntent(Hero card, bool r, BattleArray ary = null)
	{
	}

	protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
	{
		return null;
	}

	protected override void SetPanelData()
	{
	}

	protected override void OnGetToForground()
	{
	}

	protected override void OnGetToBackgorund()
	{
	}

	protected override void ClearPanelData()
	{
	}

	private void strengthenCard(Hero hero)
	{
	}

	private void homePage()
	{
	}

	private void clickBack()
	{
	}

	private void clickTalent(Hero c)
	{
	}

	private void directToSource(Hero hero)
	{
	}

	private Hero findNewestHero(Hero card)
	{
		return null;
	}

	private void initCardUnderProtectionStatus(Hero hero)
	{
	}

	private void protectCard(Hero hero)
	{
	}

	public void ShowFunctionButtons(bool bShow)
	{
	}

	public void ShowLockedMask(bool bShow)
	{
	}
}
