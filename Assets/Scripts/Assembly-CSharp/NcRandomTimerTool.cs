public class NcRandomTimerTool : NcTimerTool
{
	protected float m_fRandomTime;

	protected float m_fUpdateTime;

	protected float m_fMinIntervalTime;

	protected int m_nRepeatCount;

	protected int m_nCallCount;

	protected object m_ArgObject;

	public bool UpdateRandomTimer(bool bReset)
	{
		return false;
	}

	public bool UpdateRandomTimer()
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

	public void SetTimer(float fStartTime, float fRandomTime)
	{
	}

	public void SetTimer(float fStartTime, float fRandomTime, float fMinIntervalTime)
	{
	}

	public void SetTimer(float fStartTime, float fRandomTime, float fMinIntervalTime, int nRepeatCount)
	{
	}

	public void SetTimer(float fStartTime, float fRandomTime, object arg)
	{
	}

	public void SetTimer(float fStartTime, float fRandomTime, float fMinIntervalTime, object arg)
	{
	}

	public void SetTimer(float fStartTime, float fRandomTime, float fMinIntervalTime, int nRepeatCount, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime, float fMinIntervalTime)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime, float fMinIntervalTime, int nRepeatCount)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime, float fMinIntervalTime, object arg)
	{
	}

	public void SetRelTimer(float fStartRelTime, float fRandomTime, float fMinIntervalTime, int nRepeatCount, object arg)
	{
	}
}
