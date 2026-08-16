using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMultiItemBuy : IceUIBase
{
	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private UIEventListener btnCancel;

	[SerializeField]
	private UIEventListener btnMin;

	[SerializeField]
	private UIEventListener btnMax;

	[SerializeField]
	private UIEventListener btnPreview;

	[SerializeField]
	private UIEventListener btnNext;

	[SerializeField]
	private UILabel lbCount;

	[SerializeField]
	private UILabel lbPrice;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private PayTypeIcon PayType;

	public Action<int> E_OnConfirm;

	public Action E_OnCancel;

	private int _min;

	private int _max;

	private int _cur;

	private int _singlePrice;

	private CurrencyType mPayType;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetData(int min, int max, int current, int singlePrice, CurrencyType payType)
	{
	}

	private void Refresh(int currentVal)
	{
	}
}
