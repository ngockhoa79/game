using System;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
	private static TimerManager instance;

	private BinaryHeapMin<Timer> timers;

	private static float fRealTime;

	private DateTime _startTime;

	private static TimerManager GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	protected internal static void SetTimer(Timer tr)
	{
	}

	public static void Run(float fTime)
	{
	}

	private void SetTimer(Timer tr, float fTime)
	{
	}

	private void CheckTimer(float fTime)
	{
	}

	private void Update()
	{
	}
}
