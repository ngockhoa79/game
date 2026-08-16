using System;
using System.Collections;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIOpenServer : IceUIBase
{
	public static UIOpenServer I;

	private const string Disable = "_disable_";

	private const string Enable = "_enable_";

	private const int SEVEN = 7;

	private const int FOUR = 4;

	private TimeSpan OneWeek;

	public IceUIBtnGroup Left7DaysBtnGroup;

	public IceUIBtnGroup RightTablesBtnGroup;

	public UIEventListener HomeBtn;

	public UIEventListener AddGoldBtn;

	public UIEventListener AddCrystalBtn;

	public UILabel TimeRemains;

	public UILabel GoldLabel;

	public UILabel CrystalLabel;

	public UIOpenServerItemList ElementList;

	public Action OnHome;

	public Action OnAddGold;

	public Action OnAddCrystal;

	private Timer countDown;

	private OpenServerRewardTemplate[] rewards;

	private OpenServerSaleItemTemplate[] sales;

	private OpenServerTaskTemplate[] tasks;

	private List<OpenServerElement>[] columns;

	private int rightIndex;

	public static int clickedDayIndex;

	public static int signDayIndex;

	private bool clicked;

	private static DiamondShopInfoProto shopInfo;

	private static List<TaskItemProto> taskInfo;

	private BitArray[] redDotFlags;

	private void req(Action done)
	{
	}

	private void tipAndClose(string t)
	{
	}

	private TimeSpan passed()
	{
		return default(TimeSpan);
	}

	private DateTime createdDaysZeroPoint()
	{
		return default(DateTime);
	}

	private TimeSpan remained()
	{
		return default(TimeSpan);
	}

	private int whatsTheDateNow()
	{
		return 0;
	}

	public void Re()
	{
	}

	protected override void DoInit()
	{
	}

	private void initRedDotFlags()
	{
	}

	private void updateRedDotFlags(int day, int tab, bool flag)
	{
	}

	private void leftGroup(int f, int t)
	{
	}

	private void patchElements()
	{
	}

	private void patchPurchase(DiamondShopInfoProto.ItemBuyTimesProto proto, List<OpenServerElement> column)
	{
	}

	private void patchTask(OpenServerElement e, List<TaskItemProto> list)
	{
	}

	private void patchReward()
	{
	}

	private void createFourColumns(int day)
	{
	}

	private void setRightGroupBtnTitles(int day)
	{
	}

	private void setTask1Task2Titles(string t1, string t2)
	{
	}

	private void setTaskTitle(IceUIToggleButton btn, string sprite)
	{
	}

	private void setSpriteNames(IceUIToggleButton btn, string e, string d)
	{
	}

	private UISprite findSprite(GameObject btn)
	{
		return null;
	}

	private void rightGroup(int f, int t)
	{
	}

	private void setColumn(List<OpenServerElement> column)
	{
	}

	public void UpdateRedDots()
	{
	}

	private void setMainSceneRedDot()
	{
	}

	public void UpdatePickInfo(int i)
	{
	}

	private void setColumnRedDotIndicator(List<OpenServerElement> list, int index)
	{
	}

	private bool hasRedDot(BitArray ba)
	{
		return false;
	}

	private void setOneRedDot(IceUIToggleButton tb, bool active)
	{
	}

	private void setOneSignDayFrame(IceUIToggleButton tb, bool active)
	{
	}

	protected override void DoPrepare()
	{
	}

	private void setSignDayRedFrames()
	{
	}

	private void ack()
	{
	}

	private void rebuke()
	{
	}

	private void showGoldAndCrystal()
	{
	}

	private void remaining(TimeSpan ts)
	{
	}

	private void setTime(TimeSpan t)
	{
	}

	private void timeIsUp()
	{
	}

	protected override void DoDispose()
	{
	}

	public static void UpdateShopInfo(int id)
	{
	}

	public static bool sevenRedDotFilter(int target)
	{
		return false;
	}

	public static bool SignDayNotMeetFilter(bool showTip)
	{
		return false;
	}
}
