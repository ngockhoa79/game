using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("2D Toolkit/UI/tk2dUIToggleButton")]
public class tk2dUIToggleButton : tk2dUIBaseItemControl
{
	public GameObject offStateGO;

	public GameObject onStateGO;

	public bool activateOnPress;

	[SerializeField]
	private bool isOn;

	private bool isInToggleGroup;

	public string SendMessageOnToggleMethodName;

	public bool IsOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsInToggleGroup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<tk2dUIToggleButton> OnToggle
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

	private void ButtonClick()
	{
	}

	private void ButtonDown()
	{
	}

	private void ButtonToggle()
	{
	}

	private void SetState()
	{
	}
}
