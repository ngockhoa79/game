using System;
using UnityEngine;

public class UpdateTimerUTC : MonoBehaviour
{
	public delegate string GetDateString(TimeSpan dTime);

	public UILabel lbText;

	public GetDateString OnGetDateString;

	public Action<UpdateTimerUTC> OnTimerEnd;

	private bool mNeedUpdate;

	public DateTime EndUTCTime { get; set; }

	public void SetEndTimeFromUTC(long tick)
	{
	}

	public void SetEndTimeFromServerUTC(DateTime d)
	{
	}

	public void SetEndTimeFromLocal(DateTime d)
	{
	}

	public TimeSpan GetRestTime()
	{
		return default(TimeSpan);
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
