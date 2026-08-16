using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardLevelupExpCtrller : MonoBehaviour
{
	public UILabel LvLabel;

	public UILabel LvMaxLabel;

	public GameObject ExpRoot;

	public UILabel GainExpLabel;

	public UISprite ExpFullText;

	public UILabel OverExpLabel;

	public Transform OverTitle;

	public UISprite BlueBar;

	public UISprite GreenBar;

	public UISprite AddtiveEffect;

	public UILabel BarPercentLabel;

	public UILabel NextLvGapLabel;

	public UILabel FullGapLabel;

	public UILabel ConsumeLabel;

	public GameObject Max;

	public IceAnimatorTotalCommander OverAnim;

	private string ColorGreen;

	private Hero card;

	private int gainExp;

	private int cost;

	private int predictLevel;

	private const int XOffset1 = 45;

	private const int XOffset2 = 60;

	private const int XOffset3 = 72;

	public int TotalCost => 0;

	public int AfterLevel => 0;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetMainCard(Hero _card)
	{
	}

	public void SetGainExp(int _exp)
	{
	}

	private void RefreshUI()
	{
	}

	public float GetExpPercentInCurrentLv(int exp, int expId, int maxLv)
	{
		return 0f;
	}

	private int CalculateCost(int _expGet)
	{
		return 0;
	}
}
