using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIOpenServerItemComplex : MonoBehaviour
{
	public enum BtnType
	{
		Goto = 0,
		Get = 1,
		Got = 2,
		None = 3
	}

	public UILabel Title;

	public UIEventListener Goto;

	public UIEventListener Get;

	public UIEventListener Got;

	public UIGrid Grid;

	public void Set(string title, BtnType t, OpenServerElement e)
	{
	}

	private void setuniIcons(OpenServerElement e)
	{
	}

	private void uniIcons(OpenServerRewardTemplate.RewardItem_ ri)
	{
	}

	private void uniIcons(OpenServerTaskTemplate.RewardItem[] ria)
	{
	}

	private void createUniIcon(int t, int id, int n)
	{
	}

	private void handleBtnStatus(BtnType t, OpenServerElement e)
	{
	}

	private void handleGoto(OpenServerElement e)
	{
	}

	private void handleGet(OpenServerElement e)
	{
	}

	private List<ThingHolding> createRewardList(OpenServerElement e)
	{
		return null;
	}

	private List<ThingHolding> createTaskList(OpenServerElement e)
	{
		return null;
	}

	private void taskPickReq(OpenServerElement e)
	{
	}

	private void rewardPickReq(OpenServerElement e)
	{
	}

	private void tip(string t)
	{
	}

	private void inactive()
	{
	}
}
