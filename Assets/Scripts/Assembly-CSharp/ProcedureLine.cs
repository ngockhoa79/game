using System;
using System.Collections.Generic;

public class ProcedureLine
{
	private List<Action> mSteps;

	public Action E_OnStepEnd;

	public Action E_OnStepError;

	public int CountStep => 0;

	public void AddStep(Action a)
	{
	}

	public Action GetStep(int index)
	{
		return null;
	}
}
