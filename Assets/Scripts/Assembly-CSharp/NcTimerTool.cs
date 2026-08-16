public class NcTimerTool
{
	protected bool m_bEnable;

	private float m_fLastEngineTime;

	private float m_fCurrentTime;

	private float m_fLastTime;

	private float m_fTimeScale;

	private int m_nSmoothCount;

	private int m_nSmoothIndex;

	private float m_fSmoothRate;

	private float[] m_fSmoothTimes;

	private float m_fLastSmoothDeltaTime;

	public static float GetEngineTime()
	{
		return 0f;
	}

	public static float GetEngineDeltaTime()
	{
		return 0f;
	}

	private void InitSmoothTime()
	{
	}

	private float UpdateSmoothTime(float fDeltaTime)
	{
		return 0f;
	}

	public bool IsUpdateTimer()
	{
		return false;
	}

	private float UpdateTimer()
	{
		return 0f;
	}

	public float GetTime()
	{
		return 0f;
	}

	public float GetDeltaTime()
	{
		return 0f;
	}

	public float GetSmoothDeltaTime()
	{
		return 0f;
	}

	public bool IsEnable()
	{
		return false;
	}

	public void Start()
	{
	}

	public void Reset(float fElapsedTime)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetTimeScale(float fTimeScale)
	{
	}

	protected virtual float GetTimeScale()
	{
		return 0f;
	}
}
