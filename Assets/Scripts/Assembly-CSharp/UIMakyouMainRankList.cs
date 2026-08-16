using System;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouMainRankList : IceUIBase
{
	public class MakyouRankLevelItemVisualizer : IceUIReusableList<CrossPersonGroupTemplate>.IVisualizer
	{
		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, CrossPersonGroupTemplate data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class MakyouRankScoreItemVisualizer : IceUIReusableList<CrossPersonRankingItemProto>.IVisualizer
	{
		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, CrossPersonRankingItemProto guildInfo)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public Action E_OnClose;

	[SerializeField]
	private UIEventListener btnClose;

	[SerializeField]
	private MakyouMainScoreRankListAnimator List;

	[SerializeField]
	private MakyouMainLevelRankListAnimatot LevelList;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private GameObject guildLevel;

	[SerializeField]
	private GameObject guildScore;

	[SerializeField]
	private IceUIBtnGroup tabs;

	[SerializeField]
	private UIEventListener helpBtn;

	private string CurrentTab;

	private int CurrentIndex;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onCLickHelp(GameObject obj)
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	private void onchangeTab(int tab)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void __request_Level_info_()
	{
	}

	private void __request_info_()
	{
	}

	private void sortScoreList(List<CrossPersonRankingItemProto> Rankings)
	{
	}

	private void _refresh_view_(S2CCrossPersonRankingListAck ack)
	{
	}
}
