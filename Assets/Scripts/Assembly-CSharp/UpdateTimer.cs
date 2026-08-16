using System;
using UnityEngine;

public class UpdateTimer : MonoBehaviour
{
	public delegate string GetDateString(TimeSpan dTime);

	public UILabel lbText;

	public GetDateString OnGetDateString;

	public Action<UpdateTimer> OnTimerEnd;

	private bool mNeedUpdate;

	public DateTime EndTime { get; set; }

	public void SetEndTimeFromUTC(long tick)
	{
	}

	public void SetEndTimeFromServerUTC(DateTime d)
	{
	}

	public void SetEndTimeFromLocal(DateTime d)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BeginUpdate()
	{
	}

	public void EndUpdate()
	{
	}
}
