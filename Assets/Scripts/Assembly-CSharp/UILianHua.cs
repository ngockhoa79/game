using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class UILianHua : IceUIBase
{
	public UIEventListener eventBack;

	public UIEventListener eventHome;

	public UIEventListener bnLianHua;

	public UIEventListener bnAddCard;

	public UIEventListener bnAddGear;

	public UIEventListener bnAddSkill;

	public UIEventListener bnLianHuaShop;

	public UIEventListener bnLeft;

	public UIEventListener bnRight;

	public IceAnimatorTotalCommander leftOrRightAnimatorTotalCommander;

	public UILHAddSlot[] SelectSlot;

	private ItemHolding[] mSelected;

	private int mPreviewCount;

	public IceAnimatorTotalCommander AnimateSlotEmpty;

	public IceAnimatorTotalCommander AnimateLHEnable;

	public IceAnimatorTotalCommander AnimateLHResult;

	public GameObject[] LHResultNode;

	public IceAnimatorTotalCommander AnimateLHPreview;

	public GameObject[] LHPreviewNode;

	public UIGrid resultGrid;

	[HideInInspector]
	public C2SItemTransformReq.TypeEnum mType;

	[HideInInspector]
	public LianHuaIntent mParentIntent;

	private List<Hero> CardsOnField;

	private List<Hero> CardsOnFieldPurch;

	private List<ThingHolding> mSaveLianHuaReslut;

	public static bool IsLianhua;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetSelectData(ItemHolding[] list)
	{
	}

	public void SetSelectedList()
	{
	}

	public void ClearSelectedList()
	{
	}

	public void SetResultList(List<ThingHolding> resList)
	{
	}

	public void ClearResultList()
	{
	}

	public static void ArrayToList<T>(List<T> outList, T[] inputArray)
	{
	}

	public static void ListToArray<T>(List<T> inputList, T[] outArray)
	{
	}

	private void onChooseItem(int index, ThingHolding th)
	{
	}

	private void checkRemoveItem(List<ItemHolding> list)
	{
	}

	private void setLianHuaTypeByData()
	{
	}

	public bool IsPreviewOk()
	{
		return false;
	}

	public void DoLianHua()
	{
	}

	private void requestLianHua(List<ItemHolding> list)
	{
	}

	private bool checkSpace(List<ItemHolding> srcList, List<ThingHolding> resultList)
	{
		return false;
	}

	private void OnLianHuaSuccess(object response)
	{
	}

	private void getLianHuaPreviewResult()
	{
	}

	public void OnLianHuaPreviewResult(object response)
	{
	}

	public void AutoAddCard()
	{
	}

	private void searchHero(ERarity chooseRairity, List<ItemHolding> resList, int maxCount)
	{
	}

	public static bool IsInArray(Hero h)
	{
		return false;
	}

	public void AutoAddGear()
	{
	}

	private void searchGear(ERarity chooseRairity, List<ItemHolding> resList, int maxCount)
	{
	}

	public void AutoAddSkill()
	{
	}

	private void searchSkill(ERarity chooseRairity, List<ItemHolding> resList, int maxCount)
	{
	}

	public bool IsGearInUse(GearHolding gFind)
	{
		return false;
	}

	public bool IsSkillInUse(SkillHolding sFind)
	{
		return false;
	}

	public void PlaySlotAnimation()
	{
	}

	public void PlayButtonAnimation()
	{
	}

	public void PlayPreviewAnimation(bool play, int count)
	{
	}

	public void PlayResultAnimation(int count, Action onComplete)
	{
	}

	private void goToLianHuaShop()
	{
	}
}
