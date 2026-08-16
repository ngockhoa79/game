using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ArraySupporters : IceUIBase
{
	public enum EntrancePoint
	{
		PVECollaborationStage = 0,
		FragmentBattleReport = 1
	}

	[SerializeField]
	public UIEventListener skipBtn;

	[SerializeField]
	public UIEventListener backBtn;

	[SerializeField]
	public UIEventListener homeBtn;

	public UIAeSupporterList SupporterList;

	public UITable Table;

	public GameObject GamePlayMannerIndicator;

	public UILabel RestDuration;

	public static GamePlayManner m;

	public GameObject TitleLeft1;

	public GameObject TitleLeft2;

	public GameObject TitleMiddle;

	public EntrancePoint entrance;

	public event Action<Player> OnChosen
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnSkip
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnHome
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetDetail(List<Player> players, GamePlayManner manner)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void skip(GameObject btn)
	{
	}

	private void back(GameObject btn)
	{
	}

	private void home(GameObject btn)
	{
	}

	private void handleOnChosen(Player player)
	{
	}
}
