using UnityEngine;

public class UICePowerExpDisplayer : IceUIBase
{
	[SerializeField]
	private UILabel LV;

	[SerializeField]
	private UILabel LVMax;

	[SerializeField]
	private UILabel Power;

	[SerializeField]
	private UILabel ExpCurrent;

	[SerializeField]
	private UILabel ExpMax;

	[SerializeField]
	private UISprite progress;

	private void clear()
	{
	}

	public void SetDetail(int lv, int maxLv, int power, int currentExp, int maxExp)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}
