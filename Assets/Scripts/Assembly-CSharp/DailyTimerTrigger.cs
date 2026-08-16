using System;
using System.Collections.Generic;

public class DailyTimerTrigger
{
	private class Content
	{
		public DateTime nextTriggerTimer;

		public Action OnTriggerEvent;
	}

	private List<Content> triggers;

	private int triggerIndex;

	private Timer dailyTimer;

	public void RegistTimer(int hour, int min, int second, Action onTrigger)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	private void triggerNext()
	{
	}

	private void OnTimerAction(Timer timer)
	{
	}
}
