using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPopupCard : IceUIBase
{
	public Action<UIPopupCard> E_OnClick;

	[SerializeField]
	private UniIcon icon;

	[SerializeField]
	private UILabel lbName;

	[SerializeField]
	private IceAnimatorTotalCommander anim_idle;

	[SerializeField]
	private IceAnimatorTotalCommander anim_select;

	[SerializeField]
	private IceAnimatorTotalCommander anim_auto;

	[SerializeField]
	private IceAnimatorTotalCommander anim_cardPrize;

	[SerializeField]
	private UIEventListener btnClick;

	[SerializeField]
	private GameObject backCard;

	[SerializeField]
	private GameObject frontCard;

	public void PlayCardPrizeAnim()
	{
	}

	public void ResetCardPrizeAnim()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void Set(ThingHolding th)
	{
	}

	public void ShowSelectAnim(Action callback = null)
	{
	}

	public void ShowAutoTurn(Action callback = null)
	{
	}
}
