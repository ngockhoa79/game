using System;
using UnityEngine;

public class UINotificationAttacher : IceUIBase
{
	[SerializeField]
	private Transform goRoot;

	[SerializeField]
	private GameObject goBackground;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	[SerializeField]
	private int fontSize;

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoDispose()
	{
	}
}
