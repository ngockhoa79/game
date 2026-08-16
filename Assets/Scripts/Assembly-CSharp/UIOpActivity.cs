using System.Collections.Generic;
using UnityEngine;

public class UIOpActivity : IceUIBase
{
	[SerializeField]
	private UIPanel panel;

	[SerializeField]
	private UITable table;

	[SerializeField]
	private GameObject imageRoot;

	public int mCurOpActiId;

	private GameObject goOpActivity;

	private Dictionary<int, UIOpActivityContent> _imageDic;

	private void Start()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void _init_()
	{
	}

	private void Callback(bool bSuccess)
	{
	}

	private void LaunchOpActivity(int opActivityId)
	{
	}

	private void LoadOpActivityCallback(bool bSuccess)
	{
	}

	public void DoForeground()
	{
	}
}
