using System;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
	public GameObject root;

	private bool bStart;

	private DateTime _lastTouchTime;

	private const double TOUCH_DELTA_TIME = 0.5;

	private IceAnimatorTotalCommander _iceAnimator;

	private GameObject _iceAnimatorGo;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool CheckTimeValidate()
	{
		return false;
	}

	private Vector2 ScreenToNGUIPosition(Vector2 position)
	{
		return default(Vector2);
	}
}
