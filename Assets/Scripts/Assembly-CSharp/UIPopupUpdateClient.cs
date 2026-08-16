using System;
using UnityEngine;

public class UIPopupUpdateClient : IceUIBase
{
	[SerializeField]
	private UILabel lbClientVersion;

	[SerializeField]
	private UILabel lbUpdateContent;

	[SerializeField]
	private UIEventListener btnUpdate;

	[SerializeField]
	private IceAnimatorTotalCommander anim_enter;

	public Action E_OnUpdate;

	public void SetData(string clientVersion, string content)
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
}
