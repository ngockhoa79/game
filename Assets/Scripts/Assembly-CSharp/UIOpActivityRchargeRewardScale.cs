using System;
using UnityEngine;

public class UIOpActivityRchargeRewardScale : IceUIBase
{
	[SerializeField]
	private GameObject scaleNorm;

	[SerializeField]
	private GameObject scaleSelect;

	[SerializeField]
	private UILabel lbPrice;

	[SerializeField]
	private UILabel lbPrice2;

	[SerializeField]
	private UISprite priceBg;

	[SerializeField]
	private UISprite priceSelectedBg;

	[SerializeField]
	private UIEventListener E_Click;

	public Action<int> OnSelected;

	private static string spPriceBgName;

	private static string spSelectedPriceBgName;

	private static string spPriceBgNameGray;

	private int _index;

	public void SetData(float price, bool selected, int index, bool enabled)
	{
	}

	public void ResetSprite(bool light)
	{
	}

	protected override void DoPrepare()
	{
	}
}
