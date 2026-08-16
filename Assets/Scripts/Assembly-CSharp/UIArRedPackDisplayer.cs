using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIArRedPackDisplayer : IceUIBase
{
	public enum Mode
	{
		Innate = 0,
		Crystal = 1,
		Disable = 2,
		Deliveried = 3
	}

	public const string ResCategory = "uiarena";

	public const string PrefabConfirmDelivery = "ArenaPopUpConfirmDelivery";

	public const string PrefabPopUpCustom = "ArenaPopUpCustom";

	public const string PrefabRedPackItem = "RedPackItem";

	public const string PrefabRules = "ArenaRulesDisplayer";

	public const string PrefabRedPackResult = "ArenaPopUpRedPackResult";

	public UIArRedPackDeliveryBtn Delivery;

	public UIEventListener CloseBtn;

	public UIEventListener HelpBtn;

	public UILabel RemainCount;

	public UITable Table;

	private UIArena arena;

	private int pickCount;

	private List<RedPackCoolDownTimeProto> cdList;

	public UISprite NoRedPack;

	private int lastRank;

	public UILabel RefreshTimeLabel;

	public IceUIBtnGroup TabGroup;

	public GameObject[] RemainBgs;

	private List<S2CRedPackListAck> acks;

	private int category;

	private int defaultIndex;

	public void Set(List<S2CRedPackListAck> result, C2SRedPackListReq.TypeEnum defaultTab)
	{
	}

	private void defaultUgly()
	{
	}

	protected override void DoInit()
	{
	}

	private void handleTabSwitched(int f, int t)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void handleClose(GameObject btn)
	{
	}

	private void handleRules()
	{
	}

	private void setDetail(int t)
	{
	}

	private void handleCategory(int t, S2CRedPackListAck ack)
	{
	}

	private void clearItemList()
	{
	}

	private void createOneItem(RankingRedPackProto d, Transform t, int i)
	{
	}

	private void popConfirmDelivery(int rank)
	{
	}

	private void processingDeliveryOperation()
	{
	}

	private void addExtraRedPackages(int boughtTimes)
	{
	}

	private string getChargeTip()
	{
		return null;
	}

	private void sendBuyExtraRedPackagesReq()
	{
	}

	private void snatchRedPackage(RankingRedPackProto r, UIArRedPackItem item)
	{
	}

	private void sendSnatchRedPackReq(int redPackId, UIArRedPackItem item)
	{
	}

	private void dealingSnatchResults(int redPackId, S2CRankingPickRedPackAck ack, UIArRedPackItem item)
	{
	}

	private void patchAckData(int redPackId, long over)
	{
	}

	private int refreshRemainCount()
	{
		return 0;
	}

	private void popUpRedPackResult(int remainCount, int reputation, int contribution, int crystal, List<ItemChangeProto> dropItems)
	{
	}

	private void popupTip(string desc)
	{
	}

	private Transform getPanelTransform()
	{
		return null;
	}

	private int getPanelDepth()
	{
		return 0;
	}

	private C2SRedPackListReq.TypeEnum getCategory()
	{
		return default(C2SRedPackListReq.TypeEnum);
	}

	private C2SBuyFunctionReq.TypeEnum getBuyType()
	{
		return default(C2SBuyFunctionReq.TypeEnum);
	}

	private PriceInfo getPriceInfo(int b)
	{
		return null;
	}
}
