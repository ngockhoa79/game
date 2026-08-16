using System;
using UnityEngine;

public class UIScreenPowerChange : MonoBehaviour
{
	public IceAnimatorTotalCommander anim_up;

	public IceAnimatorTotalCommander anim_down;

	public UILabel lbPower;

	private Action E_OnFinish;

	public void Show(int deltaPower, Action callback = null)
	{
	}

	private void Stop()
	{
	}
}
