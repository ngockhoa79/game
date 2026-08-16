using UnityEngine;

public class GearRefineCostController : MonoBehaviour
{
	public GameObject StoneGroup;

	public GameObject CoinGroup;

	public GameObject DiamondGroup;

	public UILabel StoneCostValue;

	public UILabel CoinCostValue;

	public UILabel DiamondCostValue;

	private int stoneInstock;

	private int coinInstock;

	private int diamondInstock;

	private const string COLOR_YELLOW = "[FFE500]";

	private const string COLOR_RED = "[FF0000]";

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(int stone_cost, int coin_cost, int diamond_cost)
	{
	}

	private void UpdateStock()
	{
	}

	private void UpdateUI(int stoneCost, int coinCost, int diamondCost)
	{
	}
}
