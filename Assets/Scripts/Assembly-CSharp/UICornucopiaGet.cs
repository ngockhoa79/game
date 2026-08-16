using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICornucopiaGet : IceUIBase
{
	[SerializeField]
	private UILabel lbDayLeft;

	[SerializeField]
	private UIEventListener btnGetReward;

	[SerializeField]
	private GameObject goGolden;

	[SerializeField]
	private GameObject goSilver;

	[SerializeField]
	private GameObject goNormal;

	[SerializeField]
	private GameObject goRewarded;

	[SerializeField]
	private GameObject goGetReward;

	[SerializeField]
	private UIGrid uiGrid;

	private DateTime _buyTime;

	private int _slotIndex;

	private int _mark;

	private int _day_index;

	private CornucopiaInfoProto.ConfigProto _config;

	private List<ThingHolding> _rewards;

	public static bool CheckIsAllTrue(int mark, int count)
	{
		return false;
	}

	public void SetData(int index, int mark, long buyTime, CornucopiaInfoProto.ConfigProto config)
	{
	}

	protected override void DoDispose()
	{
	}

	private void _show_rewards_(List<ThingProto> rewards)
	{
	}

	private void _generate_uniicon_(ThingHolding thingHolding)
	{
	}

	private void _show_go_(int index)
	{
	}

	private DateTime _get_puredate_(DateTime time)
	{
		return default(DateTime);
	}

	private void _get_reward_(GameObject go)
	{
	}

	private void _picked_()
	{
	}
}
