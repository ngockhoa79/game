public class ProcedureManchine
{
	private ProcedureLine mProcessLine;

	private bool mIsEnded;

	private bool mIsStepComplete;

	private bool mIsStepError;

	private int mStepIndex;

	public int CurStep => 0;

	public ProcedureLine CurProcedureLine => null;

	public void SetProcedure(ProcedureLine p)
	{
	}

	public void BeginProcedure()
	{
	}

	private void stepBegin()
	{
	}

	public void StepComplete()
	{
	}

	public void StepError()
	{
	}

	public void StepReset()
	{
	}

	public void StepRun()
	{
	}
}
