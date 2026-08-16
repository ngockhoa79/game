public class NcRepeatTimerTool : NcTimerTool
{
	protected float m_fUpdateTime;

	protected float m_fIntervalTime;

	protected int m_nRepeatCount;

	protected int m_nCallCount;

	protected object m_ArgObject;

	public bool UpdateTimer()
	{
		return false;
	}

	public void ResetUpdateTime()
	{
	}

	public int GetCallCount()
	{
		return 0;
	}

	public object GetArgObject()
	{
		return null;
	}

	public float GetElapsedRate()
	{
		return 0f;
	}

	public void SetTimer(float fStartTime)
	{
	}

	public void SetTimer(float fStartTime, float fRepeatTime)
	{
	}

	public void SetTimer(float fStartTime, float fRepeatTime, int nRepeatCount)
	{
	}

	public void SetTimer(float fStartTime, object arg)
	{
	}

	public void SetTimer(float fStartTime, float fRepeatTime, object arg)
	{
	}

	public void SetTimer(float fStartTime, float fRepeatTime, int nRepeatCount, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRepeatTime)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRepeatTime, int nRepeatCount)
	{
	}

	public void SetRelTimer(float fStartRelTime, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRepeatTime, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRepeatTime, int nRepeatCount, object arg)
	{
	}
}
