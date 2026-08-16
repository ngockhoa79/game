using System;
using UnityEngine;

public class UIOpActivityGrowth : IceUIBase
{
	public class GrowthContentVisualizer : IceUIReusableList<UIOpActivityGrowthData>.IVisualizer
	{
		public readonly UIOpActivityGrowth Owner;

		public GrowthContentVisualizer(UIOpActivityGrowth owner)
		{
		}

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, UIOpActivityGrowthData data)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIEventListener btnPurchase;

	[SerializeField]
	private UIEventListener btnCharge;

	[SerializeField]
	private UIEventListener btnAddCrystal;

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UILabel lbBonus;

	[SerializeField]
	private UILabel lbVip;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UILabel lbCost;

	[SerializeField]
	private UIOpActivityGrowthList List;

	[SerializeField]
	protected UnityEngine.Object ListContentResource;

	[SerializeField]
	private GameObject btnPurchaseGray;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void BuyGrowing()
	{
	}

	private void _init_list_()
	{
	}

	protected override void DoDispose()
	{
	}

	protected void Click(UIOpActivityGrowthData data)
	{
	}

	private void _set_purchase_button_(bool bEnable)
	{
	}
}
