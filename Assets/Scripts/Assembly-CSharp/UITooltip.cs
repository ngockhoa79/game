using System;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Tooltip")]
public class UITooltip : MonoBehaviour
{
	protected static UITooltip mInstance;

	public Camera uiCamera;

	public UILabel text;

	public UISprite background;

	public float appearSpeed;

	public bool scalingTransitions;

	protected GameObject mHover;

	protected Transform mTrans;

	protected float mTarget;

	protected float mCurrent;

	protected Vector3 mPos;

	protected Vector3 mSize;

	protected UIWidget[] mWidgets;

	public static bool isVisible => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void SetAlpha(float val)
	{
	}

	protected virtual void SetText(string tooltipText)
	{
	}

	[Obsolete("Use UITooltip.Show instead")]
	public static void ShowText(string text)
	{
	}

	public static void Show(string text)
	{
	}

	public static void Hide()
	{
	}
}
