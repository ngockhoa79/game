using System.Collections;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGuildMission : MonoBehaviour
{
	public enum BonusType
	{
		Disable = 0,
		Available = 1,
		Over = 2
	}

	public class MissionItemVisualizer : IceUIReusableList<GuildMissionItemCouple>.IVisualizer
	{
		private const string ResName = "MissionItemGroup";

		private const string ResCategory = "uiguild";

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, GuildMissionItemCouple couple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	private const string ResetTipId = "Guild_Task_Tip_1";

	public UIEventListener[] BonusObtainBtns;

	private BonusType[] obtainBtnStatus;

	public UILabel[] ValueArray;

	public UISprite ProgressBar;

	public UILabel ActiveValue;

	public UILabel ResetTimeTip;

	public UIGuildMissionItemList MissionItemList;

	public UILabel Indicator;

	private BitArray obtainStatus;

	private int currentActiveValue;

	private void req()
	{
	}

	private void defaultAck()
	{
	}

	private void handleObtain(GameObject btn)
	{
	}

	private void previewDialog(List<ThingHolding> thingList)
	{
	}

	private bool noMore(int mark)
	{
		return false;
	}

	private void reqRewards(UIEventListener evtL, int index)
	{
	}

	private List<ThingHolding> fake(GuildActiveRewardTemplate t)
	{
		return null;
	}

	private List<int> reflectionValue(IGeneratorObject o)
	{
		return null;
	}

	private void tip(string t)
	{
	}

	public void Set()
	{
	}

	private void setIndicator()
	{
	}

	private void ack(int av, BitArray obtained, List<TaskItemProto> taskInfo)
	{
	}

	private List<int> getConfig()
	{
		return null;
	}

	private string getResetTip()
	{
		return null;
	}

	private GuildTaskTemplate[] getTaskList()
	{
		return null;
	}

	private void setObtainBtn(UIEventListener btn, BonusType t, int index, bool finishAll = true)
	{
	}

	private void playBtnAnimation(Transform btn, BonusType t, bool finishAll)
	{
	}

	private void playOnce(Transform t, bool finishAll)
	{
	}
}
