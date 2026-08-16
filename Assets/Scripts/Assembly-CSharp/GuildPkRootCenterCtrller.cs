using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class GuildPkRootCenterCtrller : MonoBehaviour
{
	public UILabel leftTen;

	public UILabel leftSingle;

	public UILabel rightTen;

	public UILabel rightSingle;

	public UILabel timeLaber;

	private CrossGuildInfoProto.StatusEnum status;

	private bool timerStart;

	private DateTime nextPoint;

	private bool hasTarget;

	private int leftScore;

	private int rightScore;

	public void SetScore(int _leftScore, int _rightScore)
	{
	}

	public void AddScore(int _leftAdd, int _rightAdd)
	{
	}

	private void ShowText()
	{
	}

	public void SetStatus(CrossGuildInfoProto.StatusEnum _status, DateTime _point, bool _hasTarget)
	{
	}

	private void Update()
	{
	}
}
