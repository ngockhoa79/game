using System;
using Ice.ProjectCos.UI.Intents;

public class UISmeltJourneryTroopsSelector : IceUIBase
{
	public enum UISJTS_Mode
	{
		UISJTS_Mode_SmeltJourney = 0,
		UISJTS_Mode_Convoy = 1,
		UISJTS_Mode_Invalid = 2
	}

	private const string Res = "uismeltjournery";

	private const string PrefabName = "ColumnSelector";

	public UIEventListener HomeBtn;

	public UIEventListener BackBtn;

	public Action OnHome;

	public Action OnBack;

	public UIEventListener RefreshBtn;

	public Action OnRefresh;

	public UIGrid Grid;

	public UIScrollView ScrollView;

	public UILabel Crystal;

	public UISprite TitleJourney;

	public UISprite TitleConvoy;

	private SmeltJourneyTroopsSelectorIntent.TradeMethod method;

	private int fromSlot;

	private UISJTS_Mode uiMode;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void clearGrid()
	{
	}

	public void SetDetails(SmeltJourneyTroopsSelectorIntent.TradeMethod m, int fromSlot, UISJTS_Mode eMode = UISJTS_Mode.UISJTS_Mode_SmeltJourney)
	{
	}

	public void AddColumn()
	{
	}

	public void RefreshCrystal(int c)
	{
	}

	private void handleColumnSelected(int chosenSlot)
	{
	}

	private void handleOnBoardSelected(int chosenSlot)
	{
	}

	private void handleGetOffSelected(int chosenSlot)
	{
	}

	private bool keepOneSelfColumnFilter(int fromIndex)
	{
		return false;
	}

	private bool keepOneSelfColumnFilter(int fromIndex, int wantedIndex)
	{
		return false;
	}
}
