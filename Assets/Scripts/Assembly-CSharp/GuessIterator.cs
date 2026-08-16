using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class GuessIterator
{
	private List<ThingHolding> mAwardList;

	private int mAwardCount;

	private List<int> mOpenPosition;

	private int mCurOpenStep;

	public int AwardCount => 0;

	public int AwardTotalCount => 0;

	public int StepSize => 0;

	public void SetAwardList(List<ThingHolding> awardList)
	{
	}

	public List<ThingHolding> GetAwardList()
	{
		return null;
	}

	public void AddNextStep(int position)
	{
	}

	public bool IsAwardEnd()
	{
		return false;
	}

	public bool HasNextStep()
	{
		return false;
	}

	public bool StepNext(out ThingHolding outTh, out int outPos)
	{
		outTh = null;
		outPos = default(int);
		return false;
	}
}
