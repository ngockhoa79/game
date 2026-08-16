using System;
using System.Runtime.CompilerServices;

public class AutoRecoveryStruct
{
	private DateTime lastRefreshTime;

	private int _minVal;

	private int _maxVal;

	private int _currentVal;

	private int _deltaVal;

	private float intervalTime;

	private Timer myTimer;

	public int Current => 0;

	public int Min => 0;

	public int Max => 0;

	public event Action<int, int> E_OnValueChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private AutoRecoveryStruct()
	{
	}

	public AutoRecoveryStruct(int deltaVal)
	{
	}

	public void Start(int currentVal, int max, int min, float delayTime, float intervalTime)
	{
	}

	public float GetTimeLeft()
	{
		return 0f;
	}

	public void SetVal(int val)
	{
	}

	public bool Consume(int consumeVal)
	{
		return false;
	}

	public bool CanConsumable(int consumeVal)
	{
		return false;
	}

	public void Stop()
	{
	}

	private void OnTimerFistTime(Timer sender)
	{
	}

	private void OnTimerLoop(Timer sender)
	{
	}

	private void _startTimer(float delayTime)
	{
	}

	private void _stopTimer()
	{
	}

	private bool _recoveryOnce()
	{
		return false;
	}
}
