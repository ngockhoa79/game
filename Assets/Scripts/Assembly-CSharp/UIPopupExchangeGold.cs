using System;
using UnityEngine;

public class UIPopupExchangeGold : IceUIBase
{
	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private UIEventListener btnCancel;

	[SerializeField]
	private UILabel lbTodayCanUse;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UILabel lbGold;

	[SerializeField]
	private UILabel lbMaxEff;

	[SerializeField]
	private IceAnimatorTotalCommander animation_in;

	[SerializeField]
	private IceAnimatorTotalCommander animation_out;

	[SerializeField]
	private IceAnimatorTotalCommander maxNumAnimation;

	public Action E_OnGoldExchangeOnce;

	public Action E_OnClose;

	public Action E_OnDispose;

	private bool bwait;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SetUI()
	{
	}

	public void OnGoldExchange()
	{
	}

	private void OnExchangeGoldMsgResponse(object msg)
	{
	}
}
