using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMakyouChangePop : IceUIBase
{
	[SerializeField]
	private UIEventListener ueokBtn;

	[SerializeField]
	private UILabel lbleftTimes;

	[SerializeField]
	private UILabel lbsucc;

	[SerializeField]
	private UILabel lbscore;

	[SerializeField]
	private UILabel lbProgress;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	[SerializeField]
	private UISlider slide;

	public Action E_OnClose;

	private void refrush(MakyouChangeStruct data)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onClick(GameObject obj)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoDispose()
	{
	}
}
