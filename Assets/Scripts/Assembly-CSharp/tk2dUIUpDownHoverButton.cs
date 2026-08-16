using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/tk2dUIUpDownHoverButton")]
public class tk2dUIUpDownHoverButton : tk2dUIBaseItemControl
{
	public GameObject upStateGO;

	public GameObject downStateGO;

	public GameObject hoverOverStateGO;

	[SerializeField]
	private bool useOnReleaseInsteadOfOnUp;

	private bool isDown;

	private bool isHover;

	public string SendMessageOnToggleOverMethodName;

	public bool UseOnReleaseInsteadOfOnUp => false;

	public bool IsOver
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<tk2dUIUpDownHoverButton> OnToggleOver
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ButtonUp()
	{
	}

	private void ButtonDown()
	{
	}

	private void ButtonHoverOver()
	{
	}

	private void ButtonHoverOut()
	{
	}

	public void SetState()
	{
	}

	public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
	{
	}
}
