using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UICornucopiaChoose : IceUIBase
{
	[SerializeField]
	private UIEventListener btnBuyGolden;

	[SerializeField]
	private UIEventListener btnBuySilver;

	[SerializeField]
	private UIEventListener btnBuyNormal;

	[SerializeField]
	private UILabel lbGoldenPrice;

	[SerializeField]
	private UILabel lbSilverPrice;

	[SerializeField]
	private UILabel lbNormalPrice;

	private int _goldenPrice;

	private int _silverPrice;

	private int _normalPrice;

	private CornucopiaInfoProto.ConfigProto _config;

	public Action<int, long> E_OnBuySuccess;

	public void SetData(CornucopiaInfoProto.ConfigProto config)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void _buy_cornucopia_(int index, int crystalCost)
	{
	}

	private void __internal_buy_cornucopia_(int index, int crystalCost)
	{
	}
}
