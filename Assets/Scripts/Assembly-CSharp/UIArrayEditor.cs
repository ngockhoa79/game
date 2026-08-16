using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIArrayEditor : IceUIBase
{
	public Action<Hero> OnClickCard;

	public Action<Hero> OnSetAsLeader;

	public Action<Hero> OnStrengthCard;

	public Action<bool> OnHomePage;

	public Action<bool> OnBack;

	public Action E_OnDelFriend;

	public Action E_OnLeaveMsg;

	public Action E_OnQieCuo;

	public UIAeEmbededCardInfo cardInfo;

	public UISprite ZoomBtn;

	public static Action OnPrepared;

	private bool showFriendCtrl;

	public static bool Friend;

	[SerializeField]
	private UIAeSlots slots;

	[SerializeField]
	private UIEventListener homePageButton;

	[SerializeField]
	private UIEventListener confirmButton;

	[SerializeField]
	private UIEventListener bnDelFriend;

	[SerializeField]
	private UIEventListener bnLeaveMsg;

	[SerializeField]
	private UIEventListener bnQieCuo;

	[SerializeField]
	private UIEventListener Defalt;

	[SerializeField]
	private UIEventListener PurchCrad;

	[SerializeField]
	private UIEventListener strengthBtn;

	[SerializeField]
	private UILabel cardCountText;

	[SerializeField]
	private UILabel maxCardCountText;

	[SerializeField]
	private UILabel powerText;

	[SerializeField]
	private UILabel onBoardIndicator;

	[SerializeField]
	private UIAeCaptainBtn captainBtn;

	[SerializeField]
	private GameObject GasRedDotObj;

	public GameObject FreeersArrayObj;

	private static int storedPower;

	private static int accumulate;

	private BattleArray backup;

	public static Hero DefaultHero;

	private Friend mFriend;

	public static int DefaltCrosstype;

	public BattleArray Array => null;

	public Friend FriendInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void ClearAccumulate()
	{
	}

	public void SetArrayReadOnly()
	{
	}

	public void RemoveTradeSelectorsEvent()
	{
	}

	private void dealFriendStuff(bool active)
	{
	}

	private void clear()
	{
	}

	private void set(BattleArray array, Hero defaultHero, bool heirloom)
	{
	}

	private void handleHeroGasRedDot(Hero h)
	{
	}

	private Action tipAction(Hero c)
	{
		return null;
	}

	private string indicator()
	{
		return null;
	}

	private void handleCardClicked(Hero card)
	{
	}

	private Hero findNewestHero(Hero card)
	{
		return null;
	}

	public void RefreshHeroDataOnPanel(Hero card)
	{
	}

	private void captainBtnStuff(Hero card)
	{
	}

	public void SetCaptainBtn(bool hasCall)
	{
	}

	private void refreshCardCountText(BattleArray array, int row, int column, Hero oldCard)
	{
	}

	private void refreshPowerText(BattleArray array, int row, int column, Hero oldCard)
	{
	}

	public void Set(BattleArray _array, Hero defaultHero, bool heirloom = false, bool showCtrl = false)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void DefaltCkick(GameObject obj)
	{
	}

	public void PurchCardCLick(GameObject obj)
	{
	}

	private void loadDefalt(Hero Defalthero)
	{
	}

	private void SetArrsy()
	{
	}

	private void ChangeArrayType()
	{
	}

	private void ReloadFerrers()
	{
	}

	public void OnGetToForground()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoDispose()
	{
	}

	private bool CheckHavePurpleCard()
	{
		return false;
	}
}
