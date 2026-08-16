using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICommonSkillItem : UICommonItem
{
	[SerializeField]
	protected UILuggagePortrait ItemPortrait;

	public UILabel SkillPrice;

	public ItemHolding skill { get; private set; }

	public override void SetData(ItemHolding skill, EState state = EState.Idle, EMode mode = EMode.NormalMode)
	{
	}

	private void setData(ItemHolding skill)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}
}
