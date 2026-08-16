using System;
using Ice.ProjectCos.UI.DataModel;

public class UIArrayConfirm : IceUIBase
{
	public enum ChallengeMode
	{
		Fight = 0,
		Trial = 1,
		ConvoyLoot = 2
	}

	private const string FightDisplay = "Fight";

	private const string TrialDisplay = "Trial";

	public Action<Hero> OnClickCard;

	public Action OnChallenge;

	public Action OnReturn;

	public Action OnHomePage;

	public Action OnSwitchSupporter;

	public Action OnArrayEditor;

	public Action<Player> OnInspect;

	public UIAeSlots LeftArray;

	public UIAeSlots RightArray;

	public UILabel LeftPowerText;

	public UILabel RightPowerText;

	public UISprite IconFightPower;

	public UISprite IconBodyguard;

	public UIEventListener ChallengeBtn;

	public UIEventListener InspectBtn;

	public UIEventListener ReturnButton;

	public UIEventListener HomePageBtn;

	public UIEventListener SwitchSupporterBtn;

	public UIEventListener EditArrayBtn;

	public UIEventListener RestrainBtn;

	public SubstitutionDisplayer SubstitutionDisp;

	private bool convoyOpponentGuard;

	public void SetPVX(BattleArray left, BattleArray right)
	{
	}

	private void setAsPVX()
	{
	}

	public void Set(Player left, Player right, ChallengeMode mode = ChallengeMode.Fight)
	{
	}

	private void setAsPVP(ChallengeMode mode)
	{
	}

	public void SetRightPlayerGuard(bool hasGuard)
	{
	}

	public void Set(BattleArrayMisc me, BattleArrayMisc right)
	{
	}

	private void handlePowerChanged(BattleArray ary, int arg2, int arg3, Hero arg4)
	{
	}

	private void setAsPVE()
	{
	}

	private void attachRestrainLogic()
	{
	}

	private void detachRestrainLogic()
	{
	}

	public void ActivateButtons(bool inspectBtn, bool switchSupportBtn, bool editArrayBtn)
	{
	}

	private void handleArrayCardDropped(UIAeCardDragger dragger)
	{
	}

	private void handleArrayCardBeingDragged(UIAeCardDragger dragger)
	{
	}

	private void handleChallengeBtnMode(ChallengeMode m)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void SetSubstitutionData(Hero card)
	{
	}

	private bool CheckGoldCrad()
	{
		return false;
	}

	protected override void DoDispose()
	{
	}

	private int GetLeftPower(BattleArray left)
	{
		return 0;
	}
}
