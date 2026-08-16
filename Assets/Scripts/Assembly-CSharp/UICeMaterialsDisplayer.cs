using UnityEngine;

public class UICeMaterialsDisplayer : IceUIBase
{
	[SerializeField]
	private UILabel materialCountCurrent;

	[SerializeField]
	private UILabel materialCountMax;

	[SerializeField]
	private GameObject[] stars;

	[SerializeField]
	private UISprite progress;

	private const string DarkStar = "UICEStarEmpty";

	private const string Star = "UICEStar";

	private void clear()
	{
	}

	public void SetDetail(int starNum, int current, int max)
	{
	}

	private void setStars(int num)
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
