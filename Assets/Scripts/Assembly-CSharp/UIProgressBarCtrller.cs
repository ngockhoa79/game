using System;
using UnityEngine;

public class UIProgressBarCtrller : MonoBehaviour
{
	public UISprite Foreground;

	public UISprite ForeColorAdd;

	public UILabel LvLabel;

	public UILabel ExpLabel;

	public Action<int, float> OnLevelUp;

	public Action OnFinish;

	private bool mAnimating;

	private int mCurrentLv;

	private float mCurrentPer;

	private int mTargetLv;

	private float mTargetPer;

	public const float ANIMATE_SPEED_PER_S = 3f;

	private void Update()
	{
	}

	private void Finish()
	{
	}

	private void SetExpBar(float _percent)
	{
	}

	public static float CacuLevelProgress(ref int Lv, ref int pCur, int pMax)
	{
		return 0f;
	}

	public void SetExp(int lv, int pCur, int pMax)
	{
	}

	public void SetExp(int lv, float percent)
	{
	}

	public void AnimateTo(int lv, int pCur, int pMax)
	{
	}

	public void AnimateTo(int targetLv, float targetPer)
	{
	}

	public void ShowImmediately()
	{
	}
}
