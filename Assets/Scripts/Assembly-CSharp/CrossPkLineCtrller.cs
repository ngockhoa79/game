using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class CrossPkLineCtrller : MonoBehaviour
{
	public GameObject[] LeftBlocks;

	public GameObject[] RightBlocks;

	public CrossPkFlagCtrller Flag;

	public CrossPkLineAnimsCtrller Anims;

	public UIEventListener ReplayBtn;

	public UIEventListener ZoomBox;

	public Action<int> OnLineClicked;

	public Action<int> OnReplayClicked;

	public UILabel LeftFighter;

	public UILabel RightFighter;

	private GuildPkLineFlagType flagType;

	private GuildPkBattleResultLineInfo resultInfo;

	private int playingIndex;

	private bool playing;

	private float playTimer;

	private int lineIndex => 0;

	private int lineRealIndex => 0;

	private bool enemyEmpty => false;

	public void SetEmpty()
	{
	}

	private void Update()
	{
	}

	public void SetReplayActive(bool _active)
	{
	}

	public void SetZoomClickEnable(bool _enable)
	{
	}

	public void SetData(string _left, string _right, CrossGuildInfoProto.StatusEnum _status, GuildPkLineFlagType _showFlag)
	{
	}

	public void SetForm(string _left, string _right)
	{
	}

	private void RemoveDeathMasks()
	{
	}

	public void ShowBattleResultImmediately(GuildPkBattleResultLineInfo _result)
	{
	}

	public void ShowBattleResultFromIndex(GuildPkBattleResultLineInfo _result, int _index)
	{
	}

	private void ShowFlag(bool _needAnim)
	{
	}

	private void PlayFight()
	{
	}

	private void ResetLastFightBlock()
	{
	}

	private void SetBlockDeath(int _nextIndex)
	{
	}

	private void OnZoomBoxClicked(GameObject _obj)
	{
	}

	private void OnReplayBtnClicked(GameObject _obj)
	{
	}
}
