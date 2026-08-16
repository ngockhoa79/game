using System;

public class Timer : IComparable
{
	public delegate void OnTimer(Timer sender);

	internal bool bKilled;

	public float fInterval;

	internal float fTimer;

	private bool bRunOnce;

	internal OnTimer onTimer;

	public Timer(float fInterval, OnTimer onTimer, bool bAutoRun, bool bRunOnce = false)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	protected internal int CompareTo(Timer other)
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	protected internal void Run()
	{
	}
}
