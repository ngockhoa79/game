using UnityEngine;

public class BattleResultStarGroupCtrller : MonoBehaviour
{
	public GameObject title;

	public GameObject starsDarkRoot;

	public GameObject[] stars;

	public GameObject[] startAnims;

	private const float TITLE_Y_WITH_STAR = 31f;

	private const float TITLE_Y_NO_STAR = -18f;

	private void Awake()
	{
	}

	public void SetStars(bool _needStar, int _count)
	{
	}
}
