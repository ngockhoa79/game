using UnityEngine;

public class UILabelNumberAnimator : MonoBehaviour
{
	public string EffectName;

	public float NumberAnimationIntervalTime;

	private UILabel label;

	private bool bAnimating;

	private const string ResType = "uieffects";

	private IceAnimatorTotalCommander animator;

	private int init_val;

	private int tar_val;

	private float time_passed;

	private float totalLength;

	private float nextNumberAnimateTime;

	private GameObject animatorGo;

	private UILabel Label => null;

	public void ForceSet(int val)
	{
	}

	public void Set(int value)
	{
	}

	private void Update()
	{
	}

	private void CreateAnimator()
	{
	}

	private void Clear()
	{
	}
}
